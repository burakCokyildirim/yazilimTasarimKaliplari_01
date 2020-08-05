using System;

using Foundation;
using AppKit;
using YazilimTasarim.ChainOfResponsibility;

namespace YazilimTasarim.Windows
{
    public partial class ChainOfResponsiblityWindowController : NSWindowController
    {
        public ChainOfResponsiblityWindowController() : base("ChainOfResponsiblityWindow")
        {
        }

        PageType state = PageType.MainPage;

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        partial void checkButtonTapped(NSObject sender)
        {
            Main();
        }

        partial void radioButtonsTapped(NSObject sender)
        {
            var button = sender as NSButton;

            if (button == registerRadioButton)
            {
                state = PageType.RegisterPage;
            }
            else if (button == loginRadioButton)
            {
                state = PageType.LoginPage;
            }
            else if (button == mainRadioButton)
            {
                state = PageType.MainPage;
            }
            else if (button == settingsRadioButton)
            {
                state = PageType.SettingsPage;
            }
            // as
        }

        public void Main()
        {
            Handler register = new RegisterHandler();
            Handler login = new LoginHandler();
            Handler main = new MainHandler();
            Handler settings = new SettingsHandler();

            register.succeedWith(login);
            login.succeedWith(main);
            main.succeedWith(settings);

            register.check(state);
        }

        public new ChainOfResponsiblityWindow Window
        {
            get { return (ChainOfResponsiblityWindow)base.Window; }
        }
    }
}
