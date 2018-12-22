using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System;

namespace Theory_of_Probability_LAB3
{
    [ToolboxItem(true)]
    public partial class RenderControl : OpenGL
    {
        private IntPtr DC; 
        private IntPtr HWND;
        private IntPtr WGL_CTX;

        public uint DrawMode = GL_LINE_LOOP;
        public List<Figure> F = new List<Figure>();

        public RenderControl()
        {
            InitializeComponent();
            DC = GetDC(hWnd);
            HWND = hWnd;

            WGL_CTX = wglCreateContext(DC);
            wglMakeCurrent(DC, WGL_CTX);
        }

        private void Init()
        {
            glClearColor(BackColor);
            glColor(ForeColor);

            glClearDepth(2000f);
            glEnable(GL_DEPTH_TEST);
            glDepthFunc(GL_LEQUAL);
            glShadeModel(GL_SMOOTH);
            glHint(GL_PERSPECTIVE_CORRECTION_Hint, GL_NICEST);

            glEnable(GL_LIGHTING);
            glLightModelf(GL_LIGHT_MODEL_TWO_SIDE, GL_TRUE);
            glEnable(GL_NORMALIZE);
            glEnable(GL_COLOR_MATERIAL);

            glEnable(GL_BLEND);
            glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);

            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            glOrtho(0, Width + 1, Height + 1, 0, -1f, 1f);

            glLineWidth(1);

            /*LIGHTS*/

            float[] material_diffuse = { 1.0f, 1.0f, 1.0f, 1.0f };
            glMaterialfv(GL_FRONT_AND_BACK, GL_DIFFUSE, material_diffuse);

            float[] light2_diffuse = { 0.4f, 0.7f, 0.2f };
            float[] light2_position = { 250.0f, 250.0f, 1000.0f, 1.0f };

            glEnable(GL_LIGHT2);
            glLightfv(GL_LIGHT2, GL_DIFFUSE, light2_diffuse);
            glLightfv(GL_LIGHT2, GL_POSITION, light2_position);
            glLightf(GL_LIGHT2, GL_CONSTANT_ATTENUATION, 0.0f);
            glLightf(GL_LIGHT2, GL_LINEAR_ATTENUATION, 1.0f);
            glLightf(GL_LIGHT2, GL_QUADRATIC_ATTENUATION, 1.0f);

            glColorMaterial(GL_FRONT, GL_DIFFUSE);
            glColorMaterial(GL_FRONT, GL_SPECULAR);

            glColorMaterial(GL_FRONT_AND_BACK, GL_EMISSION);

            /*LIGHTS*/
        }

        public override void OnRender()
        {
            Init();

            glTranslated(0, 0, 0);

            foreach(Figure FG in F)
            {
                glBegin(FG.DrawMode);

                    glColor3d(FG.C.R, FG.C.G, FG.C.B);

                    foreach(Point P in FG.P)
                        glVertex3d(P.X, P.Y, 0);

                glEnd();
            }

            wglSwapBuffers(DC);
            wglMakeCurrent(DC, WGL_CTX);
        }

        public void Conrolled(CNTRL_ID CID, bool inc)
        {
            switch (CID.ID)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:                    
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}
