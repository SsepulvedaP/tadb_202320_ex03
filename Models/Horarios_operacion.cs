using System.Text.Json.Serialization;

namespace tadb_202320_ex03.Models
{
    public class Horarios_operacion
    {
        [JsonPropertyName("id_hora")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("pico")]
        public bool pico { get; set; } = bool.Empty;

           public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otroHorario_Operacion = (Horarios_operacion)obj;

            return Id == otroHorario_Operacion.Id
                   && pico.Equals(otroHorario_Operacion.pico);
        }

          public override int GetHashCode()
        {
            unchecked
            {
                int hash = 3;
                hash = hash * 5 + Id.GetHashCode();
                hash = hash * 5 + (pico?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}