using Foundation;

namespace YazilimTasarim.Windows
{
	[Register("LoginWindowController")]
	partial class LoginWindowController
	{
		[Action("loginWithFacebook:")]
		partial void loginWithFacebook(Foundation.NSObject sender);

		[Action("loginWithGoogle:")]
		partial void loginWithGoogle(Foundation.NSObject sender);

		void ReleaseDesignerOutlets()
		{
		}
	}
}
