using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salont1s3
{
    class Alumno
    {
        //Debe tener un atributo nombre y 3 atributos que indiquen las notas de cada promedio
        private string nombre;

        private float notaprom1;
        private float notaprom2;
        private float notaprom3;


        //Debe tener un atributo nombre y 3 atributos que indiquen las notas de cada promedio
        public string ObtenrNomb()
        {
            return nombre;
        }


        //Debe tener un atributo nombre y 3 atributos que indiquen las notas de cada promedio
        public Alumno(string nombre, float notaprom1, float notaprom2, float notaprom3)
        {
            this.nombre = nombre;

            this.notaprom1 = notaprom1;
            this.notaprom2 = notaprom2;
            this.notaprom3 = notaprom3;
        }

        //Debe tener un método que retorne su promedio TLS
        public float ObtenrProm()
        {
            return (notaprom1 + notaprom2 + 2 * notaprom3) / 4;
        }

    }
}
