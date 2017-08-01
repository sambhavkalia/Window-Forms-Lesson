using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Sambahv kalia
 * Dae: August 1,2017
 * Description: This is demo Application to showcase User Interface
 * Version 0.1 -Created the project
 * 
 */

namespace Window_forms
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the helloButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length > 0)
            {
                HelloLabel.Text = "Hello , World! " + InputTextBox.Text;
            }
            else
            {
                HelloLabel.Text = "Hello World";
            }
        }
    }
}
