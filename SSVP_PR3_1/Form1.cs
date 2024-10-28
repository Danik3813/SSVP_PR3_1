using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSVP_PR3_1
{
    //public class newLabel : Label
    //{
    //    private Label myNewLabel;
    //    private int countLabel 
    //    public newLabel()
    //    {
    //        Random randomLocation = new Random();
    //        Label newLabel = new Label();
    //    }
    //};

    public partial class Form1 : Form
    {
        private int countButton = 0;
        private int countLabel = 0;
        private int countTextBox = 0;
        public Form1()
        {
            InitializeComponent();
        }
           
        private void label1_Click(object sender, EventArgs e)
        {
            Random randomLocation = new Random();
            Label newLabel = new Label();
            newLabel.Location = new Point(randomLocation.Next(50, 390), randomLocation.Next(10, 390));
            newLabel.Size = new Size(38, 13);
            newLabel.Text = "Слово";
            countLabel++;
            this.Controls.Add(newLabel);
            newLabel.Click += label1_Click;
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Random randomLocation = new Random();
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(randomLocation.Next(50, 390), randomLocation.Next(10, 390));
            newTextBox.Size = new Size(100, 20);
            countTextBox++;
            this.Controls.Add(newTextBox);
            newTextBox.Click += textBox1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomLocation = new Random();
            Button newButton = new Button();
            newButton.Location = new Point(randomLocation.Next(50, 390), randomLocation.Next(50, 390));
            newButton.Size = new Size(100, 20);
            newButton.Text = "Кнопка";
            countButton++;
            this.Controls.Add(newButton);
            newButton.Click += button1_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 countElements = new Form2(this);
            countElements.Show();
            countElements.getLabel6().Text = countButton.ToString();
            countElements.getLabel5().Text = countTextBox.ToString();
            countElements.getLabel4().Text = countLabel.ToString();
        }
    }
}
