using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Log;
using log4net;

namespace HelloWorld.Services
{
    /// <summary>
    /// Service Class to communicate with the Hello World Web API
    /// </summary>
    public class HelloWorldWebService : IHelloWorldWebService
    {        
        /// Application settings, Logger, Rest Client, Rest Request, Wrapped URI will be defined here
        /// 
        /// 
        public HelloWorldWebService(
            restclient,
            restrequest,
            appsettings,
            URI,
            logger)
        {
        }
        public HelloWorld helloWorld()
        {
            //Set the URL for the request
            //Setup the request - using GET method
            //Execute the call and get the response
            //check if data is present in the response and return it, else return an handled exception
        }
        
    }
}
