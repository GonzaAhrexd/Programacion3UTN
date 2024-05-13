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
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
            //Crea unos divs que muestre los valores del dado
            Label label1 = new Label();
            label1.Text = "Valor en cabecera: ";
            label1.Location = new Point(10, 10);
            label1.AutoSize = true;
            this.Controls.Add(label1);

        }
    }
}
