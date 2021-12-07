using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Generator.Types
{
    public partial class Numbers : UserControl
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            var maxInt = uxMax.Value;
            var minInt = uxMin.Value;

            string exceptions = string.Empty;
            foreach (var item in uxExceptions.Items)
            {
                exceptions += $"|{item}";
            }

            var regex = $"[{minInt}-{maxInt}]{exceptions}";

            uxResult.Text = regex;
        }

        private void uxAddException_Click(object sender, EventArgs e)
        {
            uxExceptions.Items.Add(uxException.Value);
        }
    }
}
