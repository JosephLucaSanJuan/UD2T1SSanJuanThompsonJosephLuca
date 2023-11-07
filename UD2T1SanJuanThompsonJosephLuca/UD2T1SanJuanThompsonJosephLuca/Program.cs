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

            // Introducimos los datos del empleado
            // Nombre
            Console.WriteLine("Introduce el nombre del empleado:");
            string nombre = Console.ReadLine();
            // Apellidos
            Console.WriteLine("Introduce su primer apellido");
            string apellido1 = Console.ReadLine();
            Console.WriteLine("Introduce su segundo apellido");
            string apellido2 = Console.ReadLine();
            // Edad
            Console.WriteLine("Introduce la edad del empleado");
            int edad = int.Parse(Console.ReadLine());
            // NIF
            Console.WriteLine("Introduce el NIF");
            string nif = Console.ReadLine();
            // Salario
            Console.WriteLine("Introduce el salario");
            double salario = double.Parse(Console.ReadLine());

            // Creamos el empleado
            Empleado[] empleados = new Empleado[100];
            Empleado empleado = new Empleado(nombre, apellido1, apellido2, edad, nif, salario);
            Boolean correcto = true;


            while (correcto) { 
                Console.WriteLine("\n1. Salir");
                Console.WriteLine("2. Actualiza el salario");
                Console.WriteLine("3. Muestra el nombre de un empleado");
                Console.WriteLine("4. Muestra el NIF");
                Console.WriteLine("5. Actualiza el NIF");
                Console.WriteLine("6. Muestra la edad de un empleado");
                Console.WriteLine("7. Muestra los datos de un empleado");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        correcto = false;
                        break;

                    case 2:
                        Console.WriteLine("Introduce el nuevo salario:");
                        double newSalario = double.Parse(Console.ReadLine());
                        empleado.ActualizarSalario(newSalario);
                        correcto = true;
                        break;

                    case 3:
                        //Console.WriteLine("Introduce el empleado cuyo nombre deseas mostrar: ");
                        empleado.MostrarNombre();
                        correcto = true;
                        break;

                     case 4:
                        //Console.WriteLine("Introduce el empleado cuyo NIF quieres mostrar: ");
                        empleado.MostrarNif();
                        correcto = true;
                        break;

                     case 5:
                        Console.WriteLine("Introduce el nuevo NIF:");
                        string newNif = Console.ReadLine();
                        empleado.ActualizarNif(newNif);
                        correcto = true;
                        break;

                     case 6:
                        //Console.WriteLine("Introduce el empleado cuya edad quieres mostrar: ");
                        empleado.MostrarEdad();
                        correcto = true;
                        break;

                    case 7:
                        //Console.WriteLine("Introduce el empleado cuyos datos quieres mostrar: ");
                        Console.WriteLine(empleado.toString());
                        correcto = true;
                        break;
                }
            }

            
        }
    }
}