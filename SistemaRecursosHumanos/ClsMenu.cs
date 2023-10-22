using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SistemaRecursosHumanos
{
    class ClsMenu
    {



        private List<ClsEmpleado> empleados = new List<ClsEmpleado>();

        public void AgregarEmpleado(string cedula, string nombre, double salario, string direccion, int telefono)
        {
            ClsEmpleado empleado = new ClsEmpleado(cedula, nombre, salario, direccion, telefono);
            empleados.Add(empleado);
        }

        public void ConsultarEmpleadosPorCedula(string cedula)
        {
            var empleadosConsulta = empleados.Where(e => e.Cedula == cedula);

            foreach (var empleado in empleadosConsulta)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
            }
        }

        public void ListarEmpleadosOrdenadosPorNombre()
        {
            var empleadosOrdenados = empleados.OrderBy(e => e.Nombre);

            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
            }
        }

        public void CalcularPromedioSalarios()
        {
            double promedio = empleados.Average(e => e.Salario);
            Console.WriteLine($"Promedio de salarios: {promedio}");
        }

        public void CalcularSalarioMasAltoYBajo()
        {
            double salarioMasAlto = empleados.Max(e => e.Salario);
            double salarioMasBajo = empleados.Min(e => e.Salario);

            Console.WriteLine($"Salario más alto: {salarioMasAlto}");
            Console.WriteLine($"Salario más bajo: {salarioMasBajo}");



        }

        public void BorrarEmpleado(string cedula)
        {
            var empleadoAEliminar = empleados.FirstOrDefault(e => e.Cedula == cedula);

            if (empleadoAEliminar != null)
            {
                empleados.Remove(empleadoAEliminar);
                Console.WriteLine($"Empleado con cédula {cedula} ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"No se encontró un empleado con la cédula {cedula}.");

            }
        }

        public void JuegoAdivinarValor()
            {
                Random random = new Random();
                int valorAdivinar = random.Next(1, 101); 

                int intentos = 0;
                int valorUsuario;

                Console.WriteLine("Bienvenido al juego de adivinanza. Adivina el número entre 1 y 100.");

                do
                {
                    Console.Write("Introduce tu suposición: ");
                    valorUsuario = Convert.ToInt32(Console.ReadLine());
                    intentos++;

                    if (valorUsuario < valorAdivinar)
                    {
                        Console.WriteLine("El valor es mayor. Intenta de nuevo.");
                    }
                    else if (valorUsuario > valorAdivinar)
                    {
                        Console.WriteLine("El valor es menor. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                    }
                } while (valorUsuario != valorAdivinar);

                Console.WriteLine("Fin del juego.");
            }


            //public void InicializarArreglos();




            // public void ModificarEmpleado(string cedula, string nuevoNombre, double nuevoSalario)
            // {
            // var empleadoAModificar = empleados.FirstOrDefault(e => e.Cedula == cedula);

            // if (empleadoAModificar != null)
            //{
            // empleadoAModificar.Nombre = nuevoNombre;
            // empleadoAModificar.Salario = nuevoSalario;
            // Console.WriteLine($"Empleado con cédula {cedula} ha sido modificado.");
            //}
            // else
            //{
            // Console.WriteLine($"No se encontró un empleado con la cédula {cedula}.");
            // }
            // }
            //}
            //}
        }

        //internal void JuegoAdivinarValor()
        
            //throw new NotImplementedException();
        
    }


                
            
        
    
    
    





        
    

