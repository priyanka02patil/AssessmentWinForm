using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssessmentWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DotNetTraining-oct\prd.dat"; 
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textProdId.Text));
                bw.Write(textProdName.Text);
                bw.Write(Convert.ToDouble(textProdPrice.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DotNetTraining-oct\prd.dat"; 
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textProdId.Text = br.ReadInt32().ToString();
                textProdName.Text = br.ReadString();
                textProdPrice.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {

            }

        }
    }
}
