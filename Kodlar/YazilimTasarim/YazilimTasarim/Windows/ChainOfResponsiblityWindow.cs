using System;

using Foundation;
using AppKit;

namespace YazilimTasarim.Windows
{
    public partial class ChainOfResponsiblityWindow : NSWindow
    {
        public ChainOfResponsiblityWindow(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public ChainOfResponsiblityWindow(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
