using System;
using System.Collections.Generic;
using System.Text;
using DominoBDD;
using Elevador;

namespace DominioElChivito
{

    public class Restaurante

    {
        RestauranteBD restaurantebd;
        List<Cliente> clientes;
        List<Empleado> empleados;
        List<Pedido> pedidos;
        Empleado empleadoLogeado;

        public Restaurante()
        {
            empleadoLogeado = new Empleado();
            restaurantebd = new RestauranteBD();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            pedidos = new List<Pedido>();

        }
        

        public bool agregarPedido(string comida, int cantidad, byte estado, int numero_orden, int codigo, int codigo_producto, string direccion , int telefono)
        {
            Pedido p = new Pedido(comida, cantidad, estado, numero_orden, codigo, codigo_producto, direccion , telefono);
            pedidos.Add(p);
            return restaurantebd.GuardarPedido(new PedidoElevador(comida, cantidad, estado, numero_orden, codigo, codigo_producto, direccion , telefono));

        }

        public bool agregarEmpleado(byte rol, string nombre, string apellido, int ci, int telefono ,string direccion)
        {
            Empleado e = new Empleado(rol, nombre, apellido, ci, telefono , direccion);
            empleados.Add(e);
            return restaurantebd.GuardarEmpleado(new EmpleadoElevador(rol, nombre, apellido, ci, telefono, direccion));
        }

        public bool agregarCliente(string direccion, string nombre, string apellido, int ci, int telefono)
        {
            Cliente c = new Cliente(direccion, nombre, apellido, ci, telefono);
            clientes.Add(c);
            return restaurantebd.GuardarCliente(new ClienteElevador(ci, nombre, apellido, direccion, telefono));
        }

        public bool Login(string nombre , int ci )
        {
            Empleado empleado = new Empleado(nombre, ci);

            bool resp = restaurantebd.Login(new  (empleado));
            if (resp)
            {
                empleadoLogeado = empleado;
                    return true;
            }
            //coso
        }

        public string devolverRol(byte rol)
        {
            string respuesta = "";
            if (rol == 0)
            {
                respuesta = "Administrador";
            }

            if (rol == 1)
            {
                respuesta = "Recepcionista";
            }

            if (rol == 2)
            {
                respuesta = "Cocinero";
            }
            return respuesta;
        }

        public List<Pedido> levantarPedido()
        {
            List<Pedido> resp = new List<Pedido>();

            foreach (Pedido aux in pedidos)
            {
                if (aux.Estado == 0)
                {
                    resp.Add(aux);
                }
            }
            return resp;
        }
      
    }
}
