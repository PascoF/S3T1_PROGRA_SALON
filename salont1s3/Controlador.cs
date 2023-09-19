using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salont1s3
{
    class Controlador
    {
        List<salon> Salones = new List<salon>();

        //El usuario debe poder crear salones, e introducir alumnos a los salones

        public void Acciones()
        {

            Console.WriteLine("Seleccione la acción que se realizara...");

            Console.WriteLine("1. Para crear un salón...");
            Console.WriteLine("2. Para añadir un alumno a un salón...");
            Console.WriteLine("3. Para eliminar un alumno permanentemente...");
            Console.WriteLine("4. Para visualizar clase con sus respectivos alumnos");
            Console.WriteLine("5. Para salir");

            string x = Console.ReadLine();

            if (x == "1")
            {
                Console.WriteLine("Especifique un nombre para el salon");

                string y = Console.ReadLine();

                if (y != "")
                {
                    salon salon = new salon(y);
                    Salones.Add(salon);
                    Console.WriteLine("El salon fue creado");

                    Console.WriteLine("");
                    Console.WriteLine("");


                    Acciones();

                }
                else
                {
                    Console.WriteLine("Error, especifique nombre para el salon");

                    Acciones();
                }

            }

            if (x == "2")
            {
                if (Salones.Count == 0)
                {
                    Console.WriteLine("Error, debe crear primero un salon con su respectivo nombre");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Acciones();

                }
                else
                {
                    Console.WriteLine("El alumno sera asignado a un salon, seleccione uno");
                    int i = 1;

                    foreach (salon salon in Salones)
                    {

                        Console.WriteLine(i + "." + salon.ObtenrNomb());
                        i++;
                    }
                    string Ele = Console.ReadLine();

                    if (int.Parse(Ele) <= Salones.Count && int.Parse(Ele) > 0)
                    {
                        String nombre;

                        float notaprom1;
                        float notaprom2;
                        float notaprom3;

                        Console.WriteLine($"El alumno va al salon... {Salones[int.Parse(Ele) - 1].ObtenrNomb()}");
                        Console.WriteLine("El alumno es... ");

                        nombre = Console.ReadLine();

                        if (nombre != "")
                        {
                            Console.WriteLine("Nota del primer promedio del alumno");
                            notaprom1 = float.Parse(Console.ReadLine());

                            if (notaprom1 >= 0 && notaprom1 <= 20)
                            {
                                Console.WriteLine("Nota del segundo promedio del alumno");
                                notaprom2 = float.Parse(Console.ReadLine());

                                if (notaprom2 >= 0 && notaprom2 <= 20)
                                {
                                    Console.WriteLine("Nota del tercer promedio del alumno");
                                    notaprom3 = float.Parse(Console.ReadLine());

                                    if (notaprom3 >= 0 && notaprom3 <= 20)
                                    {
                                        Salones[int.Parse(Ele) - 1].AgregAlumno(nombre, notaprom1, notaprom2, notaprom3);
                                        Console.WriteLine("El alumno se registro");
                                        Console.WriteLine("");
                                        Console.WriteLine("");


                                        Acciones();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error... Nota invalidada, no se registro al alumno..");
                                        Console.WriteLine("");
                                        Console.WriteLine("");


                                        Acciones();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Nota no valida, no se registro al alumno.");
                                    Console.WriteLine("");
                                    Console.WriteLine("");


                                    Acciones();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Nota no valida, no se registro al alumno.");
                                Console.WriteLine("");
                                Console.WriteLine("");


                                Acciones();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Nombre no es valido, no se registro al alumno.");
                            Console.WriteLine("");
                            Console.WriteLine("");


                            Acciones();
                        }



                    }
                    else
                    {
                        Console.WriteLine("El número escrito no es valido");
                        Console.WriteLine("");
                        Console.WriteLine("");


                        Acciones();
                    }
                }

            }

            if (x == "3")
            {
                Console.WriteLine("Cual salón eliminara un alumno, seleccione el numero del salon...");
                int i = 1;
                foreach (salon salon in Salones)
                {

                    Console.WriteLine(i + "." + salon.ObtenrNomb());
                    i++;
                }
                string Ele = Console.ReadLine();
                if (int.Parse(Ele) <= Salones.Count && int.Parse(Ele) > 0)
                {
                    int elealumno;

                    Console.WriteLine("");
                    Console.WriteLine("");


                    Console.WriteLine("Elija el alumno que quiere eliminar...");

                    Salones[int.Parse(Ele) - 1].VerList();

                    elealumno = int.Parse(Console.ReadLine());
                    if (elealumno > 0 && elealumno <= Salones[int.Parse(Ele) - 1].registro.Count)
                    {

                        Console.WriteLine($"El alumno {Salones[int.Parse(Ele) - 1].registro[elealumno - 1].ObtenrNomb()} fue sacado");
                        Salones[int.Parse(Ele) - 1].ElimAlumno(elealumno);

                        Console.WriteLine("");
                        Console.WriteLine("");

                        Acciones();
                    }
                    else
                    {
                        Console.WriteLine("Error... número no encontrado en los registros");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Acciones();
                    }


                }
                else
                {
                    Console.WriteLine("El número escrito no se encuentra en los registros.");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Acciones();
                }

            }

            //El usuario debe poder seleccionar un salon y hacer las operaciones que el salon permite 

            if (x == "4")
            {
                Console.WriteLine("Seleccione al salon...");
                int i = 1;
                foreach (salon salon in Salones)
                {

                    Console.WriteLine(i + "." + salon.ObtenrNomb());
                    i++;
                }
                string Ele = Console.ReadLine();

                if (int.Parse(Ele) <= Salones.Count && int.Parse(Ele) > 0)
                {

                    Console.WriteLine($"Selecciono el salon ... {Salones[int.Parse(Ele) - 1].ObtenrNomb()}");
                    Console.WriteLine("Los alumnos registrados en el salon, son...");

                    Salones[int.Parse(Ele) - 1].VerList();

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("Seleccine que necesita del salon...");

                    Console.WriteLine("1.Aprobados");
                    Console.WriteLine("2.Desaprobados");
                    Console.WriteLine("3.Promedio del salon");

                    int numero = int.Parse(Console.ReadLine());

                    if (numero == 1)
                    {
                        Salones[int.Parse(Ele) - 1].CantAprobados();
                        Salones[int.Parse(Ele) - 1].VerAprobados();
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Acciones();
                    }
                    if (numero == 2)
                    {
                        Salones[int.Parse(Ele) - 1].CantDesaprobados();
                        Salones[int.Parse(Ele) - 1].VerDesaprobados();
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Acciones();
                    }
                    if (numero == 3)
                    {
                        Salones[int.Parse(Ele) - 1].PromSalon();
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Acciones();
                    }
                    else
                    {
                        Console.WriteLine("El número insertado provoca un error, trate de nuevo");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Acciones();
                    }
                }
                else
                {
                    Console.WriteLine("El número insertado provoca un error, trate de nuevo");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Acciones();
                }
            }

            //El programa debe terminar cuando el usuario indique que quiere salir de él

            if (x == "5")
            {
                //...
            }

        }
    }
}

