using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Device input:");
        bool isOn = ReadBool("Is the device turned on? (true/false): ");
        bool hasPower = ReadBool("Is there power? (true/false): ");

        Device device1 = new Device(isOn, hasPower);
        Device device2 = new Device(device1);

        Console.WriteLine("\nDevice 1:");
        Console.WriteLine(device1.ToString());
        Console.WriteLine("Could it work?: " + device1.CanWork());

        Console.WriteLine("\nDevice 2 (duplicate):");
        Console.WriteLine(device2.ToString());

        Console.WriteLine("\nSmartDevice input:");
        bool isOn2 = ReadBool("Is the device turned on? (true/false): ");
        bool hasPower2 = ReadBool("Is there power? (true/false): ");
        bool wifi = ReadBool("Connected to Wi-Fi? (true/false): ");

        SmartDevice smart1 = new SmartDevice(isOn2, hasPower2, wifi);
        SmartDevice smart2 = new SmartDevice(smart1);

        Console.WriteLine("\nSmartDevice 1:");
        Console.WriteLine(smart1.ToString());
        Console.WriteLine("Online: " + smart1.IsOnline());
        Console.WriteLine("Activated: " + smart1.IsSmartActive());

        Console.WriteLine("\nSmartDevice 2 (duplicate):");
        Console.WriteLine(smart2.ToString());

        Console.WriteLine("\nConnecting SmartDevice 2 to Wi-Fi...");
        smart2.ConnectToWifi();
        Console.WriteLine(smart2.ToString());
    }

    static bool ReadBool(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input == "true" || input == "false")
            {    
                return bool.Parse(input);
            }
            
            Console.WriteLine("Error! Input only true or false.");
        }
    }
}
