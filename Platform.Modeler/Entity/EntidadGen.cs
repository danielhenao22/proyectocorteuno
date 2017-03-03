using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.Entity
{
    public class EntidadGen
    {
        public string nombre { get; set; }
        public int id { get; set; }

        public EntidadGen(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public EntidadGen()
        {
        }
    }
}
