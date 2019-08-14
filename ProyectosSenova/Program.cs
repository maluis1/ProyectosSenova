
//obtener todos los proyectos cuyo codigo sea numero mayor a 20 y sea par
//ordenar los proyectos ascendentemente por duracion
//seleccionar el primer proyecto que sea multiplo de 6
//listar solo las areas de los proyectos
//seleccionar los proyectos solo con nombre y codigo
//sumar la duracion de todos los proyectos
// agrupar los proyectos por proyectos
using System;
namespace ProyectosSenova
{
    class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //int puntaje = 0;

            //Proyecto miProyecto = new Proyecto();
         
            
           // miProyecto.ImprimirProyecto(miProyecto3.Proyectos);
            
            //Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            miProyecto3.IngresarProyecto();
            //Console.WriteLine("digite el numero del codigo");
            //int x = int.Parse(Console.ReadLine());
            list<Proyecto> proyectos = new list<Proyecto>();
            miProyecto3.ObtenerMayores();
            
          
            //Proyecto miProyecto4 = new Proyecto("Realidad aumentada",12540,"sistemas",10);
            //Proyecto miProyecto5 = new Proyecto("Talento Humano", 5);
            //Proyecto miProyecto6 = new Proyecto("Contabilidad", 6);


            // miProyecto3.IngresarProyecto();
            // miProyecto3.ImprimirProyecto();
            //miProyecto4.ImprimirProyecto();
            //miProyecto5.ImprimirProyecto();
            //miProyecto6.ImprimirProyecto();



            //miProyecto.Area = "Sistemas";
            //miProyecto.Codigo = 12000;
            //miProyecto.Duracion = 13;
            //miProyecto.Nombre = "Desarrollo internet  de las cosas IOT";

            //Console.WriteLine($"Area: {miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion:{miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");

            //miProyecto2.Area = "Redes";
            //miProyecto2.Codigo = 13000;
            //miProyecto2.Duracion = 14;
            //miProyecto2.Nombre = "Desarrollo Arduino";

            //Console.WriteLine($"Area: {miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion:{miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");
            Console.ReadLine();
    



        }

    }
}
