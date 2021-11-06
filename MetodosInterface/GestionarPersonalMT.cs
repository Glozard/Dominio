using System;
using Interface;
using DominioElChivito;

namespace MetodosInterface
{
    public class GestionarPersonalMT
    {
        GestionarPersonal gestionarPersonal;
        Restaurante restaurante;

        public GestionarPersonalMT(GestionarPersonal gestionarPersonal , Restaurante restaurante)
        {
            this.restaurante = restaurante;
            this.gestionarPersonal = gestionarPersonal;
        }
        public void cargarListaEmpleados()
        {
            foreach (Empleado aux in restaurante.CargarEmpleados())
            {
                string rol = " ";
                int indice = gestionarPersonal.dataEmpleados.Rows.Add();
                if (aux.Rol == 0) rol = "Administrador";
                if (aux.Rol == 1) rol = "Recepcionista";
                if (aux.Rol == 2) rol = "Cocinero";
                gestionarPersonal.dataEmpleados.Rows[indice].Cells[0].Value = aux.Ci;
                gestionarPersonal.dataEmpleados.Rows[indice].Cells[1].Value = rol;
                gestionarPersonal.dataEmpleados.Rows[indice].Cells[2].Value = aux.telefono;
                gestionarPersonal.dataEmpleados.Rows[indice].Cells[3].Value = aux.Nombre;
                gestionarPersonal.dataEmpleados.Rows[indice].Cells[4].Value = aux.Apellido;
                gestionarPersonal.dataEmpleados.Rows[indice].Cells[5].Value = aux.Direccion;
            }
        }
    }
}
