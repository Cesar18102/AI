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
    public partial class Exp : Form
    {
        private RenderControl RC;
        private const int SEC = 25;

        public Exp()
        {
            InitializeComponent();

            RC = new RenderControl();
            RC.Dock = DockStyle.Fill;
            this.Controls.Add(RC);

            aLabel.BackColor = RC.BackColor;

            Render.Start();
        }

        private void Render_Tick(object sender, EventArgs e)
        {
            RC.F.Clear();

            double l = Convert.ToDouble(L.Value);

            /*GENERATING PLAIN FREQUENCY*/

            Figure ExpGenFreq = new Figure(Color.Red, OpenGL.GL_LINE_STRIP);

            List<double> G = new List<double>();

            for (int x = 0; x < RC.Width; x++)
                G.Add(Engine.ExpRand(l));

            G.Sort((Y1, Y2) => Y2 == Y1 ? 0 : (Y2 > Y1 ? -1 : 1));

            double MX = G.Max();
            double MN = G.Min();
            double RNG = (MX - MN) / SEC;

            int[] FREQ = new int[SEC];

            for (int i = 0, x = 0; i < SEC; i++)
                for (; x < G.Count && G[x] - MN < RNG * (i + 1); FREQ[i]++, x++) ;

            double MX_FREQ = FREQ.Max();

            for (int i = 0; i < SEC; i++)
                ExpGenFreq.P.Add(new Point(Convert.ToInt32((i * RC.Width / SEC)), Convert.ToInt32((1 - FREQ[i] * l / MX_FREQ) * RC.Height)));

            RC.F.Add(ExpGenFreq);

            /*GENERATING PLAIN FREQUENCY*/

            /*CALCULATING PLAIN FREQUENCY*/

            Figure ExpFormFreq = new Figure(Color.Blue, OpenGL.GL_LINE_STRIP);

            for (int x = 0; x < RC.Width; x++)
                ExpFormFreq.P.Add(new Point(x - RC.Width / 2, Convert.ToInt32((1 - Engine.ExpDensity((Convert.ToDouble(x) / RC.Width - 0.5) * 5, l)) * RC.Height)));

            RC.F.Add(ExpFormFreq);

            /*CALCULATING PLAIN FREQUENCY*/

            /*GENERATING PLAIN FUNCTION*/

            Figure ExpGenFunc = new Figure(Color.LightCyan, OpenGL.GL_LINE_STRIP);

            int[] FUNC = new int[SEC];

            FUNC[0] = FREQ[0];
            for (int i = 1; i < SEC; FUNC[i] = FUNC[i - 1] + FREQ[i++]) ;

            double MX_FUNC = FUNC.Max();

            for (int i = 0; i < SEC; i++)
                ExpGenFunc.P.Add(new Point(Convert.ToInt32((i * RC.Width / (SEC * l))), Convert.ToInt32((1 - FUNC[i] / MX_FUNC) * RC.Height)));

            ExpGenFunc.P.Add(new Point(RC.Width, 0));

            RC.F.Add(ExpGenFunc);

            /*GENERATING PLAIN FUNCTION*/

            /*CALCULATING PLAIN FUNCTION*/

            Figure ExpFormFunc = new Figure(Color.Yellow, OpenGL.GL_LINE_STRIP);

            for (int x = 0; x < RC.Width; x++)
                ExpFormFunc.P.Add(new Point(x - RC.Width / 2, Convert.ToInt32((1 - Engine.ExpFunc((Convert.ToDouble(x) / RC.Width - 0.5) * 5, l)) * RC.Height)));

            RC.F.Add(ExpFormFunc);

            /*CALCULATING PLAIN FUNCTION*/

            RC.OnRender();
        }
    }
}
