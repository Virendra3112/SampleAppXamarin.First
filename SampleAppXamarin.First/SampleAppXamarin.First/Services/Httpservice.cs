using SampleAppXamarin.First.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleAppXamarin.First.Services
{
    public class Httpservice : IHttpservice
    {
        public Task<ResponseModel<string>> SendRequestAsync(HttpMethod method, string url, string content = null, int timeout = 60)
        {
            throw new NotImplementedException();
        }
    }
}
