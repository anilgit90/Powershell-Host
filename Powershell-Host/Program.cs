using System.Management.Automation;

namespace Powershell_Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PowerShell.Create().AddCommand("Copy-Item")
                               .AddArgument(@"G:\examples\.gitignore")
                               .AddParameter("-Destination", @"G:\")
                               .Invoke();
            Console.ReadLine();
        }
    }
}
