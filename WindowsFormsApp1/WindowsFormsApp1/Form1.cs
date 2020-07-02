using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class clickcon : Form
    {
        public clickcon()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zonecon zc = new zonecon(); //ประกาศฟอร์มหน้าโซนที่หนั่ง
            zc.Show(); //แสดงหน้าของโซนที่นั่ง
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zonecon zc = new zonecon(); //ประกาศฟอร์มหน้าโซนที่หนั่ง
            zc.Show(); //แสดงหน้าของโซนที่นั่ง
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            zonecon zc = new zonecon(); //ประกาศฟอร์มหน้าโซนที่หนั่ง
            zc.Show(); //แสดงหน้าของโซนที่นั่ง
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("จัดทำโดย นางสาว อาทิตยา ฉิมมาแก้ว" + "\n" + "นักศึกษาชั้นปีที่1" + "\n" + "คณะวิทยาศาสตร์ประยุกต์และวิศวกรรมศาสตร์" + "\n" + "สาขา วิทยาการคอมพิวเตอร์และสารสนเทศ" + "\n" + "มหาวิทยาลัยขอนแก่น วิทยาเขตหนองคาย" + "\n" + "GiftHub : https://github.com/mbz1998");
        }
    }
}
