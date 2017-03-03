using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.Entity
{
    public class EntidadVeh
    {

        public string placa { get; set; }
        public string npuertas { get; set; }
        public string color { get; set; }
        public string valor { get; set; }
        public string nombreM { get; set; }

        public int  marcaId { get; set; }

        public EntidadVeh(string placa, string npuertas, string color, string valor, int marcaId)
        {




            this.placa = placa;
            this.npuertas = npuertas;
            this.color = color;
            this.valor = valor;
           
            this.marcaId = marcaId;
        }

        public EntidadVeh()
        {

        }
}
}

