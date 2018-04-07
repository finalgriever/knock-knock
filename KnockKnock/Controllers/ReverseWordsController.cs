using System.Web.Http;
using KnockKnock.Extensions;

namespace KnockKnock.Controllers
{
    public class ReverseWordsController : ApiController
    {
        public string Get([FromUri] string sentence)
        {
            return sentence.Reverse();
        }
    }
}
