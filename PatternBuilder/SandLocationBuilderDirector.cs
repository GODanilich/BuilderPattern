using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class SandLocationBuilderDirector
    {
        private readonly ILocationBuilder _locationBuilder;
        public SandLocationBuilderDirector(ILocationBuilder locationBuilder)
        {
            _locationBuilder = locationBuilder;
        }

        public void Build()
        {
            _locationBuilder.BuildBottom(global::PatternBuilder.Properties.Resources.sand)
                            .BuildBackground(global::PatternBuilder.Properties.Resources.skybox1);
        }
    }
}
