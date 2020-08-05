using System;
using System.Text;

namespace YazilimTasarim.Adapter
{
    public class GoogleAdapter: ILoginProvider
    {

        private GoogleLoginProvider Provider;

        public GoogleAdapter(GoogleLoginProvider provider)
        {
            Provider = provider;
        }

        public void LoginWithToken(string token)
        {
            var base64Token = Convert.ToBase64String(Encoding.UTF8.GetBytes(token));

            Provider.LoginWithBase64Token(base64Token);
        }
    }
}
