using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Management_System___CSIS.DB_Connection
{
    public class UserInfo
    {
        private static UserInfo _instance;

        // Private constructor to prevent instantiation
        private UserInfo() { }

        public static UserInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserInfo();
                }
                return _instance;
            }
        }

        public string UserID { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }

        // Optionally initialize with default values
        public void Initialize(string userId, string role, string userN)
        {
            UserID = userId;
            Role = role;
            Username = userN;
        }
    }

}
