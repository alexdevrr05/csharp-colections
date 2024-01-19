// namespace Colecciones
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             // Variables necesarias
//             // string elem;
//             // int opcion;

//             // List generica
//             List<string> Personas = new List<string>();

//             // Agregamos objetos en la List
//             // Personas.Add("Alex");
//             // Personas.Add("Irene");
//             // Personas.Add("Diana");

//             // do
//             // {
//             //     Console.WriteLine("1. Agregar elemento");
//             //     Console.WriteLine("2. Salir");
//             //     opcion = Convert.ToInt32(Console.ReadLine());

//             //     if (opcion == 1)
//             //     {
//             //         Console.Write("Ingresa el elemento a agregar en la lista: ");
//             //         elem = Console.ReadLine() ?? "";
//             //         Personas.Add(elem);
//             //     }
//             // } while (opcion == 1);

//             Personas.Add("Miguel");
//             Personas.Add("Ana");
//             Personas.Add("Pepe");

//             // for (int i = 0; i < Personas.Count; i++)
//             // {
//             //     Console.WriteLine(Personas[i]);
//             // }

//             // Instruccion "foreach" para recorrer una coleccion
//             foreach (string elemento in Personas)
//             {
//                 Console.WriteLine(elemento);
//             }

//             Console.WriteLine("Informacion de la list actualizada\n");
//             // Insertamos un elemento en la list
//             Personas.Insert(2, "Victor Hugo");
//             foreach (string elemento in Personas)
//             {
//                 Console.WriteLine(elemento);
//             }

//             // Quitando un elemento de la list
//             Console.WriteLine("\n");
//             Personas.RemoveAt(3);
//             Console.WriteLine("Quitamos el elemento 3");
//             foreach (string elemento in Personas)
//             {
//                 Console.WriteLine(elemento);
//             }
//         }
//     }
// }