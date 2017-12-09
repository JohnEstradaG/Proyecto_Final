using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace Proyecto_Final
{
    public class _13090353
    {
        string matricula;
        string nombre;
        string apellido_pat;
        string apellido_mat;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;
        string contraseña;
        int tipousuario;
        bool deleted;


        [JsonProperty(PropertyName = "id")]
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }


        [JsonProperty(PropertyName = "Nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [JsonProperty(PropertyName = "Ape_pat")]
        public string ApellidoPaterno
        {
            get { return apellido_pat; }
            set { apellido_pat = value; }
        }

        [JsonProperty(PropertyName = "Ape_mat")]
        public string ApellidoMaterno
        {
            get { return apellido_mat; }
            set { apellido_mat = value; }
        }

        [JsonProperty(PropertyName = "Direccion")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [JsonProperty(PropertyName = "Telefono")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [JsonProperty(PropertyName = "Carrera")]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [JsonProperty(PropertyName = "Semestre")]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        [JsonProperty(PropertyName = "Correo")]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [JsonProperty(PropertyName = "GitHub")]
        public string Github
        {
            get { return github; }
            set { github = value; }
        }

        [JsonProperty(PropertyName = "Password")]
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        [JsonProperty(PropertyName = "TipoUsuario")]
        public int TipoUsuario
        {
            get { return tipousuario; }
            set { tipousuario = value; }
        }

        [Version]
        public string version { get; set; }
        [JsonProperty(PropertyName = "deleted")]

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }

        }
    }
}
