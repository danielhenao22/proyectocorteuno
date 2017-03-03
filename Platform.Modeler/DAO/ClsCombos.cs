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
        EntMarcaDataContext dbMarca;
        EntUsuarioDataContext dbUsuario;
        EntVehiculoDataContext dbVehiculo;

        public ClsCombos()
        {
            dbCiudad = new EntCiudadDataContext();
            dbGenero = new EntGeneroDataContext();
            dbTipoDic = new EntTipoDocDataContext();
            dbMarca = new EntMarcaDataContext();
            dbUsuario = new EntUsuarioDataContext();
            dbVehiculo = new EntVehiculoDataContext();


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

        public LinkedList<EntidadGen> buscarTodosGenero()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbGenero.GENERO.Select
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

        public LinkedList<EntidadGen> buscarTodosTipoDoc()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbTipoDic.TIPO_DOCUMENTO.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            //consulta.First();

            foreach (var ciu in consulta)
            {
                EntidadGen ent = new EntidadGen();
                ent.id = ciu.ID;
                ent.nombre = ciu.NOMBRE;
                temp.AddLast(ent);
            }
            return temp;
        }

        public LinkedList<EntidadGen> buscarTodosUsuarios()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbUsuario.USUARIO.Select
               (p => new { p.CEDULA, p.NOMBRE }).ToList();

            //consulta.First();

            foreach (var ciu in consulta)
            {
                EntidadGen ent = new EntidadGen();
                ent.id = ciu.CEDULA;
                ent.nombre = ciu.NOMBRE;
                temp.AddLast(ent);
            }
            return temp;
        }

        public LinkedList<EntidadGen> buscarTodosMarca()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbMarca.MARCA.Select
               (p => new { p.ID, p.NOMBRE }).ToList();

            //consulta.First();

            foreach (var ciu in consulta)
            {
                EntidadGen ent = new EntidadGen();
                ent.id = ciu.ID;
                ent.nombre = ciu.NOMBRE;
                temp.AddLast(ent);
            }
            return temp;
        }

        public LinkedList<EntidadGen> buscarTodosVehiculos()
        {
            LinkedList<EntidadGen> temp = new LinkedList<EntidadGen>();

            var consulta = dbVehiculo.VEHICULO.Select
               (p => new { p.PLACA, p.VALORDIA }).ToList();

            foreach (var ciu in consulta)
            {
                EntidadGen ent = new EntidadGen();
                ent.id = Convert.ToInt32(ciu.VALORDIA);
                ent.nombre = ciu.PLACA;
                temp.AddLast(ent);
            }
            return temp;
        }
        
    }
}
