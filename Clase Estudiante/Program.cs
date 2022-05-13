using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,op,res=-1,Beca=0;
            Boolean hace_servicio = false;
            int nivel_sni = 0, beca = 0;
            Console.WriteLine("Ingrese la cantidad de alumnos:");
            i = int.Parse(Console.ReadLine());
            Estudiante[] estudiantes = new Estudiante[i];
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Ingrese matricula del alumno " + (j + 1) + ":");
                int mat = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nombre del alumno " + (j + 1) + ":");
                string nom = Console.ReadLine();

                Console.WriteLine("Ingrese edad del alumno " + (j + 1) + ":");
                int eda = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la Cuota Escolar" + (j + 1) + ":");
                int cuo = int.Parse(Console.ReadLine());

                Console.WriteLine("El Estudiantes es de 1.-Licenciatura o 2.-Posgrado?");
                do
                {
                    op = int.Parse(Console.ReadLine());
                }
                while (op < -1 && op > 2);
                if (op == 1)
                {
                    Console.WriteLine("Hace Servicio Social ? 0.-NO o 1.-Si");
                    do
                    {
                        res = int.Parse(Console.ReadLine());
                    } while ((res !=0) && (res !=1));
                    if(res==1)
                    {
                        hace_servicio = true;
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Escribe tu nivel de SNI (0 a 3)");
                    do
                    {
                        nivel_sni = int.Parse(Console.ReadLine());
                    } while (nivel_sni < 0 && nivel_sni > 3);
                }
                Console.WriteLine("Cuentas con Beca ? 0.-NO 1.-SI");
                do
                {
                    beca = int.Parse(Console.ReadLine());
                } while (beca < 1 && beca > 100);
                if (beca == 1)
                {
                    Console.WriteLine("Ingresa con Enteros el total de tu Beca");
                    Beca = int.Parse(Console.ReadLine());
                } 
                if(op==1)
                {
                    estudiantes[j] = new EstudianteLicenciatura(mat, nom, eda, cuo, hace_servicio);
                    estudiantes[j].AsignarBeca(Beca);
                }
                else 
                {
                    estudiantes[j] = new EstudiantePosgrado(mat, nom, eda, cuo, nivel_sni);
                    estudiantes[j].AsignarBeca(Beca);
                }
                Console.Clear();
            }
            for (int k = 0; k < i; k++)
            {
                Console.WriteLine("\n" + estudiantes[k].mostrarDatos());
            }
            Console.ReadKey();



        }
    }
}
