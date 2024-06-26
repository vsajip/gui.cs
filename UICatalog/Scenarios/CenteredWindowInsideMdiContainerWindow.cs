﻿using Terminal.Gui;

namespace UICatalog.Scenarios {
	[ScenarioMetadata (Name: "CenteredWindowInsideMdiContainerWindow", Description: "Centered Window Inside MdiContainer Window")]
	[ScenarioCategory ("Controls")]
	public class CenteredWindowInsideMdiContainerWindow : Scenario {
		public override void Init (ColorScheme colorScheme)
		{
			Application.Run<ParentWindowMdiContainerClass> ();
			Application.Shutdown ();
		}

		public override void Run ()
		{
		}
	}


	//------------------------------------------------------------------------------

	//  <auto-generated>
	//      This code was generated by:
	//        TerminalGuiDesigner v1.0.24.0
	//      You can make changes to this file and they will not be overwritten when saving.
	//  </auto-generated>
	// -----------------------------------------------------------------------------

	public partial class ParentWindowMdiContainerClass {

		private MdiChildWindowClass _childWindow;

		public ParentWindowMdiContainerClass ()
		{
			InitializeComponent ();
			// MenuBar
			createChildMenuItem.CanExecute = CanExecuteCreateChildWindow;
			createChildMenuItem.Action = CreateChildWindow;
			centerChildMenuItem.CanExecute = CanExecuteCenterChildWindow;
			centerChildMenuItem.Action = CenterChildWindow;
			hideShowChildMenuItem.CanExecute = CanExecuteHideShowChildWindow;
			hideShowChildMenuItem.Action = HideShowChildWindow;
			borderChildMenuItem.CanExecute = CanExecuteCenterChildWindow;
			borderChildMenuItem.Action = BorderToggleChildWindow;
			parentMenu.Action = BorderToggleParentWindow;
			// StatusBar
			createChildStatusItem.CanExecute = CanExecuteCreateChildWindow;
			createChildStatusItem.Action = CreateChildWindow;
			centerChildStatusItem.CanExecute = CanExecuteCenterChildWindow;
			centerChildStatusItem.Action = CenterChildWindow;
			hideShowChildStatusItem.CanExecute = CanExecuteHideShowChildWindow;
			hideShowChildStatusItem.Action = HideShowChildWindow;
			borderChildStatusItem.CanExecute = CanExecuteCenterChildWindow;
			borderChildStatusItem.Action = BorderToggleChildWindow;
			borderParentStatusItem.Action = BorderToggleParentWindow;

			KeyPress += ParentWindowClass_KeyPress;
		}

		private void BorderToggleParentWindow ()
		{
			if (Border.BorderStyle == BorderStyle.None) {
				Border.BorderStyle = BorderStyle.Single;
				// MenuBar
				parentMenu.Title = "Borderless _Parent";
				// StatusBar
				borderParentStatusItem.Title = "~CTRL-F1~ Borderless Parent";
			} else {
				Border.BorderStyle = BorderStyle.None;
				Border.DrawMarginFrame = false;
				// MenuBar
				parentMenu.Title = "Border _Parent";
				// StatusBar
				borderParentStatusItem.Title = "~CTRL-F1~ Border Parent";
			}
		}

		private void BorderToggleChildWindow ()
		{
			if (_childWindow.Border.BorderStyle == BorderStyle.None) {
				_childWindow.Border.BorderStyle = BorderStyle.Single;
				// MenuBar
				borderChildMenuItem.Title = "_Borderless Child";
				// StatusBar
				borderChildStatusItem.Title = "~CTRL-F2~ Borderless Child";
			} else {
				_childWindow.Border.BorderStyle = BorderStyle.None;
				_childWindow.Border.DrawMarginFrame = false;
				// MenuBar
				borderChildMenuItem.Title = "_Border Child";
				// StatusBar
				borderChildStatusItem.Title = "~CTRL-F2~ Border Child";
			}
		}

		private void ParentWindowClass_KeyPress (KeyEventEventArgs obj)
		{
			switch (obj.KeyEvent.Key) {
			case Key.F8:
				menuBar.Visible = !menuBar.Visible;
				obj.Handled = true;
				break;
			case Key.F10:
				statusBar.Visible = !statusBar.Visible;
				obj.Handled = true;
				break;
			}
		}

		private bool CanExecuteCreateChildWindow () => _childWindow == null;

		private void CreateChildWindow ()
		{
			_childWindow ??= new MdiChildWindowClass ();
			Application.Top.SetNeedsDisplay ();
			Application.Run (_childWindow);
		}

