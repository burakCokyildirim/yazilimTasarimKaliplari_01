using System;
using AppKit;

namespace YazilimTasarim.Utils
{
    public static class MessageBox
    {
        public static void Show(string message, string title)
        {
            var alert = new NSAlert();
            alert.AlertStyle = NSAlertStyle.Informational;
            alert.MessageText = title;
            alert.InformativeText = message;
            alert.AddButton("Tamam");
            alert.RunModal();
        }
    }
}
