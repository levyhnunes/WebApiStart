using System.Web.Http;
using WebApiStart.Filters;

namespace WebApiStart.Controllers
{
    [JwtAuthentication]
    public class ValueController : ApiController
    {
    }
}