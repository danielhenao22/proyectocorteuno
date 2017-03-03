using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
    public class ClsUsuario
    {
     
        EntUsuarioDataContext db;

        public ClsUsuario()
        {
            db = new EntUsuarioDataContext();
        }

        public LinkedList<String> buscarTodosCiudad(int CEDULA)
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = from x in db.USUARIO where x.CEDULA == CEDULA select x;

            consulta.First();

            foreach (USUARIO usu in consulta)
            {
                temp.AddLast(usu.CEDULA.ToString());
                temp.AddLast(usu.NOMBRE);
                temp.AddLast(usu.APELLIDO);
                temp.AddLast(usu.EDAD.ToString());
                temp.AddLast(usu.GENERO_ID.ToString());
                temp.AddLast(usu.TIPO_DOCUMENTO_ID.ToString());
                temp.AddLast(usu.CIUDAD_ID.ToString());


            }
            return temp;
        }

        public bool guardar(int documento, String nombre, String apellido, int edad, int genero_id, int tipo_documento_id, int cuidad_id)
        {
            try
            {
                USUARIO usu = new USUARIO();
                usu.CEDULA = documento;
                usu.NOMBRE = nombre;
                usu.APELLIDO = apellido;
                usu.EDAD = edad;
                usu.GENERO_ID = genero_id;
                usu.TIPO_DOCUMENTO_ID = tipo_documento_id;
                usu.CIUDAD_ID = cuidad_id;
                db.USUARIO.InsertOnSubmit(usu);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public LinkedList<String> buscar(int CEDULA)
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = from x in db.USUARIO where x.CEDULA == CEDULA select x;

            consulta.First();

            foreach (USUARIO usu in consulta)
            {
                temp.AddLast(usu.CEDULA.ToString());
                temp.AddLast(usu.NOMBRE);
                temp.AddLast(usu.APELLIDO);
                temp.AddLast(usu.EDAD.ToString());
                temp.AddLast(usu.GENERO_ID.ToString());
                temp.AddLast(usu.TIPO_DOCUMENTO_ID.ToString());
                temp.AddLast(usu.CIUDAD_ID.ToString());
             

            }
            return temp;
        }

        public bool modificar(int CEDULA, String nombre, String apellido, int edad, int genero_id, int tipo_documento_id, int cuidad_id)
        {
            try
            {
                var consulta = from x in db.USUARIO where x.CEDULA == CEDULA select x;
                consulta.First();
                foreach (USUARIO usu in consulta)
                {


                    usu.CEDULA = CEDULA;
                    usu.NOMBRE = nombre;
                    usu.APELLIDO = apellido;
                    usu.EDAD = edad;
                    usu.GENERO_ID = genero_id;
                    usu.TIPO_DOCUMENTO_ID = tipo_documento_id;
                    usu.CIUDAD_ID = cuidad_id;

                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool eliminar(int CEDULA)
        {
            try
            {
                var consulta = from x in db.USUARIO where x.CEDULA == CEDULA select x;
                consulta.First();
                foreach (USUARIO usu in consulta)
                {
                    db.USUARIO.DeleteOnSubmit(usu);


                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
