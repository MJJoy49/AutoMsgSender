using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMsg
{
    public partial class UnlockDetails : Form
    {
        public UnlockDetails()
        {
            InitializeComponent();
        }

        private void CloseDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
