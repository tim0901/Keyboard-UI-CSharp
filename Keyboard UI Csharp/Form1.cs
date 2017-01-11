using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Keyboard_UI_Csharp
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            for (int x = 0; x < variables.selectedKeys.Length; x++)
            {
                variables.selectedKeys[0] = 0;
            }
            for (int x = 0; x < variables.keyRGBS.GetLength(0); x++)
            {
                variables.keyRGBS[x, 1] = 1;
                variables.keyRGBS[x, 2] = 1;
                variables.keyRGBS[x, 3] = 1;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            numericUpDownRed.Value = trackBarRed.Value;
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            trackBarRed.Value = decimal.ToInt32(numericUpDownRed.Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            numericUpDownGreen.Value = trackBarGreen.Value;
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            trackBarGreen.Value = decimal.ToInt32(numericUpDownGreen.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            numericUpDownBlue.Value = trackBarBlue.Value;
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            trackBarBlue.Value = decimal.ToInt32(numericUpDownBlue.Value);
        }

        private void labelGreen_Click(object sender, EventArgs e)
        {

        }

        private void labelBlue_Click(object sender, EventArgs e)
        {

        }

        public void newColour(int one, int two, int three, int four)
        {
            Graphics g;
            g = this.CreateGraphics();
            variables.R = 1;
            variables.G = 1;
            variables.B = 1;
            SolidBrush brushNewColour = new SolidBrush(Color.FromArgb(255, variables.R, variables.G, variables.B));
            g.FillRectangle(brushNewColour, new Rectangle(one, two, three, four));
            g.Dispose();

        }

        public void oldColour(int one, int two, int three, int four)
        {
            Graphics g;
            g = this.CreateGraphics();
            variables.oldR = 1;
            variables.oldG = 1;
            variables.oldB = 1;
            SolidBrush brushOldColour = new SolidBrush(Color.FromArgb(255, variables.oldR, variables.oldG, variables.oldB));
            g.FillRectangle(brushOldColour, new Rectangle(one, two, three, four));
            g.Dispose();
            int s;


        }

    }

    public class variables
    {
        public static int R;
        public static int G;
        public static int B;
        public static int oldR;
        public static int oldG;
        public static int oldB;
        public static int keyNumber;

        public static bool shiftPressed;
        public static int[] selectedKeys = new int[121];
        public static int[,] keyRGBS = new int[121, 4];


    }
}
