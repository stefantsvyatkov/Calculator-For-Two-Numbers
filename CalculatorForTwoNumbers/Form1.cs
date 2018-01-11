using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(firstNumBox.Text);
            double num2 = double.Parse(secondNumBox.Text);
            double result = 0;
            bool choosedOperation = true;
            switch (operation.SelectedItem)
            {
                case "Add":
                    result = num1 + num2;
                    break;
                case "Subtract":
                    result = num1 - num2;
                    break;
                case "Multiply":
                    result = num1 * num2;
                    break;
                case "Divide":
                    result = num1 / num2;
                    break;
                default:
                    choosedOperation = false;
                    MessageBox.Show("Please choose an operation!");
                    break;
            }
            if (choosedOperation)
            {
                firstNumBox.Text = string.Empty;
                secondNumBox.Text = string.Empty;
                MessageBox.Show(result.ToString());
            }
        }

        private void Form1_Close(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
