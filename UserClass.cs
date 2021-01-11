using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_template
{
    public class User
    {
        public User()
        {

        }

        public User(string strUserID)
        {
            this.strUserID = strUserID;
            this.DtUserRegDate = DateTime.Now;
        }

        public int intUserNo { get; set; }

        public string strUserID { get; set; }

        public string strUserName { get; set; }

        public DateTime DtUserRegDate { get; set; }
    }
}
