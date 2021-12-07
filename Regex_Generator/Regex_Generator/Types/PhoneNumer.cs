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
    public partial class PhoneNumer : UserControl
    {
        public PhoneNumer()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            var regex = string.Empty;
            var preCode = string.Empty;
            if (rbInternational.Checked)
                preCode = "2";
            if (rbCounty.Checked)
                preCode = "2";
            if (rbMobile.Checked)
                preCode = "3";

            var countrynumber = "[0-9]{"+ preCode + "}";
            if(!string.IsNullOrEmpty(uxCountrynum.Text))
            {
                countrynumber = $@"(\b["+uxCountrynum.Text+"]+)";
            }

            if (rbMobile.Checked)
                regex = countrynumber + @"([0-9]{8})\b";
            if (rbCounty.Checked)
                regex = countrynumber + @"([0-9]{7})\b";

            uxResult.Text = regex;
        }
    }
}
