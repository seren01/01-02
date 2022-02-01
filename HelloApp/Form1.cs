using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "🦋天官赐福，百无禁忌 🦋";
            this.Load += LoadEvent;
            this.BackColor = Color.DarkRed;
            //this.BackgroundImage = Image.FromFile("C:\\Users\\natya\\OneDrive\\Изображения\\цч.jpg");
            this.Width = 600;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🔥人間盡逍遙🔥");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();

            Form2 newForm2 = new Form2(newForm1);
            newForm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadEvent(object sender, EventArgs e)
        {
        this.BackColor = Color.DarkCyan;
        }
    }
}
