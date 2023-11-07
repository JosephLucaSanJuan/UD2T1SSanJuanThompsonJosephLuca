using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T1SanJuanThompsonJosephLuca
{
    internal class Empleado
    {
        private string nombre;
        private string apellido1;
        private string apellido2;
        private int edad;
        private string NIF;
        private double salario;

        public Empleado(string nombre, string apellido1, string apellido2, int edad, string NIF, double salario)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Edad = edad;
            Nif = NIF;
            Salario = salario;
        }

        public string Nombre
        {
            get {return nombre; } set { nombre = value; }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string Apellido2
        { 
            get { return apellido2; } set { apellido2 = value; } 
        }

        public int Edad
        {
            get { return edad; } set {  edad = value; }
        }

        public string Nif
        {
            get { return NIF; } set {  NIF = value; }
        }

        public double Salario
        {
            get { return salario; } set { salario = value; }
        }

        public string toString()
        {
            String sb = "Nombre: " + nombre+" "+apellido1+" "+apellido2;
            sb += "\nEdad: " +edad+" años";
            sb += "\nNIF: " + NIF;
            sb += "\nSalario " +salario+"€";
            return sb;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreCompleto());
        }

        public void MostrarNif()
        {
            Console.WriteLine(Nif);
        }

        public void ActualizarSalario(double sal)
        {
            Salario = sal;
        }

        public void ActualizarNif(string nif)
        {
            Nif = nif;
        }

        public void MostrarEdad()
        {
            Console.WriteLine(Edad);
        }

        public String NombreCompleto()
        {
            return nombre + " " + apellido1 + " " + apellido2;
        }
    }
}
