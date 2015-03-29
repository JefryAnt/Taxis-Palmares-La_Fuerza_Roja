using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Vehiculo
    {
        #region propiedades

        public int Placa { get; set; }
        public int Capacidad { get; set; }
        public int Ano { get; set; }
        public string Estado { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Taxista { get; set; }

        #endregion propiedades

        #region Constructores

        public Vehiculo()
        { 
        }

        public Vehiculo(int Placa)
        {
            this.Placa = Placa;
        }

        public Vehiculo(int Placa, int Capacidad, int Ano, string Estado, string Modelo, string Tipo, string Marca, int Taxista)
        {
            this.Placa = Placa;
            this.Capacidad = Capacidad;
            this.Ano = Ano;
            this.Estado = Estado;
            this.Modelo = Modelo;
            this.Tipo = Tipo;
            this.Marca = Marca;
            this.Taxista = Taxista;
        }

        #endregion Constructores

        #region Operaciones Select

        //Consulta Específica que devuelve un objeto del tipo de la Clase
        public Vehiculo ConsultaEspecificaVehiculo(int Placa)
        {
            Vehiculo objVehiculo = null;

            string consulta =
            string.Format(" exec SP_ConsultaVehiculos {0} ", Placa);


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
                        int PLACA = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        int CAPACIDAD = Convert.ToInt32(dtResultado.Rows[0][1].ToString());
                        int ANO = Convert.ToInt32(dtResultado.Rows[0][2].ToString());
                        string ESTADO = dtResultado.Rows[0][3].ToString();
                        string MODELO = dtResultado.Rows[0][4].ToString();
                        string TIPO = dtResultado.Rows[0][5].ToString();
                        string MARCA = dtResultado.Rows[0][6].ToString();
                        int TAXISTA = Convert.ToInt32(dtResultado.Rows[0][7].ToString());

                        objVehiculo = new Vehiculo(Placa, Capacidad, Ano, Estado, Modelo, Tipo, Marca, Taxista);
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



            return objVehiculo;

        }

        public DataTable ConsultaMasivaVehiculo()
        {
            DataTable dtVehiculo = new DataTable();
            string consulta = "exec SP_ConsultaVehiculos 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtVehiculo = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

            }

            objDatos = null;
            GC.Collect();

            return dtVehiculo;
        }
        #endregion Operaciones Select

        #region Operaciones Hit

        public int AgregarVehiculo()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Vehiculos {0},{1},{2},'{3}','{4}','{5}','{6}',{7}, 1  ", this.Placa, this.Capacidad, this.Ano, this.Estado, this.Modelo, this.Tipo, this.Marca, this.Taxista);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }

        public int ActualizarVehiculo()
        {
            int registrosAfectados = 0;
            string consulta =
                string.Format("exec SP_Vehiculos {0},{1},{2},'{3}','{4}','{5}','{6}',{7}, 2  ", this.Placa, this.Capacidad, this.Ano, this.Estado, this.Modelo, this.Tipo, this.Marca, this.Taxista);

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

    }
}
