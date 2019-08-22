using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Console.WriteLine("Alumno 1: ");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);

            //Usar el constructor sin parametros
            Alumno alumno2 = new Alumno();

            //Despues establece sus atributos
            alumno2.Nombre = "Pedro";
            alumno2.Matricula = "Abc123";

            Console.WriteLine("Alumno 2: ");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            Alumno alumno3 = new Alumno("Ana","XYZ987");
            Console.WriteLine("Alumno 3: ");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);

            Console.Read();
        }
    }
}
