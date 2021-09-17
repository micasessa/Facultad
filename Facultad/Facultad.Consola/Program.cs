using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjFacultad.Libreria.Entidades;

namespace EjFacultad.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;
            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar Alumnos \n2) Listar Empleados ... Sigan escribiendo ustedes";
            // Creo el objeto con el que voy a trabajar en este programa
            Facultad facultad = new Facultad("FCE");
            // pantalla de bienvenida
            Console.WriteLine("Bienvenido a " + facultad.Nombre);
            do
            {
                Console.WriteLine(menu); //mostramos el menú
                                         //capturamos la seleccion
                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7", "X" };
                if (ConsolaUtils.EsOpcionValida(opcionSeleccionada, opcionesValidas))
                {
                    if (opcionSeleccionada.ToUpper() == "X")
                    {
                        continuarActivo = false;
                        continue;
                    }
                    switch (opcionSeleccionada)
                    {
                        case "1":
                            // listar
                            Program.ListarAlumnos(facultad);
                            break;
                        case "2":
                            // listar
                            Program.ListarEmpleados(facultad);
                            break;
                        case "3":
                            // alta
                            Program.AgregarAlumno(facultad);
                            break;
                        case "4":
                            // modificar
                            Program.ModificarAlumno(facultad);
                            break;
                        case "5":
                            // borrar
                            Program.EliminarAlumno(facultad);
                            break;
                        case "6":
                            // alta
                            Program.AgregarEmpleado(facultad);
                            break;
                        case "7":
                            // modificar
                            Program.ModificarAlumno(facultad);
                            break;
                        case "8":
                            // borrar
                            Program.EliminarEmpleado(facultad);
                            break;
                        case "9":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }
    }
}
