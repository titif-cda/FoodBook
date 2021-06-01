using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    public class RegisterResponse
    {
        public string AccessToken { get; set; }
        public string Username { get; set; }

        public RegisterResponse()
        {
        }
    }
}
