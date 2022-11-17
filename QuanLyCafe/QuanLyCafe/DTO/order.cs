using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.DTO
{
    public class order
    {
        public int idBill { get; set; }
        public DateTime dateCheckIn { get; set; }
        public DateTime dateCheckOut { get; set; }
        public int idTable { get; set; }
    }
}
