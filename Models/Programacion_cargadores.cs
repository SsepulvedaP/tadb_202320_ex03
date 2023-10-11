using System.Text.Json.Serialization;

namespace tadb_202320_ex03.Models
{
    public class Programacion_cargadores
    {
        [JsonPropertyName("id")]
        public int Id { get; set; } = 0;

        [JsonPropertyName("id_hora")]
        public int Id_hora { get; set; } = 0;

        [JsonPropertyName("id_autobus")]
        public int id_autobus { get; set; } = 0;

         [JsonPropertyName("id_cargador")]
        public int id_cargador { get; set; } = 0;

        
           public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otroProgramacion_cargadores = (Programacion_cargadores)obj;

            return Id == otroProgramacion_cargadores.Id
                   && Id_hora.Equals(otroProgramacion_cargadores.Id_hora)
                   && id_autobus.Equals(otroProgramacion_cargadores.id_autobus)
                   && id_cargador.Equals(otroProgramacion_cargadores.id_cargador);
        }

          public override int GetHashCode()
        {
            unchecked
            {
                int hash = 3;
                hash = hash * 5 + Id.GetHashCode();
                hash = hash * 5 + (Id_hora?.GetHashCode() ?? 0);
                hash = hash * 5 + (id_autobus?.GetHashCode() ?? 0);
                hash = hash * 5 + (id_cargador?.GetHashCode() ?? 0);

                return hash;
            }
        }
    }
}