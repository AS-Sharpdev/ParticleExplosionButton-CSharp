using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explosion_Button
{
    /// <summary>
    /// A simple particle object with position, velocity, color, and lifetime
    /// </summary>
    public class Particle
    {
        public PointF Position { get; set; }
        public PointF Velocity { get; set; }
        public Color Color { get; set; }

        // Lifetime in frames (default = 100 → ~1.6 seconds at 60 FPS)
        public int Life { get; set; } = 100;
    }
}
