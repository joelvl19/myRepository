using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;


namespace Controlador
{
    public class Cliente
    {
        IAccionesBD con = new AccesoBDSql();
        List<Cliente> ListClientes = new List<Cliente>();

        public bool Abrir()
        {
            bool abrir = con.AccessDBSql("EMYBREAK-PC\\SQLEXPRESS;database=ordenes;integrated security = true");
            return abrir;
        }


        private int idCliente;
        private string nomCliente;
        private DateTime fecha;
        private string descServicio;
        private string estado;

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public string NomCliente
        {
            get
            {
                return nomCliente;
            }

            set
            {
                nomCliente = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string DescServicio
        {
            get
            {
                return descServicio;
            }

            set
            {
                descServicio = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public bool Agregar()
        {
            return con.Agregar("cliente", "nombre,fecha,descripcion,estado", "'" +  NomCliente + "','" + Fecha + "','" + DescServicio + "','" + Estado + "'");
        }

        public bool Modificar()
        {
            return con.Modificar("cliente", "nombre " + NomCliente + "fecha " + Fecha + ",descripcion " + DescServicio + ",estado " + Estado + "'", "id= " + idCliente + "'");
        }

        public bool Eliminar()
        {
            return con.Eliminar("cliente", "id=", IdCliente + ";");
        }

        public List<Cliente> listaCliente()
        {
            SqlDataReader dataRead = con.Consultar("cliente");
            ListClientes.Clear();
            if (dataRead.HasRows)
            {
                while (dataRead.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IdCliente = int.Parse(dataRead[0].ToString());
                    cli.NomCliente = dataRead[1].ToString();
                    cli.Fecha = Convert.ToDateTime(dataRead[2].ToString());
                    cli.DescServicio = dataRead[3].ToString();
                    cli.estado = dataRead[4].ToString();

                    ListClientes.Add(cli);
                }
            }
            con.Cerrar();
            return ListClientes;
        }


    }
}