		private bool CanExecuteCenterChildWindow () => _childWindow != null && _childWindow.Visible;

		private void CenterChildWindow ()
		{
			_childWindow.X = Pos.Center ();
			_childWindow.Y = Pos.Center ();
		}

		private bool CanExecuteHideShowChildWindow () => _childWindow != null;

		private void HideShowChildWindow ()
		{
			if (_childWindow.Visible) {
				_childWindow.Visible = false;
				// MenuBar
				hideShowChildMenuItem.Title = "Un_Hide Child";
				// StatusBar
				hideShowChildStatusItem.Title = "~CTRL-F7~ UnHide Child";
				SetNeedsDisplay ();
			} else {
				_childWindow.Visible = true;
				// MenuBar
				hideShowChildMenuItem.Title = "_Hide Child";
				// StatusBar
				hideShowChildStatusItem.Title = "~CTRL-F7~ Hide Child";
				ShowChild (_childWindow);
			}
		}
	}

	//------------------------------------------------------------------------------

	//  <auto-generated>
	//      This code was generated by:
	//        TerminalGuiDesigner v1.0.24.0
	//      Changes to this file may cause incorrect behavior and will be lost if
	//      the code is regenerated.
	//  </auto-generated>
	// -----------------------------------------------------------------------------

	public partial class ParentWindowMdiContainerClass : Terminal.Gui.Window {

		private Terminal.Gui.MenuBar menuBar;

		private Terminal.Gui.MenuBarItem childMenu;

		private Terminal.Gui.MenuItem createChildMenuItem;
		private Terminal.Gui.MenuItem centerChildMenuItem;
		private Terminal.Gui.MenuItem hideShowChildMenuItem;
		private Terminal.Gui.MenuItem borderChildMenuItem;

		private Terminal.Gui.MenuBarItem parentMenu;

		private Terminal.Gui.StatusBar statusBar;

		private Terminal.Gui.StatusItem createChildStatusItem;
		private Terminal.Gui.StatusItem centerChildStatusItem;
		private Terminal.Gui.StatusItem hideShowChildStatusItem;
		private Terminal.Gui.StatusItem borderChildStatusItem;
		private Terminal.Gui.StatusItem borderParentStatusItem;

		private void InitializeComponent ()
		{
			this.IsMdiContainer = true;
			this.menuBar = new Terminal.Gui.MenuBar ();
			this.Width = Dim.Fill (0);
			this.Height = Dim.Fill (0);
			this.X = 0;
			this.Y = 0;
			this.Modal = false;
			this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
			this.Border.BorderBrush = Terminal.Gui.Color.White;
			this.Border.Effect3D = false;
			this.Border.Effect3DBrush = null;
			this.Border.DrawMarginFrame = true;
			this.TextAlignment = Terminal.Gui.TextAlignment.Left;
			this.Title = "Mdi Parent Window (Press F8 to Hide/Show MenuBar)(Press F10 to Hide/Show StatusBar)";
			this.menuBar.Width = Dim.Fill (0);
			this.menuBar.Height = 1;
			this.menuBar.X = 0;
			this.menuBar.Y = 0;
			this.menuBar.Data = "menuBar";
			this.menuBar.TextAlignment = Terminal.Gui.TextAlignment.Left;
			this.childMenu = new Terminal.Gui.MenuBarItem ();
			this.childMenu.Title = "Ch_ild";
			this.parentMenu = new Terminal.Gui.MenuBarItem ();
			this.parentMenu.Title = "Borderless _Parent";
			this.menuBar.Menus = new Terminal.Gui.MenuBarItem [] {
					this.childMenu, this.parentMenu};
			this.createChildMenuItem = new Terminal.Gui.MenuItem ();
			this.createChildMenuItem.Title = "_Create Child";
			this.createChildMenuItem.Data = "createChildMenuItem";
			this.centerChildMenuItem = new Terminal.Gui.MenuItem ();
			this.centerChildMenuItem.Title = "C_enter Child";
			this.centerChildMenuItem.Data = "centerChildMenuItem";
			this.hideShowChildMenuItem = new Terminal.Gui.MenuItem ();
			this.hideShowChildMenuItem.Title = "_Hide Child";
			this.hideShowChildMenuItem.Data = "hideShowChildMenuItem";
			this.borderChildMenuItem = new Terminal.Gui.MenuItem ();
			this.borderChildMenuItem.Title = "_Borderless Child";
			this.borderChildMenuItem.Data = "borderChildMenuItem";
			this.childMenu.Children = new Terminal.Gui.MenuItem [] {
					this.createChildMenuItem, this.centerChildMenuItem, this.hideShowChildMenuItem, this.borderChildMenuItem};
			this.Add (this.menuBar);
			this.statusBar = new Terminal.Gui.StatusBar ();
			this.statusBar.Width = Dim.Fill ();
			this.statusBar.Height = 1;
			this.statusBar.X = 0;
			this.statusBar.Y = Pos.AnchorEnd (1);
			this.statusBar.Data = "statusBar";
			this.statusBar.TextAlignment = Terminal.Gui.TextAlignment.Left;
			this.createChildStatusItem = new Terminal.Gui.StatusItem (Key.F5 | Key.CtrlMask, "~CTRL-F5~ Create Child", null);
			this.createChildStatusItem.Data = "createChildStatusItem";
			this.centerChildStatusItem = new Terminal.Gui.StatusItem (Key.F6 | Key.CtrlMask, "~CTRL-F6~ Center Child", null);
			this.centerChildStatusItem.Data = "centerChildStatusItem";
			this.hideShowChildStatusItem = new Terminal.Gui.StatusItem (Key.F7 | Key.CtrlMask, "~CTRL-F7~ Hide Child", null);
			this.hideShowChildStatusItem.Data = "hideShowChildStatusItem";
			this.borderChildStatusItem = new Terminal.Gui.StatusItem (Key.F2 | Key.CtrlMask, "~CTRL-F2~ Borderless Child", null);
			this.borderChildStatusItem.Data = "borderChildStatusItem";
			this.borderParentStatusItem = new Terminal.Gui.StatusItem (Key.F1 | Key.CtrlMask, "~CTRL-F1~ Borderless Parent", null);
			this.borderParentStatusItem.Data = "borderParentStatusItem";
			this.statusBar.Items = new StatusItem [] {
					this.createChildStatusItem, this.centerChildStatusItem, this.hideShowChildStatusItem, this.borderChildStatusItem, this.borderParentStatusItem};
			this.Add (statusBar);
		}
	}

