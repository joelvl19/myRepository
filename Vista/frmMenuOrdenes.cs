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
using System.Net.Http;
using Newtonsoft.Json.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Vista
{
    public partial class frmMenuOrdenes : Form
    {
        Cliente cli = new Cliente();
        List<Cliente> lisCliente = new List<Cliente>();

        public frmMenuOrdenes()
        {
            cli.Abrir();
            InitializeComponent();
            cargarDatosGrid();
            desabilitarCampos();

        }
        public void desabilitarCampos()
        {
            txtClient.Enabled = false;
            txtDescri.Enabled = false;
            cmbEstado.Enabled = false;
            dtpFecha.Enabled = false;
        }

        public void igualarCampos()
        {

            cli.IdCliente = int.Parse(txtidclient.Text);
            cli.NomCliente = txtClient.Text;
            cli.Fecha = Convert.ToDateTime(dtpFecha.Value.ToString("yyyy-MM-dd"));
            cli.DescServicio = txtDescri.Text;
            cli.Estado = cmbEstado.Text;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            frmNuevaOrden VentanaOrden = new frmNuevaOrden();
            this.Hide();
            VentanaOrden.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
            this.Hide();

            // Obtiene la fila seleccionada
            DataGridViewRow filaSeleccionada = dgvClien.CurrentRow;
            if (filaSeleccionada != null)
            {
                // Crea un objeto de la clase que representa los datos
                Cliente clienteSeleccionado = new Cliente();

                // Rellena el objeto con los datos de la fila seleccionada
                clienteSeleccionado.IdCliente = Convert.ToInt32(filaSeleccionada.Cells["ColID"].Value);
                clienteSeleccionado.NomCliente = Convert.ToString(filaSeleccionada.Cells["ColNombre"].Value);
                clienteSeleccionado.Fecha = Convert.ToDateTime(filaSeleccionada.Cells["ColFecha"].Value);
                clienteSeleccionado.DescServicio = Convert.ToString(filaSeleccionada.Cells["ColDescripcion"].Value);
                clienteSeleccionado.Estado = Convert.ToString(filaSeleccionada.Cells["ColEstado"].Value);

                // Crea una instancia del formulario donde deseas mostrar los datos y pásale el objeto como parámetro
                frmModificarOrdenes VentanaModificar = new frmModificarOrdenes(clienteSeleccionado);
                VentanaModificar.ShowDialog();

            }
        }

        public void cargarDatosEnTexbox(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < lisCliente.Count; i++)
                {
                    if (Convert.ToInt64(dgvClien.CurrentRow.Cells["ColID"].Value) == lisCliente[i].IdCliente)
                    {
                        txtidclient.Text = dgvClien[0, e.RowIndex].Value.ToString();
                        txtClient.Text = dgvClien[1, e.RowIndex].Value.ToString();
                        dtpFecha.Text = dgvClien[2, e.RowIndex].Value.ToString();
                        cmbEstado.Text = dgvClien[3, e.RowIndex].Value.ToString();
                        txtDescri.Text = dgvClien[4, e.RowIndex].Value.ToString();
                    }
                }
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show("Dale Click En Aceptar" + nrex);
            }
        }
        public void cargarDatosGrid()
        {
            DataTable datat = new DataTable();
            datat.Columns.Add("ColID");
            datat.Columns.Add("ColNombre");
            datat.Columns.Add("ColFecha");
            datat.Columns.Add("ColEstado");
            datat.Columns.Add("ColDescripcion");



            lisCliente = cli.listaCliente();
            for (int i = 0; i < lisCliente.Count; i++)
            {
                DataRow DR = datat.NewRow();
                DR["ColID"] = lisCliente[i].IdCliente;
                DR["ColNombre"] = lisCliente[i].NomCliente;
                DR["ColFecha"] = lisCliente[i].Fecha;
                DR["ColEstado"] = lisCliente[i].Estado;
                DR["ColDescripcion"] = lisCliente[i].DescServicio;

                txtidclient.Text = lisCliente[i].IdCliente.ToString();
                datat.Rows.Add(DR);
            }
            dgvClien.DataSource = datat;
            int.Parse(txtidclient.Text = lisCliente[0].IdCliente.ToString());



        }

        private void frmMenuOrdenes_Load(object sender, EventArgs e)
        {
            cargarDatosGrid();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            cli.Abrir();
            if (int.Parse(txtidclient.Text) > 0)
            {


                for (int i = 0; i < dgvClien.Rows.Count; i++)
                {
                    if (int.Parse(txtidclient.Text) == int.Parse(dgvClien[0, i].Value.ToString()))
                    {
                        if (MessageBox.Show("Esta seguro que quiere eliminar a " + lisCliente[i].NomCliente + " " + lisCliente[i].Fecha + " ", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            igualarCampos();
                            cli.Eliminar();
                            dgvClien.Rows.RemoveAt(i);
                            cargarDatosGrid();

                        }
                    }
                }
            }
        }

        private void dgvClien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            try
            {
                for (int i = 0; i < lisCliente.Count; i++)
                {
                    if (Convert.ToInt64(dgvClien.CurrentRow.Cells["ColID"].Value) == lisCliente[i].IdCliente)
                    {
                        txtidclient.Text = dgvClien[0, e.RowIndex].Value.ToString();
                        txtClient.Text = dgvClien[1, e.RowIndex].Value.ToString();
                        dtpFecha.Text = dgvClien[2, e.RowIndex].Value.ToString();
                        cmbEstado.Text = dgvClien[3, e.RowIndex].Value.ToString();
                        txtDescri.Text = dgvClien[4, e.RowIndex].Value.ToString();
                    }
                }
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show("Dale Click En Aceptar" + nrex);
            }
        }

        private void btnEnviarOrdenes_Click(object sender, EventArgs e)
        {
            // Crear un objeto Document
            Document doc = new Document();

            // Especificar la ruta del archivo PDF de salida
            string outputFile = "C:/Users/EmyBreak/Desktop/guardarDatos/mipdf.pdf";

            // Crear un objeto PdfWriter para escribir en el archivo PDF de salida
            PdfWriter.GetInstance(doc, new FileStream(outputFile, FileMode.Create));

            // Abrir el objeto Document
            doc.Open();

            // Crear un objeto PdfPTable para almacenar los datos del DataGridView
            PdfPTable table = new PdfPTable(dgvClien.Columns.Count);

            // Agregar las columnas del DataGridView a la tabla
            foreach (DataGridViewColumn column in dgvClien.Columns)
            {
                table.AddCell(column.HeaderText);
            }

            // Agregar las filas del DataGridView a la tabla
            foreach (DataGridViewRow row in dgvClien.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value.ToString());
                }
            }

            // Agregar la tabla al objeto Document
            doc.Add(table);

            // Cerrar el objeto Document
            doc.Close();

            MessageBox.Show("Los datos se han exportado correctamente a un archivo PDF.");

            // Crear una solicitud HTTP POST
            string url = "https://ordenes.mssql.somee.com";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            try
            {
                // Convertir el objeto JSON a una cadena
                string json = JsonConvert.SerializeObject(cli.listaCliente());

                // Escribir la cadena JSON en la solicitud HTTP POST
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }

                // Obtener la respuesta de la solicitud HTTP POST
                string responseString;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        responseString = streamReader.ReadToEnd();
                    }
                }

                MessageBox.Show("Los datos se han enviado correctamente al servidor.");
            }
            catch (WebException ex)
            {
                MessageBox.Show("Ha ocurrido un error al enviar los datos: " + ex.Message);
            }
        }

        private void btnInform_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PARA QUE LOS BOTONES DE ELIMINAR Y MODIFICAR SE ACTIVEN ES NECESARIO DAR DOBLE CLIC EN EL DATAGRIDVIEW Y TAMBIEN CON DOBLE CLIC SELECCIONAS EL REGISTRO A ELIMINAR O MODIFICAR ");
        }

        private void dgvClien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }   
}
