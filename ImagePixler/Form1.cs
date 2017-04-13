using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagePixler
{
    public partial class Form1 : Form
    {
        private string Dateiname;
        private Bitmap Originalbild;
        private Bitmap Vorschaubild;
        private Bitmap Displaybild;
        private double RatioCorrFactor = 1;

        public Form1()
        {
            InitializeComponent();
        }

  
        /// RGB structure.
        public struct RGB
        {
            /// <summary>
            /// Gets an empty RGB structure;
            /// </summary>
            public static readonly RGB Empty = new RGB();

            private int red;
            private int green;
            private int blue;

            public static bool operator ==(RGB item1, RGB item2)
            {
                return (
                    item1.Red == item2.Red
                    && item1.Green == item2.Green
                    && item1.Blue == item2.Blue
                    );
            }

            public static bool operator !=(RGB item1, RGB item2)
            {
                return (
                    item1.Red != item2.Red
                    || item1.Green != item2.Green
                    || item1.Blue != item2.Blue
                    );
            }

            /// <summary>
            /// Gets or sets red value.
            /// </summary>
            public int Red
            {
                get
                {
                    return red;
                }
                set
                {
                    red = (value > 255) ? 255 : ((value < 0) ? 0 : value);
                }
            }

            /// <summary>
            /// Gets or sets red value.
            /// </summary>
            public int Green
            {
                get
                {
                    return green;
                }
                set
                {
                    green = (value > 255) ? 255 : ((value < 0) ? 0 : value);
                }
            }

            /// <summary>
            /// Gets or sets red value.
            /// </summary>
            public int Blue
            {
                get
                {
                    return blue;
                }
                set
                {
                    blue = (value > 255) ? 255 : ((value < 0) ? 0 : value);
                }
            }

            public RGB(int R, int G, int B)
            {
                this.red = (R > 255) ? 255 : ((R < 0) ? 0 : R);
                this.green = (G > 255) ? 255 : ((G < 0) ? 0 : G);
                this.blue = (B > 255) ? 255 : ((B < 0) ? 0 : B);
            }

            public override bool Equals(Object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;

                return (this == (RGB)obj);
            }

            public override int GetHashCode()
            {
                return Red.GetHashCode() ^ Green.GetHashCode() ^ Blue.GetHashCode();
            }
        }

        public static Color HextoColor(String colorCode)
        {
            return System.Drawing.ColorTranslator.FromHtml(colorCode);
        }

        /// Converts RGB to Color
        public static Color RGBtoColor(RGB RGBColor)
        {
            Color myColor = new Color();
            myColor = Color.FromArgb(RGBColor.Red,RGBColor.Green,RGBColor.Blue);
            return myColor;
        }
        
        /// Structure to define CIE XYZ.
        public struct CIEXYZ
        {
            /// <summary>
            /// Gets an empty CIEXYZ structure.
            /// </summary>
            public static readonly CIEXYZ Empty = new CIEXYZ();
            /// <summary>
            /// Gets the CIE D65 (white) structure.
            /// </summary>
            public static readonly CIEXYZ D65 = new CIEXYZ(0.9505, 1.0, 1.0890);


            private double x;
            private double y;
            private double z;

            public static bool operator ==(CIEXYZ item1, CIEXYZ item2)
            {
                return (
                    item1.X == item2.X
                    && item1.Y == item2.Y
                    && item1.Z == item2.Z
                    );
            }

            public static bool operator !=(CIEXYZ item1, CIEXYZ item2)
            {
                return (
                    item1.X != item2.X
                    || item1.Y != item2.Y
                    || item1.Z != item2.Z
                    );
            }

            /// <summary>
            /// Gets or sets X component.
            /// </summary>
            public double X
            {
                get
                {
                    return this.x;
                }
                set
                {
                    this.x = (value > 0.9505) ? 0.9505 : ((value < 0) ? 0 : value);
                }
            }

            /// <summary>
            /// Gets or sets Y component.
            /// </summary>
            public double Y
            {
                get
                {
                    return this.y;
                }
                set
                {
                    this.y = (value > 1.0) ? 1.0 : ((value < 0) ? 0 : value);
                }
            }

            /// <summary>
            /// Gets or sets Z component.
            /// </summary>
            public double Z
            {
                get
                {
                    return this.z;
                }
                set
                {
                    this.z = (value > 1.089) ? 1.089 : ((value < 0) ? 0 : value);
                }
            }

            public CIEXYZ(double x, double y, double z)
            {
                this.x = (x > 0.9505) ? 0.9505 : ((x < 0) ? 0 : x);
                this.y = (y > 1.0) ? 1.0 : ((y < 0) ? 0 : y);
                this.z = (z > 1.089) ? 1.089 : ((z < 0) ? 0 : z);
            }

            public override bool Equals(Object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;

                return (this == (CIEXYZ)obj);
            }

            public override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
            }

        }
        
        /// Structure to define CIE L*a*b*.
        public struct CIELab
        {
            /// <summary>
            /// Gets an empty CIELab structure.
            /// </summary>
            public static readonly CIELab Empty = new CIELab();

            private double l;
            private double a;
            private double b;


            public static bool operator ==(CIELab item1, CIELab item2)
            {
                return (
                    item1.L == item2.L
                    && item1.A == item2.A
                    && item1.B == item2.B
                    );
            }

            public static bool operator !=(CIELab item1, CIELab item2)
            {
                return (
                    item1.L != item2.L
                    || item1.A != item2.A
                    || item1.B != item2.B
                    );
            }


            /// <summary>
            /// Gets or sets L component.
            /// </summary>
            public double L
            {
                get
                {
                    return this.l;
                }
                set
                {
                    this.l = value;
                }
            }

            /// <summary>
            /// Gets or sets a component.
            /// </summary>
            public double A
            {
                get
                {
                    return this.a;
                }
                set
                {
                    this.a = value;
                }
            }

            /// <summary>
            /// Gets or sets a component.
            /// </summary>
            public double B
            {
                get
                {
                    return this.b;
                }
                set
                {
                    this.b = value;
                }
            }

            public CIELab(double l, double a, double b)
            {
                this.l = l;
                this.a = a;
                this.b = b;
            }

            public override bool Equals(Object obj)
            {
                if (obj == null || GetType() != obj.GetType()) return false;

                return (this == (CIELab)obj);
            }

            public override int GetHashCode()
            {
                return L.GetHashCode() ^ a.GetHashCode() ^ b.GetHashCode();
            }

        }
        
        /// Converts RGB to CIE XYZ (CIE 1931 color space)
        public static CIEXYZ RGBtoXYZ(int red, int green, int blue)
        {
            // normalize red, green, blue values
            double rLinear = (double)red / 255.0;
            double gLinear = (double)green / 255.0;
            double bLinear = (double)blue / 255.0;

            // convert to a sRGB form
            double r = (rLinear > 0.04045) ? Math.Pow((rLinear + 0.055) / (
                1 + 0.055), 2.2) : (rLinear / 12.92);
            double g = (gLinear > 0.04045) ? Math.Pow((gLinear + 0.055) / (
                1 + 0.055), 2.2) : (gLinear / 12.92);
            double b = (bLinear > 0.04045) ? Math.Pow((bLinear + 0.055) / (
                1 + 0.055), 2.2) : (bLinear / 12.92);

            // converts
            return new CIEXYZ(
                (r * 0.4124 + g * 0.3576 + b * 0.1805),
                (r * 0.2126 + g * 0.7152 + b * 0.0722),
                (r * 0.0193 + g * 0.1192 + b * 0.9505)
                );
        }
        
        /// Converts RGB to CIELab.
        public static CIELab RGBtoLab(int red, int green, int blue)
        {
            CIEXYZ tempCIEXYZ = RGBtoXYZ(red, green, blue);
            return XYZtoLab(tempCIEXYZ.X,tempCIEXYZ.Y,tempCIEXYZ.Z);
        }

        ///Converts Color to CIELab
        public static CIELab ColortoCIELAB(Color col)
        {
            return RGBtoLab(col.R, col.G, col.B);
        }
        
        /// XYZ to L*a*b* transformation function.
        private static double Fxyz(double t)
        {
            return ((t > 0.008856) ? Math.Pow(t, (1.0 / 3.0)) : (7.787 * t + 16.0 / 116.0));
        }
        
        /// Converts CIEXYZ to CIELab.
        public static CIELab XYZtoLab(double x, double y, double z)
        {
            CIELab lab = CIELab.Empty;

            lab.L = 116.0 * Fxyz(y / CIEXYZ.D65.Y) - 16;
            lab.A = 500.0 * (Fxyz(x / CIEXYZ.D65.X) - Fxyz(y / CIEXYZ.D65.Y));
            lab.B = 200.0 * (Fxyz(y / CIEXYZ.D65.Y) - Fxyz(z / CIEXYZ.D65.Z));

            return lab;
        }
        
        /// Returns the color difference (distance) between a sample color CIELap(2) and a reference color CIELap(1)
        public static float ColorDifferenceLAB(CIELab lab1, CIELab lab2)
        {
            /// <para>in accorance with CIE 2000 alogorithm.</para>
            /// <param name="lab1">CIELap reference color.</param>
            /// <param name="lab2">CIELap sample color.</param>
            /// <returns>Color difference.</returns>

            double p25 = Math.Pow(25, 7);

            double C1 = Math.Sqrt(lab1.A * lab1.A + lab1.B * lab1.B);
            double C2 = Math.Sqrt(lab2.A * lab2.A + lab2.B * lab2.B);
            double avgC = (C1 + C2) / 2F;

            double powAvgC = Math.Pow(avgC, 7);
            double G = (1 - Math.Sqrt(powAvgC / (powAvgC + p25))) / 2D;

            double a_1 = lab1.A * (1 + G);
            double a_2 = lab2.A * (1 + G);

            double C_1 = Math.Sqrt(a_1 * a_1 + lab1.B * lab1.B);
            double C_2 = Math.Sqrt(a_2 * a_2 + lab2.B * lab2.B);
            double avgC_ = (C_1 + C_2) / 2D;

            double h1 = (Atan(lab1.B, a_1) >= 0 ? Atan(lab1.B, a_1) : Atan(lab1.B, a_1) + 360F);
            double h2 = (Atan(lab2.B, a_2) >= 0 ? Atan(lab2.B, a_2) : Atan(lab2.B, a_2) + 360F);

            double H = (h1 - h2 > 180D ? (h1 + h2 + 360F) / 2D : (h1 + h2) / 2D);

            double T = 1;
            T -= 0.17 * Cos(H - 30);
            T += 0.24 * Cos(2 * H);
            T += 0.32 * Cos(3 * H + 6);
            T -= 0.20 * Cos(4 * H - 63);

            double deltah = 0;
            if (h2 - h1 <= 180)
                deltah = h2 - h1;
            else if (h2 <= h1)
                deltah = h2 - h1 + 360;
            else
                deltah = h2 - h1 - 360;

            double avgL = (lab1.L + lab2.L) / 2F;
            double deltaL_ = lab2.L - lab1.L;
            double deltaC_ = C_2 - C_1;
            double deltaH_ = 2 * Math.Sqrt(C_1 * C_2) * Sin(deltah / 2);

            double SL = 1 + (0.015 * Math.Pow(avgL - 50, 2)) / Math.Sqrt(20 + Math.Pow(avgL - 50, 2));
            double SC = 1 + 0.045 * avgC_;
            double SH = 1 + 0.015 * avgC_ * T;

            double exp = Math.Pow((H - 275) / 25, 2);
            double teta = Math.Pow(30, -exp);

            double RC = 2D * Math.Sqrt(Math.Pow(avgC_, 7) / (Math.Pow(avgC_, 7) + p25));
            double RT = -RC * Sin(2 * teta);

            double deltaE = 0;
            deltaE = Math.Pow(deltaL_ / SL, 2);
            deltaE += Math.Pow(deltaC_ / SC, 2);
            deltaE += Math.Pow(deltaH_ / SH, 2);
            deltaE += RT * (deltaC_ / SC) * (deltaH_ / SH);
            deltaE = Math.Sqrt(deltaE);

            return (float)deltaE;
        }

        /// Returns the color difference (distance) between a sample color Color1 and a reference color Color2
        public static float ColorDifference(Color Color1, Color Color2)
        {
            return ColorDifferenceLAB(ColortoCIELAB(Color1), ColortoCIELAB(Color2));
        }

        /// Returns the color difference (distance) between a sample color RGB1 and a reference color RGB2
        public static float ColorDifferenceRGB(RGB RGB1, RGB RGB2)
        {
            return ColorDifferenceLAB(RGBtoLab(RGB1.Red,RGB1.Green,RGB1.Blue),RGBtoLab(RGB2.Red,RGB2.Green,RGB2.Blue));
        }
        
        /// Returns the angle in degree whose tangent is the quotient of the two specified numbers.
        private static double Atan(double y, double x)
        {
            /// <param name="y">The y coordinate of a point.</param>
            /// <param name="x">The x coordinate of a point.</param>
            /// <returns>Angle in degree.</returns>
            return Math.Atan2(y, x) * 180D / Math.PI;
        }
        
        /// Returns the cosine of the specified angle in degree.
        private static double Cos(double d)
        {
            /// <param name="d">Angle in degree</param>
            /// <returns>Cosine of the specified angle.</returns>
            return Math.Cos(d * Math.PI / 180);
        }
        
        /// Returns the sine of the specified angle in degree.
        private static double Sin(double d)
        {
            /// <param name="d">Angle in degree</param>
            /// <returns>Sine of the specified angle.</returns>
            return Math.Sin(d * Math.PI / 180);
        }
        
        private void checkBoxSize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSize.Checked)
            {
                groupBox_Size.Enabled = true;
            }
            else
            {
                groupBox_Size.Enabled = false;
            }
        }

        private void checkBoxColors_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColors.Checked)
            {
                groupBox_Color.Enabled = true;
            }
            else
            {
                groupBox_Color.Enabled = false;
            }
        }

        private void checkBoxRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRatio.Checked)
            {
                textBox_Ratio.Enabled = true;
                label_Ratio.Enabled = true;
            }
            else
            {
                textBox_Ratio.Enabled = false;
                label_Ratio.Enabled = false;
            }
        }

        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Picture.ShowDialog() == DialogResult.OK)
            {
                Dateiname = openFileDialog_Picture.FileName;
                Originalbild = new Bitmap(Dateiname);
                Vorschaubild = Originalbild;
                refreshDisplay();
                checkBox_DisplayRatioCorrection.Enabled = true;
            }
        }

        private void refreshDisplay()
        {
            //TODO skalierung implementieren
            int newWidth, newHeight;

            if (((double)Vorschaubild.Width * RatioCorrFactor) / ((double)Vorschaubild.Height) > (double)pictureBox_Display.Width / (double)pictureBox_Display.Height)
            {//Bild ist breiter als hoch... breite auf breite der Picturebox setzen, höhe im gleichen verhältnis
                newWidth = pictureBox_Display.Width;
                newHeight = (int)((((double)pictureBox_Display.Width / (double)Vorschaubild.Width) * (double)Vorschaubild.Height) / RatioCorrFactor) ;
            }
            else
            {
                newHeight = (int)((double)pictureBox_Display.Height);
                newWidth = (int)((((double)pictureBox_Display.Height / (double)Vorschaubild.Height) * (double)Vorschaubild.Width)*RatioCorrFactor);
            }

            //newHeight =(int)((double)newHeight / RatioCorrFactor);

            Bitmap Zoombild = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(Zoombild))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                gr.DrawImage(Vorschaubild, new Rectangle(0, 0, newWidth, newHeight));
            }

            pictureBox_Display.Image = Zoombild;
        }

        private void button_Color_loadPalette_Click(object sender, EventArgs e)
        {
            loadPaletteDialog();
        }

        private void loadPaletteDialog()
        {
            openFileDialog_Palette.RestoreDirectory = true;
            openFileDialog_Palette.Filter = "Farbpaletten (*.col)|*.col";
            openFileDialog_Palette.Multiselect = false;
            DialogResult Result = openFileDialog_Palette.ShowDialog();
            if (Result == DialogResult.OK)
            {
                String filePath = openFileDialog_Palette.FileName;
                loadPalettefromFile(filePath);
            }
        }

        private void loadPalettefromFile(String filePath)
        {
            listView_Palette.Items.Clear(); //Palette leeren...
            foreach (String line in System.IO.File.ReadAllLines(filePath))  //...und neu befuellen
            {
                String[] color = line.Split(';');
                String colorName = color[0];
                String colorCode = color[1];
                addNewColor(colorName, colorCode);
            }
        }

        private void addNewColor(String colorName, String colorCode)
        {
            ListViewItem item = listView_Palette.Items.Add(colorName);
            item.SubItems.Add(colorCode);

            //neues Bild für die Farbvorschau in die Imagelist aufnehmen...
            imageList_Palette.Images.Add(colorCode, generateColorPreviewImage(HextoColor(colorCode)));
            item.ImageKey = colorCode;  //...und ans item haengen
            listView_Palette.ShowItemToolTips = true;
            item.ToolTipText = colorCode;

        }

        private Image generateColorPreviewImage(Color Farbe)
        {
            Bitmap bmp = new Bitmap(64, 64);
            Pen pen = new Pen(Color.Black, 4);
            Graphics G = Graphics.FromImage(bmp);
            SolidBrush brush = new SolidBrush(Farbe);
            G.FillRectangle(brush, 0, 0, 64, 64);
            G.DrawRectangle(pen, 0, 0, 64, 64);
            return bmp;
        }

        private void button_Color_savePalette_Click(object sender, EventArgs e)
        {
            savePalettetoFile();
        }

        private void savePalettetoFile()
        {
            saveFileDialog_Palette.RestoreDirectory = true;
            saveFileDialog_Palette.Filter = "Farbpaletten (*.col)|*.col";
            saveFileDialog_Palette.FileName = "MeinePalette.col";
            DialogResult Result = saveFileDialog_Palette.ShowDialog();
            if (Result == DialogResult.OK)
            {
                String filePath = saveFileDialog_Palette.FileName;
                var lines4file = new StringBuilder();
                foreach (ListViewItem item in listView_Palette.Items)
                {
                    lines4file.AppendLine(item.Text + ";" + item.SubItems[1].Text);
                }
                System.IO.File.WriteAllText(filePath, lines4file.ToString());
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo HI = listView_Palette.HitTest(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                if (HI.Location == ListViewHitTestLocations.None)
                {   //wurde kein item getroffen, werden optionen ausgeblendet
                    contextMenu_Palette.Items[0].Visible = false;
                    contextMenu_Palette.Items[1].Visible = false;
                    contextMenu_Palette.Items[2].Visible = false;
                }
                else
                {   //wurde ein item getroffen, werden optionen eingeblendet
                    contextMenu_Palette.Items[0].Visible = true;
                    contextMenu_Palette.Items[1].Visible = true;
                    contextMenu_Palette.Items[2].Visible = true;
                }
                contextMenu_Palette.Show(Cursor.Position);
            }
        }

        private void FarbeAendern(object sender, EventArgs e)
        {
            colorDialog_Palette.Color = System.Drawing.ColorTranslator.FromHtml(listView_Palette.FocusedItem.SubItems[1].Text);
            colorDialog_Palette.ShowDialog();

            Color C = colorDialog_Palette.Color;
            String colorCode = "#" + C.R.ToString("X2") + C.G.ToString("X2") + C.B.ToString("X2");
            listView_Palette.FocusedItem.SubItems[1].Text = colorCode;
            imageList_Palette.Images.Add(colorCode, generateColorPreviewImage(C));
            listView_Palette.FocusedItem.ImageKey = colorCode;
            listView_Palette.FocusedItem.Selected = false;
        }

        private void dieseFarbeUmbenennenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_Palette.FocusedItem.BeginEdit();
        }

        private void dieseFarbeEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_Palette.FocusedItem.Remove();
        }

        private void neueFarbeHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewColor("neueFarbe", "#000000");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("DefaultPalette.col"))
            {
                loadPalettefromFile("DefaultPalette.col");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DisplayRatioCorrection.Checked)
            {
                double parseresult;
                if(Double.TryParse(textBox_Ratio.Text, out parseresult))
                {
                    RatioCorrFactor = parseresult;
                }
                else
                {
                    RatioCorrFactor = 1;
                }

            }
            else
            {
                RatioCorrFactor = 1;
            }
            refreshDisplay();
        }
    }
}
