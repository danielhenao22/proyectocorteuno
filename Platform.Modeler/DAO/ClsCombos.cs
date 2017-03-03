using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
    public class ClsCombos
    {

        EntCiudadDataContext dbCiudad;
        EntGeneroDataContext dbGenero;
        EntTipoDocDataContext dbTipoDic;

        public ClsCombos()
        {
            dbCiudad = new EntCiudadDataContext();
            dbGenero = new EntGeneroDataContext();
            dbTipoDic = new EntTipoDocDataContext();


        }

        public LinkedList<EntidadGen> buscarTodosCiudad()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbCiudad.CIUDAD.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            consulta.First();

            foreach (var ciu in consulta)
            {
                EntidadGen ent = new EntidadGen();
                ent.id = ciu.ID;
                ent.nombre = ciu.NOMBRE;
                temp.AddLast(ent);
            }
            return temp;
        }

        public LinkedList<String> buscarTodosGenero()
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = dbGenero.GENERO.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            consulta.First();

            foreach (var gen in consulta)
            {
                temp.AddLast(gen.ID.ToString());
                temp.AddLast(gen.NOMBRE);
            }
            return temp;
        }

        public LinkedList<EntidadGen> buscarTodosTipoDoc()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbTipoDic.TIPO_DOCUMENTO.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            consulta.First();

            foreach (var ciu in consulta)
            {
                EntidadGen ent = new EntidadGen();
                ent.id = ciu.ID;
                ent.nombre = ciu.NOMBRE;
                temp.AddLast(ent);
            }
            return temp;
        }
    }
}
