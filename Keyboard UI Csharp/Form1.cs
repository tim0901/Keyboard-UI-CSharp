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
                    switch (variables.keyNumber)
                    {
                        case 40:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(104, 52);
                            break;
                        case 49:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 62:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(91, 104);
                            break;
                        case 69:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(52, 104);
                            break;
                        case 71:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(77, 52);
                            break;
                        case 88:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 100:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(143, 52);
                            break; ;
                        case 105:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(52, 104);
                            break;
                        case 107:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 108:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 109:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 110:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(325, 52);
                            break;
                        case 111:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 112:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 113:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 114:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                            break;
                        case 118:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(104, 52);
                            break;
                        default:
                            setSize("large");
                            break;

                    }
                }
                else
                {
                    switch (variables.keyNumber)
                    {
                        case 40:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(102, 50);
                            break;
                        case 49:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 62:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(89, 102);
                            break;
                        case 69:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(50, 102);
                            break;
                        case 71:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(75, 50);
                            break;
                        case 88:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 100:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(141, 50);
                            break;
                        case 105:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + key, true)[0].Size = new Size(50, 102);
                            break;
                        case 107:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 108:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 109:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 110:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(323, 50);
                            break;
                        case 111:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 112:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 113:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 114:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(63, 50);
                            break;
                        case 118:
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 0];
                            this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(102, 50);
                            break;
                        default:
                            setSize("small");
                            break;

                    }
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
                switch(variables.keyNumber)
                {
                    case 40:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(104, 52);
                        break;
                    case 49:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 62:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(91, 104);
                        break;
                    case 69:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(52, 104);
                        break;
                    case 71:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(77, 52);
                        break;
                    case 88:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 100:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(143, 52);
                        break; ;
                    case 105:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(52, 104);
                        break;
                    case 107:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 108:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 109:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 110:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(325, 52);
                        break;
                    case 111:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 112:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 113:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 114:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(65, 52);
                        break;
                    case 118:
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Location = variables.keyLocations[variables.keyNumber, 1];
                        this.Controls.Find("key" + variables.keyNumber, true)[0].Size = new Size(104, 52);
                        break;
                    default:
                        setSize("large");
                        break;

                }

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
                int keySwitch = key;
                switch (keySwitch)
                {
                    case 40:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(102, 50);
                        break;
                    case 49:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 62:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(89, 102);
                        break;
                    case 69:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(50, 102);
                        break;
                    case 71:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(75, 50);
                        break;
                    case 88:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 100:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(143, 52);
                        break;
                    case 105:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(50, 102);
                        break;
                    case 107:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 108:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 109:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 110:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(323, 50);
                        break;
                    case 111:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 112:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 113:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 114:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(63, 50);
                        break;
                    case 118:
                        this.Controls.Find("key" + key, true)[0].Size = new Size(102, 50);
                        break;
                    default:
                        this.Controls.Find("key" + key, true)[0].Size = variables.small;
                        break;
                }
                this.Controls.Find("key" + key, true)[0].Location = variables.keyLocations[key, 0];
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
            keyLocations[3, 0] = new Point(202, 260);
            keyLocations[3, 1] = new Point(201, 259);
            keyLocations[4, 0] = new Point(254, 260); 
            keyLocations[4, 1] = new Point(253, 259);
            keyLocations[5, 0] = new Point(306, 260); 
            keyLocations[5, 1] = new Point(305, 259);
            keyLocations[6, 0] = new Point(358, 260); 
            keyLocations[6, 1] = new Point(357, 259);
            keyLocations[7, 0] = new Point(444, 260); 
            keyLocations[7, 1] = new Point(443, 259);
            keyLocations[8, 0] = new Point(496, 260); 
            keyLocations[8, 1] = new Point(495, 259);
            keyLocations[9, 0] = new Point(548, 260); 
            keyLocations[9, 1] = new Point(547, 259);
            keyLocations[10, 0] = new Point(600, 260); 
            keyLocations[10, 1] = new Point(599, 259);
            keyLocations[11, 0] = new Point(687, 260); 
            keyLocations[11, 1] = new Point(686, 259);
            keyLocations[12, 0] = new Point(739, 260);
            keyLocations[12, 1] = new Point(738, 259);
            keyLocations[13, 0] = new Point(791, 260); 
            keyLocations[13, 1] = new Point(790, 259);
            keyLocations[14, 0] = new Point(843, 260); 
            keyLocations[14, 1] = new Point(842, 259);
            keyLocations[15, 0] = new Point(929, 260);
            keyLocations[15, 1] = new Point(928, 259);
            keyLocations[16, 0] = new Point(981, 260);
            keyLocations[16, 1] = new Point(980, 259);
            keyLocations[17, 0] = new Point(1033, 260);
            keyLocations[17, 1] = new Point(1033, 259);
            keyLocations[18, 0] = new Point(1119, 208);
            keyLocations[18, 1] = new Point(1118, 207);
            keyLocations[19, 0] = new Point(1171, 208);
            keyLocations[19, 1] = new Point(1170, 207);
            keyLocations[20, 0] = new Point(1223, 208);
            keyLocations[20, 1] = new Point(1222, 207);
            keyLocations[21, 0] = new Point(1275, 208);
            keyLocations[21, 1] = new Point(1274, 207);
            keyLocations[22, 0] = new Point(1119, 260);
            keyLocations[22, 1] = new Point(1118, 259);
            keyLocations[23, 0] = new Point(1171, 260);
            keyLocations[23, 1] = new Point(1170, 259);
            keyLocations[24, 0] = new Point(1223, 260);
            keyLocations[24, 1] = new Point(1222, 259);
            keyLocations[25, 0] = new Point(1275, 260);
            keyLocations[25, 1] = new Point(1274, 259);
            keyLocations[26, 0] = new Point(50, 330);
            keyLocations[26, 1] = new Point(49, 329);
            keyLocations[27, 0] = new Point(115, 330);
            keyLocations[27, 1] = new Point(114, 329);
            keyLocations[28, 0] = new Point(167, 330);
            keyLocations[28, 1] = new Point(166, 329);
            keyLocations[29, 0] = new Point(219, 330);
            keyLocations[29, 1] = new Point(218, 329);
            keyLocations[30, 0] = new Point(271, 330);
            keyLocations[30, 1] = new Point(270, 329);
            keyLocations[31, 0] = new Point(323, 330);
            keyLocations[31, 1] = new Point(322, 329);
            keyLocations[32, 0] = new Point(375, 330);
            keyLocations[32, 1] = new Point(374, 329);
            keyLocations[33, 0] = new Point(427, 330);
            keyLocations[33, 1] = new Point(426, 329);
            keyLocations[34, 0] = new Point(479, 330);
            keyLocations[34, 1] = new Point(478, 329);
            keyLocations[35, 0] = new Point(531, 330);
            keyLocations[35, 1] = new Point(530, 329);
            keyLocations[36, 0] = new Point(583, 330);
            keyLocations[36, 1] = new Point(582, 329);
            keyLocations[37, 0] = new Point(635, 330);
            keyLocations[37, 1] = new Point(634, 329);
            keyLocations[38, 0] = new Point(687, 330);
            keyLocations[38, 1] = new Point(686, 329);
            keyLocations[39, 0] = new Point(739, 330);
            keyLocations[39, 1] = new Point(738, 329);
            keyLocations[40, 0] = new Point(791, 330);
            keyLocations[40, 1] = new Point(790, 329);
            keyLocations[41, 0] = new Point(929, 330);
            keyLocations[41, 1] = new Point(928, 329);
            keyLocations[42, 0] = new Point(981, 330);
            keyLocations[42, 1] = new Point(980, 329);
            keyLocations[43, 0] = new Point(1033, 330);
            keyLocations[43, 1] = new Point(1033, 329);
            keyLocations[44, 0] = new Point(1119, 330);
            keyLocations[44, 1] = new Point(1118, 329);
            keyLocations[45, 0] = new Point(1171, 330);
            keyLocations[45, 1] = new Point(1170, 329);
            keyLocations[46, 0] = new Point(1223, 330);
            keyLocations[46, 1] = new Point(1222, 329);
            keyLocations[47, 0] = new Point(1275, 330);
            keyLocations[47, 1] = new Point(1274, 329);
            keyLocations[48, 0] = new Point(50, 382);
            keyLocations[48, 1] = new Point(49, 381);
            keyLocations[49, 0] = new Point(115, 382);
            keyLocations[49, 1] = new Point(114, 381);
            keyLocations[50, 0] = new Point(180, 382);
            keyLocations[50, 1] = new Point(179, 381);
            keyLocations[51, 0] = new Point(232, 382);
            keyLocations[51, 1] = new Point(231, 381);
            keyLocations[52, 0] = new Point(284, 382);
            keyLocations[52, 1] = new Point(283, 381);
            keyLocations[53, 0] = new Point(336, 382);
            keyLocations[53, 1] = new Point(335, 381);
            keyLocations[54, 0] = new Point(388, 382);
            keyLocations[54, 1] = new Point(387, 381);
            keyLocations[55, 0] = new Point(440, 382);
            keyLocations[55, 1] = new Point(439, 381);
            keyLocations[56, 0] = new Point(492, 382);
            keyLocations[56, 1] = new Point(491, 381);
            keyLocations[57, 0] = new Point(544, 382);
            keyLocations[57, 1] = new Point(543, 381);
            keyLocations[58, 0] = new Point(596, 382);
            keyLocations[58, 1] = new Point(595, 381);
            keyLocations[59, 0] = new Point(648, 382);
            keyLocations[59, 1] = new Point(647, 381);
            keyLocations[60, 0] = new Point(700, 382);
            keyLocations[60, 1] = new Point(699, 381);
            keyLocations[61, 0] = new Point(752, 382);
            keyLocations[61, 1] = new Point(751, 381);
            keyLocations[62, 0] = new Point(804, 382);
            keyLocations[62, 1] = new Point(803, 381);
            keyLocations[63, 0] = new Point(929, 382);
            keyLocations[63, 1] = new Point(928, 381);
            keyLocations[64, 0] = new Point(981, 382);
            keyLocations[64, 1] = new Point(980, 381);
            keyLocations[65, 0] = new Point(1033, 382);
            keyLocations[65, 1] = new Point(1032, 381);
            keyLocations[66, 0] = new Point(1119, 382);
            keyLocations[66, 1] = new Point(1118, 381);
            keyLocations[67, 0] = new Point(1171, 382);
            keyLocations[67, 1] = new Point(1170, 381);
            keyLocations[68, 0] = new Point(1223, 382);
            keyLocations[68, 1] = new Point(1222, 381);
            keyLocations[69, 0] = new Point(1275, 382);
            keyLocations[69, 1] = new Point(1274, 381);
            keyLocations[70, 0] = new Point(50, 434);
            keyLocations[70, 1] = new Point(49, 433);
            keyLocations[71, 0] = new Point(115, 434);
            keyLocations[71, 1] = new Point(114, 433);
            keyLocations[72, 0] = new Point(192, 434);
            keyLocations[72, 1] = new Point(191, 433);
            keyLocations[73, 0] = new Point(244, 434);
            keyLocations[73, 1] = new Point(243, 433);
            keyLocations[74, 0] = new Point(296, 434);
            keyLocations[74, 1] = new Point(295, 433);
            keyLocations[75, 0] = new Point(348, 434);
            keyLocations[75, 1] = new Point(347, 433);
            keyLocations[76, 0] = new Point(400, 434);
            keyLocations[76, 1] = new Point(399, 433);
            keyLocations[77, 0] = new Point(452, 434);
            keyLocations[77, 1] = new Point(451, 433);
            keyLocations[78, 0] = new Point(504, 434);
            keyLocations[78, 1] = new Point(503, 433);
            keyLocations[79, 0] = new Point(556, 434);
            keyLocations[79, 1] = new Point(555, 433);
            keyLocations[80, 0] = new Point(608, 434);
            keyLocations[80, 1] = new Point(607, 433);
            keyLocations[81, 0] = new Point(660, 434);
            keyLocations[81, 1] = new Point(659, 433);
            keyLocations[82, 0] = new Point(712, 434);
            keyLocations[82, 1] = new Point(711, 433);
            keyLocations[83, 0] = new Point(764, 434);
            keyLocations[83, 1] = new Point(763, 433);
            keyLocations[84, 0] = new Point(1119, 434);
            keyLocations[84, 1] = new Point(1118, 433);
            keyLocations[85, 0] = new Point(1171, 434);
            keyLocations[85, 1] = new Point(1170, 433);
            keyLocations[86, 0] = new Point(1223, 434);
            keyLocations[86, 1] = new Point(1222, 433);
            keyLocations[87, 0] = new Point(50, 486);
            keyLocations[87, 1] = new Point(49, 485);
            keyLocations[88, 0] = new Point(115, 486);
            keyLocations[88, 1] = new Point(114, 485);
            keyLocations[89, 0] = new Point(180, 486);
            keyLocations[89, 1] = new Point(179, 485);
            keyLocations[90, 0] = new Point(232, 486);
            keyLocations[90, 1] = new Point(231, 485);
            keyLocations[91, 0] = new Point(284, 486);
            keyLocations[91, 1] = new Point(283, 485);
            keyLocations[92, 0] = new Point(336, 486);
            keyLocations[92, 1] = new Point(335, 485);
            keyLocations[93, 0] = new Point(388, 486);
            keyLocations[93, 1] = new Point(387, 485);
            keyLocations[94, 0] = new Point(440, 486);
            keyLocations[94, 1] = new Point(439, 485);
            keyLocations[95, 0] = new Point(492, 486);
            keyLocations[95, 1] = new Point(491, 485);
            keyLocations[96, 0] = new Point(544, 486);
            keyLocations[96, 1] = new Point(543, 485);
            keyLocations[97, 0] = new Point(596, 486);
            keyLocations[97, 1] = new Point(595, 485);
            keyLocations[98, 0] = new Point(648, 486);
            keyLocations[98, 1] = new Point(647, 485);
            keyLocations[99, 0] = new Point(700, 486);
            keyLocations[99, 1] = new Point(699, 485);
            keyLocations[100, 0] = new Point(752, 486);
            keyLocations[100, 1] = new Point(751, 485);
            keyLocations[101, 0] = new Point(981, 486);
            keyLocations[101, 1] = new Point(980, 485);
            keyLocations[102, 0] = new Point(1119, 486);
            keyLocations[102, 1] = new Point(1118, 485);
            keyLocations[103, 0] = new Point(1171, 486);
            keyLocations[103, 1] = new Point(1170, 485);
            keyLocations[104, 0] = new Point(1223, 486);
            keyLocations[104, 1] = new Point(1222, 485);
            keyLocations[105, 0] = new Point(1275, 486);
            keyLocations[105, 1] = new Point(1274, 485);
            keyLocations[106, 0] = new Point(50, 538);
            keyLocations[106, 1] = new Point(49, 537);
            keyLocations[107, 0] = new Point(115, 538);
            keyLocations[107, 1] = new Point(114, 537);
            keyLocations[108, 0] = new Point(180, 538);
            keyLocations[108, 1] = new Point(179, 537);
            keyLocations[109, 0] = new Point(245, 538);
            keyLocations[109, 1] = new Point(244, 537);
            keyLocations[110, 0] = new Point(310, 538);
            keyLocations[110, 1] = new Point(309, 537);
            keyLocations[111, 0] = new Point(635, 538);
            keyLocations[111, 1] = new Point(634, 537);
            keyLocations[112, 0] = new Point(700, 538);
            keyLocations[112, 1] = new Point(699, 537);
            keyLocations[113, 0] = new Point(765, 538);
            keyLocations[113, 1] = new Point(764, 537);
            keyLocations[114, 0] = new Point(830, 538);
            keyLocations[114, 1] = new Point(829, 537);
            keyLocations[115, 0] = new Point(929, 538);
            keyLocations[115, 1] = new Point(928, 537);
            keyLocations[116, 0] = new Point(981, 538);
            keyLocations[116, 1] = new Point(980, 537);
            keyLocations[117, 0] = new Point(1033, 538);
            keyLocations[117, 1] = new Point(1032, 537);
            keyLocations[118, 0] = new Point(1119, 538);
            keyLocations[118, 1] = new Point(1118, 537);
            keyLocations[119, 0] = new Point(1223, 538);
            keyLocations[119, 1] = new Point(1222, 537);
        }
    }
}
