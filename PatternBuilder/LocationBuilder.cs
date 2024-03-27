using PatternBuilder.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace PatternBuilder
{
    public class LocationBuilder : ILocationBuilder
    {
        
        public LocationBuilder(System.Drawing.Image bottom, System.Drawing.Image background) // без паттерна
        {
            _background = new PictureBox();
            _bottom = new PictureBox();
            _background.Image = background;
            _background.Location = new System.Drawing.Point(2, 0);
            _background.Name = "pictureBox2";
            _background.Size = new System.Drawing.Size(797, 329);
            _background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _background.TabIndex = 1;
            _background.TabStop = false;

            _bottom.Image = bottom;
            _bottom.Location = new System.Drawing.Point(2, 322);
            _bottom.Name = "pictureBox1";
            _bottom.Size = new System.Drawing.Size(797, 126);
            _bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _bottom.TabIndex = 0;
            _bottom.TabStop = false;

        }

        public LocationBuilder(System.Drawing.Image bottom)
        {
            _bottom = new PictureBox();
            _bottom.Image = bottom;
            _bottom.Location = new System.Drawing.Point(2, 322);
            _bottom.Name = "pictureBox1";
            _bottom.Size = new System.Drawing.Size(797, 126);
            _bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _bottom.TabIndex = 0;
            _bottom.TabStop = false;
        }

        public LocationBuilder()
        {
            _background = new PictureBox();
            _bottom = new PictureBox();
        }

        private PictureBox _bottom;
        private PictureBox _background;
        public ILocationBuilder BuildBackground(System.Drawing.Image image)
        {
            _background.Image = image;
            _background.Location = new System.Drawing.Point(2, 0);
            _background.Name = "pictureBox2";
            _background.Size = new System.Drawing.Size(797, 329);
            _background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _background.TabIndex = 1;
            _background.TabStop = false;

            return this;
        }

        public ILocationBuilder BuildBottom(System.Drawing.Image image)
        {   
            _bottom.Image = image;
            _bottom.Location = new System.Drawing.Point(2, 322);
            _bottom.Name = "pictureBox1";
            _bottom.Size = new System.Drawing.Size(797, 126);
            _bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _bottom.TabIndex = 0;
            _bottom.TabStop = false;
            return this;
        }

        public ILocationBuilder BuildForeground()
        {
            throw new NotImplementedException();
        }

        public PictureBox GetBottom()
        {
            return _bottom;
        }

        public PictureBox GetBackground() 
        {
            return _background;
        }

        PictureBox ILocationBuilder.GetForeground()
        {
            throw new NotImplementedException();
        }
    }
}
