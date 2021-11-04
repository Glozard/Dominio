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
        public RestauranteBD()
        {
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

        public EmpleadoElevador LoginBD(string nombre, int ci , byte rol)
        {
            return empleadobd.Login(nombre, ci , rol);
            
        }

        public DataTable CargarPedidos()
        {
            return pedidobd.CargarPedidos();
        }

        public List<ClienteElevador> CargarClientes()
        {
            return clientebd.CargarClientes();
        }
    }
}
