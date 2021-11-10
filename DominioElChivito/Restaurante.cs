using System;
using System.Collections.Generic;
using System.Data;
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
        

        public bool agregarPedido(string comida, int cantidad, string estado, int numero_orden, int codigo, int codigo_producto, string direccion , string telefono , string cliente)
        {

            PedidoElevador pe = new PedidoElevador(cantidad, estado, numero_orden, codigo, codigo_producto, direccion, telefono, comida , cliente);
            bool resp = restaurantebd.GuardarPedido(pe);
            Pedido p = new Pedido(pe);
            pedidos.Add(p);
            return resp;
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
        public int CargarCodigo(string tipo_comida)
        {
           return restaurantebd.CargarCodigo(tipo_comida);
        }

        public DataTable CargarPedidos()
        {
            DataTable pedidos = new DataTable();
            pedidos = restaurantebd.CargarPedidos();
            return pedidos;
        }
        public DataTable CargarProductos()
        {
            DataTable productos = new DataTable();
            productos = restaurantebd.CargarProductos();
            return productos;
        }
        public List<Cliente> CargarClientes()
        {
            List<ClienteElevador> clientesElevador = restaurantebd.CargarClientes();
            List<Cliente> clientes = new List<Cliente>();
            foreach (ClienteElevador aux in clientesElevador)
            {
                Cliente cl = new Cliente(aux);
                clientes.Add(cl);
            }
            return clientes;
        }
        public List<Empleado> CargarEmpleados()
        {
            List<EmpleadoElevador> empleadoElevador = restaurantebd.CargarEmpleados();
            List<Empleado> empleados = new List<Empleado>();
            foreach (EmpleadoElevador aux in empleadoElevador)
            {
                Empleado cl = new Empleado(aux);
                empleados.Add(cl);
            }
            return empleados;
        }

        public bool ModificarEmpleado(int ci , int rol , int telefono, string nombre ,string apellido, string direccion)
        {
            EmpleadoElevador empleado = new EmpleadoElevador(rol, nombre , apellido , ci , telefono , direccion);
            return restaurantebd.ModificarEmpleado(empleado);
        }
        public bool ModificarEstadoProducto(string tipo_producto)
        {
            return restaurantebd.ModificarEstadoProducto(tipo_producto);
        }
        public bool ModificarEstadoProductoDisponible(string tipo_producto)
        {
            return restaurantebd.ModificarEstadoProductoDisponible(tipo_producto);
        }
        public bool EliminarEmpleado(int ci) 
        { 
            return restaurantebd.EliminarEmpleado(ci);
        }
        public bool PedidoTerminado(int codigo)
        {
            return restaurantebd.PedidoTerminado(codigo);
        }



        public Empleado Login(string nombre, int ci , int rol)
        {
            Empleado empleado1 = null;
            EmpleadoElevador empleado = restaurantebd.LoginBD(nombre, ci , rol);
            if (empleado != null)
            {
                empleado1 = new Empleado(empleado);
                empleadoLogeado = empleado1;
            }
            return empleado1; 
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

      
    }
}
