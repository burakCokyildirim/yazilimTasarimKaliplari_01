using System;
using Foundation;
using AppKit;
using YazilimTasarim.Adapter;

namespace YazilimTasarim.Windows
{
    public partial class LoginWindowController : NSWindowController
    {
        public LoginWindowController() : base("LoginWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        partial void loginWithFacebook(NSObject sender)
        {
            ILoginProvider provider = new FacebookLoginProvider();
            Login(provider);
        }

        partial void loginWithGoogle(NSObject sender)
        {
            ILoginProvider provider = new GoogleAdapter(new GoogleLoginProvider());
            Login(provider);
        }

        public void Login(ILoginProvider provider)
        {
            provider.LoginWithToken("testToken1234689");
        }

        public new LoginWindow Window
        {
            get { return (LoginWindow)base.Window; }
        }
    }
}
