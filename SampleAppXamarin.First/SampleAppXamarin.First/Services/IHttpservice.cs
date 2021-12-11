using SampleAppXamarin.First.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleAppXamarin.First.Services
{
    public interface IHttpservice
    {
        Task<ResponseModel<string>> SendRequestAsync(HttpMethod method, string url, string content = null, int timeout = 60);
    }
}
