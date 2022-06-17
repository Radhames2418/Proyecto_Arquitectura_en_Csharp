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
    public partial class Administrador : Form
    {

        N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
        E_REGISTRO_ITLA objEntidad = new E_REGISTRO_ITLA();
        public Administrador()
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
            textApellido.Text = "";
            dateTimeFN.ResetText();
            textUsuario.Text = "";
            textContrasena.Text = "";
            combo_TipoUsuario.Text = "";

        
        
        }


        private void Administrador_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
        }

        public void accionesTabla()
        {

            tablaUsuario.Columns[0].Visible = false; ///ID
            tablaUsuario.Columns[1].Width = 80;
            tablaUsuario.Columns[2].Width = 100;
            tablaUsuario.Columns[3].Width = 133;
            tablaUsuario.Columns[4].Width = 100;
            tablaUsuario.Columns[5].Width = 90;
            tablaUsuario.Columns[6].Width = 100;
            tablaUsuario.Columns[7].Visible = false;
            tablaUsuario.Columns[8].Visible = false;
            tablaUsuario.Columns[9].Visible = false;
            tablaUsuario.Columns[10].Visible = false;
            tablaUsuario.Columns[11].Visible = false;
            tablaUsuario.Columns[12].Visible = false;
            tablaUsuario.Columns[13].Visible = false;
            tablaUsuario.Columns[14].Visible = false;
            tablaUsuario.Columns[15].Visible = false;
            tablaUsuario.Columns[16].Visible = false;
            tablaUsuario.Columns[17].Visible = false;
            tablaUsuario.Columns[18].Visible = false;
            tablaUsuario.Columns[19].Visible = false;
            tablaUsuario.Columns[20].Visible = false;
            tablaUsuario.Columns[21].Visible = false;
            tablaUsuario.Columns[22].Visible = false;
            tablaUsuario.Columns[23].Visible = false;




            tablaUsuario.ClearSelection();
        }


        public void mostrarBuscarTabla(string buscar)
        {

            N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
            tablaUsuario.DataSource = objNegocio.ListarUsuario(buscar);
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
            tablaUsuario.ClearSelection();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if(textNombre.Text != "" && textApellido.Text !="" && textUsuario.Text != "" && textContrasena.Text != "" && combo_TipoUsuario.Text != "")
            {
                try
                {
                    objEntidad.Nombre_usuario1 = textNombre.Text;
                    objEntidad.Apellido_usuario1 = textApellido.Text;
                    objEntidad.Fecha_Nacimiento1 = dateTimeFN.Value;
                    objEntidad.N_Usuario1 = textUsuario.Text;
                    objEntidad.Contraseña_usuario1 = textContrasena.Text;
                    objEntidad.Tipo_de_usuario1 = combo_TipoUsuario.Text;

                    objNegocio.InsertandoUsuario(objEntidad);
                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaUsuario.ClearSelection();


                }

                catch (Exception ex)
                
                {
                    MessageBox.Show("No se guardar registro" );
                    objNegocio.CerrarConexion();

                
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
            if (tablaUsuario.SelectedRows.Count > 0)
            {
                textNombre.Text = tablaUsuario.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = tablaUsuario.CurrentRow.Cells[2].Value.ToString();
                dateTimeFN.Text = tablaUsuario.CurrentRow.Cells[3].Value.ToString();
                dateTimeFN.Value = DateTime.Parse(tablaUsuario.CurrentRow.Cells[3].Value.ToString());
                textUsuario.Text = tablaUsuario.CurrentRow.Cells[4].Value.ToString();
                textContrasena.Text = tablaUsuario.CurrentRow.Cells[5].Value.ToString();
                combo_TipoUsuario.Text = tablaUsuario.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (tablaUsuario.SelectedRows.Count > 0)
            {
                try
                {

                    objEntidad.IdUsuario1 = Convert.ToInt32(tablaUsuario.CurrentRow.Cells[0].Value.ToString());
                    objEntidad.Nombre_usuario1 = textNombre.Text;
                    objEntidad.Apellido_usuario1 = textApellido.Text;
                    objEntidad.Fecha_Nacimiento1 = dateTimeFN.Value;
                    objEntidad.N_Usuario1 = textUsuario.Text;
                    objEntidad.Contraseña_usuario1 = textContrasena.Text;
                    objEntidad.Tipo_de_usuario1 = combo_TipoUsuario.Text;


                    objNegocio.ActualizandoUsuario(objEntidad);
                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaUsuario.ClearSelection();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);

                }

            }
            else
            {

                MessageBox.Show("Seleccione la fila que desea editar");

            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (tablaUsuario.SelectedRows.Count > 0)
            {

                try
                {
                    objEntidad.IdUsuario1 = Convert.ToInt32(tablaUsuario.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminandoUsuario(objEntidad);

                    MessageBox.Show("Se elimino correctamente");
                    LimpiarTodo();
                    tablaUsuario.ClearSelection();
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

        private void buton_Edificio_Click(object sender, EventArgs e)
        {
            Administrador_Edificio Edificio = new Administrador_Edificio();
            Edificio.Show();
            this.SetVisibleCore(false);

        }

        private void Boton_Admin_Click(object sender, EventArgs e)
        {
        }

        private void buton_Aula_Click(object sender, EventArgs e)
        {
            Administrador_Aula Aula = new Administrador_Aula();
            Aula.Show();
            this.SetVisibleCore(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buton_Visitante_Click(object sender, EventArgs e)
        {
            Administrador_Usuario usuario = new Administrador_Usuario();
            usuario.Show();
            this.SetVisibleCore(false);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            textUsuario.Text = textNombre.Text+textApellido.Text+dateTimeFN.Text;
        }

        private void buton_Consulta_Click(object sender, EventArgs e)
        {
            Administrador_Consulta consulta = new Administrador_Consulta();
            consulta.Show();
            this.SetVisibleCore(false);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBox1.Text);
        }
    }
}
