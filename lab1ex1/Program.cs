namespace lab1ex1
{
    class Program
    {
        /*
         Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
        paralelipiped dreptunghic, va afisa volumul lui
         */
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