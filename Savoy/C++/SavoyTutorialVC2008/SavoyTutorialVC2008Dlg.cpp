
// SavoyTutorialVC2008Dlg.cpp : implementation file
//

#include "stdafx.h"
#include "SavoyTutorialVC2008.h"
#include "SavoyTutorialVC2008Dlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// CSavoyTutorialVC2008Dlg dialog




CSavoyTutorialVC2008Dlg::CSavoyTutorialVC2008Dlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSavoyTutorialVC2008Dlg::IDD, pParent)
	, m_strPPID(_T(""))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CSavoyTutorialVC2008Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_SAVOYHSMSCTRL1, m_hsms);
	DDX_Control(pDX, IDC_SAVOYSECSIICTRL1, m_inmsg);
	DDX_Text(pDX, IDC_EDIT1, m_strPPID);
	DDX_Control(pDX, IDC_SAVOYSECSIICTRL2, m_outmsg);
}

BEGIN_MESSAGE_MAP(CSavoyTutorialVC2008Dlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_BUTTON1, &CSavoyTutorialVC2008Dlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CSavoyTutorialVC2008Dlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CSavoyTutorialVC2008Dlg::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CSavoyTutorialVC2008Dlg::OnBnClickedButton4)
END_MESSAGE_MAP()


// CSavoyTutorialVC2008Dlg message handlers

BOOL CSavoyTutorialVC2008Dlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CSavoyTutorialVC2008Dlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CSavoyTutorialVC2008Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CSavoyTutorialVC2008Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CSavoyTutorialVC2008Dlg::OnBnClickedButton1()
{
	// Setup
	m_hsms.LoadIniFile();
	if(m_hsms.Setup(""))
	{
		// If OK button was pressed, establish connection
		m_hsms.SetConnect(true);
	}
}

void CSavoyTutorialVC2008Dlg::OnBnClickedButton2()
{
	// Send S1F13
	m_outmsg.SetSml("s1f13w{}");
	m_hsms.Send(m_outmsg.GetMsg());
}

void CSavoyTutorialVC2008Dlg::OnBnClickedButton3()
{
	// Send S2F41 PP-Select
	UpdateData();
	m_outmsg.SetSml("s2f41w{<a'PP-SELECT'>{{<a'PPID'><a'" + m_strPPID + "'>}}}");
	m_hsms.Send(m_outmsg.GetMsg());
}

void CSavoyTutorialVC2008Dlg::OnBnClickedButton4()
{
	// Send S2F41 Start
	m_outmsg.SetSml("s2f41w{<A'START'>{{}}}");
	m_hsms.Send(m_outmsg.GetMsg());
}
BEGIN_EVENTSINK_MAP(CSavoyTutorialVC2008Dlg, CDialog)
	ON_EVENT(CSavoyTutorialVC2008Dlg, IDC_SAVOYHSMSCTRL1, 1, CSavoyTutorialVC2008Dlg::ConnectedSavoyhsmsctrl1, VTS_BSTR VTS_I4)
	ON_EVENT(CSavoyTutorialVC2008Dlg, IDC_SAVOYHSMSCTRL1, 4, CSavoyTutorialVC2008Dlg::ReceivedSavoyhsmsctrl1, VTS_BSTR VTS_I4 VTS_BSTR)
END_EVENTSINK_MAP()

void CSavoyTutorialVC2008Dlg::ConnectedSavoyhsmsctrl1(LPCTSTR lpszIPAddress, long lPortNumber)
{
	// Connected
	// Send select request
	m_outmsg.SetSml("Select.req");
	m_hsms.Send(m_outmsg.GetMsg());
}

void CSavoyTutorialVC2008Dlg::ReceivedSavoyhsmsctrl1(LPCTSTR lpszIPAddress, long lPortNumber, LPCTSTR lpszMsg)
{
	m_inmsg.SetMsg(lpszMsg);
	switch(m_inmsg.GetSType())
	{
	case 0:
		// Data message
		if(m_inmsg.GetWbit() && m_inmsg.GetFunction()%2)
		{
			// Need to reply something...
			m_outmsg.SetSml("<b 0>");
			m_outmsg.Reply(lpszMsg);
			m_hsms.Send(m_outmsg.GetMsg());
		}
		break;
	case 1:
		// Select request
		m_outmsg.SetSml("Select.rsp");
		m_outmsg.Reply(lpszMsg);
		m_hsms.Send(m_outmsg.GetMsg());
		break;
	}
}
