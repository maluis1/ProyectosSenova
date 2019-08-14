﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectosSenova
{
    public class Proyecto
       
    {
        #region Atributos
        public List<Proyecto> proyectos = new List<Proyecto>();//definicion lista
        #endregion
        #region Propiedades
        //prop
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion

        #region Constructores
        //ctor
        public Proyecto(String nombre,double codigo ,string area, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {

        }
        public Proyecto(string area,int duracion)
        {
            Area = area;
            Duracion = duracion;
        }
        #endregion

        #region Metodos
        public void ObtenerMayores()
        {
    List<Proyecto> pro20 = new List<Proyecto>();
            foreach (var item in proyectos)
            {
                double mod = item.Codigo % 2;
                if ((item.Codigo > 20) && (mod == 0))
                {
                  pro20.Add(item);
                }
            }
            ImprimirProyecto(pro20);
        }
        public void IngresarProyecto()
        {
            var res = "y";
            while (res=="y")
            {
                Proyecto miproyecto = new Proyecto();
                Console.WriteLine("Ingrese el nombre del proyecto: ");
                miproyecto.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el codigo: ");
                miproyecto.Codigo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Area del proyecto: ");
                miproyecto.Area = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion del proyecto: ");
                miproyecto.Duracion = int.Parse(Console.ReadLine());
                proyectos.Add(miproyecto);
                Console.WriteLine("desea agregar un nuevo proyecto");
                res = Console.ReadLine();
            }
        }

       public void ImprimirProyecto(List<Proyecto>proyecto1)
        {
            foreach (var item in proyecto1)
            {
                Console.WriteLine($" Nombre: { item.Nombre}");
                Console.WriteLine($" Codigo: {item.Codigo}");
                Console.WriteLine($" Area: {item.Area}");
                Console.WriteLine($" Duracion: {item.Duracion}");
            }  
        }
        #endregion
    }
}
