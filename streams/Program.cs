namespace streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with streams");
            string path = @"C:\filehandlingdotnet\Filestream.txt";
            using (StreamReader SR = new StreamReader(path))
            {
                while (SR.Peek() != -1)
                {
                    Console.WriteLine(Convert.ToChar(SR.Read()));
                }
            }
        }
    }
}
