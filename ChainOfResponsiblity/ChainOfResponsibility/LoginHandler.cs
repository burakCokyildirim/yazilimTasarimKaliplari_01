using System;
using YazilimTasarim.Utils;

namespace YazilimTasarim.ChainOfResponsibility
{
    public class LoginHandler : Handler
    {
        public override void check(PageType type)
        {
            if (type == PageType.LoginPage)
                MessageBox.Show("Mevcut sayfa Login", "Bilgi");
            else
                successor.next(type);
        }
    }
}
