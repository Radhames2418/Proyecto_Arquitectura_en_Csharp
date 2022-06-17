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
    public partial class Consulta : Form
    {

        N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
        E_REGISTRO_ITLA objEntidad = new E_REGISTRO_ITLA();
        MemoryStream ms1 = new MemoryStream();
        public Consulta()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void Administrador_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();



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
            tablaVisitante.Columns[13].Width = 28; // NOmbre 
            tablaVisitante.Columns[14].Width = 43 ; //Apellido
            tablaVisitante.Columns[15].Width = 50; //Carrera
            tablaVisitante.Columns[16].Width = 45; // Edificio
            tablaVisitante.Columns[17].Width = 45; //Fecha entrada
            tablaVisitante.Columns[18].Width = 85; //ID EDificio
            tablaVisitante.Columns[19].Width = 70; //Hora entradad
            tablaVisitante.Columns[20].Width = 60; //Hora salida
            tablaVisitante.Columns[21].Visible = false; //Motivos_Visita
            tablaVisitante.Columns[22].Width = 80;//Foto
            tablaVisitante.Columns[23].Width = 80;//ID Aula
            tablaVisitante.Columns[23].Width = 80; //ID Aula

            tablaVisitante.ClearSelection();
        }


        public void mostrarBuscarTabla(string buscar)
        {

            N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
            tablaVisitante.DataSource = objNegocio.ListarVisitante(buscar);
        }


        public void mostrarBuscarTabla1(string buscar)
        {

            N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
            tablaVisitante.DataSource = objNegocio.ListarVisitante1(buscar);
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

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBuscar.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            mostrarBuscarTabla1(textBox1.Text);

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buton_Visitante_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.SetVisibleCore(false);
        }
    }
}
