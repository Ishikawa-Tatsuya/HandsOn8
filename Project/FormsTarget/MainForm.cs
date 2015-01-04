using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsTarget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonModalessClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                var f = new Form();
                f.Text = i.ToString();
                f.Show(this);
            }
        }

        private void ButtonModalClick(object sender, EventArgs e)
        {
            using (var f = new ModalForm())
            {
                f.ShowDialog(this);
            }
        }

        private void ButtonModalCatenaClick(object sender, EventArgs e)
        {
            using (var f = new ModalForm())
            {
                if (f.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
            }
            using (var f = new ModalForm())
            {
                f.ShowDialog(this);
            }
        }
    }
}
