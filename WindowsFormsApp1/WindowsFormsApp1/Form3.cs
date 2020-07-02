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
    public partial class A1zone : Form
    {
        public A1zone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //ปิดการทำงาน
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (totaltik.Text == string.Empty) //ถ้าช่องใส่จำนวนตั๋วว่าง
            {
                checktikfall(); //ตรวจสอบข้อมูล
            }
            else
            {
                checktik(); //ตรวจสอบข้อมูล
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
        void checktik()
        {
            {
                MessageBox.Show("ยืนยันการเลือกที่นั่ง", //แสดงข้อความตรงกลางของ MessageBox
                             "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                            MessageBoxButtons.OKCancel, //ปุ่มกดการทำรายการ
                            MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox
                MessageBox.Show("เลือกที่นั่งเรียบร้อยแล้ว", //แสดงข้อความตรงกลางของ MessageBox
                                    "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                                    MessageBoxButtons.OK, //ปุ่มกดการทำรายการ
                                    MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void A1zone_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void total_buy_Click(object sender, EventArgs e)
        {

        }
        private void totaltik_TextChanged(object sender, EventArgs e)
        {

            string tt = totaltik.Text; //กำหนดตัวแปรที่ต้องการ
            int tik; //กำหนดค่าตัวแปรของตัวเลข
            int.TryParse(tt, out tik); //เช็คว่าข้อมูลที่กรอกนั้นเป็นคัวเลขที่ต้องการหรือไม่
            int sum = 5500 * tik; //คำนวณราคาบัตรและราคา
            if (tik == 1) //ถ้าเลือก1ใบ
            {
                sum = 5500 * tik; //คำนวณราคาบัตรและราคา
                total_buy.Text = sum.ToString(); //รวมจำนวนและราคาทั้งหมดที่คำนวณจากสูตรที่ตั้งจะแสดงผลที่ total_buy (ผลลัพธ์)
            }
            else if (tik >= 1 && tik <= 4) //ถ้าเลือกตั้งแต่สองใบขึ้นไป
            {
                sum = 5500 * tik; //คำนวณราคาบัตรและราคา
                total_buy.Text = sum.ToString(); //รวมจำนวนและราคาทั้งหมดที่คำนวณจากสูตรที่ตั้งจะแสดงผลที่ total_buy (ผลลัพธ์)
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
        }
        void checktikfall()
        {
               MessageBox.Show("ยังไม่ทำรายการ กรุณาทำรายการใหม่", //แสดงข้อความตรงกลางของ MessageBox
                               "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                               MessageBoxButtons.OK, //ปุ่มกดการทำรายการ
                               MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
