using System;
using System.Collections.Generic;
using System.Text;
#if NETFULL
using System.Drawing.Drawing2D;
using System.Drawing;
#else
using System.DrawingCore.Drawing2D;
using System.DrawingCore;
#endif

namespace Svg.Pathing
{
    public class SvgMoveToSegment : SvgPathSegment
    {
        public SvgMoveToSegment(PointF moveTo)
        {
            this.Start = moveTo;
            this.End = moveTo;
        }

        public override void AddToPath(GraphicsPath graphicsPath)
        {
            graphicsPath.StartFigure();
        }
        
        public override string ToString()
		{
        	return "M" + this.Start.ToSvgString();
		}

    }
}
