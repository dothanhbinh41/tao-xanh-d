using System;
using System.IO;

namespace TaoXanhD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current date and time: {DateTime.Now}");

            WriteTimezoneInfo();
            Console.WriteLine();
            WriteEnvironmentInfo();
            Console.WriteLine();
            WritePathInfo();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void WriteTimezoneInfo()
        {
            Console.WriteLine("Timezone Information");
            WriteObjectProperties(typeof(TimeZoneInfo), TimeZoneInfo.Local, new string(' ', 4));
        }

        static void WriteEnvironmentInfo()
        {
            Console.WriteLine("Environment Information");
            WriteObjectProperties(typeof(Environment), null, new string(' ', 4));
        }

        static void WritePathInfo()
        {
            Console.WriteLine("Path Information");
            Console.WriteLine($"{new string(' ', 4)}{nameof(Path.DirectorySeparatorChar)}: '{Path.DirectorySeparatorChar}'");
            Console.WriteLine($"{new string(' ', 4)}{nameof(Path.AltDirectorySeparatorChar)}: '{Path.AltDirectorySeparatorChar}'");
            Console.WriteLine($"{new string(' ', 4)}{nameof(Path.PathSeparator)}: '{Path.PathSeparator}'");
            Console.WriteLine($"{new string(' ', 4)}{nameof(Path.VolumeSeparatorChar)}: '{Path.VolumeSeparatorChar}'");

        }

        static void WriteObjectProperties(Type targetType, object targetInstance, string prefix = "")
        {
            var properties = targetType.GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine($"{prefix}{property.Name}: {property.GetValue(targetInstance)}");
            }
        }
    }
}