	//------------------------------------------------------------------------------

	//  <auto-generated>
	//      This code was generated by:
	//        TerminalGuiDesigner v1.0.24.0
	//      You can make changes to this file and they will not be overwritten when saving.
	//  </auto-generated>
	// -----------------------------------------------------------------------------

	public partial class MdiChildWindowClass {

		public MdiChildWindowClass ()
		{
			InitializeComponent ();
			this.button1.Clicked += Button1_Clicked;
		}

		private void Button1_Clicked ()
		{
			Terminal.Gui.MessageBox.Query ("Press Me", "I hope you like the child window behavior!", "Ok");
		}
	}


	//------------------------------------------------------------------------------

	//  <auto-generated>
	//      This code was generated by:
	//        TerminalGuiDesigner v1.0.24.0
	//      Changes to this file may cause incorrect behavior and will be lost if
	//      the code is regenerated.
	//  </auto-generated>
	// -----------------------------------------------------------------------------

	public partial class MdiChildWindowClass : Terminal.Gui.Window {

		private Terminal.Gui.Button button1;
		private Terminal.Gui.Label Label1;
		private Terminal.Gui.Label Label2;
		private Terminal.Gui.Label Label3;
		private Terminal.Gui.Label Label4;

		private void InitializeComponent ()
		{
			this.Width = 80;
			this.Height = 16;
			this.X = Pos.Center ();
			this.Y = Pos.Center ();
			this.ColorScheme = Colors.TopLevel;
			this.Modal = false;
			this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
			this.Border.BorderBrush = Terminal.Gui.Color.White;
			this.Border.Effect3D = false;
			this.Border.Effect3DBrush = null;
			this.Border.DrawMarginFrame = true;
			this.TextAlignment = Terminal.Gui.TextAlignment.Left;
			this.Title = "Child Window";
			this.button1 = new Terminal.Gui.Button ();
			this.button1.X = Pos.Center ();
			this.button1.Y = Pos.Center ();
			this.button1.Text = "Press Me";
			this.Label1 = new Terminal.Gui.Label ("TL");
			this.Label2 = new Terminal.Gui.Label ("TR");
			this.Label2.X = Pos.AnchorEnd (2);
			this.Label3 = new Terminal.Gui.Label ("BL");
			this.Label3.Y = Pos.AnchorEnd (1);
			this.Label4 = new Terminal.Gui.Label ("BR");
			this.Label4.X = Pos.AnchorEnd (2);
			this.Label4.Y = Pos.AnchorEnd (1);
			this.Add (this.button1, this.Label1, this.Label2, this.Label3, this.Label4);
		}
	}
}