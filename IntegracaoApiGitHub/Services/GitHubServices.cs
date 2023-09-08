using IntegracaoApiGitHub.Entities;
using Newtonsoft.Json;
using RestSharp;

namespace IntegracaoApiGitHub.Services
{
    public class GitHubServices
    {
        public async Task<GitHub> Integracao(string username)
        {
            try 
            {
                var client = new RestClient("https://api.github.com/users");
                var request = new RestRequest($"{username}", Method.Get);
                var response = client.ExecuteGet(request);
                
                if(response.StatusCode.ToString() == "NotFound")
                {
                    return new GitHub
                    {
                        IsError = true,
                        Message = "Usuário inexistente"
                    };
                }

                var data = JsonConvert.DeserializeObject<GitHub>(response.Content!.ToString());
                return data!;
            }
            catch (JsonReaderException ex)
            {
                return new GitHub
                {
                    IsError = true,
                    Message = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new GitHub
                {
                    IsError = true,
                    Message = ex.Message
                };
            }
        } 
    }
}
