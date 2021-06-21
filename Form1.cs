using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addis_River_Side_Attendance_System
{
    public partial class Admin_Page : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        SerialPort port;
        public Admin_Page()
        {
            InitializeComponent();

            var date = DateTime.Now;
            lblTodayDate.Text = System.DateTime.Now.ToShortDateString();
            lblTimeNow.Text = date.Hour + " : " + date.Minute;
            lblTodayDay.Text = date.DayOfWeek.ToString();
            port = new SerialPort("COM4", 9600);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            open.Filter = "Image Files(*.jpg; *.jpeg *.gif; *.bmp)|*.jpg; *.jpeg *.gif; *.bmp ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_inAdd.Image = new Bitmap(open.FileName);

            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
           // dateTimePicker_inSheet.
        }

        private void btnUpload_InEdit_Click(object sender, EventArgs e)
        {
            open.Filter = "Image Files(*.jpg; *.jpeg *.gif; *.bmp)|*.jpg; *.jpeg *.gif; *.bmp ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_inEdit.Image = new Bitmap(open.FileName);

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)//enroll button
        {      
            portWrite("1");
            txtStatus.AppendText(Attendance_Page.arduinoData);
        }

        private void portWrite(String message)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            portWrite("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUpPage signup = new SignUpPage();
            this.Close(); 
            signup.Show();
        }

        private void btnAdd_InAdd_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                char g;
                if (radioButton2.Checked == true)
                    g = 'M';
                else
                    g = 'F';
                Employee emp = new Employee(textBox5.Text, textBox3.Text, textBox2.Text, dateTimePicker3.Text, dateTimePicker1.Text, int.Parse(tboxPnum.Text), int.Parse(textBox4.Text), int.Parse(comboBox4.SelectedText), g);
                if (emp.validation())
                {
                    Database db = new Database();
                    db.addEmployee(emp);
                    clear();
                }
                else
                    MessageBox.Show("Something's Wrong!");
            }
            else
                MessageBox.Show("Required Values Missing!");
        }

        private void btnClear_InAdd_Click(object sender, EventArgs e)
        {
            clear();
           
        }

        public void clear()
        {
            textBox5.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            dateTimePicker3.Checked = false;
            dateTimePicker1.Checked = false;
            tboxPnum.Text = "";
            textBox4.Text = "";
        }

        public bool checkNull()
        {
            bool valid;
            if (textBox5.Text == "" || textBox3.Text == "" || textBox2.Text == "" || dateTimePicker3.Checked == false || dateTimePicker1.Checked == false || textBox4.Text == "")
            {
                valid = false;
            }
            else
            {
                valid = true;
                if (tboxPnum.Text == "")
                {
                    tboxPnum.Text = "0000000000";
                }
            }
            return valid;
        }

        private void txtSearch_inEdit_KeyUp(object sender, KeyEventArgs e)
        {
            Database db = new Database();          
            DataTable dt = db.searchEmp(txtSearch_inEdit.Text);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                textBox9.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "M")
                    radioButton4.Checked = true;
                else
                    radioButton3.Checked = true;
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
            
    }
}
