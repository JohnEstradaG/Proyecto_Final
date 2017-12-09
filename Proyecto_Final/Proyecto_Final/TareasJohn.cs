using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
   public class TareasJohn
    {
        string id;
        string correos;
        string tarea;
        bool estatus;
        string descripcion;
        string prioridad;
        DateTime fecha;
        int dependencias;
        bool deleted;

        [JsonProperty(PropertyName = "Id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "Correo")]
        public string Correos
        {
            get { return correos; }
            set { correos = value; }
        }

        [JsonProperty(PropertyName = "Tarea")]
        public string Tarea
        {
            get { return tarea; }
            set { tarea = value; }
        }

        [JsonProperty(PropertyName = "Estatus")]
        public bool Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

        [JsonProperty(PropertyName = "Descripcion")]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [JsonProperty(PropertyName = "Prioridad")]
        public string Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        [JsonProperty(PropertyName = "FechaDeEntrega")]
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        [JsonProperty(PropertyName = "Dependencia")]
        public int Dependencia
        {
            get { return dependencias; }
            set { dependencias = value; }
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
