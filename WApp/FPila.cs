using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CApp;

namespace WApp
{
    public partial class FPila : Form
    {
        public FPila()
        {
            InitializeComponent();
        }
        clsPila P = new clsPila();
        private void FPila_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int elemento = int.Parse(textBox1.Text);
            P.Add(elemento);
            textBox2.Text = P.Imprimir();
        }
    }
}
