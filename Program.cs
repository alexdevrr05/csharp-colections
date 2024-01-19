namespace Colecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Stack
            Stack<double> MiPila = new Stack<double>();
            // Insertar objetos al principio del Stack
            MiPila.Push(5.9);
            MiPila.Push(8.2);
            MiPila.Push(54.2);
            MiPila.Push(91.1);

            int i = 0;
            foreach (double item in MiPila)
            {
                Console.WriteLine("{0}. {1}", i++, item);
            }

            i = 0;
            Console.WriteLine("\nDespues de insertar un elemento");
            MiPila.Push(77.7);
            foreach (double item in MiPila)
            {
                Console.WriteLine("{0}. {1}", i++, item);
            }
        }
    }
}