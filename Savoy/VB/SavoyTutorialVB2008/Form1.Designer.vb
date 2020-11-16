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
		Me.hsms = New AxSAVOYLib.AxSavoyHsms
		Me.inmsg = New AxSAVOYLib.AxSavoySecsII
		Me.outmsg = New AxSAVOYLib.AxSavoySecsII
		Me.Button1 = New System.Windows.Forms.Button
		Me.Button2 = New System.Windows.Forms.Button
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.Button3 = New System.Windows.Forms.Button
		Me.Button4 = New System.Windows.Forms.Button
		CType(Me.hsms, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.inmsg, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.outmsg, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'hsms
		'
		Me.hsms.Enabled = True
		Me.hsms.Location = New System.Drawing.Point(12, 12)
		Me.hsms.Name = "hsms"
		Me.hsms.OcxState = CType(resources.GetObject("hsms.OcxState"), System.Windows.Forms.AxHost.State)
		Me.hsms.Size = New System.Drawing.Size(266, 70)
		Me.hsms.TabIndex = 0
		'
		'inmsg
		'
		Me.inmsg.Enabled = True
		Me.inmsg.Location = New System.Drawing.Point(12, 88)
		Me.inmsg.Name = "inmsg"
		Me.inmsg.OcxState = CType(resources.GetObject("inmsg.OcxState"), System.Windows.Forms.AxHost.State)
		Me.inmsg.Size = New System.Drawing.Size(178, 82)
		Me.inmsg.TabIndex = 1
		'
		'outmsg
		'
		Me.outmsg.Enabled = True
		Me.outmsg.Location = New System.Drawing.Point(12, 176)
		Me.outmsg.Name = "outmsg"
		Me.outmsg.OcxState = CType(resources.GetObject("outmsg.OcxState"), System.Windows.Forms.AxHost.State)
		Me.outmsg.Size = New System.Drawing.Size(178, 82)
		Me.outmsg.TabIndex = 2
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(196, 88)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(82, 30)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "&Open..."
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(196, 124)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(82, 30)
		Me.Button2.TabIndex = 4
		Me.Button2.Text = "On&line"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(196, 160)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(82, 20)
		Me.TextBox1.TabIndex = 5
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(196, 186)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(82, 30)
		Me.Button3.TabIndex = 6
		Me.Button3.Text = "&PP Select"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(196, 222)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(82, 30)
		Me.Button4.TabIndex = 7
		Me.Button4.Text = "PP &Start"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(290, 270)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.outmsg)
		Me.Controls.Add(Me.inmsg)
		Me.Controls.Add(Me.hsms)
		Me.Name = "Form1"
		Me.Text = "Savoy Tutorial VB2008"
		CType(Me.hsms, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.inmsg, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.outmsg, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents hsms As AxSAVOYLib.AxSavoyHsms
	Friend WithEvents inmsg As AxSAVOYLib.AxSavoySecsII
	Friend WithEvents outmsg As AxSAVOYLib.AxSavoySecsII
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Button3 As System.Windows.Forms.Button
	Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
