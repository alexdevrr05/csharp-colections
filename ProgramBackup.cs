// namespace Colecciones
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             // string valorElemento;
//             Alumno valorElemento;
//             GuardaObjetos Objeto1 = new GuardaObjetos(3);

//             Alumno Alumno1 = new(7.5);
//             Alumno Alumno2 = new(9.5);
//             Alumno Alumno3 = new(10);

//             // Agregar objetos a la clase "GuardaObjectos"
//             Objeto1.AgregarElementos(Alumno1);
//             Objeto1.AgregarElementos(Alumno2);
//             Objeto1.AgregarElementos(Alumno3);


//             // Objeto1.AgregarElementos("Alex");

//             valorElemento = (Alumno)Objeto1.ObtenerElemento(0);
//             Console.WriteLine(valorElemento.Calificacion);
//         }
//     }
//     class GuardaObjetos
//     {
//         public object[] matrizElementos;
//         int i = 0;
//         public GuardaObjetos(int elementospa)
//         {
//             matrizElementos = new object[elementospa];
//         }
//         public void AgregarElementos(object elementoPa)
//         {
//             matrizElementos[i] = elementoPa;
//             i++;
//         }
//         public object ObtenerElemento(int indicePa)
//         {
//             return matrizElementos[indicePa];
//         }

//     }

//     class Alumno
//     {
//         // Campos
//         double calificacion;
//         public Alumno(double calificacionPa)
//         {
//             calificacion = calificacionPa;
//         }

//         // Propiedades 
//         public double Calificacion
//         {
//             get => calificacion;
//         }
//     }
// }