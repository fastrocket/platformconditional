using System;
using System.Runtime.InteropServices;

/// <summary>
/// Example showing conditional compilation taken from:
/// https://blog.magnusmontin.net/2018/11/05/platform-conditional-compilation-in-net-core
/// </summary>
namespace platformconditional
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    Console.WriteLine("Running on Linux!");
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    Console.WriteLine("Running on macOS!");
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    Console.WriteLine("Running on Windows!");

#if Linux
        Console.WriteLine("Built on Linux!"); 
#elif OSX
        Console.WriteLine("Built on macOS!"); 
#elif Windows
        Console.WriteLine("Built in Windows!"); 
#endif
            }
        }
    }
}
