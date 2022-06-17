using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
using System.Data.SqlClient;


namespace CAPA_PRESENTACION
{
    public partial class Login : Form
    {
        N_REGISTRO_ITLA objNegocio = new N_REGISTRO_ITLA();
        E_REGISTRO_ITLA objEntidad = new E_REGISTRO_ITLA();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Logic();
            

        }

        public void Logic() 
        {

            try
            {

               

                DataTable dt = new DataTable();
                objEntidad.N_Usuario1 = txtNombre.Text;
                objEntidad.Contraseña_usuario1 = textContrasena.Text;

                dt = objNegocio.LogicUsuario(objEntidad);


                if (dt.Rows.Count == 1) 
                {

                   
                    if (dt.Rows[0][1].ToString() == "ADMIN") 
                    {
                        Administrador Admin = new Administrador();
                        Admin.Show();
                        this.SetVisibleCore(false) ;

                                        
                    } 
                    else if (dt.Rows[0][1].ToString() == "USUARIO")
                    {

                        Usuario usuario = new Usuario();
                        usuario.Show();
                        this.SetVisibleCore(false);



                    }

                } 
                else
                {

                    MessageBox.Show("Usuario o contrasena incorrecta");
                
                
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void Boton_iniciar_Click(object sender, EventArgs e)
        {
            Logic();     
        }
    }
}
