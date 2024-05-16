using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            // form2 = new FormTest();
            // form3 = new FormReg();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        // private readonly FormTest form2;
        // private readonly FormReg form3;

        private void Button1_Click(object sender, EventArgs e)
        {
            string loginUser = textBox1.Text;
            string passUser = textBox2.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) { 
                FormTest formTest = new FormTest();
                formTest.Show();
            
            // Optionally, hide the current login form
                this.Hide();
            }
            else
                MessageBox.Show("No");
        }


        private void Label3_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            formReg.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Pink;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;

        // public FormReg Form3 => form3;

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Left += e.X - lastPoint.X; 
           // this.Top += e.Y - lastPoint.Y;
          
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
