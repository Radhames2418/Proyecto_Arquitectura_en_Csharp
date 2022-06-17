using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CAPA_ENTIDAD;
using System.Data;




namespace CAPA_DATOS
{
    public class D_REGISTRO_ITLA
    {

        SqlConnection conexion = new SqlConnection("server=RADHAMES ; database=Registro_itla1  ; integrated security = true");

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Metodos de la tabla usuario

       
        public List<E_REGISTRO_ITLA> ListarUsuario(string buscar)
        {

            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LeerFilas = cmd.ExecuteReader();


            List<E_REGISTRO_ITLA> Listar = new List<E_REGISTRO_ITLA>();
            while (LeerFilas.Read())
            {

                Listar.Add(new E_REGISTRO_ITLA

                {
                    IdUsuario1 = LeerFilas.GetInt32(0),
                    Nombre_usuario1 = LeerFilas.GetString(1),
                    Apellido_usuario1 = LeerFilas.GetString(2),
                    Fecha_Nacimiento1 = LeerFilas.GetDateTime(3),
                    N_Usuario1 = LeerFilas.GetString(4),
                    Contraseña_usuario1 = LeerFilas.GetString(5),
                    Tipo_de_usuario1 = LeerFilas.GetString(6),
                }); ;

            }

            conexion.Close();
            LeerFilas.Close();


            return Listar;

        }

