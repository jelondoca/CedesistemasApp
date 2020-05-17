﻿using System;
namespace CedesistemasApp.Models
{
    public class RestaurantModel
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Imagen { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string SitioWeb { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

        public object Productos { get; set; }

        public int Calificacion { get; set; }

    }
}
