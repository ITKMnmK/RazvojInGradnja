namespace FeriDockerCI
{
    public class GreetingService
    {
        public string GetGreeting(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Pozdravljen, uporabnik!";
            }

            return $"Pozdravljen, {name.Trim()}!";
        }
    }
}
