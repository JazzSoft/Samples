<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.AxSwingSecsI1 = New AxSWINGLib.AxSwingSecsI
		Me.AxSwingSecsII1 = New AxSWINGLib.AxSwingSecsII
		Me.AxSwingSecsII2 = New AxSWINGLib.AxSwingSecsII
		Me.Button1 = New System.Windows.Forms.Button
		Me.Button2 = New System.Windows.Forms.Button
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.Button3 = New System.Windows.Forms.Button
		CType(Me.AxSwingSecsI1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AxSwingSecsII1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AxSwingSecsII2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'AxSwingSecsI1
		'
		Me.AxSwingSecsI1.Enabled = True
		Me.AxSwingSecsI1.Location = New System.Drawing.Point(12, 12)
		Me.AxSwingSecsI1.Name = "AxSwingSecsI1"
		Me.AxSwingSecsI1.OcxState = CType(resources.GetObject("AxSwingSecsI1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxSwingSecsI1.Size = New System.Drawing.Size(164, 240)
		Me.AxSwingSecsI1.TabIndex = 0
		'
		'AxSwingSecsII1
		'
		Me.AxSwingSecsII1.Enabled = True
		Me.AxSwingSecsII1.Location = New System.Drawing.Point(182, 12)
		Me.AxSwingSecsII1.Name = "AxSwingSecsII1"
		Me.AxSwingSecsII1.OcxState = CType(resources.GetObject("AxSwingSecsII1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxSwingSecsII1.Size = New System.Drawing.Size(182, 117)
		Me.AxSwingSecsII1.TabIndex = 1
		'
		'AxSwingSecsII2
		'
		Me.AxSwingSecsII2.Enabled = True
		Me.AxSwingSecsII2.Location = New System.Drawing.Point(182, 135)
		Me.AxSwingSecsII2.Name = "AxSwingSecsII2"
		Me.AxSwingSecsII2.OcxState = CType(resources.GetObject("AxSwingSecsII2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxSwingSecsII2.Size = New System.Drawing.Size(182, 117)
		Me.AxSwingSecsII2.TabIndex = 2
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(370, 12)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(88, 31)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "&Online"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(370, 75)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(88, 31)
		Me.Button2.TabIndex = 4
		Me.Button2.Text = "&PP Select"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(370, 49)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(88, 20)
		Me.TextBox1.TabIndex = 5
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(370, 112)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(88, 31)
		Me.Button3.TabIndex = 6
		Me.Button3.Text = "PP &Start"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(470, 264)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.AxSwingSecsII2)
		Me.Controls.Add(Me.AxSwingSecsII1)
		Me.Controls.Add(Me.AxSwingSecsI1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.AxSwingSecsI1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AxSwingSecsII1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AxSwingSecsII2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents AxSwingSecsI1 As AxSWINGLib.AxSwingSecsI
	Friend WithEvents AxSwingSecsII1 As AxSWINGLib.AxSwingSecsII
	Friend WithEvents AxSwingSecsII2 As AxSWINGLib.AxSwingSecsII
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
