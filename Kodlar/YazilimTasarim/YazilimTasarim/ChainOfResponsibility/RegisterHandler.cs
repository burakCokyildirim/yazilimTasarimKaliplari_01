using System;
using YazilimTasarim.Utils;

namespace YazilimTasarim.ChainOfResponsibility
{
    public class RegisterHandler: Handler
    {
        public override void check(PageType type)
        {
            if (type == PageType.RegisterPage)
                MessageBox.Show("Mevcut sayfa Register", "Bilgi");
            else
                next(type);
        }
    }
}
