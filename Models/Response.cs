using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizStreamContact.Models
{
    public class Response
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public Response()
        {
        }
        public Response(string firstName, string lastName, string email, string response)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Details = response;
        }
        public string ToCSV()
        {
            string output;

            output = LastName + "," + FirstName + "," + Email + "," + Details ;
            return output;
        }
    }
}
