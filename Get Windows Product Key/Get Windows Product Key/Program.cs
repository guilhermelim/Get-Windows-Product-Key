using Get_Windows_Product_Key.Tools;
using System;
using System.Linq;
using System.Management;

namespace Get_Windows_Product_Key
{
    class Program
    {
        static readonly string title = "Get Windows Product Key";

        // Get Windows Information
        public static string GetWindowsProductName()
        {
            var name = (new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>().Select(x => x.GetPropertyValue("Caption"))).First();
            return name != null ? name.ToString() : "Unknown";
        }
        public static string GetWindowsBuildNumber()
        {
            var name = (new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>().Select(x => x.GetPropertyValue("BuildNumber"))).First();
            return name != null ? name.ToString() : "Unknown";
        }
        public static string GetWindowsProductId()
        {
            var name = (new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>().Select(x => x.GetPropertyValue("SerialNumber"))).First();
            return name != null ? name.ToString() : "Unknown";
        }
        public static string GetWindowsDirectory()
        {
            var name = (new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>().Select(x => x.GetPropertyValue("WindowsDirectory"))).First();
            return name != null ? name.ToString() : "Unknown";
        }
        public static string GetWindowsMachineName()
        {
            return Environment.MachineName;
        }

        // Console Write Colors
        static void WriteColor(ConsoleColor _foregroundColor, String _text)
        {
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(_text);
            Console.ResetColor();
        }
        static void WriteLineColor(ConsoleColor _foregroundColor, String _text)
        {
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(_text);
            Console.ResetColor();
        }
        
        static void Main(string[] args)
        {
            
            Console.Title = title;
            WriteColor(ConsoleColor.Red, "\t" + title + "\n");

            WriteColor(ConsoleColor.White, "Windows Product Name: ");
            WriteLineColor(ConsoleColor.White, GetWindowsProductName());

            WriteColor(ConsoleColor.White, "Windows Build Number: ");
            WriteLineColor(ConsoleColor.White, GetWindowsBuildNumber());

            WriteColor(ConsoleColor.White, "Windows ProductId: ");
            WriteLineColor(ConsoleColor.Blue, GetWindowsProductId());

            WriteColor(ConsoleColor.White, "Windows Product Key: ");
            WriteLineColor(ConsoleColor.Red, KeyDecoder.GetWindowsProductKeyFromRegistry());

            WriteColor(ConsoleColor.White, "Windows Installation Folder: ");
            WriteLineColor(ConsoleColor.White, GetWindowsDirectory());

            WriteColor(ConsoleColor.White, "Windows Machine Name: ");
            WriteLineColor(ConsoleColor.White, GetWindowsMachineName() + "\n");

            WriteLineColor(ConsoleColor.Red, "\tPress any key to continue ... ");
            Console.ReadKey(true);
        }
    }
}
