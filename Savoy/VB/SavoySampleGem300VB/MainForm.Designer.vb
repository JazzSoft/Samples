<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
		Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
		Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
		Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
		Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.gem = New AxSAVOYLib.AxSavoyGem
		Me.TabControl1 = New System.Windows.Forms.TabControl
		Me.TabPage1 = New System.Windows.Forms.TabPage
		Me.joblist = New System.Windows.Forms.ListView
		Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
		Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
		Me.jobtree = New System.Windows.Forms.TreeView
		Me.TabPage2 = New System.Windows.Forms.TabPage
		Me.eventlist = New System.Windows.Forms.ListBox
		Me.TabPage3 = New System.Windows.Forms.TabPage
		Me.recipelist = New System.Windows.Forms.ListBox
		Me.MenuStrip1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.gem, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.NewToolStripMenuItem.Text = "&New"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
		Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.OpenToolStripMenuItem.Text = "&Open"
		'
		'toolStripSeparator
		'
		Me.toolStripSeparator.Name = "toolStripSeparator"
		Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
		Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.SaveToolStripMenuItem.Text = "&Save"
		'
		'SaveAsToolStripMenuItem
		'
		Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
		Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.SaveAsToolStripMenuItem.Text = "Save &As"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
		'
		'PrintToolStripMenuItem
		'
		Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
		Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.PrintToolStripMenuItem.Text = "&Print"
		'
		'PrintPreviewToolStripMenuItem
		'
		Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
		Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'EditToolStripMenuItem
		'
		Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
		Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
		Me.EditToolStripMenuItem.Text = "&Edit"
		'
		'UndoToolStripMenuItem
		'
		Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
		Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
		Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.UndoToolStripMenuItem.Text = "&Undo"
		'
		'RedoToolStripMenuItem
		'
		Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
		Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.RedoToolStripMenuItem.Text = "&Redo"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
		'
		'CutToolStripMenuItem
		'
		Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
		Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.CutToolStripMenuItem.Text = "Cu&t"
		'
		'CopyToolStripMenuItem
		'
		Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
		Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.CopyToolStripMenuItem.Text = "&Copy"
		'
		'PasteToolStripMenuItem
		'
		Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
		Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.PasteToolStripMenuItem.Text = "&Paste"
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
		'
		'SelectAllToolStripMenuItem
		'
		Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
		Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.SelectAllToolStripMenuItem.Text = "Select &All"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.ToolsToolStripMenuItem.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem
		'
		Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
		Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
		Me.CustomizeToolStripMenuItem.Text = "&Customize"
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
		Me.OptionsToolStripMenuItem.Text = "&Options..."
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "&Help"
		'
		'ContentsToolStripMenuItem
		'
		Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
		Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.ContentsToolStripMenuItem.Text = "&Contents"
		'
		'IndexToolStripMenuItem
		'
		Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
		Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.IndexToolStripMenuItem.Text = "&Index"
		'
		'SearchToolStripMenuItem
		'
		Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
		Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.SearchToolStripMenuItem.Text = "&Search"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.AboutToolStripMenuItem.Text = "&About..."
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator6, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator7, Me.HelpToolStripButton})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(813, 25)
		Me.ToolStrip1.TabIndex = 1
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'NewToolStripButton
		'
		Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
		Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripButton.Name = "NewToolStripButton"
		Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.NewToolStripButton.Text = "&New"
		'
		'OpenToolStripButton
		'
		Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
		Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.OpenToolStripButton.Name = "OpenToolStripButton"
		Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.OpenToolStripButton.Text = "&Open"
		'
		'SaveToolStripButton
		'
		Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
		Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveToolStripButton.Name = "SaveToolStripButton"
		Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.SaveToolStripButton.Text = "&Save"
		'
		'PrintToolStripButton
		'
		Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
		Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintToolStripButton.Name = "PrintToolStripButton"
		Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.PrintToolStripButton.Text = "&Print"
		'
		'toolStripSeparator6
		'
		Me.toolStripSeparator6.Name = "toolStripSeparator6"
		Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
		'
		'CutToolStripButton
		'
		Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
		Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CutToolStripButton.Name = "CutToolStripButton"
		Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.CutToolStripButton.Text = "C&ut"
		'
		'CopyToolStripButton
		'
		Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
		Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CopyToolStripButton.Name = "CopyToolStripButton"
		Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.CopyToolStripButton.Text = "&Copy"
		'
		'PasteToolStripButton
		'
		Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
		Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PasteToolStripButton.Name = "PasteToolStripButton"
		Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.PasteToolStripButton.Text = "&Paste"
		'
		'toolStripSeparator7
		'
		Me.toolStripSeparator7.Name = "toolStripSeparator7"
		Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
		'
		'HelpToolStripButton
		'
		Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
		Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.HelpToolStripButton.Name = "HelpToolStripButton"
		Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
		Me.HelpToolStripButton.Text = "He&lp"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 512)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(813, 22)
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.gem)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
		Me.SplitContainer1.Size = New System.Drawing.Size(813, 463)
		Me.SplitContainer1.SplitterDistance = 229
		Me.SplitContainer1.TabIndex = 3
		'
		'gem
		'
		Me.gem.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gem.Enabled = True
		Me.gem.Location = New System.Drawing.Point(0, 0)
		Me.gem.Name = "gem"
		Me.gem.OcxState = CType(resources.GetObject("gem.OcxState"), System.Windows.Forms.AxHost.State)
		Me.gem.Size = New System.Drawing.Size(229, 463)
		Me.gem.TabIndex = 0
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(580, 463)
		Me.TabControl1.TabIndex = 3
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.joblist)
		Me.TabPage1.Controls.Add(Me.jobtree)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(572, 437)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Job"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'joblist
		'
		Me.joblist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.joblist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
		Me.joblist.GridLines = True
		Me.joblist.Location = New System.Drawing.Point(153, 6)
		Me.joblist.Name = "joblist"
		Me.joblist.Size = New System.Drawing.Size(413, 176)
		Me.joblist.TabIndex = 3
		Me.joblist.UseCompatibleStateImageBehavior = False
		Me.joblist.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "Carrier ID"
		Me.ColumnHeader1.Width = 75
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "PJID"
		Me.ColumnHeader2.Width = 75
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "CJID"
		Me.ColumnHeader3.Width = 75
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Recipe"
		Me.ColumnHeader4.Width = 75
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "Slots"
		Me.ColumnHeader5.Width = 150
		'
		'jobtree
		'
		Me.jobtree.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.jobtree.Location = New System.Drawing.Point(6, 6)
		Me.jobtree.Name = "jobtree"
		Me.jobtree.Size = New System.Drawing.Size(141, 425)
		Me.jobtree.TabIndex = 2
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.eventlist)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(572, 437)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Event"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'eventlist
		'
		Me.eventlist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.eventlist.FormattingEnabled = True
		Me.eventlist.IntegralHeight = False
		Me.eventlist.Location = New System.Drawing.Point(6, 6)
		Me.eventlist.Name = "eventlist"
		Me.eventlist.Size = New System.Drawing.Size(141, 425)
		Me.eventlist.TabIndex = 0
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.recipelist)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(572, 437)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Recipe"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'recipelist
		'
		Me.recipelist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.recipelist.FormattingEnabled = True
		Me.recipelist.IntegralHeight = False
		Me.recipelist.Location = New System.Drawing.Point(6, 6)
		Me.recipelist.Name = "recipelist"
		Me.recipelist.Size = New System.Drawing.Size(141, 425)
		Me.recipelist.TabIndex = 1
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(813, 534)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "MainForm"
		Me.Text = "Savoy Sample GEM 300"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.gem, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents gem As AxSAVOYLib.AxSavoyGem
	Friend WithEvents eventlist As System.Windows.Forms.ListBox
	Friend WithEvents recipelist As System.Windows.Forms.ListBox
	Friend WithEvents jobtree As System.Windows.Forms.TreeView
	Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
	Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
	Friend WithEvents joblist As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

End Class
