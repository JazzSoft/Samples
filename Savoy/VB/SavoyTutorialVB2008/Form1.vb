Public Class Form1

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		' Setup
		hsms.LoadIniFile()
		If hsms.Setup("") Then
			' If OK button was pressed, establish connection
			hsms.Connect = True
		End If
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		' Send S1F13
		outmsg.SML = "s1f13w{}"
		hsms.Send(outmsg.Msg)
	End Sub

	Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
		' Send S2F41 PP-Select
		outmsg.SML = "s2f41w{<a'PP-SELECT'>{{<a'PPID'><a'" + TextBox1.Text + "'>}}}"
		hsms.Send(outmsg.Msg)
	End Sub

	Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
		' Send S2F41 Start
		outmsg.SML = "s2f41w{<A'START'>{{}}}"
		hsms.Send(outmsg.Msg)
	End Sub

	Private Sub hsms_Connected(ByVal sender As System.Object, ByVal e As AxSAVOYLib._DSavoyHsmsEvents_ConnectedEvent) Handles hsms.Connected
		' Connected
		' Send select request
		outmsg.SML = "Select.req"
		hsms.Send(outmsg.Msg)
	End Sub

	Private Sub hsms_Received(ByVal sender As System.Object, ByVal e As AxSAVOYLib._DSavoyHsmsEvents_ReceivedEvent) Handles hsms.Received
		inmsg.Msg = e.lpszMsg
		Select Case inmsg.SType
			Case 0
				' Data message
				If inmsg.Wbit And (inmsg.Function Mod 2) <> 0 Then
					' Need to reply something...
					outmsg.SML = "<b 0>"
					outmsg.Reply(e.lpszMsg)
					hsms.Send(outmsg.Msg)
				End If
			Case 1
				' Select request
				outmsg.SML = "Select.rsp"
				outmsg.Reply(e.lpszMsg)
				hsms.Send(outmsg.Msg)
		End Select
	End Sub
End Class
