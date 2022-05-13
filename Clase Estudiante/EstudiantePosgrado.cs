using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Estudiante
{
    class EstudiantePosgrado : Estudiante
    {
        public int NivelSNI;

        public EstudiantePosgrado() : base()
        {
            NivelSNI = 0;
        }
        public EstudiantePosgrado(int Matricula, string Nombre, int Edad, double CuotaEscolar, int NivelSNI) : base(Matricula, Nombre, Edad, CuotaEscolar)
        {
            this.NivelSNI = NivelSNI;
        }

        public override void AsignarBeca(int descuento)
        {
            base.AsignarBeca(descuento);
            if(NivelSNI == 1 || NivelSNI == 2)
            {
                this.CuotaEscolar -= (this.CuotaEscolar * .15);
            }
            else
            {
                this.CuotaEscolar -= (this.CuotaEscolar * .30);
            }
        }

        public override string mostrarDatos()
        {
            return base.mostrarDatos() + "\n" + "NivelSNI: " + NivelSNI;
        }
    }
}
