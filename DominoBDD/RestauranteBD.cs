using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Elevador;
namespace DominoBDD
{
    public class RestauranteBD
    {

        PedidoBD pedidobd;
        ClienteBD clientebd;
        EmpleadoBD empleadobd;
        ProductoBD productobd;
        public RestauranteBD()
        {
            productobd = new ProductoBD();
            empleadobd = new EmpleadoBD();
            clientebd = new ClienteBD();
            pedidobd = new PedidoBD();
        }

        public bool GuardarPedido(PedidoElevador e)
        {
            return pedidobd.GuardarPedido(e);
        }

        public bool GuardarCliente(ClienteElevador c)
        {
            return clientebd.GuardarCliente(c);
        }

        public bool GuardarEmpleado(EmpleadoElevador e)
        {
            return empleadobd.GuardarEmpleado(e);
        }

        public EmpleadoElevador LoginBD(string nombre, int ci, int rol)
        {
            return empleadobd.Login(nombre, ci, rol);
        }

        public DataTable CargarPedidos()
        {
            return pedidobd.CargarPedidos();
        }

        public List<ClienteElevador> CargarClientes()
        {
            return clientebd.CargarClientes();
        }
        public List<EmpleadoElevador> CargarEmpleados()
        {
            return empleadobd.CargarEmpleado();
        }
        public bool ModificarEmpleado(EmpleadoElevador e)
        {
            return empleadobd.ModificarEmpleado(e);
        }
        public bool EliminarEmpleado(int ci)
        {
            return empleadobd.EliminarEmpleado(ci);
        }
        public bool PedidoTerminado(int codigo)
        {
            return pedidobd.PedidoTerminado(codigo);
        }
        public DataTable CargarProductos() 
        {
            return productobd.CargarProductos();
        }
        public int CargarCodigo(string tipo_comida)
        {
           return productobd.CargarCodigo(tipo_comida);
           
        }
        public bool ModificarEstadoProducto(string tipo_comida)
        {
            return productobd.ModificarEstadoProducto(tipo_comida);
        }
        public bool ModificarEstadoProductoDisponible(string tipo_comida)
        {
            return productobd.ModificarEstadoProductoDisponible(tipo_comida);
        }



    }
}
