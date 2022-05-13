using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Estudiante
{
    class EstudianteLicenciatura : Estudiante
    {
        public Boolean RealizarServicio;

        public EstudianteLicenciatura() : base()
        {
            RealizarServicio = false;
        }
        
        public EstudianteLicenciatura(int Matricula, string Nombre, int Edad, double CuotaEscolar, Boolean RealizarServicio) : base(Matricula,Nombre,Edad,CuotaEscolar)
        {
            this.RealizarServicio = RealizarServicio;
        }

        public override void AsignarBeca(int descuento)
        {
            base.AsignarBeca(descuento);
            if(RealizarServicio == true)
            {
                this.CuotaEscolar -= (this.CuotaEscolar * .15);  
            }
        }

        public override string mostrarDatos()
        {
            return base.mostrarDatos() + "\n" + "Realizar Servicio: " + RealizarServicio;  
        }
    }

}
