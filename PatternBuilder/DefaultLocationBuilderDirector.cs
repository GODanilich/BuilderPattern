using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class DefaultLocationBuilderDirector
    {
        private readonly ILocationBuilder _locationBuilder;

        public DefaultLocationBuilderDirector(ILocationBuilder locationBuilder)
        {
            _locationBuilder = locationBuilder;
        }

        public void Build()
        {
            _locationBuilder.BuildBottom(global::PatternBuilder.Properties.Resources.grass)
                            .BuildBackground(global::PatternBuilder.Properties.Resources.skybox1);
        }
    }
}
