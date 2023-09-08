using IntegracaoApiGitHub.Entities;

namespace IntegracaoApiGitHub.Interfaces
{
    public interface IGitHub
    {
        Task<GitHub> Integracao(string username);
    }
}
