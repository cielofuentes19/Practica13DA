using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio02_12.Models
{
    public class Facultades
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FacultadesDe { get; set; }
        public Facultades(int iD, string name, string facultades)
        {
            ID = iD;
            Name = name;
            FacultadesDe = facultades;
        }
    }
}