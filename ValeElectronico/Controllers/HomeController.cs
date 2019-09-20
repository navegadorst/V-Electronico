using Microsoft.IdentityModel.Tokens;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValeElectronico.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            var client = new RestClient("https://YOUR_DOMAIN/api/v2/connections/CONNECTION_ID");
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("authorization", "Bearer MGMT_API_ACCESS_TOKEN");
            request.AddParameter("undefined", "{  \"options\": { \"identity-api\": \"microsoft-identity-platform-v2.0\", \"scopes\": \"email\" } }", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);




            //for step 2
            TokenValidationParameters validationParameters = new TokenValidationParameters
            {
                // Since this is a multi-tenant app, you should ideally only accept users from a list of tenants that you want to.
                // * Instead of using the default validation (validating against a single issuer value, as we do in line of business apps), you can inject your own multi-tenant validation logic through a IssuerValidator.
                // * Or you can provide a static list of acceptable tenantIds, as detailed below
                // ValidIssuers = new List<string>()
                // {
                //     "https://sts.windows.net/6d9c0c36-c30e-442b-b60a-ca22d8994d14/",
                //     "https://sts.windows.net/f69b5f46-9a0d-4a5c-9e25-54e42bbbd4c3/",
                //     "https://sts.windows.net/fb674642-8965-493d-beee-2703caa74f9a/"
                // }
                ValidateIssuer = true,
                //IssuerValidator = AadIssuerValidator.ValidateAadIssuer
            };
            return View();
        }
    }
}