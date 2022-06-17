using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{
    public partial class Administrador_Edificio : Form
    {

        N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
        E_REGISTRO_ITLA objEntidad = new E_REGISTRO_ITLA();
        public Administrador_Edificio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public void LimpiarTodo() 
        {

            textNombre.Text = "";
        
        }


        private void Administrador_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            tablaEdificio.ClearSelection();

        }

        public void accionesTabla()
        {

            tablaEdificio.Columns[0].Visible = false;
            tablaEdificio.Columns[1].Visible = false;
            tablaEdificio.Columns[2].Visible = false;
            tablaEdificio.Columns[3].Visible = false;
            tablaEdificio.Columns[4].Visible = false;
            tablaEdificio.Columns[5].Visible = false;
            tablaEdificio.Columns[6].Visible = false;
            tablaEdificio.Columns[7].Visible = false;
            tablaEdificio.Columns[8].Width = 100;
            tablaEdificio.Columns[9].Visible = false;
            tablaEdificio.Columns[10].Visible = false;
            tablaEdificio.Columns[11].Visible = false;
            tablaEdificio.Columns[12].Visible = false;
            tablaEdificio.Columns[13].Visible = false;
            tablaEdificio.Columns[14].Visible = false;
            tablaEdificio.Columns[15].Visible = false;
            tablaEdificio.Columns[16].Visible = false;
            tablaEdificio.Columns[17].Visible = false;
            tablaEdificio.Columns[19].Visible = false;
            tablaEdificio.Columns[20].Visible = false;
            tablaEdificio.Columns[21].Visible = false;
            tablaEdificio.Columns[22].Visible = false;
            tablaEdificio.Columns[23].Visible = false;
            tablaEdificio.ClearSelection();
        }


        public void mostrarBuscarTabla(string buscar)
        {

            N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
            tablaEdificio.DataSource = objNegocio.ListarEdificio(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBox1.Text);

        }

        private void pictureBox_regresar_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.SetVisibleCore(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Boton_iniciar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            tablaEdificio.ClearSelection();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if(textNombre.Text != "")
            {
                try
                {
                    objEntidad.Nombre_edificio1 = textNombre.Text;

                    objNegocio.InsertandoEdificio(objEntidad);
                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaEdificio.ClearSelection();


                }

                catch (Exception ex)
                
                {
                    MessageBox.Show("No se guardar registro");
                
                }
            
            
            
            
            
            } 
            else            
            {
                MessageBox.Show("Completa los datos");        
            }
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaEdificio.SelectedRows.Count > 0)
            {
                textNombre.Text = tablaEdificio.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (tablaEdificio.SelectedRows.Count > 0)
            {
                try
                {

                    objEntidad.IdEdificio1 =  Convert.ToInt32(tablaEdificio.CurrentRow.Cells[7].Value.ToString());
                    objEntidad.Nombre_edificio1 = textNombre.Text;


                    objNegocio.ActualizandoEdificio(objEntidad);
                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaEdificio.ClearSelection();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro");

                }

            }
            else
            {

                MessageBox.Show("Seleccione la fila que desea editar");

            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (tablaEdificio.SelectedRows.Count > 0)
            {

                try
                {
                    objEntidad.IdEdificio1 = Convert.ToInt32(tablaEdificio.CurrentRow.Cells[7].Value.ToString());
                    objNegocio.EliminandoEdificio(objEntidad);

                    MessageBox.Show("Se elimino correctamente");
                    LimpiarTodo();
                    tablaEdificio.ClearSelection();
                    mostrarBuscarTabla("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el registro");

                }

            }
            else
            {

                MessageBox.Show("Selecciona la fila que desea eliminar");
            }
        }

        private void Boton_Admin_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.SetVisibleCore(false);

        }

        private void buton_Aula_Click(object sender, EventArgs e)
        {
            Administrador_Aula Aula = new Administrador_Aula();
            Aula.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Consulta_Click(object sender, EventArgs e)
        {
            Administrador_Consulta consulta = new Administrador_Consulta();
            consulta.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Visitante_Click(object sender, EventArgs e)
        {
            Administrador_Usuario usuario = new Administrador_Usuario();
            usuario.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Edificio_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBox1.Text);
        }
    }
}
