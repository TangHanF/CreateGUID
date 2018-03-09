using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUID生成器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string guid = "";
            if (radioButton1.Checked) {
                guid = Guid.NewGuid().ToString();
            }
            else if (radioButton2.Checked)
            {
                guid = Guid.NewGuid().ToString("N");
            }
            else if (radioButton3.Checked)
            {
                guid = Guid.NewGuid().ToString("B");
            }
            else if (radioButton4.Checked)
            {
                guid = Guid.NewGuid().ToString("P");
            }
            

            try
            {
                Clipboard.Clear();
                Clipboard.SetText(guid);
            }
            catch (Exception ex) {
                label2.Text = "复制到剪切板失败！";
            }
            label1.Text = guid;
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				this.TopMost = true;
			}
			else {
				this.TopMost = false;
			}
		}
	}
}
