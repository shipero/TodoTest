using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using ToDo.Models;

namespace ToDo
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterMicrosoftClient(
                clientId: "000000004C0FF117",
                clientSecret: "-WXHKeSgH2wdJLpbr2mFmOD09g4-cgL6");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "dRur8eZeyU4cY6cdo8VVFQ",
                consumerSecret: "OegIG39lu6dMGJjVAXySsGHgSpF1UMtBqJGOmnJti4");

            //OAuthWebSecurity.RegisterFacebookClient(
            //    appId: "",
            //    appSecret: "");

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
