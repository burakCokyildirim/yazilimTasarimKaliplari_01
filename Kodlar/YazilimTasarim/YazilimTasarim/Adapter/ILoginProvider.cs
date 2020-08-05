using System;
namespace YazilimTasarim.Adapter
{
    public interface ILoginProvider
    {
        void LoginWithToken(string token);
    }
}
