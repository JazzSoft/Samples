Public Class MainForm

	Protected Enum VIDEnum
		VIDECTimer = 201
		VIDTimeFormat
		VIDControlState

		' Load port state
		VIDLoadPortState1 = 301
		VIDLoadPortState2

		' Access mode
		VIDAccessMode1 = 311
		VIDAccessMode2

		' Slot map
		VIDSlotMap1 = 321
		VIDSlotMap2

		' Carrier ID
		VIDCarrierID1 = 331
		VIDCarrierID2
	End Enum

	Protected Enum CEIDEnum
		CEIDOffline = 51
		CEIDOnlineLocal
		CEIDOnlineRemote

		CEIDPJState = 60
		CEIDCJState = 70
		CEIDWaferProcessData = 80

		' Carrier transfer request
		CEIDCarrierTransferRequest1 = 101
		CEIDCarrierTransferRequest2

		' Load port transfer
		CEIDLoadPortTransfer1 = 111
		CEIDLoadPortTransfer2

		' FOUP lock state
		CEIDFoupLockState1 = 121
		CEIDFoupLockState2

		' Carrier transfer
		CEIDCarrierTransfer1 = 131
		CEIDCarrierTransfer2

		' Carrier iD status
		CEIDCarrierIDStatus1 = 141
		CEIDCarrierIDStatus2

		' Carrier location
		CEIDCarrierLocation1 = 151
		CEIDCarrierLocation2

		' FOUP door state
		CEIDFoupDoorState1 = 161
		CEIDFoupDoorState2

		' Carrier slot map state
		CEIDCarrierSlotMapState1 = 171
		CEIDCarrierSlotMapState2

		' Access mode
		CEIDAccessMode1 = 181
		CEIDAccessMode2
	End Enum

	Protected Enum ALIDEnum
		ALIDLoadWaferFailure = 1
	End Enum

	Protected Sub ReceivedS3F17()
		With gem
			' Carrier action
			.Node = "2"
			Dim strCarrierAction As String = .NodeValue

			If strCarrierAction.ToUpper() <> "ProceedWithCarrier".ToUpper() Then
				' Not supported
				Exit Sub
			End If


			' TODO : Verify


			' TEST
			'.set_VIDRawValue(VIDEnum.VIDSlotMap1, "<a'0000011111000001111100000'>")
			.set_VIDValue(VIDEnum.VIDSlotMap1, "1111100000111110000011111")
			.InvokeEvent(CEIDEnum.CEIDCarrierSlotMapState1)
		End With
	End Sub

	Protected Sub SendS7F20()
		With gem
			.Reply = True
			.Node = ""
			Dim strRecipe As String = "s7f20{"


			' TODO : Query recipe data base, enumerate file name, etc...

			For Each item In recipelist.Items
				strRecipe += "<a'" + item + "'>"
			Next


			strRecipe += "}"
			.SML = strRecipe
		End With
	End Sub

	Protected Sub ReceivedS14F9()
		With gem
			' Arguments
			Dim args As New Hashtable()
			.Node = "3"
			Dim nCnt As Integer
			Dim nNodeCount As Integer = .NodeCount
			For nCnt = 1 To nNodeCount
				' Attribute ID
				.Node = "3/" + Format$(nCnt) + "/1"
				Dim strAttributeID As String = .NodeValue

				' Attribute data
				.Node = "3/" + Format$(nCnt) + "/2"
				Dim strAttributeData As String = .NodeValue

				args.Add(strAttributeID, strAttributeData)
			Next

			' CJID
			Dim strCJID As String = args("ControlJobID")

			' Carrier ID
			.Node = "3/3/2/1"
			Dim strCarrierID As String = .NodeValue

			' Check arguments
			If strCJID Is Nothing Then
				SendS14F10(strCJID, strCarrierID, "", "{<u4 444><a'CJID was not specified'>}")
				Exit Sub
			End If
			If strCarrierID Is Nothing Then
				SendS14F10(strCJID, strCarrierID, "", "{<u4 555><a'Carrier ID was not specified'>}")
				Exit Sub
			End If

			' Has CJID already been registered?
			For nCnt = 0 To joblist.Items.Count - 1
				If strCJID = joblist.Items(nCnt).SubItems(2).Text Then
					' Error : Registered
					SendS14F10(strCJID, strCarrierID, "", "{<u4 666><a'CJID is in use'>}")
					Exit Sub
				End If
			Next

			' Locate port number
			Dim nPort As Integer
			If strCarrierID = .get_VIDValue(VIDEnum.VIDCarrierID1) Then
				' Port 1
				nPort = 1
			Else
				If strCarrierID = .get_VIDValue(VIDEnum.VIDCarrierID2) Then
					' Port 2
					nPort = 2
				Else
					' Error : Carrier ID doesn't match
					SendS14F10(strCJID, strCarrierID, "", "{<u4 777><a'Carrier ID doesn' 0x27 't match'>}")
					Exit Sub
				End If
			End If

			' PJIDs
			.Node = "3/2/2"
			Dim strSlot As String = ""
			Dim tree As TreeNode = jobtree.Nodes("Port" + Format$(nPort))
			Dim listPJID As New List(Of TreeNode)
			nNodeCount = .NodeCount
			For nCnt = 0 To nNodeCount - 1
				.Node = "3/2/2/" + Format$(nCnt + 1) + "/1"
				Dim treeFind As TreeNode = FindTreeItem(.NodeValue, tree)
				If treeFind Is Nothing Then
					SendS14F10(strCJID, strCarrierID, "", "{<u4 888><a'PJID doesn' 0x27 't match'>}")
					Exit Sub
				End If

				listPJID.Add(treeFind)
			Next

			' Move PJs under CJ
			Dim treeCJ As TreeNode = tree.Nodes.Add(strCJID)
			For nCnt = 0 To listPJID.Count - 1
				Dim treePJ As TreeNode = listPJID(nCnt).Clone()
				treeCJ.Nodes.Add(treePJ)
				treePJ.Expand()

				Dim lvi As ListViewItem = FindListItem(listPJID(nCnt).Text, 1, joblist)
				If lvi Is Nothing Then
				Else
					lvi.SubItems(2).Text = strCJID
				End If

				tree.Nodes.RemoveByKey(listPJID(nCnt).Text)
			Next
			treeCJ.Expand()

			SendS14F10(strCJID, strCarrierID, "<a'TODO : Set attributes'>", "")
		End With
	End Sub

	Protected Function FindTreeItem(ByVal strFind As String, ByRef tree As TreeNode) As TreeNode
		FindTreeItem = Nothing
		Dim nCnt As Integer
		For nCnt = 0 To tree.Nodes.Count - 1
			If strFind = tree.Nodes(nCnt).Text Then
				FindTreeItem = tree.Nodes(nCnt)
				Exit Function
			End If
		Next
	End Function

	Protected Function FindListItem(ByVal strFind As String, ByVal nColumn As Integer, ByRef list As ListView) As ListViewItem
		FindListItem = Nothing
		Dim nCnt As Integer
		For nCnt = 0 To list.Items.Count - 1
			If strFind = list.Items(nCnt).SubItems(nColumn).Text Then
				FindListItem = list.Items(nCnt)
				Exit Function
			End If
		Next
	End Function

	Protected Function IsValidRecipe(ByVal strRecipe) As Boolean
		IsValidRecipe = False
		Dim nCnt As Integer
		For nCnt = 0 To recipelist.Items.Count - 1
			If strRecipe = recipelist.Items(nCnt) Then
				IsValidRecipe = True
				Exit Function
			End If
		Next
	End Function

	Protected Sub SendS14F10(ByVal strCJID As String, ByVal strCarrierID As String, ByVal strAttribute As String, ByVal strError As String)
		With gem
			.Reply = True
			.Node = ""
			Dim bAck As Boolean
			If strError = "" Then
				bAck = True
			Else
				bAck = False
			End If
			.SML = "s16f12" & _
			 "{" & _
			 "  <a'" & strCJID & "'>" & _
			 "  {" & _
			 strAttribute & _
			 "  }" & _
			 "  {" & _
			 "    <bool " & bAck.ToString() & ">" & _
			 "    {" & _
			 strError & _
			 "    }" & _
			 "  }" & _
			 "}"
		End With
	End Sub

	Protected Sub ReceivedS16F11()
		With gem
			' PJID
			.Node = "2"
			Dim strPJID As String = .NodeValue

			' Carrier ID
			.Node = "4/1/1"
			Dim strCarrierID As String = .NodeValue

			' Recipe
			.Node = "5/2"
			Dim strRecipe As String = .NodeValue

			' Check recipe
			If Not IsValidRecipe(strRecipe) Then
				SendS16F12(strPJID, strCarrierID, "{<u4 111><a'Invalid recipe name'>}")
				Exit Sub
			End If

			' Has PJID already been registered?
			Dim nCnt As Integer
			For nCnt = 0 To joblist.Items.Count - 1
				If strPJID = joblist.Items(nCnt).SubItems(1).Text Then
					' Error : Registered
					SendS16F12(strPJID, strCarrierID, "{<u4 222><a'PJID is in use'>}")
					Exit Sub
				End If
			Next

			' Locate port number
			Dim nPort As Integer
			If strCarrierID = .get_VIDValue(VIDEnum.VIDCarrierID1) Then
				' Port 1
				nPort = 1
			Else
				If strCarrierID = .get_VIDValue(VIDEnum.VIDCarrierID2) Then
					' Port 2
					nPort = 2
				Else
					' Error : Carrier ID doesn't match
					SendS16F12(strPJID, strCarrierID, "{<u4 333><a'Carrier ID doesn' 0x27 't match'>}")
					Exit Sub
				End If
			End If

			' Slot#s
			.Node = "4/1/2"
			Dim strSlot As String = ""
			Dim tree As TreeNode = jobtree.Nodes("Port" + Format$(nPort)).Nodes.Add(strPJID, strPJID)
			Dim nNodeCount As Integer = .NodeCount
			For nCnt = 0 To nNodeCount - 1
				.Node = "4/1/2/" + Format$(nCnt + 1)

				tree.Nodes.Add(.NodeValue, .NodeValue)

				If strSlot <> "" Then
					strSlot += ", "
				End If

				strSlot += .NodeValue
			Next
			tree.Expand()
			jobtree.Nodes("Port" + Format$(nPort)).Expand()

			' Register to list
			Dim lvi As ListViewItem = joblist.Items.Add(strCarrierID)
			lvi.SubItems.Add(strPJID)
			lvi.SubItems.Add("")
			lvi.SubItems.Add(strRecipe)
			lvi.SubItems.Add(strSlot)


			SendS16F12(strPJID, strCarrierID, "")
		End With
	End Sub

	Protected Sub SendS16F12(ByVal strPJID As String, ByVal strCarrierID As String, ByVal strInfo As String)
		With gem
			.Reply = True
			.Node = ""
			Dim bAck As Boolean
			If strInfo = "" Then
				bAck = True
			Else
				bAck = False
			End If
			.SML = "s16f12" & _
			 "{" & _
			 "  <a'" & strPJID & "'>" & _
			 "  {" & _
			 "    <bool " & bAck.ToString() & ">" & _
			 "    {" & _
			 strInfo & _
			 "    }" & _
			 "  }" & _
			 "}"
		End With
	End Sub

	Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		With gem
			.LoadData()
			.PhysicalConnection = True

			' Enumerate all events
			Dim nCnt As Integer
			For nCnt = 0 To .CEIDCount - 1
				Dim lCEID As Long
				lCEID = .ToCEID(nCnt)

				Dim nIndex As Integer
				nIndex = eventlist.Items.Add(.get_CEIDDescription(lCEID))
			Next
		End With

		With recipelist
			' Dummy recipe list
			.Items.Add("Recipe1")
			.Items.Add("Recipe99")
			.Items.Add("RecipeABC")
			.Items.Add("RecipeXYZ")
		End With

		With jobtree
			.Nodes.Add("Port1", gem.get_VIDValue(331))
			.Nodes.Add("Port2", gem.get_VIDValue(332))
		End With
	End Sub

	Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
		gem.Setup("", -1)
	End Sub

	Private Sub gem_CommunicationStateChanged(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_CommunicationStateChangedEvent) Handles gem.CommunicationStateChanged
		Debug.Print("CommunicationStateChanged(" + Format$(e.sPrevState) + ", " + Format$(e.sNewState) + ")")
	End Sub

	Private Sub gem_Connected(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_ConnectedEvent) Handles gem.Connected
		Debug.Print("Connected(" + e.lpszIPAddress + ", " + Format$(e.lPortNumber) + ")")
	End Sub

	Private Sub gem_ConnectionStateChanged(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_ConnectionStateChangedEvent) Handles gem.ConnectionStateChanged
		Debug.Print("ConnectionStateChanged(" + Format$(e.sPrevState) + ", " + Format$(e.sNewState) + ")")
	End Sub

	Private Sub gem_ControlStateChanged(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_ControlStateChangedEvent) Handles gem.ControlStateChanged
		Debug.Print("ControlStateChanged(" + Format$(e.sPrevState) + ", " + Format$(e.sNewState) + ")")
	End Sub

	Private Sub gem_Disconnected(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_DisconnectedEvent) Handles gem.Disconnected
		Debug.Print("Disconnected(" + e.lpszIPAddress + ", " + Format$(e.lPortNumber) + ")")
	End Sub

	Private Sub gem_Problem(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_ProblemEvent) Handles gem.Problem
		Debug.Print("Problem(" + Format$(e.sErrorCode) + ", " + e.lpszAdditionalInfo + ")")
	End Sub

	Private Sub gem_Received(ByVal sender As System.Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_ReceivedEvent) Handles gem.Received
		Debug.Print("Received(" + e.lpszIPAddress + ", " + Format$(e.lPortNumber) + ")")
		With gem
			If .ControlState = 4 Then
				If .Stream = 3 And .Function = 17 Then
					' S3F17 Proceed with carrier
					ReceivedS3F17()
				End If

				If .Stream = 7 And .Function = 19 Then
					' S7F19 Query recipe list
					SendS7F20()
				End If

				If .Stream = 14 And .Function = 9 Then
					' S14F9 CJ create
					ReceivedS14F9()
				End If

				If .Stream = 16 And .Function = 11 Then
					' S16F11 PJ create
					ReceivedS16F11()
				End If
			End If
			.DefProc()
		End With
	End Sub

	Private Sub gem_Sent(ByVal sender As Object, ByVal e As System.EventArgs) Handles gem.Sent
		Debug.Print("Sent()")
	End Sub

	Private Sub gem_VIDChanged(ByVal sender As Object, ByVal e As AxSAVOYLib._DSavoyGemEvents_VIDChangedEvent) Handles gem.VIDChanged
		Debug.Print("VIDChanged(" + Format$(e.lVID) + ")")
	End Sub

	Private Sub eventlist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlist.DoubleClick
		' Make sure an event was selected
		If eventlist.SelectedIndex < 0 Then
			Exit Sub
		End If

		' Send event
		With gem
			Dim lCEID As Long = .ToCEID(eventlist.SelectedIndex)
			.InvokeEvent(lCEID)
		End With
	End Sub

	Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
		gem.AboutBox()
	End Sub
End Class
