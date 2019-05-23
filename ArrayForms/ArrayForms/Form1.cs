using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void button1_Click(object sender, EventArgs e)
            {
            const int size = 10;
            int[] FirstNumber = new int[size];
            FirstNumber[0] = 1;
            FirstNumber[3] = 3;
            FirstNumber[9] = 8;
            string message = "";
            for (int index = 0; index < FirstNumber.Length; index++)
            {
                if (FirstNumber[index] != 0)
                    message = message + "Value at index " + index + " is:" + FirstNumber[0].ToString() + "\n";
            }
            // message = message+"Value at index 0 is:"+number[0].ToString()+"\n";
            //message = message + "Value at index 3 is:" + number[3].ToString()+"\n";
            //message = = message + "Value at index 9 is:" + number[9].ToString()+"\n";
            ShowRichTextBox.Text = message;
        }


           

       

       
    }
}
