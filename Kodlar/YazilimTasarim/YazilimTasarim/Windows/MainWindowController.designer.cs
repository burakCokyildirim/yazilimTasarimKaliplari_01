using Foundation;

namespace YazilimTasarim.Windows
{
	[Register("MainWindowController")]
	partial class MainWindowController
	{
		[Action("adapter:")]
		partial void adapter(Foundation.NSObject sender);

		[Action("chainOfResponsibility:")]
		partial void chainOfResponsibility(Foundation.NSObject sender);

		[Action("singleResponsibility:")]
		partial void singleResponsibility(Foundation.NSObject sender);

		void ReleaseDesignerOutlets()
		{
		}
	}
}
