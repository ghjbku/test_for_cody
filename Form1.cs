using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_for_cody
{
    public partial class Form1 : Form
    {
        private GroupBox old_scene;
        private GroupBox new_scene;
        public Form1()
        {
            InitializeComponent();
        }

        private void last_scene_MouseClick(object sender, MouseEventArgs e)
        {
            start_fade_out();
            Controls.Remove(new_scene);
            old_scene.Parent = this;
;
        }

        private void next_scene_MouseClick(object sender, MouseEventArgs e)
        {
            new_scene = get_gb_from_Form2();
            start_fade_out();
            save_old_scene();
            Controls.Remove(Controls.Find("old_gb", true)[0]);
            new_scene.Parent = this;
        }

        private void save_old_scene() {
            old_scene = (GroupBox)Controls.Find("old_gb", true)[0];
        }

        private void start_fade_out() {
            PictureBox pb = (PictureBox)Controls.Find("pb_1", true)[0];
            change_img_visible(pb,true);
            loop_til_max_width(pb);
            change_img_visible(pb, false);
        }

        private void change_img_visible(PictureBox pb,Boolean val) {
           pb.Visible = val;
        }

        private void loop_til_max_width(PictureBox pb) {
                for (int i = 14; i < this.Width; i += 15)
                {
                    pb.Width = i;
                    Task.Delay(5).Wait();
                }
        }

        private GroupBox get_gb_from_Form2()
        {
            Form2 form = new Form2();
            return form.get_form_data();
        }


    }
}
