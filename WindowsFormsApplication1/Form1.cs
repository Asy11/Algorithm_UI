using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OpenFileDialog openfileDialog1;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openfileDialog1 = new OpenFileDialog();
            openfileDialog1.Filter = "Cursor Files|*.txt";

            if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openfileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(openfileDialog1.FileName);
            }
            catch
            {
                MessageBox.Show("파일을 선택하지 않았습니다.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메뉴 목록창");
        }
    }
}
