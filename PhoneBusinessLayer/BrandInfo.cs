using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBusinessLayer
{
    public class BrandInfo
    {
        public string Brand { get; set; }
        public DateTime EstablishedDate { get; set; }
        public string Founder { get; set; }

        public BrandInfo(string brand, DateTime establishedDate, string founder)
        {
            Brand = brand;
            EstablishedDate = establishedDate;
            Founder = founder;
        }
    }
}
