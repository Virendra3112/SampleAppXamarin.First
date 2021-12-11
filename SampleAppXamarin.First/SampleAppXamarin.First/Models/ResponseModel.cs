using System.Net;

namespace SampleAppXamarin.First.Models
{
    public class ResponseModel<T>
    {
        public HttpStatusCode Status { get; set; }

        public bool IsSuccess
        {
            get
            {
                return Status == HttpStatusCode.OK || Status == HttpStatusCode.Created;
            }

        }
        public T Result { get; set; }
    }
}

