using System;

using Foundation;
using AppKit;

namespace YazilimTasarim.Windows
{
    public partial class MainWindowController : NSWindowController
    {
        public MainWindowController() : base("MainWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        partial void singleResponsibility(NSObject sender)
        {
            throw new NotImplementedException();
        }

        partial void chainOfResponsibility(NSObject sender)
        {
            var controller = new ChainOfResponsiblityWindowController();
            controller.Window.MakeKeyAndOrderFront(this);
        }

        partial void adapter(NSObject sender)
        {
            var loginWindow = new LoginWindowController();
            loginWindow.Window.MakeKeyAndOrderFront(this);
        }

        public new MainWindow Window
        {
            get { return (MainWindow)base.Window; }
        }
    }
}
