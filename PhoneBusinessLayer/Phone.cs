using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBusinessLayer
{
    public class Phone
    {
        public string Brand { get; }
        public string Model { get; }
        public string OS { get; }
        public string Processor { get; }
        public DateTime ReleaseDate { get; }
        public float ScreenSize { get; set; }
        public byte BatteryLife { get; }
        public byte Camera { get; }
        public byte FrontCamera { get; }
        public short Storage { get; }
        public byte NumberOfSims { get; }
        public bool WiFi { get; }
        public bool GPS { get; }
        public bool Bluetooth { get; }
        public bool NFC { get; }
        public bool RemoteControl { get; }
        public bool FingerPrintSensor { get; }

        public Phone(string brand, string model, string oS, string processor, 
                DateTime releaseDate, float screenSize, byte batteryLife, 
                byte camera, byte frontCamera, short storage, 
                byte numberOfSims, bool wiFi, bool gPS, bool bluetooth, 
                bool nFC, bool remoteControl, bool fingerPrintSensor)
        {
            Brand = brand;
            Model = model;
            OS = oS;
            Processor = processor;
            ReleaseDate = releaseDate;
            ScreenSize = screenSize;
            BatteryLife = batteryLife;
            Camera = camera;
            FrontCamera = frontCamera;
            Storage = storage;
            NumberOfSims = numberOfSims;
            WiFi = wiFi;
            GPS = gPS;
            Bluetooth = bluetooth;
            NFC = nFC;
            RemoteControl = remoteControl;
            FingerPrintSensor = fingerPrintSensor;
        }        
    }
}
