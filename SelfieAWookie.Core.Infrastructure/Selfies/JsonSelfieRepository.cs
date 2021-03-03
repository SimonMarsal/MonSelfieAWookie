using SelfieAWookie.Core.Domain;

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class JsonSelfieRepository : ISelfieRepository
    {
        public IList<Selfie> GetAll()
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestSelfies.json");
            string jsonResult = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Selfie>>(jsonResult);
        }
    }
}
