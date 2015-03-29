using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Llamada
    {
        
        #region Propiedades

        public int Codigo { get; set; }
        public string Hora { get; set; }
        public string Direccion { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public int Movil { get; set; }

        #endregion Propiedades

        #region Constructores

        public Llamada() 
        { 
        }

        public Llamada(int Codigo)
        {
            this.Codigo = Codigo;
        }

        public Llamada(int Codigo, string Hora, string Direccion, int Cliente, string NombreCliente, int Movil)
        {
            this.Codigo = Codigo;
            this.Hora = Hora;
            this.Direccion = Direccion;
            this.Cliente = Cliente;
            this.NombreCliente = NombreCliente;
            this.Movil = Movil;

        }

        #endregion Constructores

        #region Operaciones Select

        //Consulta Específica que devuelve un objeto del tipo de la Clase
        public Llamada ConsultaEspecificaLlamada(int Codigo)
        {
            Llamada objLlamada = null;

            string consulta =
            string.Format(" exec SP_ConsultaLlamadas {0} ", Codigo);


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

                        int CODIGO = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string HORA = dtResultado.Rows[0][1].ToString();
                        string DIRECCION = dtResultado.Rows[0][2].ToString();
                        int CLIENTE = Convert.ToInt32(dtResultado.Rows[0][3].ToString());
                        string NOMBRECLIENTE = dtResultado.Rows[0][4].ToString();
                        int MOVIL = Convert.ToInt32(dtResultado.Rows[0][5].ToString());


                        objLlamada = new Llamada(Codigo, Hora, Direccion, Cliente, NombreCliente, Movil);
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



            return objLlamada;

        }

        public DataTable ConsultaMasivaLlamada()
        {
            DataTable dtLlamada = new DataTable();
            string consulta = "exec SP_ConsultaLlamadas 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtLlamada = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

            }

            objDatos = null;
            GC.Collect();

            return dtLlamada;
        }
        #endregion Operaciones Select

        #region Operaciones Hit

        public int AgregarLlamada()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Llamadas {0},'{1}','{2}',{3},'{4}',{5}, 1 ", this.Codigo, this.Hora, this.Direccion, this.Cliente, this.NombreCliente, this.Movil);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }

        #endregion Operaciones Hit

        #region identity llamada

        public int numeroLlamada()
        {
            int n = 0;
            Llamada objLlamada = null;
            string consulta = "select COUNT(*) as Numero from Llamadas";
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

        #endregion identity llamada

    }
}
