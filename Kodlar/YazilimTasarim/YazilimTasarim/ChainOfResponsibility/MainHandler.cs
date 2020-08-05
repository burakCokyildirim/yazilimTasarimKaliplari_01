using System;
using YazilimTasarim.Utils;

namespace YazilimTasarim.ChainOfResponsibility
{
    public class MainHandler : Handler
    {
        public override void check(PageType type)
        {
            if (type == PageType.MainPage)
                MessageBox.Show("Mevcut sayfa Main", "Bilgi");
            else
                next(type);
        }
    }
}