        public void InsertarUsuario(E_REGISTRO_ITLA Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@nombre_usuario", Usuario.Nombre_usuario1);
            cmd.Parameters.AddWithValue("@Apellido_usuario", Usuario.Apellido_usuario1);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", Usuario.Fecha_Nacimiento1);
            cmd.Parameters.AddWithValue("@N_Usuario", Usuario.N_Usuario1);
            cmd.Parameters.AddWithValue("@Contraseña_usuario", Usuario.Contraseña_usuario1);
            cmd.Parameters.AddWithValue("@Tipo_de_usuario", Usuario.Tipo_de_usuario1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarUsuario(E_REGISTRO_ITLA Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Usuario.IdUsuario1);
            cmd.Parameters.AddWithValue("@nombre_usuario", Usuario.Nombre_usuario1);
            cmd.Parameters.AddWithValue("@Apellido_usuario", Usuario.Apellido_usuario1);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", Usuario.Fecha_Nacimiento1);
            cmd.Parameters.AddWithValue("@N_Usuario", Usuario.N_Usuario1);
            cmd.Parameters.AddWithValue("@Contraseña_usuario", Usuario.Contraseña_usuario1);
            cmd.Parameters.AddWithValue("@Tipo_de_usuario", Usuario.Tipo_de_usuario1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        

        public void EliminarUsuario(E_REGISTRO_ITLA Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Usuario.IdUsuario1);
            cmd.ExecuteNonQuery();

            conexion.Close();

        }


        public DataTable LogicUsuario(E_REGISTRO_ITLA Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_LogicUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@N_Usuario", Usuario.N_Usuario1);
            cmd.Parameters.AddWithValue("@Contraseña_usuario", Usuario.Contraseña_usuario1);
            cmd.ExecuteNonQuery();

            conexion.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

           
            

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Metodos de la tabla Edificio

        public List<E_REGISTRO_ITLA> ListarEdificio(string buscar)
        {

            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LeerFilas = cmd.ExecuteReader();


            List<E_REGISTRO_ITLA> Listar = new List<E_REGISTRO_ITLA>();
            while (LeerFilas.Read())
            {

                Listar.Add(new E_REGISTRO_ITLA

                {
                    IdEdificio1 = LeerFilas.GetInt32(0),
                    Nombre_edificio1 = LeerFilas.GetString(1),

                }); ;

            }

            conexion.Close();
            LeerFilas.Close();


            return Listar;

        }

        public void InsertarEdificio(E_REGISTRO_ITLA Edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@nombre_edificio", Edificio.Nombre_edificio1);
            cmd.ExecuteNonQuery();
            conexion.Close();


        }

        public void ActualizarEdificio(E_REGISTRO_ITLA Edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Id", Edificio.IdEdificio1);
            cmd.Parameters.AddWithValue("@nombre_edificio", Edificio.Nombre_edificio1);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEdificio(E_REGISTRO_ITLA Edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Edificio.IdEdificio1);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Metodos de la tabla Aula


        public List<E_REGISTRO_ITLA> ListarAula(string buscar)
        {

            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LeerFilas = cmd.ExecuteReader();


            List<E_REGISTRO_ITLA> Listar = new List<E_REGISTRO_ITLA>();
            while (LeerFilas.Read())
            {

                Listar.Add(new E_REGISTRO_ITLA

                {
                    IdAula1 = LeerFilas.GetInt32(0),
                    Nombre_aula1 = LeerFilas.GetString(1),
                    Id_edificio_aula1 = LeerFilas.GetString(2)

                }); ;

            }

            conexion.Close();
            LeerFilas.Close();


            return Listar;

        }

        public void InsertarAula(E_REGISTRO_ITLA Aula)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@nombre_aula", Aula.Nombre_aula1);
            cmd.Parameters.AddWithValue("@ID_edificio_aula", Aula.Id_edificio_aula1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarAula(E_REGISTRO_ITLA Aula)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Aula.IdAula1);
            cmd.Parameters.AddWithValue("@nombre_aula", Aula.Nombre_aula1);
            cmd.Parameters.AddWithValue("@ID_edificio_aula", Aula.Id_edificio_aula1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarAula(E_REGISTRO_ITLA Aula)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Aula.IdAula1);
            cmd.ExecuteNonQuery();

            conexion.Close();

        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Metodos de la tabla Aula


        public List<E_REGISTRO_ITLA> ListarVisitante(string buscar)
        {

            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LeerFilas = cmd.ExecuteReader();


            List<E_REGISTRO_ITLA> Listar = new List<E_REGISTRO_ITLA>();
            while (LeerFilas.Read())
            {

                Listar.Add(new E_REGISTRO_ITLA

                {
                    IdVisitante1 = LeerFilas.GetInt32(0),
                    CodigoVisitante1 = LeerFilas.GetString(1),
                    NombreVisitante1 = LeerFilas.GetString(2),
                    ApellidoVisitante1 = LeerFilas.GetString(3),
                    CarreraVisitante1 = LeerFilas.GetString(4),
                    CorreoVisitante1 = LeerFilas.GetString(5),
                    ID_Edificio_Visitante1 = LeerFilas.GetString(6),
                    Hora_entradaVisitante1 = LeerFilas.GetDateTime(7),
                    Hora_salidaVisitante1 = LeerFilas.GetDateTime(8),
                    Motivos_visita1 = LeerFilas.GetString(9),
                    ID_Aula_Visitante1 = LeerFilas.GetString(11)



                }) ; ;

            }

            conexion.Close();
            LeerFilas.Close();


            return Listar;

        }

        public void InsertarVisitante(E_REGISTRO_ITLA Visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Visitante.NombreVisitante1);
            cmd.Parameters.AddWithValue("@Apellido", Visitante.ApellidoVisitante1);
            cmd.Parameters.AddWithValue("@Carrera", Visitante.CarreraVisitante1);
            cmd.Parameters.AddWithValue("@Correo", Visitante.CorreoVisitante1);
            cmd.Parameters.AddWithValue("@ID_Edificio", Visitante.ID_Edificio_Visitante1);
            cmd.Parameters.AddWithValue("@Hora_entrada", Visitante.Hora_entradaVisitante1);
            cmd.Parameters.AddWithValue("@Hora_salida", Visitante.Hora_salidaVisitante1);
            cmd.Parameters.AddWithValue("@Motivos_visita", Visitante.Motivos_visita1);
            cmd.Parameters.AddWithValue("@Foto_visitante", Visitante.Foto_Visitante1);
            cmd.Parameters.AddWithValue("@ID_Aula", Visitante.ID_Aula_Visitante1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarVisitante(E_REGISTRO_ITLA Visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarVisitant", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Visitante.IdVisitante1);
            cmd.Parameters.AddWithValue("@Nombre", Visitante.NombreVisitante1);
            cmd.Parameters.AddWithValue("@Apellido", Visitante.ApellidoVisitante1);
            cmd.Parameters.AddWithValue("@Carrera", Visitante.CarreraVisitante1);
            cmd.Parameters.AddWithValue("@Correo", Visitante.CorreoVisitante1);
            cmd.Parameters.AddWithValue("@ID_Edificio", Visitante.ID_Edificio_Visitante1);
            cmd.Parameters.AddWithValue("@Hora_entrada", Visitante.Hora_entradaVisitante1);
            cmd.Parameters.AddWithValue("@Hora_salida", Visitante.Hora_salidaVisitante1);
            cmd.Parameters.AddWithValue("@Motivos_visita", Visitante.Motivos_visita1);
            cmd.Parameters.AddWithValue("@Foto_visitante", Visitante.Foto_Visitante1);
            cmd.Parameters.AddWithValue("@ID_Aula", Visitante.ID_Aula_Visitante1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarVisitante(E_REGISTRO_ITLA Visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarVisitante", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Id", Visitante.IdVisitante1);
            cmd.ExecuteNonQuery();

            conexion.Close();

        }


        ///////////////////////////////////////////////////////////////////////////////////////
        /// Metodos de los combox
        public DataTable ComboxEdificio()
        {
            SqlCommand cmd = new SqlCommand("SP_ComboxEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ComboxAula(E_REGISTRO_ITLA Aula)
        {
            SqlCommand cmd = new SqlCommand("SP_ComboxAula", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@nombre_edificio", Aula.Id_edificio_aula1);
            cmd.ExecuteNonQuery();
            conexion.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        /////////////////////////////////////////////////////////////////////////////////////
        //// Foto visitante

        public byte[] BuscarFotos(int buscar) 
        {

            SqlCommand cmd = new SqlCommand("SP_BuscarVisitanteFoto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Buscar", buscar);
            cmd.ExecuteNonQuery();
            conexion.Close();

            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("Visitante");

            byte[] Imagenes = new byte[0];
            dp.Fill(ds,"Visitante");

            DataRow myRow = ds.Tables["Visitante"].Rows[0];
            Imagenes = (byte[])myRow["Foto_visitante"];

            return Imagenes;

        }


        ///////////////////////////////////////////////////////
        ///Buscar Edificio
        ///

        public List<E_REGISTRO_ITLA> ListarVisitante1(string buscar)
        {

            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarVisitanteEdificio", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            LeerFilas = cmd.ExecuteReader();


            List<E_REGISTRO_ITLA> Listar = new List<E_REGISTRO_ITLA>();
            while (LeerFilas.Read())
            {

                Listar.Add(new E_REGISTRO_ITLA

                {
                    IdVisitante1 = LeerFilas.GetInt32(0),
                    CodigoVisitante1 = LeerFilas.GetString(1),
                    NombreVisitante1 = LeerFilas.GetString(2),
                    ApellidoVisitante1 = LeerFilas.GetString(3),
                    CarreraVisitante1 = LeerFilas.GetString(4),
                    CorreoVisitante1 = LeerFilas.GetString(5),
                    ID_Edificio_Visitante1 = LeerFilas.GetString(6),
                    Hora_entradaVisitante1 = LeerFilas.GetDateTime(7),
                    Hora_salidaVisitante1 = LeerFilas.GetDateTime(8),
                    Motivos_visita1 = LeerFilas.GetString(9),
                    ID_Aula_Visitante1 = LeerFilas.GetString(11)



                }); ;

            }

            conexion.Close();
            LeerFilas.Close();


            return Listar;

        }

        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
