using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOPDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtRoomNumber.Clear();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text.Trim()) && !String.IsNullOrEmpty(txtRoomNumber.Text.Trim()))
                CoreBusiness.Describe(txtName.Text.Trim(), txtRoomNumber.Text.Trim());
            else
                MessageBox.Show("信息不完整", "提示");
        }

    }
}
