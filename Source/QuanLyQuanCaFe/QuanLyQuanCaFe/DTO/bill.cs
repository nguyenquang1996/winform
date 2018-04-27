using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DTO
{
    public class bill
    {
        private bill(int id,DateTime? DateCheckIn, DateTime? datecheckout,int status)
        {
            this.Id = id;
            this.Datecheckin = DateCheckIn;
            this.Datecheckout = datecheckout;
            this.Status = status;
        }

        public bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Datecheckin = (DateTime?)row["DateCheckIn"];
            var datecheckoutemp = row["datecheckout"];
            if(datecheckoutemp.ToString()!="")
                this.Datecheckout = (DateTime?)datecheckoutemp;
            else

            this.Status = (int)row["status"];
        }

        private int id;
        private DateTime? DateCheckIn;
        private DateTime? datecheckout;
        private int status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime? Datecheckin {
            get { return DateCheckIn; }
            set { DateCheckIn = value; }
        }
        public DateTime? Datecheckout {
            get { return datecheckout; }
            set { datecheckout = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
