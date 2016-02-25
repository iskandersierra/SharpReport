using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace SharpReport.WebApi.Controllers
{
    /// <summary>
    /// Manages access to user documents
    /// </summary>
    public class DocumentsController : ApiController
    {
        public async Task<IHttpActionResult> Post(CancellationToken cancellationToken)
        {
            // Request.Content.ReadAsMultipartAsync();
            return BadRequest();
        }
    }
}