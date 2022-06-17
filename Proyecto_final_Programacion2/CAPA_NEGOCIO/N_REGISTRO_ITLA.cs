using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDAD;
using CAPA_DATOS;
using System.Data.SqlClient;
using System.Data;

namespace CAPA_NEGOCIO
{
    public class N_REGISTRO_ITLA
    {

        D_REGISTRO_ITLA objDato = new D_REGISTRO_ITLA();

        /// Tabla de Usuario

        public List<E_REGISTRO_ITLA> ListarUsuario(string buscar)
        {
            return objDato.ListarUsuario(buscar);

        }

        public void InsertandoUsuario(E_REGISTRO_ITLA Usuario)
        {
            objDato.InsertarUsuario(Usuario);
        }

        public void ActualizandoUsuario(E_REGISTRO_ITLA Usuario)
        {
            objDato.ActualizarUsuario(Usuario);
        }

        public void EliminandoUsuario(E_REGISTRO_ITLA Usuario)
        {
            objDato.EliminarUsuario(Usuario);
        }

        public DataTable LogicUsuario(E_REGISTRO_ITLA Usuario)
        {
            return objDato.LogicUsuario(Usuario);
        }

        //Tabla de Edificio

        public List<E_REGISTRO_ITLA> ListarEdificio(string buscar)
        {
            return objDato.ListarEdificio(buscar);

        }

        public void InsertandoEdificio(E_REGISTRO_ITLA Edificio)
        {
            objDato.InsertarEdificio(Edificio);
        }

        public void ActualizandoEdificio(E_REGISTRO_ITLA Edificio)
        {
            objDato.ActualizarEdificio(Edificio);
        }

        public void EliminandoEdificio(E_REGISTRO_ITLA Edificio)
        {
            objDato.EliminarEdificio(Edificio);
        }


        // Tabla Aula

        public List<E_REGISTRO_ITLA> ListarAula(string buscar)
        {
            return objDato.ListarAula(buscar);

        }

        public void InsertandoAula(E_REGISTRO_ITLA Aula)
        {
            objDato.InsertarAula(Aula);
        }

        public void ActualizandoAula(E_REGISTRO_ITLA Aula)
        {
            objDato.ActualizarAula(Aula);
        }

        public void EliminandoAula(E_REGISTRO_ITLA Aula)
        {
            objDato.EliminarAula(Aula);
        }

        // Tabla visitante

        public List<E_REGISTRO_ITLA> ListarVisitante(string buscar)
        {
            return objDato.ListarVisitante(buscar);

        }

        public void InsertandoVisitante(E_REGISTRO_ITLA Visitante)
        {
            objDato.InsertarVisitante(Visitante);
        }

        public void ActualizandoVisitante(E_REGISTRO_ITLA Visitante)
        {
            objDato.ActualizarVisitante(Visitante);
        }

        public void EliminandVisitante(E_REGISTRO_ITLA Visitante)
        {
            objDato.EliminarVisitante(Visitante);
        }


        //Metodos Combox
        public DataTable ComboxEdificio()
        {
            return objDato.ComboxEdificio();
        }

        public DataTable ComboxAula(E_REGISTRO_ITLA Aula)
        {
            return objDato.ComboxAula(Aula);
        }

        //Metodo Imagen

        public byte[] BuscarFotos(int buscar) 
        {
            return objDato.BuscarFotos(buscar);  
        }


        //Buscar Edificio Visitante
        public List<E_REGISTRO_ITLA> ListarVisitante1(string buscar)
        {
            return objDato.ListarVisitante1(buscar);

        }

        public void CerrarConexion() 
        {

            objDato.CerrarConexion();
        
        
        }


    }
}
