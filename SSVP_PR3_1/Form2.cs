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
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        public Label getLabel6()
        {
            return label6;
        }
        public Label getLabel5()
        {
            return label5;
        }
        public Label getLabel4()
        {
            return label4;
        }
        public void deleteNewElements()
        {
            return label4;
        }
    }
}
