using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory_of_Probability_LAB3
{
    public partial class Plain : Form
    {
        private RenderControl RC;
        private const int SEC = 2;

        public Plain()
        {
            InitializeComponent();

            SetBorders();

            RC = new RenderControl();
            RC.Dock = DockStyle.Fill;
            this.Controls.Add(RC);

            aLabel.BackColor = RC.BackColor;
            bLabel.BackColor = RC.BackColor;

            Render.Start();
        }

        private void SetBorders()
        {
            aVal.Maximum = Convert.ToInt32(bVal.Value) - 1;
            bVal.Minimum = Convert.ToInt32(aVal.Value) + 1;
        }

        private void BorderChanged(object sender, EventArgs e)
        {
            SetBorders();
        }

        private void Render_Tick(object sender, EventArgs e)
        {

            RC.F.Clear();

            int a = Convert.ToInt32(aVal.Value);
            int b = Convert.ToInt32(bVal.Value);

            /*GENERATING PLAIN FUNCTION*/

            Figure PlainGenFunc = new Figure(Color.Red, OpenGL.GL_LINE_STRIP);

            List<double> G = new List<double>();

            for (int x = 0; x < RC.Width; x++)
                G.Add(Engine.PlainRand(a, b));

            G.Sort((Y1, Y2) => Y2 == Y1 ? 0 : (Y2 > Y1 ? -1 : 1));

            for (int i = 0; i < G.Count; i++)
                PlainGenFunc.P.Add(new Point(i, Convert.ToInt32((1 - G[i]) * RC.Height)));

            RC.F.Add(PlainGenFunc);

            /*GENERATING PLAIN FUNCTION*/

            /*CALCULATING PLAIN FUNCTION*/

            Figure PlainFormFunc = new Figure(Color.Blue, OpenGL.GL_LINE_STRIP);

            for (int x = 0; x < RC.Width; x++)
                PlainFormFunc.P.Add(new Point(x, Convert.ToInt32((1 - Engine.PlainFunc(Convert.ToDouble(x) / RC.Width, a, b)) * RC.Height)));

            RC.F.Add(PlainFormFunc);

            /*CALCULATING PLAIN FUNCTION*/

            /*GENERATING PLAIN FREQUENCY*/

            double MX = G.Max();
            double MN = G.Min();
            double D = (MX - MN) / SEC;

            int[] FREQ = new int[SEC];

            for (int i = 0, x = 0; i < SEC; i++)
                for (; x < G.Count && G[x] - MN < D * (i + 1); FREQ[i]++, x++) ;

            Figure PlainGenFreq = new Figure(Color.Brown, OpenGL.GL_LINE_STRIP);

            for (int i = 0; i < SEC; i++) {

                double ShouldBeBySector = (double)G.Count / SEC;
                PlainGenFreq.P.Add(new Point((int)(i * RC.Width / SEC), Convert.ToInt32((1 - FREQ[i] / (ShouldBeBySector * 2.0)) * RC.Height)));
            }

            PlainGenFreq.P.Add(new Point(RC.Width, Convert.ToInt32(0.5 * RC.Height)));

            RC.F.Add(PlainGenFreq);

            /*GENERATING PLAIN FREQUENCY*/

            /*CALCULATING PLAIN FREQUENCY*/

            Figure PlainFormFreq = new Figure(Color.Yellow, OpenGL.GL_LINE_STRIP);

            for (int i = 0; i < SEC; i++)
                PlainFormFreq.P.Add(new Point((int)(i * RC.Width / SEC), Convert.ToInt32(0.5 * RC.Height)));

            PlainFormFreq.P.Add(new Point(RC.Width, Convert.ToInt32(0.5 * RC.Height)));

            RC.F.Add(PlainFormFreq);

            /*CALCULATING PLAIN FREQUENCY*/

            RC.OnRender();
        }
    }
}
