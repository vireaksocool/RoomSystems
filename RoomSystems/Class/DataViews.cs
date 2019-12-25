using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RoomSystems.Class.ClassDO;

namespace RoomSystems.Class
{
    public class DataViews
    {
        public string roomid { get; set; }
        public string customerid { get; set; }
        //string values;
        public DataViews()
        {

        }
        public DataViews(string roomid, string customerid)
        {
            this.roomid = roomid;
            this.customerid = customerid;
        }
    }
}
