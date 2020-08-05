using System;
using YazilimTasarim.Utils;

namespace YazilimTasarim.Adapter
{
    public class GoogleLoginProvider
    {
        public void LoginWithBase64Token(string base64Token)
        {
            MessageBox.Show($"Google hesabınız ile uygulamaya login olundu.\nToken: {base64Token}", "Bilgi");
        }
    }
}
