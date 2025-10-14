using System.Text.Json.Serialization;

namespace AppNomesBr.Domain.DataTransferObject.ExternalIntegrations.IBGE.Censos
{
    public class RankingNome
    {
        public string? Sexo { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("frequencia")]
        public long Frequencia { get; set; }

        [JsonPropertyName("ranking")]
        public int Ranking { get; set; }
    }
}
