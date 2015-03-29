using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public class Gestor : IGestor
    {

        #region Objetos

        Usuario objUsuario = null;
        Cliente objCliente = null;
        Llamada objLlamada = null;
        Tarifa objTarifa = null;
        Vehiculo objVehiculo = null;
        Taxista objTaxista = null;
        Factura objFactura = null;

        #endregion Objetos

        #region Usuario

        public int AgregarUsuario(string idUsuario, string password, int idTipoUsuario)
        {
            objUsuario = new Usuario(idUsuario, password, idTipoUsuario);
            return objUsuario.AgregarUsuario();

        }

        public int ActualizarUsuario(string idUsuario, string password, int idTipoUsuario)
        {
            objUsuario = new Usuario(idUsuario, password, idTipoUsuario);
            return objUsuario.ActualizarUsuario();
        }

        public DataTable ConsultaMasivaUsuario()
        {
            objUsuario = new Usuario();
            return objUsuario.ConsultaMasivaUsuario();
        }

        public Usuario ConsultaEspecificaUsuario(string idUsuario)
        {
            objUsuario = new Usuario();
            return objUsuario.ConsultaEspecificaUsuario(idUsuario);

        }
        #endregion Usuario

        #region Cliente


        public int AgregarCliente(int Cedula, string Nombre, string Apellido, string Telefono, string Direccion)
        {
            objCliente = new Cliente(Cedula, Nombre, Apellido, Telefono, Direccion);
            return objCliente.AgregarCliente();

        }

        public int ActualizarCliente(int Cedula, string Nombre, string Apellido, string Telefono, string Direccion)
        {
            objCliente = new Cliente(Cedula, Nombre, Apellido, Telefono, Direccion);
            return objCliente.ActualizarCliente();
        }


        public DataTable ConsultaMasivaCliente()
        {
            objCliente = new Cliente();
            return objCliente.ConsultaMasivaCliente();
        }

        public Cliente ConsultaEspecificaCliente(int Cedula)
        {
            objCliente = new Cliente();
            return objCliente.ConsultaEspecificaCliente(Cedula);

        }

        #endregion Clientes

        #region Llamadas

        public int AgregarLlamada(int Codigo, string Hora, string Direccion, int Cliente, string NombreCliente, int Movil)
        {
            objCliente = new Cliente(Cliente);
            if (objCliente.ConsultaEspecificaCliente(Cliente) != null)
            {
                Cliente = objCliente.Cedula;
            }
            objVehiculo = new Vehiculo(Movil);
            if (objVehiculo.ConsultaEspecificaVehiculo(Movil) != null)
            {
                Movil = objVehiculo.Placa;
            }
            objLlamada = new Llamada(Codigo, Hora, Direccion, objCliente.Cedula, NombreCliente, objVehiculo.Placa);
            if (objLlamada.ConsultaEspecificaLlamada(Codigo) == null)
            {
                return objLlamada.AgregarLlamada();
            }
            else
            {
                return 0;
            }
        }

        public DataTable ConsultaMasivaLlamada()
        {
            objLlamada = new Llamada();
            return objLlamada.ConsultaMasivaLlamada();
        }

        public Llamada ConsultaEspecificaLlamada(int Codigo)
        {
            objLlamada = new Llamada();
            return objLlamada.ConsultaEspecificaLlamada(Codigo);

        }

        #endregion Llamadas

        #region Tarifas

        public int AgregarTarifa(int Id_Tarifas, decimal Monto, string Lugar, string Distancia, string Extras)
        {
            objTarifa = new Tarifa(Id_Tarifas, Monto, Lugar, Distancia, Extras);
            return objTarifa.AgregarTarifa();
        }

        public int ActualizarTarifa(int Id_Tarifas, decimal Monto, string Lugar, string Distancia, string Extras)
        {
            objTarifa = new Tarifa(Id_Tarifas, Monto, Lugar, Distancia, Extras);
            return objTarifa.ActualizarTarifa();
        }

        public DataTable ConsultaMasivaTarifa()
        {
            objTarifa = new Tarifa();
            return objTarifa.ConsultaMasivaTarifa();
        }

        public Tarifa ConsultaEspecificaTarifa(int Id_Tarifas)
        {
            objTarifa = new Tarifa();
            return objTarifa.ConsultaEspecificaTarifa(Id_Tarifas);
        }



        #endregion Tarifas

        #region Vehiculos

        public int AgregarVehiculo(int Placa, int Capacidad, int Ano, string Estado, string Modelo, string Tipo, string Marca, int Taxista)
        {
            objTaxista = new Taxista(Taxista);
            if (objTaxista.ConsultaEspecificaTaxista(Taxista) != null)
            {
                Taxista = objTaxista.Identificacion;
            }

            objVehiculo = new Vehiculo(Placa, Capacidad, Ano, Estado, Modelo, Tipo, Marca, objTaxista.Identificacion);
            if (objVehiculo.ConsultaEspecificaVehiculo(Placa) == null)
            {
                return objVehiculo.AgregarVehiculo();
            }
            else
            {
                return 0;
            }

        }

        public int ActualizarVehiculo(int Placa, int Capacidad, int Ano, string Estado, string Modelo, string Tipo, string Marca, int Taxista)
        {
            objTaxista = new Taxista(Taxista);
            if (objTaxista.ConsultaEspecificaTaxista(Taxista) != null)
            {
                Taxista = objTaxista.Identificacion;
            }

            objVehiculo = new Vehiculo(Placa, Capacidad, Ano, Estado, Modelo, Tipo, Marca, objTaxista.Identificacion);
            if (objVehiculo.ConsultaEspecificaVehiculo(Placa) != null)
            {
                return objVehiculo.ActualizarVehiculo();
            }
            else
            {
                return 0;
            }

        }

        public DataTable ConsultaMasivaVehiculo()
        {
            objVehiculo = new Vehiculo();
            return objVehiculo.ConsultaMasivaVehiculo();
        }

        public Vehiculo ConsultaEspecificaVehiculo(int Placa)
        {
            objVehiculo = new Vehiculo();
            return objVehiculo.ConsultaEspecificaVehiculo(Placa);

        }

        #endregion Vehiculos

        #region Taxistas

        public int AgregarTaxista(int Identificacion, DateTime Fecha_Nacimineto, string Nombre, string Apellido, string Residencia, string Telefono, string Codigo_Taxista)
        {
            objTaxista = new Taxista(Identificacion, Fecha_Nacimineto, Nombre, Apellido, Residencia, Telefono, Codigo_Taxista);
            return objTaxista.AgregarTaxista();

        }

        public int ActualizarTaxista(int Identificacion, DateTime Fecha_Nacimineto, string Nombre, string Apellido, string Residencia, string Telefono, string Codigo_Taxista)
        {
            objTaxista = new Taxista(Identificacion, Fecha_Nacimineto, Nombre, Apellido, Residencia, Telefono, Codigo_Taxista);
            return objTaxista.ActualizarTaxista();
        }

        public DataTable ConsultaMasivaTaxista()
        {
            objTaxista = new Taxista();
            return objTaxista.ConsultaMasivaTaxista();
        }

        public Taxista ConsultaEspecificaTaxista(int Identificacion)
        {
            objTaxista = new Taxista();
            return objTaxista.ConsultaEspecificaTaxista(Identificacion);

        }

        #endregion Taxistas

        #region Factura


        public int AgregarFactura(int Numero_Factura, decimal Monto, DateTime Fecha, string Detalles, int Vehiculo, int Taxista)
        {
            objVehiculo = new Vehiculo(Vehiculo);
            if (objVehiculo.ConsultaEspecificaVehiculo(Vehiculo) != null)
            {
                Vehiculo = objVehiculo.Placa;
            }
            objTaxista = new Taxista(Taxista);
            if (objTaxista.ConsultaEspecificaTaxista(Taxista) != null)
            {
                Taxista = objTaxista.Identificacion;
            }
            objFactura = new Factura(Numero_Factura, Monto, Fecha, Detalles, objVehiculo.Placa, objTaxista.Identificacion);
            if (objFactura.ConsultaEspecificaFactura(Numero_Factura) == null)
            {
                return objFactura.AgregarFactura();
            }
            else
            {
                return 0;
            }
            
        }

        public DataTable ConsultaMasivaFactura()
        {
            objFactura = new Factura();
            return objFactura.ConsultaMasivaFactura();
        }

        public Factura ConsultaEspecificaFactura(int Numero_Factura)
        {
            objFactura = new Factura();
            return objFactura.ConsultaEspecificaFactura(Numero_Factura);

        }

        #endregion Factura


    }
}
