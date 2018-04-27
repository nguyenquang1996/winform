    using QuanLyQuanCaFe.DAO;
using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaFe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            loadtable();
        }



        void loadtable()
        {
            List<table> tablelist =  tabledao.Instance.LoadTableList();
            foreach(table item in tablelist)
            {
                Button bnt = new Button() { Width = tabledao.tablewidth, Height = tabledao.tableheight };
                bnt.Text = item.Name + Environment.NewLine + item.Statuc;
                bnt.Click += bnt_Click;
                bnt.Tag = item;
                switch(item.Statuc)
                {
                    case "trong":
                        bnt.BackColor = Color.Aqua;
                        break;
                    default:
                        bnt.BackColor = Color.Pink;
                        break;
                }
                flpTable.Controls.Add(bnt);
            }
        }

        void showhoadon(int id)
        {
            List<billinfo> listbillinfo = billinfodao.Instance.getlistbillinfo(billdao.Instance.getuncheckoutbillidbytableid(id));
            foreach(billinfo item in listbillinfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.Foodid.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());

                lsvBill.Items.Add(lsvitem);
            }
        }

        private void bnt_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as table).Id ;
            showhoadon(tableid);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
