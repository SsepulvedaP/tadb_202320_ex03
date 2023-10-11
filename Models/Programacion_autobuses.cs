using System.Text.Json.Serialization;

namespace tadb_202320_ex03.Models
{
    public class Programacion_autobuses
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("id_hora")]
        public int Id_hora { get; set; } = 0;

        [JsonPropertyName("id_autobus")]
        public int id_autobus { get; set; } = 0;

        
           public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otroProgramacion_autobuses = (Programacion_autobuses)obj;

            return Id == otroProgramacion_autobuses.Id
                   && Id_hora.Equals(otroProgramacion_autobuses.Id_hora)
                   && id_autobus.Equals(otroProgramacion_autobuses.id_autobus);
        }

          public override int GetHashCode()
        {
            unchecked
            {
                int hash = 3;
                hash = hash * 5 + Id.GetHashCode();
                hash = hash * 5 + (Id_hora?.GetHashCode() ?? 0);
                hash = hash * 5 + (id_autobus?.GetHashCode() ?? 0);

                return hash;
            }
        }
    }
}