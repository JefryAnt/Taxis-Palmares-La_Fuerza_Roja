using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Tarifa
    {
        #region Propiedades

        public int Id_Tarifas { get; set; }
        public decimal Monto { get; set; }
        public string Lugar { get; set; }
        public string Distancia { get; set; }
        public string Extras { get; set; }


        #endregion Propiedades

        #region Constructores

        public Tarifa()
        {
        }

        public Tarifa(int Id_Tarifas)
        {
            this.Id_Tarifas = Id_Tarifas;
        }

        public Tarifa(int Id_Tarifas, decimal Monto, string Lugar, string Distancia, string Extras)
        {
            this.Id_Tarifas = Id_Tarifas;
            this.Monto = Monto;
            this.Lugar = Lugar;
            this.Distancia = Distancia;
            this.Extras = Extras;

        }

        #endregion Constructores

        #region Operaciones Select

        //Consulta Específica que devuelve un objeto del tipo de la Clase
        public Tarifa ConsultaEspecificaTarifa(int Id_Tarifas)
        {
            Tarifa objTarifa = null;

            string consulta =
            string.Format(" exec SP_ConsultaTarifas {0} ", Id_Tarifas);


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
                        objTarifa = new Tarifa(Id_Tarifas, Monto, Lugar, Distancia, Extras);

                        int ID_TARIFAS = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        decimal MONTO = Convert.ToDecimal(dtResultado.Rows[0][1]); //.ToString()
                        string LUGAR = dtResultado.Rows[0][2].ToString();
                        string DISTANCIA = dtResultado.Rows[0][3].ToString();
                        string EXTRAS = dtResultado.Rows[0][4].ToString();   

                        objTarifa = new Tarifa(Id_Tarifas, Monto, Lugar, Distancia, Extras);
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

            return objTarifa;

        }

        public DataTable ConsultaMasivaTarifa()
        {
            DataTable dtTarifa = new DataTable();
            string consulta = "exec SP_ConsultaTarifas 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtTarifa = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

            }

            objDatos = null;
            GC.Collect();

            return dtTarifa;
        }
        #endregion Operaciones Select

        #region Operaciones Hit

        public int AgregarTarifa()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Tarifas {0},{1},'{2}','{3}','{4}', 1 ", this.Id_Tarifas, this.Monto, this.Lugar, this.Distancia, this.Extras);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }


        public int ActualizarTarifa()
        {
            int registrosAfectados = 0;
            string consulta =
                string.Format("exec SP_Tarifas {0},{1},'{2}','{3}','{4}', 2 ", this.Id_Tarifas, this.Monto, this.Lugar, this.Distancia, this.Extras);

            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }

        #endregion Operaciones Hit

        #region identity Tarifa

        public int numeroTarifa()
        {
            int n = 0;
            Tarifa objtarifa = null;
            string consulta = "select COUNT(*) as Numero from Tarifas";
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

        #endregion identity Tarifa

    }
}
