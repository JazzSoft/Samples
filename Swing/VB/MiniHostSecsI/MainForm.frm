VERSION 5.00
Object = "{2BEAF722-5DD2-11D2-8455-00E0290C233C}#3.20#0"; "swing.ocx"
Begin VB.Form Form1 
   Caption         =   "Swing Sample - Mini Host"
   ClientHeight    =   4200
   ClientLeft      =   120
   ClientTop       =   420
   ClientWidth     =   6975
   LinkTopic       =   "Form1"
   ScaleHeight     =   4200
   ScaleWidth      =   6975
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      Height          =   315
      Left            =   5460
      TabIndex        =   6
      Text            =   "PPID"
      Top             =   720
      Width           =   1395
   End
   Begin VB.CommandButton Command1 
      Caption         =   "PP &Start"
      Height          =   495
      Index           =   2
      Left            =   5460
      TabIndex        =   5
      Top             =   1860
      Width           =   1395
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&PP Select"
      Height          =   495
      Index           =   1
      Left            =   5460
      TabIndex        =   4
      Top             =   1260
      Width           =   1395
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Online"
      Height          =   495
      Index           =   0
      Left            =   5460
      TabIndex        =   3
      Top             =   120
      Width           =   1395
   End
   Begin SWINGLib.SwingSecsII SwingSecsII1 
      Height          =   1935
      Index           =   0
      Left            =   2520
      TabIndex        =   1
      Top             =   120
      Width           =   2835
      _Version        =   196628
      _ExtentX        =   5001
      _ExtentY        =   3413
      _StockProps     =   160
      Appearance      =   1
   End
   Begin SWINGLib.SwingSecsI SwingSecsI1 
      Height          =   3975
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2295
      _Version        =   196628
      _ExtentX        =   4048
      _ExtentY        =   7011
      _StockProps     =   160
      Appearance      =   1
   End
   Begin SWINGLib.SwingSecsII SwingSecsII1 
      Height          =   1935
      Index           =   1
      Left            =   2520
      TabIndex        =   2
      Top             =   2160
      Width           =   2835
      _Version        =   196628
      _ExtentX        =   5001
      _ExtentY        =   3413
      _StockProps     =   160
      Appearance      =   1
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click(Index As Integer)
    With SwingSecsII1(1)
        Select Case Index
        Case 0
            'Attempt online
            .List = "s1f13w{}"
        Case 1
            'Select recipe
            .List = "s2f41w{<a'PP-SELECT'>{{<a'PPID'><a'" + Text1.Text + "'>}}}"
        Case 2
            'Start measurement
            .List = "s2f41w{<a'START'>{{}}}"
        End Select
        SwingSecsI1.Send .Msg
    End With
End Sub

Private Sub Form_Load()
    With SwingSecsI1
        .Active = True
        If Not .Active Then
            MsgBox "Error : Cannot open serial port!"
        End If
    End With
End Sub

Private Sub SwingSecsI1_Read(ByVal pszMsg As String)
    With SwingSecsII1(0)
        .Msg = pszMsg
        If .Stream = 1 And .Function = 14 Then
            'S1F14
            MsgBox "You are online"
        End If
        If .Stream = 6 And .Function = 11 Then
            'S6F11
            SwingSecsII1(1).List = "s6f12<b 0>"
            SwingSecsII1(1).Reply pszMsg
            SwingSecsI1.Send SwingSecsII1(1).Msg
            'CEID
            .Pointer = "2"
            Select Case CInt(.Value)
            Case 10
                MsgBox "Recipe selected"
            Case 11
                MsgBox "Recipe selection failure"
            Case 20
                MsgBox "Measurement completed"
            Case 30
                'Measurement data
            End Select
        End If
    End With
End Sub
