using System;
using System.Numerics;
using System.Web.Http;
using KnockKnock.Models;

namespace KnockKnock.Controllers
{
    public class FibonacciController : ApiController
    {
        public BigInteger Get([FromUri] int n)
        {
            var sequence = new FibonacciSequence();
            return sequence[Math.Abs(n)];
        }
    }
}
