namespace Consolexplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Explorer");
            Console.WriteLine("Availiable Drivers are");
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType != DriveType.Network)
                {
                    Console.WriteLine($"{drive.Name}");
                    DirectoryInfo driverinfo = new DirectoryInfo(drive.Name);
                    foreach (var directory in args)
                    {
                        
                    }
                }
            }
        }
    }
}
