// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace BoxDumper
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton B_DUMP { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_DumpKeyRange { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OEKX { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OEKX2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OKEY { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OS2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton B_OutPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSComboBox C_DStart { get; set; }

		[Outlet]
		MonoMac.AppKit.NSComboBox C_End { get; set; }

		[Outlet]
		MonoMac.AppKit.NSComboBox C_Format { get; set; }

		[Outlet]
		MonoMac.AppKit.NSComboBox C_Start { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CHK_ALT { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CHK_ALT2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CHK_PK6 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_O { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_O1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField L_O2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_C { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextView T_Dialog { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_EKX { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_EKX2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_KEY { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_O { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_O1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_O2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_OutPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_SAV { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField T_SAV2 { get; set; }

		[Action ("B_ChangeOutputFolder_Click:")]
		partial void B_ChangeOutputFolder_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DUMP_Click:")]
		partial void B_DUMP_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_DumpKeyRange_Click:")]
		partial void B_DumpKeyRange_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenBlank_Click:")]
		partial void B_OpenBlank_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenBoxKey_Click:")]
		partial void B_OpenBoxKey_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OpenBoxSave_Click:")]
		partial void B_OpenBoxSave_Click (MonoMac.Foundation.NSObject sender);

		[Action ("B_OS2_Click:")]
		partial void B_OS2_Click (MonoMac.Foundation.NSObject sender);

		[Action ("changecheck:")]
		partial void changecheck (MonoMac.Foundation.NSObject sender);

		[Action ("changestart:")]
		partial void changestart (MonoMac.Foundation.NSObject sender);

		[Action ("CHK_ALT_Click:")]
		partial void CHK_ALT_Click (MonoMac.Foundation.NSObject sender);

		[Action ("switchmode:")]
		partial void switchmode (MonoMac.Foundation.NSObject sender);

		[Action ("updaterange:")]
		partial void updaterange (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (T_SAV != null) {
				T_SAV.Dispose ();
				T_SAV = null;
			}

			if (T_EKX != null) {
				T_EKX.Dispose ();
				T_EKX = null;
			}

			if (T_KEY != null) {
				T_KEY.Dispose ();
				T_KEY = null;
			}

			if (T_OutPath != null) {
				T_OutPath.Dispose ();
				T_OutPath = null;
			}

			if (C_Format != null) {
				C_Format.Dispose ();
				C_Format = null;
			}

			if (C_DStart != null) {
				C_DStart.Dispose ();
				C_DStart = null;
			}

			if (C_Start != null) {
				C_Start.Dispose ();
				C_Start = null;
			}

			if (C_End != null) {
				C_End.Dispose ();
				C_End = null;
			}

			if (T_Dialog != null) {
				T_Dialog.Dispose ();
				T_Dialog = null;
			}

			if (CHK_ALT != null) {
				CHK_ALT.Dispose ();
				CHK_ALT = null;
			}

			if (CHK_ALT2 != null) {
				CHK_ALT2.Dispose ();
				CHK_ALT2 = null;
			}

			if (T_O != null) {
				T_O.Dispose ();
				T_O = null;
			}

			if (T_C != null) {
				T_C.Dispose ();
				T_C = null;
			}

			if (T_O1 != null) {
				T_O1.Dispose ();
				T_O1 = null;
			}

			if (T_O2 != null) {
				T_O2.Dispose ();
				T_O2 = null;
			}

			if (B_DUMP != null) {
				B_DUMP.Dispose ();
				B_DUMP = null;
			}

			if (CHK_PK6 != null) {
				CHK_PK6.Dispose ();
				CHK_PK6 = null;
			}

			if (T_SAV2 != null) {
				T_SAV2.Dispose ();
				T_SAV2 = null;
			}

			if (T_EKX2 != null) {
				T_EKX2.Dispose ();
				T_EKX2 = null;
			}

			if (B_DumpKeyRange != null) {
				B_DumpKeyRange.Dispose ();
				B_DumpKeyRange = null;
			}

			if (B_OutPath != null) {
				B_OutPath.Dispose ();
				B_OutPath = null;
			}

			if (L_O1 != null) {
				L_O1.Dispose ();
				L_O1 = null;
			}

			if (L_O2 != null) {
				L_O2.Dispose ();
				L_O2 = null;
			}

			if (L_O != null) {
				L_O.Dispose ();
				L_O = null;
			}

			if (B_OEKX != null) {
				B_OEKX.Dispose ();
				B_OEKX = null;
			}

			if (B_OKEY != null) {
				B_OKEY.Dispose ();
				B_OKEY = null;
			}

			if (B_OS2 != null) {
				B_OS2.Dispose ();
				B_OS2 = null;
			}

			if (B_OEKX2 != null) {
				B_OEKX2.Dispose ();
				B_OEKX2 = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
