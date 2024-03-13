using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Point point = new Point(20,10);

            button.Location = point;
            button.Name = "Button1";
            button.Text = "Click";
            button.BackColor=Color.CadetBlue;
            button.Height = 50;
            button.Width = 100;


            Label label = new Label();
            Point point2 = new Point(200,100);

            label.Location = point2;
            label.Name = "Label1";
            label.Text = "Hello";
            label.BackColor =Color.Aquamarine;
            label.Height = 250;
            label.Width = 100;
            label.AutoSize=true;
            this.Controls.Add(label);

            this.Controls.Add(button);

            for(int i = 0; i < 5; i++)
            {
                TextBox textBox = new TextBox();
                Point point3 = new Point(300,i*50);    
                textBox.Location = point3;
                textBox.Name = "TextBox1" + i;
                textBox.Text = i.ToString();
                this.Controls.Add(textBox);
            }
        }
    }
}
