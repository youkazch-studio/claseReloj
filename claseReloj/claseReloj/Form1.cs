using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseReloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text = "Escriba la marca del Reloj";
            button1.Text = "Agregar";



        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            Reloj reloj = new Reloj();
            reloj.setmarca(txtMarca.Text);
            reloj.setmodelo(txtModelo.Text);

          
            listBox1.Items.Add(.getmarcamodelo());

          
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txtTitulo.Focus();
        }
    }
}
