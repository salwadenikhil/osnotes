namespace ConsoleApp3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("File handling examples");
        string path = @"C:\filehandlingdotnet\Filestream.txt";
        if (!File.Exists(path))
        {
            var FS = File.Create(path);
            FS.Close();
        }
        else
        {
            File.WriteAllText(path , $"Avengers DoomsDay - {DateTime.Now}");
            var logs = File.ReadAllLines(path);
            foreach (string line in logs)
            {
                Console.WriteLine(line);
            }
        }
    }
}
