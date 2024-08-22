using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScompany
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ประเภทสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemType from = new itemType();
            from.Show();
        }

        private void สนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            item from = new item();
            from.Show();
            
        }

        private void ลกคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer from = new customer();
            from.Show();
        }

        private void แผนกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department from = new department();
            from.Show();
        }

        private void พนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee from = new employee();
            from.Show();
        }
    }
}
