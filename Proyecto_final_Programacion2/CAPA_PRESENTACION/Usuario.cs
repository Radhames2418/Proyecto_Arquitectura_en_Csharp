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
using System.IO;

namespace CAPA_PRESENTACION
{
    public partial class Usuario : Form
    {

        N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
        E_REGISTRO_ITLA objEntidad = new E_REGISTRO_ITLA();
        MemoryStream ms1 = new MemoryStream();
        public Usuario()
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
            textCarrera.Text = "";
            textMotivos.Text = "";
            maskeCorreo.Text = "";

            pictureBox_Foto.Image = Image.FromStream(ms1);




        }


        private void Administrador_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            comboEdificio();
            comboAula();
            pictureBox_Foto.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);


        }

        public void accionesTabla()
        {

            tablaVisitante.Columns[0].Visible = false;
            tablaVisitante.Columns[1].Visible = false;
            tablaVisitante.Columns[2].Visible = false;
            tablaVisitante.Columns[3].Visible = false;
            tablaVisitante.Columns[4].Visible = false;
            tablaVisitante.Columns[5].Visible = false;
            tablaVisitante.Columns[6].Visible = false;
            tablaVisitante.Columns[7].Visible = false;
            tablaVisitante.Columns[8].Visible = false;
            tablaVisitante.Columns[9].Visible = false;
            tablaVisitante.Columns[10].Visible = false;
            tablaVisitante.Columns[11].Visible = false;
            tablaVisitante.Columns[12].Visible = false; //  ID 
            tablaVisitante.Columns[13].Width = 80; // Codigo 
            tablaVisitante.Columns[14].Width = 80; //Nombre
            tablaVisitante.Columns[15].Width = 80; //Apellido
            tablaVisitante.Columns[16].Visible = false; // Carrera
            tablaVisitante.Columns[17].Visible = false; //Correo
            tablaVisitante.Columns[18].Visible = false; //ID EDificio
            tablaVisitante.Columns[19].Visible = false; //Hora entradad
            tablaVisitante.Columns[20].Visible = false; //Hora salida
            tablaVisitante.Columns[21].Visible = false; //Motivos_Visita
            tablaVisitante.Columns[22].Visible = false; //Foto
            tablaVisitante.Columns[23].Visible = false; //ID Aula
            tablaVisitante.Columns[23].Visible = false; //ID Aula




            tablaVisitante.ClearSelection();
        }


        public void mostrarBuscarTabla(string buscar)
        {

            N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
            tablaVisitante.DataSource = objNegocio.ListarVisitante(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBuscar.Text);

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
            tablaVisitante.ClearSelection();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

           

            if(textNombre.Text != "" && textApellido.Text != "" && comboxEdificio.Text != "" && comboxAula.Text != "" && maskeCorreo.Text != "" && textMotivos.Text != "")
            {
                try
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBox_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    objEntidad.NombreVisitante1 = textNombre.Text;
                    objEntidad.ApellidoVisitante1 = textApellido.Text;
                    objEntidad.CarreraVisitante1 = textCarrera.Text;
                    objEntidad.CorreoVisitante1 = maskeCorreo.Text;
                    objEntidad.ID_Edificio_Visitante1 = comboxEdificio.Text;
                    objEntidad.Hora_entradaVisitante1 = dateTimeEntrada.Value;
                    objEntidad.Hora_salidaVisitante1 = dateTimeSalida.Value;
                    objEntidad.Motivos_visita1 = textMotivos.Text;
                    objEntidad.Foto_Visitante1 = ms.GetBuffer();
                    objEntidad.ID_Aula_Visitante1 = comboxAula.Text;


                    objNegocio.InsertandoVisitante(objEntidad);
                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaVisitante.ClearSelection();


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

        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaVisitante.SelectedRows.Count > 0)
            {
                textNombre.Text = tablaVisitante.CurrentRow.Cells[14].Value.ToString();
                 textApellido.Text = tablaVisitante.CurrentRow.Cells[15].Value.ToString();
                 textCarrera.Text = tablaVisitante.CurrentRow.Cells[16].Value.ToString();
                 comboxEdificio.Text = tablaVisitante.CurrentRow.Cells[17].Value.ToString();
                 dateTimeEntrada.Text = tablaVisitante.CurrentRow.Cells[18].Value.ToString();
                 dateTimeSalida.Text = tablaVisitante.CurrentRow.Cells[19].Value.ToString();
                 textMotivos.Text = tablaVisitante.CurrentRow.Cells[20].Value.ToString();
                 maskeCorreo.Text = tablaVisitante.CurrentRow.Cells[23].Value.ToString();



                MemoryStream ms = new MemoryStream(objNegocio.BuscarFotos(Convert.ToInt32(tablaVisitante.CurrentRow.Cells[12].Value.ToString())));
                pictureBox_Foto.Image = Image.FromStream(ms);
                


            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (tablaVisitante.SelectedRows.Count > 0)
            {
                try
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBox_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    objEntidad.IdVisitante1 = Convert.ToInt32(tablaVisitante.CurrentRow.Cells[12].Value.ToString());
                    objEntidad.NombreVisitante1 = textNombre.Text;
                    objEntidad.ApellidoVisitante1 = textApellido.Text;
                    objEntidad.CarreraVisitante1 = textCarrera.Text;
                    objEntidad.CorreoVisitante1 = maskeCorreo.Text;
                    objEntidad.ID_Edificio_Visitante1 = comboxEdificio.Text;
                    objEntidad.Hora_entradaVisitante1 = dateTimeEntrada.Value;
                    objEntidad.Hora_salidaVisitante1 = dateTimeSalida.Value;
                    objEntidad.Motivos_visita1 = textMotivos.Text;
                    objEntidad.Foto_Visitante1 = ms.GetBuffer();
                    objEntidad.ID_Aula_Visitante1 = comboxAula.Text;


                    objNegocio.ActualizandoVisitante(objEntidad);
                    MessageBox.Show("Se edito el registro");
                    mostrarBuscarTabla("");
                    LimpiarTodo();
                    tablaVisitante.ClearSelection();




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
            if (tablaVisitante.SelectedRows.Count > 0)
            {

                try
                {
                    objEntidad.IdVisitante1 = Convert.ToInt32(tablaVisitante.CurrentRow.Cells[12].Value.ToString());
                    objNegocio.EliminandVisitante(objEntidad);

                    MessageBox.Show("Se elimino correctamente");
                    LimpiarTodo();
                    tablaVisitante.ClearSelection();
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

        private void buton_Aula_Click(object sender, EventArgs e)
        {
            Administrador_Aula Aula = new Administrador_Aula();
            Aula.Show();
            this.SetVisibleCore(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buton_Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK) 
            {
                pictureBox_Foto.Image = Image.FromFile(fo.FileName);

            }


        }

        public void comboEdificio()
        {

            comboxEdificio.DataSource = objNegocio.ComboxEdificio();
            comboxEdificio.DisplayMember = "nombre_edificio";
            comboxEdificio.ValueMember = "nombre_edificio";

        }

        public void comboAula()
        {

            objEntidad.Id_edificio_aula1 = comboxEdificio.Text;

            comboxAula.DataSource = objNegocio.ComboxAula(objEntidad);
            comboxAula.DisplayMember = "nombre_aula";
            comboxAula.ValueMember = "nombre_aula";

        }

        private void comboxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboAula();
        }

        private void lblNombre1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Foto_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Admin_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Edificio_Click_1(object sender, EventArgs e)
        {
            Administrador_Edificio edificio = new Administrador_Edificio();
            edificio.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Aula_Click_1(object sender, EventArgs e)
        {
            Administrador_Aula aula = new Administrador_Aula();
            aula.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Consulta_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
            this.SetVisibleCore(false);
        }

        private void buton_Visitante_Click(object sender, EventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBuscar.Text);
        }
    }
}
