using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomSystems.Class
{
    class classGetID
    {
        public static string RID;
        public static string rents_roomID 
        {
            get { return RID; }
            set { RID = value; }
        }
    }
}
