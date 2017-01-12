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
            for (int x = 0; x < variables.keyRGBS.GetLength(0); x++)
            {
                variables.keyRGBS[x, 1] = 1;
                variables.keyRGBS[x, 2] = 1;
                variables.keyRGBS[x, 3] = 1;
            }
            variables.setup();

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
            newColour();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            trackBarRed.Value = decimal.ToInt32(numericUpDownRed.Value);
            newColour();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            numericUpDownGreen.Value = trackBarGreen.Value;
            newColour();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            trackBarGreen.Value = decimal.ToInt32(numericUpDownGreen.Value);
            newColour();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            numericUpDownBlue.Value = trackBarBlue.Value;
            newColour();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            trackBarBlue.Value = decimal.ToInt32(numericUpDownBlue.Value);
            newColour();
        }

        private void labelGreen_Click(object sender, EventArgs e)
        {

        }

        private void labelBlue_Click(object sender, EventArgs e)
        {

        }

        public void newColour()
        {
            Graphics g;
            g = this.CreateGraphics();

            variables.R = decimal.ToInt32(numericUpDownRed.Value);
            variables.G = decimal.ToInt32(numericUpDownGreen.Value);
            variables.B = decimal.ToInt32(numericUpDownBlue.Value);
            SolidBrush brushNewColour = new SolidBrush(Color.FromArgb(255, variables.R, variables.G, variables.B));
            g.FillRectangle(brushNewColour, new Rectangle(421, 51, 99, 49));
            g.Dispose();
        }

        public void oldColour()
        {
            Graphics g;
            g = this.CreateGraphics();

            if (variables.onSelect == 1 && variables.clickedKeys.Count != 0)
            { 
                variables.oldR = variables.keyRGBS[variables.clickedKeys.Last(), 0];
                variables.oldG = variables.keyRGBS[variables.clickedKeys.Last(), 1];
                variables.oldB = variables.keyRGBS[variables.clickedKeys.Last(), 2];

            }
            else
            {
                variables.oldR = decimal.ToInt32(numericUpDownRed.Value);
                variables.oldG = decimal.ToInt32(numericUpDownGreen.Value);
                variables.oldB = decimal.ToInt32(numericUpDownBlue.Value);

            }
            SolidBrush brushOldColour = new SolidBrush(Color.FromArgb(255, variables.oldR, variables.oldG, variables.oldB));
            g.FillRectangle(brushOldColour, new Rectangle(421, 101, 99, 49));
            g.Dispose();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            foreach (var key in variables.clickedKeys)
            {
                    variables.keyRGBS[key, 0] = variables.R;
                    variables.keyRGBS[key, 1] = variables.G;
                    variables.keyRGBS[key, 2] = variables.B;
            }
            oldColour();
            keyboardRefresh();
        }

        private void key1_Click(object sender, EventArgs e)
        {
            variables.keyNumber = 1;
            shiftCheck();

            if (variables.clickedKeys.Contains(variables.keyNumber))
            {
                if (variables.shiftPressed == false)
                {
                    keySizeReset();
                    variables.clickedKeys.Add(variables.keyNumber);
                    setSizeLarge();
                }
                else
                {
                    setSizeSmall();
                    variables.clickedKeys.Remove(variables.keyNumber);
                }
            }
            else
            {
                if (variables.shiftPressed == false)
                {
                    keySizeReset();
                }
                variables.clickedKeys.Add(variables.keyNumber);
                setSizeLarge();

            }
            variables.onSelect = 1;
            oldColour();

        }

        public void keySizeReset()
        {
            //this.key1.Location = new Point(200, 300);
            //this.key1.Size = new Size(50, 50);
            //this.key2.Location = new Point(252, 300);
            //this.key2.Size = new Size(50, 50);

            foreach (var key in variables.clickedKeys)
            {
                setSizeSmall();
            }
            variables.clickedKeys.Clear();
        }

        public void shiftCheck()
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                variables.shiftPressed = true;
            }
            else
            {
                variables.shiftPressed = false;
            }

        }

        protected override void OnPaint(PaintEventArgs PaintEvnt) 
           {
            Graphics g;
            g = this.CreateGraphics();
            Pen outline = new Pen(Color.Black);
            g.DrawRectangle(outline, 420, 50, 100, 100);
            g.DrawLine(outline, 420, 100, 520, 100);
            SolidBrush brushNewColour = new SolidBrush(Color.FromArgb(255, variables.R, variables.G, variables.B));
            g.FillRectangle(brushNewColour, new Rectangle(421, 51, 99, 49));
            SolidBrush brushOldColour = new SolidBrush(Color.FromArgb(255, variables.oldR, variables.oldG, variables.oldB));
            g.FillRectangle(brushOldColour, new Rectangle(421, 101, 99, 49));
            g.Dispose();
        }

        public void keyboardRefresh()
        {
            this.key1.BackColor = Color.FromArgb(100, variables.keyRGBS[1, 0], variables.keyRGBS[1, 1], variables.keyRGBS[1, 2]);
            this.key2.BackColor = Color.FromArgb(100, variables.keyRGBS[2, 0], variables.keyRGBS[2, 1], variables.keyRGBS[2, 2]);
        }

        private void key2_Click(object sender, EventArgs e)
        {
            variables.keyNumber = 2;
            shiftCheck();

            if (variables.clickedKeys.Contains(variables.keyNumber))
            {
                if (variables.shiftPressed == false)
                {
                    keySizeReset();
                    variables.clickedKeys.Add(variables.keyNumber);
                    setSizeLarge();
                }
                else
                {
                    setSizeSmall();
                    variables.clickedKeys.Remove(variables.keyNumber);
                }
            }
            else
            {
                if (variables.shiftPressed == false)
                {
                    keySizeReset();
                }
                variables.clickedKeys.Add(variables.keyNumber);
                setSizeLarge();

            }
            variables.onSelect = 1;
            oldColour();
        }

        public void setSizeLarge()
        {
            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = variables.large;

        }

        public void setSizeSmall()
        {
            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = variables.small;

        }
    }

    public class variables
    {
        public static int R = 0;
        public static int G = 0 ;
        public static int B = 0;
        public static int oldR = 0;
        public static int oldG= 0;
        public static int oldB = 0;
        public static int keyNumber = 0;
        public static bool shiftPressed;
        public static int[,] keyRGBS = new int[121, 4];
        public static int onSelect;
        public static int lastKeyPressed;
        public static List<int> clickedKeys = new List<int>();
        public static Size large = new Size(52,52);
        public static Size small = new Size(50, 50);
        public static Point[,] keyLocations = new Point[121,2];

        
        public static void setup()
        {
            keyLocations[1, 0] = new Point(200, 300);
            keyLocations[1, 1] = new Point(199, 299);
            keyLocations[2, 0] = new Point(252, 300);
            keyLocations[2, 1] = new Point(251, 299);
            keyLocations[3, 0] = new Point(304, 300);
            keyLocations[3, 1] = new Point(253, 299);
            keyLocations[4, 0] = new Point(200, 300);
            keyLocations[4, 1] = new Point(199, 299);
            keyLocations[5, 0] = new Point(200, 300);
            keyLocations[5, 1] = new Point(199, 299);
            keyLocations[6, 0] = new Point(200, 300);
            keyLocations[6, 1] = new Point(199, 299);
            keyLocations[7, 0] = new Point(200, 300);
            keyLocations[7, 1] = new Point(199, 299);
            keyLocations[8, 0] = new Point(200, 300);
            keyLocations[8, 1] = new Point(199, 299);

        }


    }
}
