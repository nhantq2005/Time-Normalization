using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanHoaThoiGian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct ThoiGian
        {
            int gio, phut, giay;
            public ThoiGian(int gio, int phut, int giay)
            {
                this.gio = gio;
                this.phut = phut;
                this.giay = giay;
            }

            public int Gio
            {
                get { return gio; }
                set { gio = value; }
            }

            public int Phut
            {
                get { return phut; }
                set { phut = value; }
            }

            public int Giay
            {
                get { return giay; }   
                set { giay = value; }
            }

            public void chuanHoa()
            {
                int t = giay / 60;
                giay %= 60;
                phut += t;
                t = phut / 60;
                phut %= 60;
                gio += t;
                gio = gio >=24 ?gio%24 : gio;
            }

            public string hienThi()
            {
                chuanHoa();
               return string.Format("{0:0} : {1:00}  :{2:00}",
                   this.gio, this.phut, this.giay);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ThoiGian t = new ThoiGian(
                int.Parse(inputHour.Text),
                int.Parse(inputMinute.Text),
                int.Parse(inputSecond.Text)
                );
            outputTime.Text=t.hienThi();
        }
    }
}
