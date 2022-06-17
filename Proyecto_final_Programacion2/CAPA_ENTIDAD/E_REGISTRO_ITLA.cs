using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_REGISTRO_ITLA
    {
        

        /// Atributos y metodos de la variable usuarrio

        private int IdUsuario;
        private string nombre_usuario;
        private string Apellido_usuario;
        private DateTime Fecha_Nacimiento;
        private string N_Usuario;
        private string Contraseña_usuario;
        private string Tipo_de_usuario;

        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public string Nombre_usuario1 { get => nombre_usuario; set => nombre_usuario = value; }
        public string Apellido_usuario1 { get => Apellido_usuario; set => Apellido_usuario = value; }
        public DateTime Fecha_Nacimiento1 { get => Fecha_Nacimiento; set => Fecha_Nacimiento = value; }
        public string N_Usuario1 { get => N_Usuario; set => N_Usuario = value; }
        public string Contraseña_usuario1 { get => Contraseña_usuario; set => Contraseña_usuario = value; }
        public string Tipo_de_usuario1 { get => Tipo_de_usuario; set => Tipo_de_usuario = value; }


        /// Atributos y metodos de la tabla edificio

        private int IdEdificio;
        private string nombre_edificio;

        public int IdEdificio1 { get => IdEdificio; set => IdEdificio = value; }
        public string Nombre_edificio1 { get => nombre_edificio; set => nombre_edificio = value; }


        // Atributos y metodos de la tabla aula

        private int IdAula;
        private string nombre_aula;
        private string Id_edificio_aula;

        public int IdAula1 { get => IdAula; set => IdAula = value; }
        public string Nombre_aula1 { get => nombre_aula; set => nombre_aula = value; }
        public string Id_edificio_aula1 { get => Id_edificio_aula; set => Id_edificio_aula = value; }
       


        // Atributos y metodos de la tabla visitantes

        private int IdVisitante;
        private string CodigoVisitante;
        private string NombreVisitante;
        private string ApellidoVisitante;
        private string CarreraVisitante;
        private string CorreoVisitante;
        private string ID_Edificio_Visitante;
        private DateTime Hora_entradaVisitante;
        private DateTime Hora_salidaVisitante;
        private string Motivos_visita;
        private byte[] Foto_Visitante;
        private string ID_Aula_Visitante;


        public int IdVisitante1 { get => IdVisitante; set => IdVisitante = value; }
        public string CodigoVisitante1 { get => CodigoVisitante; set => CodigoVisitante = value; }
        public string NombreVisitante1 { get => NombreVisitante; set => NombreVisitante = value; }
        public string ApellidoVisitante1 { get => ApellidoVisitante; set => ApellidoVisitante = value; }
        public string CarreraVisitante1 { get => CarreraVisitante; set => CarreraVisitante = value; }
        public string ID_Edificio_Visitante1 { get => ID_Edificio_Visitante; set => ID_Edificio_Visitante = value; }
        public DateTime Hora_entradaVisitante1 { get => Hora_entradaVisitante; set => Hora_entradaVisitante = value; }
        public DateTime Hora_salidaVisitante1 { get => Hora_salidaVisitante; set => Hora_salidaVisitante = value; }
        public string Motivos_visita1 { get => Motivos_visita; set => Motivos_visita = value; }
        public byte[] Foto_Visitante1 { get => Foto_Visitante; set => Foto_Visitante = value; }
        public string ID_Aula_Visitante1 { get => ID_Aula_Visitante; set => ID_Aula_Visitante = value; }
        public string CorreoVisitante1 { get => CorreoVisitante; set => CorreoVisitante = value; }
    }
}
