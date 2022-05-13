using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Estudiante
{
    class Estudiante
    {
        protected int Matricula;
        protected string Nombre;
        protected int Edad;
        protected string Password;
        protected double CuotaEscolar;

        public Estudiante()
        {
            Matricula = 1810885;
            Nombre = "Brandon Ibarra";
            Edad = 21;
            Password = "ññ@";
            CuotaEscolar = 3000;
        }

        public Estudiante(int Matricula, string Nombre, int Edad, double CuotaEscolar)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.asignarEdad(Edad);
            this.asignarPassword();
            this.CuotaEscolar = CuotaEscolar;
        }

        public void SetMatricula(int matricula)
        {
            this.Matricula = matricula;
        }

        public virtual void AsignarBeca(int descuento)
        {
            this.CuotaEscolar -= (descuento * .01) * this.CuotaEscolar;
        }

        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }

        public void asignarEdad(int ed)
        {
            if(ed < 15)
            {
                this.Edad = 15;
            }
            else if (ed > 90)
            {
                this.Edad = 90;
            }
            else
            {
                this.Edad = ed;
            }
        }

        public void asignarPassword()
        {
            int largo = 10;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < largo; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }
        }

        public virtual string mostrarDatos()
        {
            string inicioMsg = "El estudiante";
            return inicioMsg + "\n" + "Matricula:" + this.Matricula + "\n"
            + "Nombre:" + this.Nombre + "\n" + "Edad:" + this.Edad + "\n" 
            + "Password: " + this.Password + "\n" + "CuotaEscolar:" + this.CuotaEscolar;
        }
    }
}
