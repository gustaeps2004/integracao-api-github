namespace IntegracaoApiGitHub.Entities
{
    public class GitHub
    {
        public string login { get; set; }
        public string avatar_url { get; set; }
        public string repos_url { get; set; }
        public bool site_admin { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public string followers { get; set; }
        public string following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool IsError { get; set; } = false;
        public string Message { get; set; }

        public override string ToString()
        {
            return $"Login: {login} \n"
                    + $"Avatar URL: {avatar_url} \n"
                    + $"Repos URL: {repos_url} \n"
                    + $"Site admin: {site_admin} \n"
                    + $"Location: {location} \n"
                    + $"Bio: {bio} \n"
                    + $"Followers: {followers} \n"
                    + $"Following: {following} \n"
                    + $"Created at: {created_at.ToString("dd/MM/yyyy")} \n"
                    + $"Updates at: {updated_at.ToString("dd/MM/yyyy")} \n";
        }
    }
}
