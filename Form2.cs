using System;
using System.Windows.Forms;

namespace test_for_cody
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public GroupBox get_form_data() {
            return (GroupBox)Controls.Find("gb_from_another_form",true)[0];
        }
    }
}
