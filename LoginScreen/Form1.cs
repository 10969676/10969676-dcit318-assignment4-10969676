using System;
<<<<<<< HEAD
using System.Windows.Forms;

namespace LoginApp
=======
<<<<<<< HEAD
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class DrawingForm : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;

        public DrawingForm()
=======
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddressBook
>>>>>>> 4e8fffa372268a0cd5f8b0714b514cb0e0a84945
{
    public partial class Form1 : Form
    {
        public Form1()
<<<<<<< HEAD
=======
>>>>>>> d04d714f08eec715e4ce0f3796cb670bee2160c7
>>>>>>> 4e8fffa372268a0cd5f8b0714b514cb0e0a84945
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"Username: {username}\nPassword: {password}");
=======
<<<<<<< HEAD
        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
=======
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            MessageBox.Show($"Saved:\nName: {name}\nEmail: {email}\nPhone: {phone}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

>>>>>>> 4e8fffa372268a0cd5f8b0714b514cb0e0a84945
        }

        private void label1_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
=======
>>>>>>> d04d714f08eec715e4ce0f3796cb670bee2160c7
>>>>>>> 4e8fffa372268a0cd5f8b0714b514cb0e0a84945
        }
    }
}
