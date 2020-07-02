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
    public partial class zonecon : Form
    {
        public zonecon()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {   
        }
        private void button7_Click(object sender, EventArgs e)
        {
        }
        private void button10_Click(object sender, EventArgs e)
        {
        }
        private void button9_Click(object sender, EventArgs e)
        {
        }
        private void button11_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            A1zone a1z = new A1zone(); //ประกาศหน้าฟอร์มโซนเอหนึ่ง
            a1z.Show(); //แสดงหน้าฟอร์มโซนเอหนึ่ง
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            A2zone a2z = new A2zone(); //ประกาศหน้าฟอร์มโซนเอสอง
            a2z.Show(); //แสดงหน้าฟอร์มโซนเอสอง
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            A3zone a3z = new A3zone(); //ประกาศหน้าฟอร์มโซนเอสาม
            a3z.Show(); //แสดงหน้าฟอร์มโซนเอสาม
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            B1zone b1z = new B1zone(); //ประกาศหน้าฟอร์มโซนบีหนึ่ง
            b1z.Show(); //แสดงหน้าฟอร์มโซนบหนึ่ง
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            B2zone b2z = new B2zone(); //ประกาศหน้าฟอร์มโซนบีสอง
            b2z.Show(); //แสดงหน้าฟอร์มโซนบีสอง
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            B3zone b3z = new B3zone(); //ประกาศหน้าฟอร์มโซนบีสาม
            b3z.Show(); //แสดงหน้าฟอร์มโซนบีสาม
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            C1zone C1z = new C1zone(); //ประกาศหน้าฟอร์มโซนซีหนึ่ง
            C1z.Show(); //แสดงหน้าฟอร์มโซนซีหนึ่ง
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            C2zone C2z = new C2zone(); //ประกาศหน้าฟอร์มโซนซีสอง
            C2z.Show(); //แสดงหน้าฟอร์มโซนซีสอง
        }
    }
}
