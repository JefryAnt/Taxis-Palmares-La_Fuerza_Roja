using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Factura
    {
        
        #region Propiedades

        public int Numero_Factura { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalles { get; set; }
        public int Vehiculo { get; set; }
        public int Taxista { get; set; }

        #endregion Propiedades

        #region Constructores

        public Factura() 
        {
        }

        public Factura(int Numero_Factura)
        {
            this.Numero_Factura = Numero_Factura;
        }

        public Factura(int Numero_Factura, decimal Monto, DateTime Fecha, string Detalles, int Vehiculo, int Taxista)
        {
            this.Numero_Factura = Numero_Factura;
            this.Monto = Monto;
            this.Fecha = Fecha;
            this.Detalles = Detalles;
            this.Vehiculo = Vehiculo;
            this.Taxista = Taxista;

        }

        #endregion Constructores

        #region Operaciones Select

        //Consulta Específica que devuelve un objeto del tipo de la Clase
        public Factura ConsultaEspecificaFactura(int Numero_Factura)
        {
            Factura objFactura = null;

            string consulta =
            string.Format(" exec SP_ConsultaFactura {0} ", Numero_Factura);


            //abro el objeto de acceso a datos
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //hago el proceso para recuperar el usuario
                    DataTable dtResultado = objDatos.DevolverSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {

                        int NUMERO_FACTURA = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        decimal MONTO = Convert.ToDecimal(dtResultado.Rows[0][1].ToString());
                        DateTime FECHA = Convert.ToDateTime(dtResultado.Rows[0][2].ToString());
                        string DETALLES = dtResultado.Rows[0][3].ToString();
                        int VEHICULO = Convert.ToInt32(dtResultado.Rows[0][4].ToString());
                        int TAXISTA = Convert.ToInt32(dtResultado.Rows[0][5].ToString());

                        objFactura = new Factura(Numero_Factura, Monto, Fecha, Detalles, Vehiculo, Taxista);
                    }

                    //cierro la conexión
                    objDatos.CerrarConexion();

                }


            }
            catch (Exception)
            {

            }

            //libero la memoria
            objDatos = null;
            GC.Collect();



            return objFactura;

        }

        public DataTable ConsultaMasivaFactura()
        {
            DataTable dtFactura = new DataTable();
            string consulta = "exec SP_ConsultaFactura 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtFactura = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

            }

            objDatos = null;
            GC.Collect();

            return dtFactura;
        }
        #endregion Operaciones Select

        #region Operaciones Hit
        public int AgregarFactura()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Factura {0},{1},'{2}','{3}',{4},{5}, 1 ", this.Numero_Factura, this.Monto, this.Fecha.ToString("yyyy-MM-dd"), this.Detalles, this.Vehiculo, this.Taxista);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }


        public int NumeroFactura()
        {
            int n = 0;
            Factura objfactura = null;
            string consulta = "select COUNT(*) as Numero from Factura";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.DevolverSelect(consulta);
                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int CODIGO = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        n = CODIGO + 1;
                    }
                   
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {
                n = 0;
            }
            objDatos = null;
            GC.Collect();
            return n;
        }
        #endregion Operaciones Hit
    }
}
