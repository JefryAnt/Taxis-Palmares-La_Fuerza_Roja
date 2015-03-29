using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Taxista
    {
        #region Propiedades

        public int Identificacion { get; set; }
        public DateTime Fecha_Nacimineto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Residencia { get; set; }
        public string Telefono { get; set; }
        public string Codigo_Taxista { get; set; }


        #endregion Propiedades

        #region Constructores

        public Taxista()
        {
        }

        public Taxista(int Identificacion)
        {
            this.Identificacion = Identificacion;
        }

        public Taxista(int Identificacion, DateTime Fecha_Nacimineto, string Nombre, string Apellido, string Residencia, string Telefono, string Codigo_Taxista)
        {
            this.Identificacion = Identificacion;
            this.Fecha_Nacimineto = Fecha_Nacimineto;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Residencia = Residencia;
            this.Telefono = Telefono;
            this.Codigo_Taxista = Codigo_Taxista;

        }

        #endregion Constructores

        #region Operaciones Select

        //Consulta Específica que devuelve un objeto del tipo de la Clase
        public Taxista ConsultaEspecificaTaxista(int Identificacion)
        {
            Taxista objTaxista = null;

            string consulta =
            string.Format(" exec SP_ConsultaTaxistas {0} ", Identificacion);


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
                        objTaxista = new Taxista(Identificacion, Fecha_Nacimineto, Nombre, Apellido, Residencia, Telefono, Codigo_Taxista);

                        int IDENTIFICACION = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        DateTime FECHA_NACIMIENTO = Convert.ToDateTime(dtResultado.Rows[0][1].ToString());
                        string NOMBRE = dtResultado.Rows[0][2].ToString();
                        string APELLIDO = dtResultado.Rows[0][3].ToString();
                        string RESIDENCIA = dtResultado.Rows[0][4].ToString();
                        string TELEFONO = dtResultado.Rows[0][5].ToString();
                        string CODIGO_TAXISTA = dtResultado.Rows[0][6].ToString();

                        objTaxista = new Taxista(Identificacion, Fecha_Nacimineto, Nombre, Apellido, Residencia, Telefono, Codigo_Taxista);
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



            return objTaxista;

        }

        public DataTable ConsultaMasivaTaxista()
        {
            DataTable dtTaxista = new DataTable();
            string consulta = "exec SP_ConsultaTaxistas 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtTaxista = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

            }

            objDatos = null;
            GC.Collect();

            return dtTaxista;
        }
        #endregion Operaciones Select


        #region Operaciones Hit
        public int AgregarTaxista()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Taxistas {0},'{1}','{2}','{3}','{4}','{5}','{6}', 1 ", this.Identificacion, this.Fecha_Nacimineto.ToString("yyyy-MM-dd"), this.Nombre, this.Apellido, this.Residencia, this.Telefono, this.Codigo_Taxista);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }


        public int ActualizarTaxista()
        {
            int registrosAfectados = 0;
            string consulta =
                string.Format("exec SP_Taxistas {0},'{1}','{2}','{3}','{4}','{5}','{6}', 2 ", this.Identificacion, this.Fecha_Nacimineto.ToString("yyyy-MM-dd"), this.Nombre, this.Apellido, this.Residencia, this.Telefono, this.Codigo_Taxista);

            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;

            return registrosAfectados;
        }

        #endregion Operaciones Hit


        #region combo taxista
        public DataTable ComboTaxista()
        {
            DataTable dt = new DataTable();
            string comando = "select tx.Identificacion, tx.Nombre+' '+tx.Apellido as Nombre from Taxistas tx;";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                dt = objDatos.DevolverSelect(comando);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            return dt;
        }

        #endregion

    }
}
