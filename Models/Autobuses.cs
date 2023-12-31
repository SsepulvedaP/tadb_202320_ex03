using System.Text.Json.Serialization;

namespace tadb_202320_ex03.Models
{
    public class Autobuses
    {
        [JsonPropertyName("id_autobus")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("marca")]
        public string marca { get; set; } = string.Empty;

         public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otroBus = (Autobuses)obj;

            return Id == otroBus.Id
                   && marca.Equals(otroBus.marca);
        }

          public override int GetHashCode()
        {
            unchecked
            {
                int hash = 3;
                hash = hash * 5 + Id.GetHashCode();
                hash = hash * 5 + (marca?.GetHashCode() ?? 0);
                return hash;
            }
        }


    }
}