using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternBuilder
{
    public partial class Form1 : Form
    {

        private int state = 1;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = global::PatternBuilder.Properties.Resources.sand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                var l = new LocationBuilder();
                var sand = new SandLocationBuilderDirector(l);
                sand.Build();
                pictureBox1.Image = l.GetBottom().Image;
                pictureBox2.Image = l.GetBackground().Image;
                state = 2;
            }
            else
            {
                var l = new LocationBuilder();
                var def = new DefaultLocationBuilderDirector(l);
                def.Build();
                pictureBox1.Image = l.GetBottom().Image;
                pictureBox2.Image = l.GetBackground().Image;
                state = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
