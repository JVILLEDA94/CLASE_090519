using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
    public class ManttVendor
    {
        bdConex test= new bdConex();
        private String codVendor, nombreVendor;
        public DataTable dt = new DataTable();
    

        public String NombreVendor
        {
            get { return nombreVendor; }
            set { nombreVendor = value; }
        }

        public String CodVendor
        {
            get { return codVendor; }
            set { codVendor = value; }
        }

        public void insertVendor()
        {
            try 
            {
                String insert = "INSERT INTO [dbo].[VENDEDOR](VENDEDOR,NOMBRE) VALUES('" + CodVendor + "','" + NombreVendor + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void updateVendor()
        {
            try
            {
                String update = "update  [dbo].[VENDEDOR] set NOMBRE ='" + nombreVendor + "' where VENDEDOR ='" + codVendor + "'" ;
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void deleteVendor()
        {
            try
            {
                String update = "delete from  [dbo].[VENDEDOR] where VENDEDOR ='" + codVendor + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }

        }

        public void mostrarVendor()
        {
            try
            {
                String consulta = "select * from VENDEDOR";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }

        }


        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
    }
}
