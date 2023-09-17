namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float length, width, height;
            length = Convert.ToInt32(Console.ReadLine());
            width = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(width * height * length);
        }
    }
}