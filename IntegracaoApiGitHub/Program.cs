using IntegracaoApiGitHub.Services;
string username = "";

while (String.IsNullOrEmpty(username.Trim()))
{
    Console.Write("Digite um username: ");
    username = Console.ReadLine();

    if (String.IsNullOrEmpty(username.Trim()))
    {
        Console.Clear();
        Console.WriteLine("Username inválido!");
        Console.WriteLine("");
    }
}

GitHubServices _services = new();
var valuesGitHub = await _services.Integracao(username);
Console.Clear();

if(valuesGitHub.IsError)
{
    Console.WriteLine(valuesGitHub.Message);
}
else
{
    Console.WriteLine(valuesGitHub);
}
