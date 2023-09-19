using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salont1s3
{
    class salon
    {
        private string nombre;
        public List<Alumno> registro = new List<Alumno>();

        public salon(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenrNomb()
        {
            return nombre;
        }
        //Debe tener un atributo que sea una lista de alumnos
        public void VerList()
        {
            int i = 1;
            foreach (Alumno alumno in registro)
            {
                Console.WriteLine(i + "." + alumno.ObtenrNomb());
                i++;
            }
        }

        //Debe tener un método que permita registrar un alumno al salón
        public void AgregAlumno(string nombre, float notaprom1, float notaprom2, float notaprom3)
        {
            Alumno alumno = new Alumno(nombre, notaprom1, notaprom2, notaprom3);
            registro.Add(alumno);
        }

        //Debe tener un método que permita remover un alumno del salón
        public void ElimAlumno(int numero)
        {
            if (numero <= registro.Count && numero > 0)
            {
                registro.RemoveAt(numero - 1);
            }
            else
            {
                Console.WriteLine("Error... No existo alumno con ese número.");
            }
        }

        //Debe tener un método que permita calcular la cantidad de aprobados
        public void CantAprobados()
        {
            int cantaprobadoss = 0;
            foreach (Alumno alumno in registro)
            {
                if (alumno.ObtenrProm() >= 12.5f)
                {
                    cantaprobadoss++;
                }
            }
            Console.WriteLine("Cuando han pasado:" + cantaprobadoss);
        }

        //Debe tener un método que permita calcular la cantidad de desaprobados
        public void CantDesaprobados()
        {
            int cantdedesaprobadoss = 0;
            foreach (Alumno alumno in registro)
            {
                if (alumno.ObtenrProm() < 12.5f)
                {
                    cantdedesaprobadoss++;
                }
            }
            Console.WriteLine("Cuantos han jalados:" + cantdedesaprobadoss);
        }

        //Debe tener un método que permita obtener la lista de solo los alumnos que aprobaron
        public void VerAprobados()
        {
            List<Alumno> alumnosaprobados = new List<Alumno>();
            foreach (Alumno alumno in registro)
            {
                if (alumno.ObtenrProm() >= 12.5f)
                {
                    alumnosaprobados.Add(alumno);
                }
            }
            foreach (Alumno alumnoaprobado in alumnosaprobados)
            {
                Console.WriteLine(alumnoaprobado.ObtenrNomb() + "- Promedio aprobados: " + alumnoaprobado.ObtenrProm());
            }
        }

        //Debe tener un método que permita obtener la lista de los alumnos que desaprobaron
        public void VerDesaprobados()
        {
            List<Alumno> alumnosdesaprobados = new List<Alumno>();
            foreach (Alumno alumno in registro)
            {
                if (alumno.ObtenrProm() < 12.5f)
                {
                    alumnosdesaprobados.Add(alumno);
                }
            }
            foreach (Alumno alumnodesaprobado in alumnosdesaprobados)
            {
                Console.WriteLine(alumnodesaprobado.ObtenrNomb() + "- Promedio desaprobados: " + alumnodesaprobado.ObtenrProm());
            }
        }

        //Debe tener un método que permita calcular el promedio de los alumnos
        public void PromSalon()
        {
            float suma = 0;
            float promedio;

            foreach (Alumno alumno in registro)
            {
                suma = suma + alumno.ObtenrProm();
            }
            promedio = suma / registro.Count;
            Console.WriteLine("La nota promediada de los alumnos del sal es... " + promedio);
        }

    }

}
