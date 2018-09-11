using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class LoginRequest
    {
        //{"email":"STRING","password":"STRING","undelete":false,"captcha_key":null}
        public string email { get; set; }
        public string password { get; set; }
        public bool undelete { get; set; }
        public object captcha_key { get; set; }

        public LoginRequest()
        {
        }
        public LoginRequest(string _email, string _password)
        {
            email = _email;
            password = _password;
            undelete = false;
            captcha_key = null;
        }
    }
}
