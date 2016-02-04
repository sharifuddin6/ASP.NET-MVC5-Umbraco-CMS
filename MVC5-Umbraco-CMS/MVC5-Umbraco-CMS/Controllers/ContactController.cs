using System.Net.Http;
using System.Text;
using System.Web.Http;
using MVC5_Umbraco_CMS.Domain.Models;

namespace MVC5_Umbraco_CMS.Controllers
{
    public class ContactController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(MessageModel message)
        {
            var response = new HttpResponseMessage
            {
                Content = new StringContent("{\"success\":\"0\"}", Encoding.UTF8, "application/json")
            };
            return response;
        }

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// PUT api/<controller>/5
        //public void Put(MessageModel message)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}