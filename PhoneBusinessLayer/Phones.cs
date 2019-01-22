using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBusinessLayer
{
    public enum PhoneBrand
    {
        Apple, Lenovo, Meizu, Xiaomi, Samsung, Nokia, LG
    }

    public class Phones
    {
        static List<Phone> listOfPhones = null;

        static Phones()
        {
            listOfPhones = new List<Phone>()
            {
                new Phone($"{PhoneBrand.Apple}", "6", "IOS 8.0", "A8", new DateTime(2014, 9, 11), 4.70f, 24, 8, 2, 16, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "6", "IOS 8.0", "A8", new DateTime(2014, 9, 11), 4.70f, 24, 8, 2, 32, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "6", "IOS 8.0", "A8", new DateTime(2014, 9, 11), 4.70f, 24, 8, 2, 64, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "6", "IOS 8.0", "A8", new DateTime(2014, 9, 11), 4.70f, 24, 8, 2, 128, 1, true, true, true, true, true, true),
                           
                new Phone($"{PhoneBrand.Apple}", "7", "IOS 10", "quad-core", new DateTime(2016, 9, 15), 4.70f, 24, 12, 7, 32, 1, true, true, true, false, true, true),
                new Phone($"{PhoneBrand.Apple}", "7", "IOS 10", "quad-core", new DateTime(2016, 9, 15), 4.70f, 24, 12, 7, 64, 1, true, true, true, false, true, true),
                new Phone($"{PhoneBrand.Apple}", "7", "IOS 10", "quad-core", new DateTime(2016, 9, 15), 4.70f, 24, 12, 7, 128, 1, true, true, true, false, true, true),
                new Phone($"{PhoneBrand.Apple}", "7", "IOS 10", "quad-core", new DateTime(2016, 9, 15), 4.70f, 24, 12, 7, 256, 1, true, true, true, false, true, true),
                          
                new Phone($"{PhoneBrand.Apple}", "SE", "IOS 9.3", "A9", new DateTime(2016, 3, 5), 4.70f, 24, 12, 2, 32, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "SE", "IOS 9.3", "A9", new DateTime(2016, 3, 5), 4.70f, 24, 12, 2, 64, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "SE", "IOS 9.3", "A9", new DateTime(2016, 3, 5), 4.70f, 24, 12, 2, 128, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "SE", "IOS 9.3", "A9", new DateTime(2016, 3, 5), 4.70f, 24, 12, 2, 256, 1, true, true, true, true, true, true),
                          
                new Phone($"{PhoneBrand.Apple}", "X", "IOS 11", "hexa-core", new DateTime(2017, 9, 15), 5.80f, 24, 12, 7, 64, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "X", "IOS 11", "hexa-core", new DateTime(2017, 9, 15), 5.80f, 24, 12, 7, 128, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "X", "IOS 11", "hexa-core", new DateTime(2017, 9, 15), 5.80f, 24, 12, 7, 256, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Apple}", "X", "IOS 11", "hexa-core", new DateTime(2017, 9, 15), 5.80f, 24, 12, 7, 512, 1, true, true, true, true, true, true),

                new Phone($"{PhoneBrand.Lenovo}", "S5", "Android 8.0", "octa-core", new DateTime(2018, 3, 10), 5.70f, 20, 13, 16, 32, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Lenovo}", "K5", "Android 7.0", "octa-core", new DateTime(2017, 3, 10), 5.70f, 22, 13, 8, 32, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Lenovo}", "Z5", "Android 8.1", "octa-core", new DateTime(2018, 7, 10), 6.20f, 20, 16, 8, 64, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Lenovo}", "A5", "Android 8.1", "quad-core", new DateTime(2018, 6, 10), 5.45f, 18, 13, 8, 16, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Lenovo}", "A6600", "Android 6.0", "quad-core", new DateTime(2016, 9, 16), 5.0f, 20, 8, 2, 16, 2, true, true, true, false, true, true),

                new Phone($"{PhoneBrand.Meizu}", "16 Plus", "Android 8.0", "octa-core", new DateTime(2018, 8, 16), 6.50f, 30, 12, 20, 128, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Meizu}", "6T", "Android 7.0", "octa-core", new DateTime(2018, 5, 1), 5.70f, 30, 13, 8, 32, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Meizu}", "X8", "Android 8.1", "octa-core", new DateTime(2018, 9, 16), 6.20f, 30, 12, 20, 64, 2, true, true, true, true, true, true),

                new Phone($"{PhoneBrand.Xiaomi}", "Mi Max 3", "Android 8.1", "octa-core", new DateTime(2018, 7, 16), 6.90f, 20, 12, 8, 64, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Xiaomi}", "Redmi 6A", "Android 8.1", "quad-core", new DateTime(2018, 6, 16), 5.45f, 18, 13, 5, 16, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Xiaomi}", "Mi 8", "Android 8.1", "octa-core", new DateTime(2018, 9, 16), 6.26f, 30, 12, 24, 32, 2, true, true, true, true, true, true),

                new Phone($"{PhoneBrand.Samsung}", "Galaxy J6", "Android 8.0", "octa-core", new DateTime(2018, 5, 16), 5.60f, 30, 13, 8, 32, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Samsung}", "Galaxy Wide 3", "Android 8.0", "octa-core", new DateTime(2018, 5, 16), 5.50f, 30, 13, 13, 32, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Samsung}", "Galaxy A8 Star", "Android 8.0", "octa-core", new DateTime(2018, 5, 13), 6.28f, 30, 16, 24, 64, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Samsung}", "Galaxy Note 9", "Android 8.1", "octa-core", new DateTime(2018, 8, 1), 6.40f, 28, 12, 8, 128, 2, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Samsung}", "Galaxy Jean", "Android 8.0", "octa-core", new DateTime(2018, 7, 16), 6.00f, 20, 16, 24, 32, 1, true, true, true, true, true, true),
                new Phone($"{PhoneBrand.Samsung}", "A7", "Android 8.0", "octa-core", new DateTime(2018, 9, 16), 6.00f, 30, 24, 24, 64, 2, true, true, true, true, true, true),
            };
        }

        public static List<Phone> GetAllPhones() => listOfPhones;
    }
}
