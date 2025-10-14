using AppNomesBr.Domain.DataTransferObject.ExternalIntegrations.IBGE.Censos;

namespace AppNomesBr.Domain.Interfaces.Services
{
    public interface INomesBrService
    {
        Task<RankingNomesRoot[]> ListaRanking(string cidade = null, string sexo = null);

        Task<RankingNomesRoot[]> ListaMeuRanking();
        Task InserirNovoRegistroNoRanking(string nome, string sexo = null);
    }
}
