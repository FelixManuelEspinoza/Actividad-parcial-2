using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_parcial_2
{
    internal class Persona
    {
        private string nombre;
        private long DNI;
        private DateTime Fechadenacimiento;

        public string propNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public long propDNI
        {
            set { DNI = value; }
            get { return DNI; }
        }

        public DateTime propFechaDeNacimiento
        {
            set { Fechadenacimiento = value; }
            get { return Fechadenacimiento; }





        }

        public Persona(string nomb,int dni,DateTime Fechnac) 
        {
             nombre = nomb;
            DNI = dni;
            Fechadenacimiento = Fechnac;

        }

        public Persona()
        {
        }

        public int EdadPersona()
        {
            int edad = 0;
            {
                if (Fechadenacimiento.Date > DateTime.Today)
                    throw new Exception("Fecha invalida");
                else
                    edad = DateTime.Today.AddTicks(Fechadenacimiento.Ticks).Year - 1;
                return edad;
            }
        }
    }
}
