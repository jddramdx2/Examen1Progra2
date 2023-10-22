using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace SistemaRecursosHumanos
{

    class ClsEmpleado
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public ClsEmpleado(string cedula, string nombre, double salario, string direccion, int telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Salario = salario;
            Direccion = direccion;
            Telefono = telefono;


        }

    }
}


