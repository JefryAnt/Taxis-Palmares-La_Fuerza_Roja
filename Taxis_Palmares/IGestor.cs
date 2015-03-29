using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Taxis_Palmares
{
    public interface IGestor
    {

        #region Operaciones Usuario

        int AgregarUsuario(string idUsuario, string password, int idTipoUsuario);
        int ActualizarUsuario(string idUsuario, string password, int idTipoUsuario);
        DataTable ConsultaMasivaUsuario();
        Usuario ConsultaEspecificaUsuario(string idUsuario);

        #endregion Operaciones Usuario

        #region Operaciones Cliente

        int AgregarCliente(int Cedula, string Nombre, string Apellido, string Telefono, string Direccion);
        int ActualizarCliente(int Cedula, string Nombre, string Apellido, string Telefono, string Direccion);
        DataTable ConsultaMasivaCliente();
        Cliente ConsultaEspecificaCliente(int Cedula);

        #endregion Operaciones Cliente

        #region Operaciones Llamadas

        int AgregarLlamada(int Codigo, string Hora, string Direccion, int Cliente, string NombreCliente, int Movil);
        DataTable ConsultaMasivaLlamada();
        Llamada ConsultaEspecificaLlamada(int Codigo);

        #endregion Operaciones Llamadas

        #region Operaciones Tarifas

        int AgregarTarifa(int Id_Tarifas, decimal Monto, string Lugar, string Distancia, string Extras);
        int ActualizarTarifa(int Id_Tarifas, decimal Monto, string Lugar, string Distancia, string Extras);
        DataTable ConsultaMasivaTarifa();
        Tarifa ConsultaEspecificaTarifa(int Id_Tarifas);

        #endregion Operaciones Tarifas

        #region Operaciones Vehiculos

        int AgregarVehiculo(int Placa, int Capacidad, int Ano, string Estado, string Modelo, string Tipo, string Marca, int Taxista);
        int ActualizarVehiculo(int Placa, int Capacidad, int Ano, string Estado, string Modelo, string Tipo, string Marca, int Taxista);
        DataTable ConsultaMasivaVehiculo();
        Vehiculo ConsultaEspecificaVehiculo(int Placa);

        #endregion Operaciones Vehiculos

        #region Operaciones Taxistas

        int AgregarTaxista(int Identificacion, DateTime Edad, string Nombre, string Apellido, string Residencia, string Telefono, string Codigo_Taxista);
        int ActualizarTaxista(int Identificacion, DateTime Edad, string Nombre, string Apellido, string Residencia, string Telefono, string Codigo_Taxista);
        DataTable ConsultaMasivaTaxista();
        Taxista ConsultaEspecificaTaxista(int Identificacion);

        #endregion Operaciones Taxistas

        #region Operaciones Factura

        int AgregarFactura(int Numero_Factura, decimal Monto, DateTime Fecha, string Detalles, int Vehiculo, int Taxista);
        DataTable ConsultaMasivaFactura();
        Factura ConsultaEspecificaFactura(int Numero_Factura);

        #endregion Operaciones Factura


    }
}
