using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class JsonSelfieRepository : ISelfieRepository
    {
        public void Create(Selfie model)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Selfie model)
        {
            throw new NotImplementedException();
        }

        public IList<Selfie> GetAll()
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestSelfies.json");
            string jsonResult = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Selfie>>(jsonResult);
        }

        public Task<IList<Selfie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
