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
    public partial class Normal : Form
    {
        private RenderControl RC;
        private const int SEC = 25;

        public Normal()
        {
            InitializeComponent();

            RC = new RenderControl();
            RC.Dock = DockStyle.Fill;
            this.Controls.Add(RC);

            aLabel.BackColor = RC.BackColor;
            bLabel.BackColor = RC.BackColor;

            Render.Start();
        }

        private void Render_Tick(object sender, EventArgs e) {

            RC.F.Clear();

            double M = Convert.ToDouble(MathExpect.Value);
            double D = Convert.ToDouble(Deviation.Value);

            /*GENERATING PLAIN FREQUENCY*/

            Figure NormalGenFreq = new Figure(Color.Red, OpenGL.GL_LINE_STRIP);

            List<double> G = new List<double>();

            for (int x = 0; x < RC.Width; x++)
            {
                double[] Z = Engine.NormalRand(M, D);
                G.Add(Z[0]);
                G.Add(Z[1]);
            }

            G.Sort((Y1, Y2) => Y2 == Y1 ? 0 : (Y2 > Y1 ? -1 : 1));

            double MX = G.Max();
            double MN = G.Min();
            double RNG = (MX - MN) / SEC;

            int[] FREQ = new int[SEC];

            for (int i = 0, x = 0; i < SEC; i++)
                for (; x < G.Count && G[x] - MN < RNG * (i + 1); FREQ[i]++, x++) ;

            double MX_FREQ = FREQ.Max();

            for (int i = 0; i < SEC; i++)
                NormalGenFreq.P.Add(new Point(Convert.ToInt32((i * RC.Width / SEC) + M * RC.Width / 10), Convert.ToInt32((1 - FREQ[i] / (MX_FREQ * D * Math.Sqrt(2 * Math.PI))) * RC.Height)));

            RC.F.Add(NormalGenFreq);

            /*GENERATING PLAIN FREQUENCY*/

            /*CALCULATING PLAIN FREQUENCY*/

            Figure NormalFormFreq = new Figure(Color.Blue, OpenGL.GL_LINE_STRIP);

            for (int x = 0; x < RC.Width; x++)
                NormalFormFreq.P.Add(new Point(x, Convert.ToInt32((1 - Engine.NormalDensity((Convert.ToDouble(x) / RC.Width - 0.5) * 10, M, D)) * RC.Height)));

            RC.F.Add(NormalFormFreq);

            /*CALCULATING PLAIN FREQUENCY*/

            /*GENERATING PLAIN FUNCTION*/

            Figure NormalGenFunc = new Figure(Color.LightCyan, OpenGL.GL_LINE_STRIP);

            int[] FUNC = new int[SEC];

            FUNC[0] = FREQ[0];
            for (int i = 1; i < SEC; FUNC[i] = FUNC[i - 1] + FREQ[i++]) ;

            double MX_FUNC = FUNC.Max();

            for (int i = 0; i < SEC; i++)
                NormalGenFunc.P.Add(new Point(Convert.ToInt32((i * RC.Width / SEC) * Math.Sqrt(D) + M * RC.Width / 10), Convert.ToInt32((1 - FUNC[i] / MX_FUNC) * RC.Height)));

            NormalGenFunc.P.Add(new Point(RC.Width, 0));

            RC.F.Add(NormalGenFunc);

            /*GENERATING PLAIN FUNCTION*/

            /*CALCULATING PLAIN FUNCTION*/

            Figure NormalFormFunc = new Figure(Color.Yellow, OpenGL.GL_LINE_STRIP);

            for (int x = 0; x < RC.Width; x++)
                NormalFormFunc.P.Add(new Point(x, Convert.ToInt32((1 - Engine.NormalFunc((Convert.ToDouble(x) / RC.Width - 0.5) * 10, M, D)) * RC.Height)));

            RC.F.Add(NormalFormFunc);

            /*CALCULATING PLAIN FUNCTION*/

            RC.OnRender();
        }
    }
}
