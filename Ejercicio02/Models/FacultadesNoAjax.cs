using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio02_12.Models
{
    public class FacultadesNoAjax
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public FacultadesNoAjax(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}