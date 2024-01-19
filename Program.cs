namespace Colecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opc, indice;
            string alumno;

            // Instancia de List
            List<string> Alumnos = new List<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Eliminar estudiante");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Buscar por nombre");

                // Asignar opcion
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opc)
                {
                    case 1:
                        Console.Write("Digita el nombre del estudiante que desees agregar a la lista: ");
                        alumno = Console.ReadLine() ?? "";
                        Alumnos.Add(alumno);
                        break;

                    case 2:
                        // Console.Write("Escribe el nombre del alumno que desees eliminar: ");
                        // alumno = Console.ReadLine() ?? "";
                        // Alumnos.Remove(alumno);

                        Console.Write("Escribe el numero del estudiante que quiere eliminar ");
                        indice = Convert.ToInt32(Console.ReadLine());
                        indice--; // Reducimos en 1 al indice


                        if (indice >= Alumnos.Count || indice < 0)
                        {
                            Console.WriteLine("El alumno no existe");
                        }
                        else
                        {
                            string alumnoEliminado = Alumnos[indice];
                            Alumnos.RemoveAt(indice);
                            Console.WriteLine("{0} se ha eliminado satisfactoriamente", alumnoEliminado);
                        }
                        ConsolePause();

                        break;

                    case 3:
                        int i = 1;
                        foreach (string estudiante in Alumnos)
                        {
                            Console.WriteLine("{0}. {1}", i++, estudiante);
                        }
                        ConsolePause();
                        break;
                    case 4:
                        // string encontrarAlumno;
                        int j;
                        Console.WriteLine("Ingrese el nombre del estudiante a buscar: ");
                        alumno = Console.ReadLine() ?? "";

                        j = Alumnos.IndexOf(alumno);
                        if (j != -1)
                        {
                            Console.WriteLine("El alumno {0} tiene el numero de lista {1}",
                             Alumnos[j], j + 1);
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado el alumno: {0}", alumno);
                        }
                        ConsolePause();
                        break;
                }
            } while (opc >= 1 && opc <= 4);
        }

        static void ConsolePause()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadLine();
        }
    }
}