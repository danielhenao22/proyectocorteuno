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

        public LinkedList<String> buscarTodosCiudad()
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = dbCiudad.CIUDAD.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            consulta.First();

            foreach (var ciu in consulta)
            {
                temp.AddLast(ciu.NOMBRE.ToString());
                temp.AddLast(ciu.NOMBRE);
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

        public LinkedList<String> buscarTodosTipoDoc()
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = dbTipoDic.TIPO_DOCUMENTO.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            consulta.First();

            foreach (var tip in consulta)
            {
                temp.AddLast(tip.ID.ToString());
                temp.AddLast(tip.NOMBRE);
            }
            return temp;
        }
    }
}
