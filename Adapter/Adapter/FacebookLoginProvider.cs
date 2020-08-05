using System;
using YazilimTasarim.Utils;

namespace YazilimTasarim.Adapter
{
    public class FacebookLoginProvider: ILoginProvider
    {
        public void LoginWithToken(string token)
        {
            MessageBox.Show($"Facebook hesabınız ile uygulamaya login olundu.\nToken: {token}", "Bilgi");
        }
    }
}
