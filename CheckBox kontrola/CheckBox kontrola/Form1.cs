using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnposalji_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            txtIspis.AppendText("Odabrali ste:" + Environment.NewLine);
            if (chkdoručak.Checked)
                txtIspis.AppendText(chkdoručak.Text + Environment.NewLine);
            if (chkručak.Checked)
                txtIspis.AppendText(chkručak.Text + Environment.NewLine);
            if (chkvečera.Checked)
                txtIspis.AppendText(chkvečera.Text + Environment.NewLine);
        }

        private void chksakrijnarudžbu_CheckedChanged(object sender, EventArgs e)
        {
            if (chksakrijnarudžbu.Checked)
                txtIspis.Hide();
            else
                txtIspis.Show();
        }
    }
}
