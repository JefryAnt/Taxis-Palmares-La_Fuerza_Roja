using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Cliente
    {
        #region Propiedades

        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


        #endregion Propiedades

        #region Constructores

        public Cliente()
        {
        }

        public Cliente(int Cedula)
        {
            this.Cedula = Cedula;
        }

        public Cliente(int Cedula, string Nombre, string Apellido, string Telefono, string Direccion)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Direccion = Direccion;

        }

        #endregion Constructores

        #region Operaciones Select

        //Consulta Específica que devuelve un objeto del tipo de la Clase
        public Cliente ConsultaEspecificaCliente(int Cedula)
        {
            Cliente objCliente = null;

            string consulta =
            string.Format(" exec SP_ConsultaCliente {0} ", Cedula);


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
                        objCliente = new Cliente(Cedula, Nombre, Apellido, Telefono, Direccion);

                        int CEDULA = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string NOMBRE = dtResultado.Rows[0][1].ToString();
                        string APELLIDO = dtResultado.Rows[0][2].ToString();
                        string TELEFONO = dtResultado.Rows[0][3].ToString();
                        string DIRECCION = dtResultado.Rows[0][4].ToString();

                        objCliente = new Cliente(Cedula,Nombre,Apellido,Telefono,Direccion);
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



            return objCliente;

        }

        public DataTable ConsultaMasivaCliente()
        {
            DataTable dtCliente = new DataTable();
            string consulta = "exec SP_ConsultaCliente 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtCliente = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

            }

            objDatos = null;
            GC.Collect();

            return dtCliente;
        }
        #endregion Operaciones Select

        #region Operaciones Hit
        public int AgregarCliente()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Cliente {0},'{1}','{2}','{3}','{4}', 1 ", this.Cedula, this.Nombre, this.Apellido, this.Telefono, this.Direccion);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }


        public int ActualizarCliente()
        {
            int registrosAfectados = 0;
            string consulta =
                string.Format("exec SP_Cliente {0},'{1}','{2}','{3}','{4}', 2 ", this.Cedula, this.Nombre, this.Apellido, this.Telefono, this.Direccion);

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

        #region combo Cliente
        public DataTable ComboCliente()
        {
            DataTable dt = new DataTable();
            string comando = "select cl.Cedula, cl.Nombre+' '+cl.Apellido as Nombre from Cliente cl;";
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
