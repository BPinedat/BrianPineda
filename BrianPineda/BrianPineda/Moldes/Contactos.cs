using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrianPineda.Moldes
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        [MaxLength(20)]
        public int Edad { get; set; }

        public int Telefono { get; set; }

        public string Pais { get; set; }

        public string Nota { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }
    }
}
