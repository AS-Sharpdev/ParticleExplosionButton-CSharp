using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explosion_Button
{
    // Main form that contains a button which "explodes" into particles when clicked
    public partial class Form1 : Form
    {
        // List of all particles currently on the screen
        private List<Particle> particles = new List<Particle>();

        // Timer to update particle positions (approx. 60 FPS)
        private Timer timer = new Timer();

        // The button that will trigger the explosion
        Button btn;

        public Form1()
        {
            InitializeComponent();

            // Create a button dynamically
            btn = new Button();
            btn.Text = "Boomm!";
            btn.Location = new Point(150, 100);
            btn.Click += Btn_Click;   // Event: when the button is clicked
            this.Controls.Add(btn);

            // Timer setup (16 ms ≈ 60 updates per second)
            timer.Interval = 16;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Enable double buffering to reduce flickering when repainting
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// Timer tick event updates all particles:
        /// - Moves particles
        /// - Applies gravity
        /// - Removes particles when their lifetime ends
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = particles.Count - 1; i >= 0; i--)
            {
                // Update particle position
                particles[i].Position = new PointF(
                    particles[i].Position.X + particles[i].Velocity.X,
                    particles[i].Position.Y + particles[i].Velocity.Y
                );

                // Apply gravity (increasing Y velocity)
                particles[i].Velocity = new PointF(
                    particles[i].Velocity.X,
                    particles[i].Velocity.Y + 0.2f
                );

                // Decrease lifetime
                particles[i].Life--;

                // Remove particle if lifetime is over
                if (particles[i].Life <= 0)
                    particles.RemoveAt(i);
            }

            // Force form to redraw (calls OnPaint)
            this.Invalidate();
        }

        /// <summary>
        /// Button click event → creates an "explosion" of particles
        /// </summary>
        private void Btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Generate 50 particles with random direction, speed, and color
            for (int i = 0; i < 50; i++)
            {
                particles.Add(new Particle
                {
                    // Start at the button’s location
                    Position = btn.Location,

                    // Random velocity (spread effect)
                    Velocity = new PointF(
                        (float)(rnd.NextDouble() * 6 - 3), // X between -3 and +3
                        (float)(rnd.NextDouble() * -6)     // Y negative (upwards)
                    ),

                    // Random color
                    Color = Color.FromArgb(
                        rnd.Next(256),
                        rnd.Next(256),
                        rnd.Next(256)
                    )
                });
            }
        }

        /// <summary>
        /// Draw all active particles as small colored circles
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var p in particles)
            {
                using (Brush b = new SolidBrush(p.Color))
                    e.Graphics.FillEllipse(b, p.Position.X, p.Position.Y, 5, 5);
            }
        }
    }
}
