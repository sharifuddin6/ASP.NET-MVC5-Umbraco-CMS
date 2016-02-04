using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using MVC5_Umbraco_CMS.Domain.Models;

namespace MVC5_Umbraco_CMS.Controllers
{
    public class FeedbackController : ApiController
    {
        [HttpGet]
        public IEnumerable<MessageModel> Get()
        {
            return new List<MessageModel>
            {
                new MessageModel()
                {
                    Email = "email1@example.com",
                    Name = "name1",
                    Message = "Lorem ipsum dolor sit amet, an veri fugit invidunt eum, id nec noluisse constituam, mea ancillae pericula id. Ei omnes facilis ceteros vix. Mea delenit vivendum maiestatis id. Oratio fierent constituam his cu, dolores petentium his cu. Cu mel platonem mandamus, vix dicat detracto noluisse in, aperiam detraxit mei id.",
                    DateTime = DateTime.Now
                },
                new MessageModel()
                {
                    Email = "email2@example.com",
                    Name = "name2",
                    Message = "Nec ei primis neglegentur. At scripta nostrud efficiantur sit, mel commune atomorum cu. Ea accusata tincidunt scriptorem est, ex vix sonet virtute elaboraret. Qui viris omnium in, per vide discere eu. Ad vis vidit sensibus argumentum.",
                    DateTime = DateTime.Now
                },
                new MessageModel()
                {
                    Email = "email3@example.com",
                    Name = "name3",
                    Message = "Et augue omnium mnesarchum mei. Error verterem quo id, te mei modo atqui aliquip, tation quodsi constituam eum an. Iudico apeirian ex ius, per in ipsum ancillae probatus. At graeci senserit erroribus mea, te dicat ocurreret mea. Laudem sanctus admodum no cum, facilisis gloriatur quo at, doctus voluptatum eos te. Eius iuvaret qui ne, vix prima dicam nostrud no, albucius torquatos pro ut.",
                    DateTime = DateTime.Now
                }
            };
        }

        [HttpPost]
        public HttpResponseMessage Post(MessageModel message)
        {
            var response = new HttpResponseMessage
            {
                Content = new StringContent("{\"success\":\"0\"}", Encoding.UTF8, "application/json")
            };
            return response;
        }
        
        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}