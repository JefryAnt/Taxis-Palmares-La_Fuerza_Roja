using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Taxis_Palmares
{
    public class Usuario
    {
        #region propiedades

        public string User { get; set; }
        public string Password { get; set; }
        public bool EsAdmin { get; set; }
        public int Tipo { get; set; }

        #endregion propiedades

        #region Constructores

        public Usuario() { }

        public Usuario(string pUser, string pPass, bool esAdmin)
        {
            User = pUser;
            Password = pPass;
            EsAdmin = esAdmin;
        }

        public Usuario(string pUser, string pPass, int pTipo)
        {
            User = pUser;
            Password = pPass;
            Tipo = pTipo;
        }

        #endregion Constructores

        #region Operacion login

        public Usuario Logear(string User)
        {
            Usuario myUser = null;
            Conexion.Conexion myCon = new Conexion.Conexion();
            if (myCon.AbrirConexion())
            {
                string query = string.Format("exec Sp_Login '{0}'", User);
                DataTable dt = new DataTable();
                dt = myCon.DevolverSelect(query);
                if (dt.Rows.Count > 0)
                {
                    string id = dt.Rows[0][0].ToString();
                    string esAdmin = dt.Rows[0][1].ToString();
                    string pass = dt.Rows[0][2].ToString();
                    bool bAdmin = (esAdmin == "1");
                    myUser = new Usuario(id, pass, bAdmin);
                }
                myCon.CerrarConexion();
            }
            myCon = null;
            return myUser;
        }


        #endregion  Operacion login

        #region Operaciones Select

        public Usuario ConsultaEspecificaUsuario(string idUsuario)
        {
            Usuario objUsuario = null;
            string consulta =
            string.Format(" exec SP_ConsultaUsuario {0} ", idUsuario);
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
                        string ID = dtResultado.Rows[0][0].ToString();
                        string PA = dtResultado.Rows[0][1].ToString();
                        int IDT = Convert.ToInt32(dtResultado.Rows[0][2].ToString());

                        objUsuario = new Usuario(ID, PA, IDT);
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
            return objUsuario;
        }

        public DataTable ConsultaMasivaUsuario()
        {
            DataTable dtUsuario = new DataTable();
            string consulta = "exec SP_ConsultaUsuario 0";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    //proceso
                    dtUsuario = objDatos.DevolverSelect(consulta);
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {
            }
            objDatos = null;
            GC.Collect();

            return dtUsuario;
        }

        #endregion Operaciones Select

        #region Operaciones Hit

        public int AgregarUsuario()
        {
            int registrosAfectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta =
            string.Format("exec SP_Usuario '{0}','{1}',{2} , 1 ", this.User, this.Password, this.Tipo);

            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();

            }
            objDatos = null;
            GC.Collect();
            return registrosAfectados;
        }


        public int ActualizarUsuario()
        {
            int registrosAfectados = 0;
            string consulta =
                string.Format("exec SP_Usuario '{0}','{1}',{2} , 2 ", this.User, this.Password, this.Tipo);

            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                registrosAfectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;

            return registrosAfectados;
        }

        #endregion Operaciones Hit

        #region combo Usuario
        public DataTable ComboUsuario()
        {
            DataTable dt = new DataTable();
            string comando = "SELECT tp.idTipo, tp.Descripcion FROM TipoUsuario tp;";
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
