using System;

namespace Phone
{
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;

        // Constructor Method
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }

        // Abstract Method
        public abstract void DisplayInfo();

        // Getters & Setters
        public string VersionNumber { get { return _versionNumber; } }
        public int BatteryPercentage { get { return _batteryPercentage; } }
        public string Carrier { get { return _carrier; } }
        public String RingTone { get { return _ringTone; } }

    }
}