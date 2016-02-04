using System;

namespace MVC5_Umbraco_CMS.Domain.Models
{
    public class MessageModel
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public DateTime DateTime { get; set; }
    }
}