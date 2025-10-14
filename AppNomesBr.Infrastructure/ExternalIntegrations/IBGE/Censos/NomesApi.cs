using AppNomesBr.Domain.Interfaces.ExternalIntegrations.IBGE.Censos;
using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Controls;

namespace AppNomesBr.Infrastructure.ExternalIntegrations.IBGE.Censos
{
    public class NomesApi : INomesApi
    {
        private readonly string? baseUrl = "api/v2/censos/nomes/";
        private readonly string rankingEndpoint = "ranking";
        private readonly HttpClient httpClient;

        public NomesApi(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.rankingEndpoint = baseUrl + this.rankingEndpoint;
        }

        public async Task<string> RetornaCensosNomesRanking(string cidade = null, string sexo = null)
        {
            var endpoint = baseUrl + rankingEndpoint;
            var queryParams = new List<string>();

            if (!string.IsNullOrWhiteSpace(cidade))
            {
                queryParams.Add($"localidade={cidade}");
            }
            if (!string.IsNullOrWhiteSpace(sexo))
            {
                queryParams.Add($"sexo={sexo.ToUpper()}");
            }

            if (queryParams.Any())
            {
                endpoint += "?" + string.Join("&", queryParams);
            }

            var response = await httpClient.GetAsync(endpoint);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> RetornaCensosNomesPeriodo(string nome, string sexo = null)
        {
            var url = baseUrl + nome;
            if (!string.IsNullOrWhiteSpace(sexo))
            {
                url += $"?sexo={sexo.ToUpper()}";
            }
            var response = await httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
