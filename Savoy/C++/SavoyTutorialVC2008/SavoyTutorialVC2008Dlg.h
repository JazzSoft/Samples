
// SavoyTutorialVC2008Dlg.h : header file
//

#pragma once
#include "SavoyHsms.h"
#include "SavoySecsII.h"


// CSavoyTutorialVC2008Dlg dialog
class CSavoyTutorialVC2008Dlg : public CDialog
{
// Construction
public:
	CSavoyTutorialVC2008Dlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_SAVOYTUTORIALVC2008_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	CSavoyHsms m_hsms;
	CSavoySecsII m_inmsg;
	CString m_strPPID;
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton4();
	DECLARE_EVENTSINK_MAP()
	void ConnectedSavoyhsmsctrl1(LPCTSTR lpszIPAddress, long lPortNumber);
	void ReceivedSavoyhsmsctrl1(LPCTSTR lpszIPAddress, long lPortNumber, LPCTSTR lpszMsg);
	CSavoySecsII m_outmsg;
};
