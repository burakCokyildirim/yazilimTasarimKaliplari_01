using System;
using YazilimTasarim.Utils;

namespace YazilimTasarim.ChainOfResponsibility
{
    public class SettingsHandler : Handler
    {
        public override void check(PageType type)
        {
            if (type == PageType.SettingsPage)
                MessageBox.Show("Mevcut sayfa Settings", "Bilgi");
            else
                successor.next(type);
        }
    }
}
