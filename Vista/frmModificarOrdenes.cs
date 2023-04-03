using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmModificarOrdenes : Form
    {
        IAccionesBD con = new AccesoBDSql();
        Cliente cli = new Cliente();
        List<Cliente> ListaCliente = new List<Cliente>();
        private Cliente clienteSelec;

        public frmModificarOrdenes(Cliente clienteSeleccionado)
        {
            InitializeComponent();

            // Asigna el objeto al campo privado
            clienteSelec = clienteSeleccionado;

            // Asigna los valores del objeto a los TextBox
            txtid.Text = clienteSelec.IdCliente.ToString();
            txtClient.Text = clienteSelec.NomCliente;
            dtpFecha.Value = clienteSelec.Fecha;
            txtDescripcion.Text = clienteSelec.DescServicio;
            cmbEstado.SelectedItem = clienteSelec.Estado;

        }

        public void igualarCampos()
        {

            cli.IdCliente = int.Parse(txtid.Text);
            cli.NomCliente = txtClient.Text;
            cli.Fecha = DateTime.Parse(dtpFecha.Value.ToString("yyyy-MM-dd"));
            cli.DescServicio = txtDescripcion.Text;
            cli.Estado = cmbEstado.Text;
        }

        public void cargarDatos()
        {
            con.Abrir();
            SqlDataReader dataRead = con.Consultar("SELECT * FROM cliente");
            ListaCliente.Clear();
            if (dataRead.HasRows)
            {
                while (dataRead.Read())
                {
                    txtid.Text = dataRead.GetInt32(0).ToString();
                    txtClient.Text = dataRead.GetString(1);
                    dtpFecha.Value = dataRead.GetDateTime(2);
                    txtDescripcion.Text = dataRead.GetString(3);
                    cmbEstado.SelectedItem = dataRead.GetString(4);

                    Cliente cli = new Cliente();
                    cli.IdCliente = dataRead.GetInt32(0);
                    cli.NomCliente = dataRead.GetString(1);
                    cli.Fecha = dataRead.GetDateTime(2);
                    cli.DescServicio = dataRead.GetString(3);
                    cli.Estado = dataRead.GetString(4);

                    ListaCliente.Add(cli);
                }
            }

            con.Cerrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmMenuOrdenes frmPrincipal = new frmMenuOrdenes();

            cli.Abrir();
            igualarCampos();
            if (cli.Modificar())
            {
                MessageBox.Show("El Registro ah sido modificado con exitoso");
            }
            else
            {
                MessageBox.Show("La modificacion ah fallado");
            }
            this.Hide();
            frmPrincipal.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuOrdenes frmPrincipal = new frmMenuOrdenes();
            this.Hide();
            frmPrincipal.ShowDialog();
        }
    }
}
