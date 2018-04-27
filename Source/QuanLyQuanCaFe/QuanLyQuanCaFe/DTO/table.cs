using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DTO
{
    public class table
    {
        public table(int id, string name,string statuc)
        {
            this.Id = id;
            this.Name = name;
            this.Statuc = statuc;
        }
        private string name;
        private int id;
        private string statuc;

        public table (DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Statuc = row["statuss"].ToString();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Statuc
        {
            get { return statuc; }
            set { statuc = value; }
        }
    }
}
 