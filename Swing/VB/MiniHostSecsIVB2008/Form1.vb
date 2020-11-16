Public Class Form1

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		'Attempt online
		With AxSwingSecsII2
			.List = "s1f13w{}"
			AxSwingSecsI1.Send(.Msg)
		End With
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		'Select recipe
		With AxSwingSecsII2
			.List = "s2f41w{<a'PP-SELECT'>{{<a'PPID'><a'" + TextBox1.Text + "'>}}}"
			AxSwingSecsI1.Send(.Msg)
		End With
	End Sub

	Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
		'Start measurement
		With AxSwingSecsII2
			.List = "s2f41w{<a'START'>{{}}}"
			AxSwingSecsI1.Send(.Msg)
		End With
	End Sub

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		With AxSwingSecsI1
			.Active = True
			If Not .Active Then
				MsgBox("Error : Cannot open serial port!")
			End If
		End With
	End Sub

	Private Sub AxSwingSecsI1_Read(ByVal sender As System.Object, ByVal e As AxSWINGLib._DSwingSecsIEvents_ReadEvent) Handles AxSwingSecsI1.Read
		With AxSwingSecsII1
			.Msg = e.pszMsg
			If .Stream = 1 And .Function = 14 Then
				'S1F14
				MsgBox("You are online")
			End If
			If .Stream = 6 And .Function = 11 Then
				'S6F11
				AxSwingSecsII2.List = "s6f12<b 0>"
				AxSwingSecsII2.Reply(e.pszMsg)
				AxSwingSecsI1.Send(AxSwingSecsII2.Msg)
				'CEID
				.Pointer = "2"
				Select Case CInt(.Value)
					Case 10
						MsgBox("Recipe selected")
					Case 11
						MsgBox("Recipe selection failure")
					Case 20
						MsgBox("Measurement completed")
					Case 30
						'Measurement data
				End Select
			End If
		End With
	End Sub
End Class
