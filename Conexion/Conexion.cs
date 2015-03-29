using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Conexion
{
    public class Conexion
    {
        #region Propiedades
        SqlConnection cnx = null;
        #endregion Propiedades


        #region Constructor
        //Constructor principal de la clase de Acceso a Datos
        //inicializa el objeto conexión del Tipo SqlConnection
        public Conexion()
        {


            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionTaxis"].ToString());

        }
        #endregion Constructor


        #region Funciones

        public bool AbrirConexion()
        {
            bool abrioConexion = true;
            try
            {
                cnx.Open();
            }
            catch (Exception)
            {
                abrioConexion = false;
            }
            return abrioConexion;
        }

        public bool CerrarConexion()
        {
            bool cerroExitosamente = true;
            try
            {
                cnx.Close();
            }
            catch (Exception)
            {
                cerroExitosamente = false;
            }
            return cerroExitosamente;
        }


        public DataTable DevolverSelect(string consulta)
        {
            DataTable dtSelect = new DataTable();
            // que ocupo para hacer un select en la base de datos
            //conexión con la base de datos
            //statement sql que voy a ejecutar
            SqlCommand comando = new SqlCommand(consulta, cnx);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dtSelect);
            return dtSelect;

        }

        public int OperacionesHit(string consulta)
        {
            int numeroRegistrosAfectados = 0;
            SqlCommand comando = new SqlCommand(consulta, cnx);
            numeroRegistrosAfectados = comando.ExecuteNonQuery();
            return numeroRegistrosAfectados;
        }

        #endregion Funciones


        #region Destructor
        ~Conexion()
        {
            this.cnx = null;
        }
        #endregion Destructor

    }
}
