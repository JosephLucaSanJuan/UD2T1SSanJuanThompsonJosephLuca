///////////////////////////////////////////
// Tarea: UD2T1
// Alumno/a: David Quest
// Curso: 2023/2024
///////////////////////////////////////////

namespace UD2T1SanJuanThompsonJosephLuca
{
    internal class UD2_Tarea1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Introduce el nombre del empleado:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce su primer apellido");
            string apellido1 = Console.ReadLine();
            Console.WriteLine("Introduce su seguindo apellido");
            string apellido2 = Console.ReadLine();
            Console.WriteLine("Introduce la edaddel empleado: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el NIF:");
            string NIF = Console.ReadLine();
        }
    }
}