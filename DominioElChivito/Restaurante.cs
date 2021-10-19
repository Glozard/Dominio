using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Restaurante
    {
        List<Cliente> clientes;
        List<Empleado> empleados;
        List<Pedido> pedidos;
        public Restaurante()
        {
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            pedidos = new List<Pedido>();
        }

        public void agregarPedido(string direccion, int cantidad, int numero_orden, int codigo, int codigo_producto)
        {
            Pedido p = new Pedido(direccion, cantidad, numero_orden, codigo, codigo_producto);
            pedidos.Add(p);
        }

        public void agregarEmpleado(byte rol, string nombre, string apellido, int ci, int telefono)
        {
            Empleado e = new Empleado(rol, nombre, apellido, ci, telefono);
            empleados.Add(e);
        }

        public void agregarCliente(string direccion, string nombre, string apellido, int ci, int telefono)
        {
            Cliente c = new Cliente(direccion, nombre, apellido, ci, telefono);
            clientes.Add(c);
        }
        public string devolverRol(byte rol)
        {
            string respuesta = "";
            if (rol == 0) {
                respuesta = "Administrador";
            }

            if (rol == 1) {
                respuesta = "Recepcionista";
            }

            if (rol == 2) {
                respuesta = "Cocinero";
            }
            return respuesta;
        }
       

    }//.

}
