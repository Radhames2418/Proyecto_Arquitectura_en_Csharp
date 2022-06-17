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
    public partial class Administrador_Aula : Form
    {

        N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
        E_REGISTRO_ITLA objEntidad = new E_REGISTRO_ITLA();
        public Administrador_Aula()
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
            comboEdificios.Text = "";
        
        }


        private void Administrador_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            tablaAula.ClearSelection();
            comboEdificio();
            LimpiarTodo();

        }


        public void comboEdificio() 
        {

            comboEdificios.DataSource = objNegocio.ComboxEdificio();
            comboEdificios.DisplayMember = "nombre_edificio";
            comboEdificios.ValueMember = "nombre_edificio";

        }

        public void accionesTabla()
        {

            tablaAula.Columns[0].Visible = false;
            tablaAula.Columns[1].Visible = false;
            tablaAula.Columns[2].Visible = false;
            tablaAula.Columns[3].Visible = false;
            tablaAula.Columns[4].Visible = false;
            tablaAula.Columns[5].Visible = false;
            tablaAula.Columns[6].Visible = false;
            tablaAula.Columns[7].Visible = false;
            tablaAula.Columns[8].Visible = false;
            tablaAula.Columns[9].Visible = false; // id
            tablaAula.Columns[10].Width = 70;
            tablaAula.Columns[11].Visible = true;
            tablaAula.Columns[12].Visible = false;
            tablaAula.Columns[13].Visible = false;
            tablaAula.Columns[14].Visible = false;
            tablaAula.Columns[15].Visible = false;
            tablaAula.Columns[16].Visible = false;
            tablaAula.Columns[17].Visible = false;
            tablaAula.Columns[19].Visible = false;
            tablaAula.Columns[20].Visible = false;
            tablaAula.Columns[21].Visible = false;
            tablaAula.Columns[22].Visible = false;
            tablaAula.Columns[23].Visible = false;
            tablaAula.ClearSelection();
        }


        public void mostrarBuscarTabla(string buscar)
        {

            N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
            tablaAula.DataSource = objNegocio.ListarAula(buscar);
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
            tablaAula.ClearSelection();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if(textNombre.Text != "" && comboEdificios.Text != "")
            {
                try
                {
                    objEntidad.Nombre_aula1 = textNombre.Text;
                    objEntidad.Id_edificio_aula1 = comboEdificios.Text;

                    objNegocio.InsertandoAula(objEntidad);
                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaAula.ClearSelection();


                }

                catch (Exception ex)
                
                {
                    MessageBox.Show("No se guardar registro" + ex);
                
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


        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (tablaAula.SelectedRows.Count > 0)
            {
                try
                {

                    objEntidad.IdAula1 =  Convert.ToInt32(tablaAula.CurrentRow.Cells[9].Value.ToString());
                    objEntidad.Nombre_aula1 = textNombre.Text;
                    objEntidad.Id_edificio_aula1 = comboEdificios.Text;


                    objNegocio.ActualizandoAula(objEntidad);
                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaAula.ClearSelection();




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
            if (tablaAula.SelectedRows.Count > 0)
            {

                try
                {
                    objEntidad.IdAula1 = Convert.ToInt32(tablaAula.CurrentRow.Cells[9].Value.ToString());
                    objNegocio.EliminandoAula(objEntidad);

                    MessageBox.Show("Se elimino correctamente");
                    LimpiarTodo();
                    tablaAula.ClearSelection();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaAula.SelectedRows.Count > 0)
            {
                textNombre.Text = tablaAula.CurrentRow.Cells[10].Value.ToString();

                comboEdificios.Text = comboEdificios.DisplayMember = tablaAula.CurrentRow.Cells[11].Value.ToString();

            }

        }

        private void buton_Edificio_Click(object sender, EventArgs e)
        {
            Administrador_Edificio Edificio = new Administrador_Edificio();
            Edificio.Show();
            this.SetVisibleCore(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBox1.Text);
        }
    }
}
