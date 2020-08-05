// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace YazilimTasarim.Windows
{
	[Register ("ChainOfResponsiblityWindowController")]
	partial class ChainOfResponsiblityWindowController
	{
		[Outlet]
		AppKit.NSButton loginRadioButton { get; set; }

		[Outlet]
		AppKit.NSButton mainRadioButton { get; set; }

		[Outlet]
		AppKit.NSButton registerRadioButton { get; set; }

		[Outlet]
		AppKit.NSButton settingsRadioButton { get; set; }

		[Action ("checkButtonTapped:")]
		partial void checkButtonTapped (Foundation.NSObject sender);

		[Action ("radioButtonsTapped:")]
		partial void radioButtonsTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (settingsRadioButton != null) {
				settingsRadioButton.Dispose ();
				settingsRadioButton = null;
			}

			if (mainRadioButton != null) {
				mainRadioButton.Dispose ();
				mainRadioButton = null;
			}

			if (loginRadioButton != null) {
				loginRadioButton.Dispose ();
				loginRadioButton = null;
			}

			if (registerRadioButton != null) {
				registerRadioButton.Dispose ();
				registerRadioButton = null;
			}
		}
	}
}
