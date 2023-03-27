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

namespace Vista
{
    public partial class frmNuevaOrden : Form
    {
        IAccionesBD con = new AccesoBDSql();
        Cliente cli = new Cliente();
        
        public frmNuevaOrden()
        {
            cli.Abrir();
            InitializeComponent();
        }

        public void limpiar()
        {
            txtClient.Clear();
            dtpFecha.ResetText();
            txtDescripcion.Clear();
        }

        public void igualarCampos()
        {
         
            cli.IdCliente = int.Parse(txtid.Text);
            cli.NomCliente = txtClient.Text;
            cli.Fecha = DateTime.Parse(dtpFecha.Value.ToString("yyyy-MM-dd"));
            cli.DescServicio = txtDescripcion.Text;
            cli.Estado = cmbEstado.Text;
        }
            
        private void btnCrear_Click(object sender, EventArgs e)
        {
          
            frmMenuOrdenes frmPrincipal = new frmMenuOrdenes();

            cli.Abrir();
            igualarCampos();
            if (cli.Agregar())
            {
                MessageBox.Show("El Registro ah sido exitoso");
            }
            else
            {
                MessageBox.Show("El Registro ah fallado");
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
