namespace APIKeyManager.Services
{
    public interface IApiKeyService
    {
        IEnumerable<string> GetApiKeys();
        void AddApiKey(string apiKey);
        void DeleteApiKey(int id);
    }

    public class ApiKeyService : IApiKeyService
    {
        private static List<string> ApiKeys = new List<string>();

        public IEnumerable<string> GetApiKeys()
        {
            return ApiKeys;
        }

        public void AddApiKey(string apiKey)
        {
            ApiKeys.Add(apiKey);
        }

        public void DeleteApiKey(int id)
        {
            if (id >= 0 && id < ApiKeys.Count)
            {
                ApiKeys.RemoveAt(id);
            }
        }
    }
}
