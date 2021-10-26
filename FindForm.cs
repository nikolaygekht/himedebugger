using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace himedbg
{
    public partial class FindForm : Form
    {
        public string TextToSearch { get; set; }

        public FindForm()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(TextToSearch))
                textToSearch.Text = TextToSearch;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            TextToSearch = textToSearch.Text;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
