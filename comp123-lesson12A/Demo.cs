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
 name:mehul khosla
 date:august 1,2017
 description: the demo app to showcase user interfac
 version: 0.1 - created the project*/
namespace comp123_lesson12A
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is the event handler for helloButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length > 0)
            {
                HelloLable.Text = "Hello, World!!" + InputTextBox.Text;

            }
            else
            {
                HelloLable.Text = "hello world!!";
            }
        }
        private void HelloLable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
