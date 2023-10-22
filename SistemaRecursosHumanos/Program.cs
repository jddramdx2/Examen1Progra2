using System;

namespace SistemaRecursosHumanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsMenu menu = new ClsMenu();

            // Menú principal
            while (true)
            {
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Consultar Empleados por Cédula");
                Console.WriteLine("3. Listar Empleados Ordenados por Nombre");
                Console.WriteLine("4. Calcular Promedio de Salarios");
                Console.WriteLine("5. Calcular Salario Más Alto y Bajo");
                Console.WriteLine("6. Borrar un empleado");
                Console.WriteLine("7. Modificar empleado");
                Console.WriteLine("8. Inicializar Arreglos");
                Console.WriteLine("9. Opcion de bono, pruebame!");
                Console.WriteLine("10. Salir");
                Console.Write("Elija una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la cédula del empleado: ");
                        string cedula = Console.ReadLine();
                        Console.Write("Ingrese el nombre del empleado: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el salario del empleado: ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la direccion del empleado: ");
                        string direccion = Console.ReadLine();
                        Console.Write("Ingrese el telefono del empleado: ");
                        int telefono = Convert.ToInt32(Console.ReadLine());
                        menu.AgregarEmpleado(cedula, nombre, salario, direccion, telefono);
                        break;
                    case 2:
                        Console.Write("Ingrese la cédula a consultar: ");
                        string cedulaConsulta = Console.ReadLine();
                        menu.ConsultarEmpleadosPorCedula(cedulaConsulta);
                        break;
                    case 3:
                        menu.ListarEmpleadosOrdenadosPorNombre();
                        break;
                    case 4:
                        menu.CalcularPromedioSalarios();
                        break;
                    case 5:
                        menu.CalcularSalarioMasAltoYBajo();
                        break;
                    case 6:
                        Console.Write("Ingrese la cédula del empleado a borrar: ");
                        string cedulaBorrar = Console.ReadLine();
                        menu.BorrarEmpleado(cedulaBorrar);

                        break;
                    case 7:
                        Console.Clear();
                        Console.ReadLine();
                       // Console.Write("Ingrese la cédula del empleado a modificar: ");
                       //string cedulaModificar = Console.ReadLine();
                       // Console.Write("Ingrese el nuevo nombre: ");
                       // string nuevoNombre = Console.ReadLine();
                       // Console.Write("Ingrese el nuevo salario: ");
                       //double nuevoSalario = Convert.ToDouble(Console.ReadLine());
                       //menu.ModificarEmpleado(cedulaModificar, nuevoNombre, nuevoSalario);
                        break;
                    case 8:
                        Console.Clear();
                        //menu.InicializarArreglos();
                        Console.WriteLine("Arreglo de empleados inicializado.");
                        Console.ReadLine();

                        break;
                    case 9:
                        menu.JuegoAdivinarValor();
                        
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}














