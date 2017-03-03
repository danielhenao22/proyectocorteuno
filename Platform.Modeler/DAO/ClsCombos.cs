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

            var consulta = from x in dbCiudad.CIUDAD select x;

            consulta.First();

            foreach (CIUDAD ciu in consulta)
            {
                temp.AddLast(ciu.ID.ToString());
                temp.AddLast(ciu.NOMBRE);
            }
            return temp;
        }

        public LinkedList<String> buscarTodosGenero()
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = from x in dbGenero.GENERO select x;

            consulta.First();

            foreach (GENERO gen in consulta)
            {
                temp.AddLast(gen.ID.ToString());
                temp.AddLast(gen.NOMBRE);
            }
            return temp;
        }

        public LinkedList<String> buscarTodosTipoDoc()
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = from x in dbTipoDic.TIPO_DOCUMENTO select x;

            consulta.First();

            foreach (TIPO_DOCUMENTO tip in consulta)
            {
                temp.AddLast(tip.ID.ToString());
                temp.AddLast(tip.NOMBRE);
            }
            return temp;
        }
    }
}
