using Zuela.api.Enums;

namespace Zuela.api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public TempoVerbal TempoVerbal { get; set; }
        public int GrupoID { get; set; }
        public string Ingles { get; set; }
        public string Frances { get; set; }
        public string Portugues { get; set; }
    }
}
