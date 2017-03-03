using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
     public class ClsAlquiler
    {

        EntAlquilerDataContext db;

        public ClsAlquiler()
        {
            db = new EntAlquilerDataContext();
            // :c 
            // :d
        }

        public bool guardar(int usuario_id, String vehiculo_id, DateTime fecha_alquiler)
        {
            try
            {
                ALQUILER alq = new ALQUILER();                
                
                alq.USUARIO_CEDULA = usuario_id;
                alq.VEHICULO_PLACA = vehiculo_id;
                alq.FECHA_ALQUILER = fecha_alquiler;
                db.ALQUILER.InsertOnSubmit(alq);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("EROR"+ex);
                return false;

            }
        }


        public LinkedList<String> buscar(int id)
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = db.ALQUILER.Where(p => p.ID == id);

            consulta.First();

            foreach (ALQUILER alq in consulta)
            {
                temp.AddLast(alq.ID.ToString());
                temp.AddLast(alq.USUARIO_CEDULA.ToString());
                temp.AddLast(alq.VEHICULO_PLACA.ToString());
                temp.AddLast(alq.FECHA_ALQUILER.ToString());
                
             

            }
            return temp;
        }

        public bool modificar(int id , int usuario_id, String vehiculo_id, DateTime fecha_alquiler)
        {
            try
            {
                var consulta = db.ALQUILER.Where(p => p.ID == id); ;
                consulta.First();
                foreach (ALQUILER alq in consulta)
                {


                   
                    alq.USUARIO_CEDULA = usuario_id;
                    alq.VEHICULO_PLACA = vehiculo_id;
                    alq.FECHA_ALQUILER = fecha_alquiler;

                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                var consulta = db.ALQUILER.Where(p => p.ID == id);
                consulta.First();
                foreach (ALQUILER alq in consulta)
                {
                    db.ALQUILER.DeleteOnSubmit(alq);


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
