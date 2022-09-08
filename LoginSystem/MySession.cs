using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LoginSystem
{
    public class MySession
    {
        private MySession()
        {
            IsLogged = false;
        }

        public static MySession Current
        {
            get
            {
                MySession session =
                  (MySession)HttpContext.Current.Session["__MySession__"];
                if (session == null)
                {
                    session = new MySession();
                    HttpContext.Current.Session["__MySession__"] = session;
                }
                return session;
            }
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public bool IsLogged { get; set; }
    }
}
