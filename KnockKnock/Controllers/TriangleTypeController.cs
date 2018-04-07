using System.Web.Http;
using KnockKnock.Models;
using KnockKnock.Exceptions;

namespace KnockKnock.Controllers
{
    public class TriangleTypeController : ApiController
    {
        public string Get([FromUri] int a, [FromUri] int b, [FromUri] int c)
        {
            try
            {
                var triangle = new Triangle(a, b, c);
                return triangle.Type;
            }
            catch(DomainException e)
            {
                return "Error";
            }
        }
    }
}
