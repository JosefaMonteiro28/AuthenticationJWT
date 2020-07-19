using AuthenticationJWT.Data;
using System;

namespace AuthenticationJWT.Application
{
    public class App
    {
        public Context db = new Context();
        public AppResult res = new AppResult();

        public class AppResult
        {
            public bool Success { get; set; }

            public string Message { get; set; }

            public object Object { get; set; }

            public AppResult Good(string msg, object obj = null)
            {
                Success = true;
                Message = msg;
                if (obj != null)
                {
                    Object = obj;
                }
                return this;
            }

            public AppResult Bad(string msg, object obj = null)
            {
                Success = false;
                Message = msg;
                if (obj != null)
                {
                    Object = obj;
                }
                return this;
            }

            public AppResult Good(object obj)
            {
                Success = true;
                Message = "Operation performed successfully.";
                if (obj != null)
                {
                    Object = obj;
                }
                return this;
            }  
        }
    }
}
