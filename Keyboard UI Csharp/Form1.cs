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
                variables.keyRGBS[x, 0] = 1;
                variables.keyRGBS[x, 1] = 1;
                variables.keyRGBS[x, 2] = 1;
            }
            variables.setup();

        }

        private void Form1_Load(object sender, EventArgs e)
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
        
        private void key_Click(object sender, EventArgs e)
        {
            PictureBox key = sender as PictureBox;
            variables.keyNumber = Convert.ToInt32(key.Tag);
            if (Control.ModifierKeys == Keys.Shift)
            {
                variables.shiftPressed = true;
            }
            else
            {
                variables.shiftPressed = false;
            }
            if (variables.clickedKeys.Contains(variables.keyNumber))
            {
                if (variables.shiftPressed == false)
                {
                    keySizeReset();
                    variables.clickedKeys.Add(variables.keyNumber);
                    setSize("large");
                }
                else
                {
                    setSize("small");
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
                setSize("large");

            }
            variables.onSelect = 1;
            oldColour();
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
            foreach (var key in variables.clickedKeys)
            {
                this.Controls.Find("key" + key, true)[0].BackColor = Color.FromArgb(100, variables.keyRGBS[key, 0], variables.keyRGBS[key, 1], variables.keyRGBS[key, 2]);
            }
        }
        
        public void keySizeReset()
        {
            foreach (var key in variables.clickedKeys)
            {
                this.Controls.Find("key" + key, true)[0].Location = variables.keyLocations[key, 0];
                this.Controls.Find("key" + key, true)[0].Size = variables.small;
            }
            variables.clickedKeys.Clear();
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

        public void setSize(string size)
        {
            if (size == "large")
            {
                this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                this.Controls.Find("key" + variables.keyNumber, true)[0].Size = variables.large;
            }
            else if(size == "small")
            {
                this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                this.Controls.Find("key" + variables.keyNumber, true)[0].Size = variables.small;
            }
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
            keyLocations[1, 0] = new Point(50, 260);
            keyLocations[1, 1] = new Point(49, 259);
            keyLocations[2, 0] = new Point(115, 260);
            keyLocations[2, 1] = new Point(114, 259);
            keyLocations[3, 0] = new Point(167, 260); 
            keyLocations[3, 1] = new Point(166, 259);
            keyLocations[4, 0] = new Point(219, 260); 
            keyLocations[4, 1] = new Point(218, 259);
            keyLocations[5, 0] = new Point(271, 260); 
            keyLocations[5, 1] = new Point(270, 259);
            keyLocations[6, 0] = new Point(336, 260); 
            keyLocations[6, 1] = new Point(335, 259);
            keyLocations[7, 0] = new Point(388, 260); 
            keyLocations[7, 1] = new Point(387, 259);
            keyLocations[8, 0] = new Point(440, 260); 
            keyLocations[8, 1] = new Point(439, 259);
            keyLocations[9, 0] = new Point(492, 260); 
            keyLocations[9, 1] = new Point(491, 259);
            keyLocations[10, 0] = new Point(557, 260); 
            keyLocations[10, 1] = new Point(556, 259);
            keyLocations[11, 0] = new Point(609, 260);
            keyLocations[11, 1] = new Point(608, 259);
            keyLocations[12, 0] = new Point(661, 260); 
            keyLocations[12, 1] = new Point(660, 259);
            keyLocations[13, 0] = new Point(713, 260); 
            keyLocations[13, 1] = new Point(712, 259);

        }
    }
}
