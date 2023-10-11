using System.Text.Json.Serialization;

namespace tadb_202320_ex03.Models
{
    public class Cargadores
    {
        [JsonPropertyName("id_cargador")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("voltaje")]
        public string Voltaje { get; set; } = string.Empty;


           public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otroCargador = (Cargadores)obj;

            return Id == otroCargador.Id
                   && marca.Equals(otroCargador.Voltaje);
        }

          public override int GetHashCode()
        {
            unchecked
            {
                int hash = 3;
                hash = hash * 5 + Id.GetHashCode();
                hash = hash * 5 + (Voltaje?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}