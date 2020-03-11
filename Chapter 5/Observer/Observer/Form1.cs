using Observer.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using IObserver = Observer.Interfaces.IObserver;

namespace Observer
{
    public partial class Form1 : Form, IObserver
    {
        private delegate void BitmapParameterDelegate(Bitmap image);

        private readonly ClockTimer timerSubject;

        private readonly int[,] digits = new int[10, 7]
        {
            // consequently sets top, top left, top right, middle,
            // botom left, bottom right and bottom segments of 7-segment digit.
            {1, 1, 1, 0, 1, 1, 1},
            {0, 0, 1, 0, 0, 1, 0},
            {1, 0, 1, 1, 1, 0, 1},
            {1, 0, 1, 1, 0, 1, 1},
            {0, 1, 1, 1, 0, 1, 0},
            {1, 1, 0, 1, 0, 1, 1},
            {1, 1, 0, 1, 1, 1, 1},
            {1, 0, 1, 0, 0, 1, 0},
            {1, 1, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 1}
        };

        private readonly PointF[][] segments = new PointF[][]
        {
            // Top segment
            new[] { new PointF(7.0F, 6.0F), new PointF(11.0F, 2.0F), new PointF(31.0F, 2.0F), new PointF(35.0F, 6.0F), new PointF(31.0F, 10.0F), new PointF(11.0F, 10.0F) },
            // Top-left segment
            new[] { new PointF(6.0F, 7.0F), new PointF(10.0F, 11.0F), new PointF(10.0F, 31.0F), new PointF(6.0F, 35.0F), new PointF(2.0F, 31.0F), new PointF(2.0F, 11.0F) },
            // Top-right segment
            new[] { new PointF(36.0F, 7.0F), new PointF(40.0F, 11.0F), new PointF(40.0F, 31.0F), new PointF(36.0F, 35.0F), new PointF(32.0F, 31.0F), new PointF(32.0F, 11.0F) },
            // Middle horizontal segment
            new[] { new PointF(7.0F, 36.0F), new PointF(11.0F, 32.0F), new PointF(31.0F, 32.0F), new PointF(35.0F, 36.0F), new PointF(31.0F, 40.0F), new PointF(11.0F, 40.0F) },
            // Bottom-left segment
            new[] { new PointF(6.0F, 37.0F), new PointF(10.0F, 41.0F), new PointF(10.0F, 61.0F), new PointF(6.0F, 65.0F), new PointF(2.0F, 61.0F), new PointF(2.0F, 41.0F) },
            // Bottom-right segment
            new[] { new PointF(36.0F, 37.0F), new PointF(40.0F, 41.0F), new PointF(40.0F, 61.0F), new PointF(36.0F, 65.0F), new PointF(32.0F, 61.0F), new PointF(32.0F, 41.0F) },
            // Bottom segment
            new[] { new PointF(7.0F, 66.0F), new PointF(11.0F, 62.0F), new PointF(31.0F, 62.0F), new PointF(35.0F, 66.0F), new PointF(31.0F, 70.0F), new PointF(11.0F, 70.0F) },
        };

        public Form1(ISubject subject)
        {
            InitializeComponent();
            if (subject is ClockTimer timerSubject)
            {
                this.timerSubject = timerSubject;
            }
            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            if (subject == this.timerSubject)
            {
                Bitmap buffer;
                buffer = new Bitmap(this.Width, this.Height);
                using (Graphics g = Graphics.FromImage(buffer))
                {
                    DisplayDigit(g, Pens.Black, timerSubject.SecondsPassed() % 10);
                }

                if (this.InvokeRequired)
                {
                    // We are not in the UI thread, so we need to call BeginInvoke.
                    BeginInvoke(new BitmapParameterDelegate(UpdateBackground), new[] { buffer });
                }
                else
                {
                    // Must be in the UI thread if we've got this far.
                    UpdateBackground(buffer);
                }
            }
        }

        #region Helper methods

        private void DisplayDigit(Graphics g, Pen p, int number)
        {
            if (number >= 10 || number < 0)
            {
                throw new ArgumentException(nameof(number));
            }

            for (int i = 0; i != 7; ++i)
            {
                if (digits[number, i] != 0)
                {
                    g.DrawPolygon(p, segments[i]);
                }
            }
        }

        private void UpdateBackground(Bitmap image)
        {
            this.BackgroundImage = image;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            timerSubject.Detach(this);
        }
    }
}
