using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClub.Db
{
    partial class Booking
    {
        public string IB
        {
            get
            {
                return IsBooked == true ? "Подверждено бронь" : "Не подтверждено";
            }
        }
    }
}
