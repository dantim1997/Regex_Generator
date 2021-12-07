using Regex_Generator.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Generator
{
    public partial class RegexGenerator : Form
    {
        public RegexGenerator()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var clicked = e.ClickedItem.Name;

            switch (clicked)
            {
                case "uxNumbers": uxCreator.Controls.Clear(); uxCreator.Controls.Add(new Numbers()); break;
                case "uxPhoneNumber": uxCreator.Controls.Clear(); uxCreator.Controls.Add(new PhoneNumer()); break;
            }
        }
    }
}
