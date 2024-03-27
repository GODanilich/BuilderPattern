using PatternBuilder.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternBuilder
{
    public interface ILocationBuilder
    {
        ILocationBuilder BuildBottom(Image image);
        
        ILocationBuilder BuildForeground();

        ILocationBuilder BuildBackground(Image image);

        PictureBox GetBottom();

        PictureBox GetBackground();

        PictureBox GetForeground();
    }
}
