
// SavoyTutorialVC2008.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "SavoyTutorialVC2008.h"
#include "SavoyTutorialVC2008Dlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CSavoyTutorialVC2008App

BEGIN_MESSAGE_MAP(CSavoyTutorialVC2008App, CWinAppEx)
	ON_COMMAND(ID_HELP, &CWinApp::OnHelp)
END_MESSAGE_MAP()


// CSavoyTutorialVC2008App construction

CSavoyTutorialVC2008App::CSavoyTutorialVC2008App()
{
	// TODO: add construction code here,
	// Place all significant initialization in InitInstance
}


// The one and only CSavoyTutorialVC2008App object

CSavoyTutorialVC2008App theApp;


// CSavoyTutorialVC2008App initialization

BOOL CSavoyTutorialVC2008App::InitInstance()
{
	// InitCommonControlsEx() is required on Windows XP if an application
	// manifest specifies use of ComCtl32.dll version 6 or later to enable
	// visual styles.  Otherwise, any window creation will fail.
	INITCOMMONCONTROLSEX InitCtrls;
	InitCtrls.dwSize = sizeof(InitCtrls);
	// Set this to include all the common control classes you want to use
	// in your application.
	InitCtrls.dwICC = ICC_WIN95_CLASSES;
	InitCommonControlsEx(&InitCtrls);

	CWinAppEx::InitInstance();

	AfxEnableControlContainer();

	// Standard initialization
	// If you are not using these features and wish to reduce the size
	// of your final executable, you should remove from the following
	// the specific initialization routines you do not need
	// Change the registry key under which our settings are stored
	// TODO: You should modify this string to be something appropriate
	// such as the name of your company or organization
	SetRegistryKey(_T("Local AppWizard-Generated Applications"));

	CSavoyTutorialVC2008Dlg dlg;
	m_pMainWnd = &dlg;
	INT_PTR nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
		// TODO: Place code here to handle when the dialog is
		//  dismissed with OK
	}
	else if (nResponse == IDCANCEL)
	{
		// TODO: Place code here to handle when the dialog is
		//  dismissed with Cancel
	}

	// Since the dialog has been closed, return FALSE so that we exit the
	//  application, rather than start the application's message pump.
	return FALSE;
}
