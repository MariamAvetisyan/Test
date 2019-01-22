using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBusinessLayer
{
    public class Brands
    {
        static List<BrandInfo> brands = null;

        static Brands()
        {
            brands = new List<BrandInfo>()
            {
                new BrandInfo($"{PhoneBrand.Apple}", new DateTime(1976, 4, 1), "Steve Jobs"),
                new BrandInfo($"{PhoneBrand.Lenovo}", new DateTime(1984, 11, 1), "Liu Chuanzhi"),
                new BrandInfo($"{PhoneBrand.Meizu}", new DateTime(2003, 5, 15), "Jack Wong"),
                new BrandInfo($"{PhoneBrand.Xiaomi}", new DateTime(2010, 4, 6), "Lei Jun"),
                new BrandInfo($"{PhoneBrand.Samsung}", new DateTime(1938, 3, 1), "Lee Byung-chul"),
                new BrandInfo($"{PhoneBrand.Nokia}", new DateTime(1865, 4, 12), "Fredrik Idestam"),
                new BrandInfo($"{PhoneBrand.LG}", new DateTime(1958, 10, 10), "Koo In-hwoi")
            };
        }

        public static List<BrandInfo> GetBrandInfos() => brands;
    }
}
