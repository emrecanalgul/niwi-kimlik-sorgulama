using KPSPublicYabanciDogrula;
using System;
using System.Threading.Tasks;

namespace NiwiLib
{
    public static class Niwi
    {
        public static bool TcKimlikNoDogrula(long tcKimlik, string ad, string soyad, int dogumYili)
        {
            KPSPublic.KPSPublicSoapClient client = new KPSPublic.KPSPublicSoapClient(KPSPublic.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(tcKimlik, ad, soyad, dogumYili).Result;
            return response.Body.TCKimlikNoDogrulaResult;
        }

        public static bool KisiVeCuzdanDogrula(long tCKimlikNo, string ad, string soyad, bool soyadYok, int? dogumGun, bool dogumGunYok, int? dogumAy, bool dogumAyYok, int dogumYil, string cuzdanSeri, int? cuzdanNo, string tCKKSeriNo)
        {
            KPSPublicV2.KPSPublicV2SoapClient client = new KPSPublicV2.KPSPublicV2SoapClient(KPSPublicV2.KPSPublicV2SoapClient.EndpointConfiguration.KPSPublicV2Soap);
            var response = client.KisiVeCuzdanDogrulaAsync(tCKimlikNo, ad, soyad, soyadYok, dogumGun, dogumGunYok, dogumAy, dogumAyYok, dogumYil, cuzdanSeri, cuzdanNo, tCKKSeriNo).Result;
            return response.Body.KisiVeCuzdanDogrulaResult;
        }

        public static bool YabanciKimlikNoDogrula(long kimlikNo, string ad, string soyad, int? dogumGun, int? dogumAy, int dogumYil)
        {
            KPSPublicYabanciDogrulaSoapClient client = new KPSPublicYabanciDogrulaSoapClient(KPSPublicYabanciDogrulaSoapClient.EndpointConfiguration.KPSPublicYabanciDogrulaSoap);
            var response = client.YabanciKimlikNoDogrulaAsync(kimlikNo, ad, soyad, dogumGun, dogumAy, dogumYil).Result;
            return response.Body.YabanciKimlikNoDogrulaResult;
        }
    }
}
