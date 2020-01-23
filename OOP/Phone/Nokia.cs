using System;

namespace Phone
{
    public class Nokia : Phone, IRingable
    {
        private bool isUnlocked;
        private static string silentTone = "Zzzz zzz zzz";
        //Constructor Method
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
        {
            isUnlocked = false;
        }

        public string Ring()
        {
            return (isUnlocked) ? RingTone : silentTone;
        }
        public string Unlock()
        {
            isUnlocked = true;
            return "Unlocked with fingerprint scanner";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$");
            Console.WriteLine($"Nokia: {VersionNumber}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Battery: {BatteryPercentage}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$");
        }
    }
}