using Platform.Modeler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.DAO
{
    public class ClsVehiculo
    {
        EntVehiculoDataContext db;

        public ClsVehiculo()
        {
            db = new EntVehiculoDataContext();
        }

        public bool guardar(String placa, String numero_puestos, String color, String valor_dia, int marca_id)
        {
            try
            {
                VEHICULO veh = new VEHICULO();
                veh.PLACA = placa;
                veh.numero_puestos = numero_puestos;
                veh.COLOR = color;
                veh.VALOR_DIA = valor_dia;
                veh.MARCA_ID = marca_id;

                db.VEHICULO.InsertOnSubmit(veh);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }


        public LinkedList<String> buscar(String placa)
        {
            LinkedList<String> temp = new LinkedList<String>();

            var consulta = from x in db.VEHICULO where x.PLACA == placa select x;

            consulta.First();

            foreach (VEHICULO veh in consulta)
            {
                temp.AddLast(veh.numero_puestos);
                temp.AddLast(veh.COLOR);
                temp.AddLast(veh.VALOR_DIA);
                temp.AddLast(veh.MARCA_ID.ToString());
             

            }
            return temp;
        }

        public bool modificar(String placa, String numero_puestos, String color, String valor_dia, int marca_id)
        {
            try
            {
                var consulta = from x in db.VEHICULO where x.PLACA == placa select x;
                consulta.First();
                foreach (VEHICULO veh in consulta)
                {
                    
                    veh.PLACA = placa;
                    veh.numero_puestos = numero_puestos;
                    veh.COLOR = color;
                    veh.VALOR_DIA = valor_dia;
                    veh.MARCA_ID = marca_id;

                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool eliminar(String placa)
        {
            try
            {
                var consulta = from x in db.VEHICULO where x.PLACA == placa select x;
                consulta.First();
                foreach (VEHICULO est in consulta)
                {
                    db.VEHICULO.DeleteOnSubmit(est);


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
