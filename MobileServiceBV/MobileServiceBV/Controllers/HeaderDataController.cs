using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using MobileServiceBV.DataObjects;
using MobileServiceBV.Models;

namespace MobileServiceBV.Controllers
{
    public class HeaderDataController : TableController<HeaderData>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<HeaderData>(context, Request, Services);
        }

        // GET tables/HeaderData
        public IQueryable<HeaderData> GetAllHeaderData()
        {
            return Query(); 
        }

        // GET tables/HeaderData/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<HeaderData> GetHeaderData(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/HeaderData/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<HeaderData> PatchHeaderData(string id, Delta<HeaderData> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/HeaderData
        public async Task<IHttpActionResult> PostHeaderData(HeaderData item)
        {
            HeaderData current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/HeaderData/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteHeaderData(string id)
        {
             return DeleteAsync(id);
        }

    }
}