using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        private bool DisplayRatioCorrection = false;
        private bool automode_on = false;
        private bool cropmode_on = false;
        private BackgroundWorker _worker = null;
        private int crop_display_x1, crop_display_x2, crop_display_y1, crop_display_y2 = 0;
        private int crop_image_x1, crop_image_x2, crop_image_y1, crop_image_y2 = 0;

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

        public static String ColortoHex(Color Col)
        {
            return ColorTranslator.ToHtml(Col);
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
                DisplayRatioCorrection = checkBox_DisplayRatioCorrection.Checked;
                displayImage(Vorschaubild);
            }
        }

        private void displayImage(Image Bild)
        {
            if (DisplayRatioCorrection)
            {
                RatioCorrFactor = Double.Parse(textBox_Ratio.Text);
            }
            else
            {
                RatioCorrFactor = 1;
            }
            int newWidth, newHeight;

            if (((double)Vorschaubild.Width * RatioCorrFactor) / ((double)Vorschaubild.Height) > (double)pictureBox_Display.Width / (double)pictureBox_Display.Height)
            {//Bild ist (mit korrekturfaktor) breiter als hoch... breite auf breite der Picturebox setzen, höhe verhältnis
                newWidth = pictureBox_Display.Width;
                newHeight = (int)((((double)pictureBox_Display.Width / (double)Vorschaubild.Width) * (double)Vorschaubild.Height) / RatioCorrFactor) ;
            }
            else
            {//Bild ist (mit korrekturfaktor) hoeher als breit... hoehe auf hoehe der Picturebox setzen, breite im verhältnis
                newHeight = (int)((double)pictureBox_Display.Height);
                newWidth = (int)((((double)pictureBox_Display.Height / (double)Vorschaubild.Height) * (double)Vorschaubild.Width)*RatioCorrFactor);
            }

            Displaybild = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(Displaybild))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                gr.DrawImage(Vorschaubild, new Rectangle(0, 0, newWidth, newHeight));
            }

            pictureBox_Display.Image = Displaybild;
            button_SaveImage.Enabled = true;
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
            label_Palette_colorCount.Text = "Farben: " + listView_Palette.Items.Count;
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
            label_Palette_colorCount.Text = "Farben: " + listView_Palette.Items.Count;
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

        private void button_Palette_generatefromImage_Click(object sender, EventArgs e)
        {
            generatePalettefromImage((int)numericUpDown1.Value);
        }

        private void generatePalettefromImage(int maxColors)
        {
            int Toleranz = 5;
            
            List<Color> Farbliste;
            Farbliste = scanImageforColors(Vorschaubild, Toleranz);


            do //Liste mit immer höherer Toleranz generieren, bis die Farbanzahl gering genug ist.
            {
                int i = 0;
                while (i < Farbliste.Count - 1)
                {
                    if (colorsSimilar(Farbliste[i], Farbliste[i + 1], Toleranz))
                    {
                        Farbliste.RemoveAt(i + 1);
                    }
                    i++;
                }

                Toleranz++;



            } while (Farbliste.Count > maxColors);



            String colorCode = "";
            listView_Palette.Items.Clear(); //Palette leeren...
            foreach (Color Col in Farbliste)  //...und neu befuellen
            {
                colorCode = ColortoHex(Col);
                addNewColor(colorCode, colorCode);
            }
        }

        private List<Color> scanImageforColors(Bitmap Bild,int FarbToleranz)
        {
            List<Color> genPalette = new List<Color>();

            bool farbebereitsvorhanden = false;
            Color pixelfarbe;

            progressBar1.Maximum = Bild.Width;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            try
            {
                for (int x = 0; x < Bild.Size.Width; x++)
                {
                    progressBar1.Value = x;
                    for (int y = 0; y < Bild.Size.Height; y++)
                    {
                        pixelfarbe = Bild.GetPixel(x, y);
                        farbebereitsvorhanden = false;
                        foreach (Color listfarbe in genPalette)
                        {
                            if (colorsSimilar(listfarbe, pixelfarbe, FarbToleranz))
                            {
                                farbebereitsvorhanden = true;
                            }
                        }
                        if (!farbebereitsvorhanden)
                        {
                            genPalette.Add(pixelfarbe);
                        }
                    }
                }

                //Parallel.For(0, Bild.Size.Width, x =>
                //{
                //    progressBar1.Value = x;
                //    for (int y = 0; y < Bild.Size.Height; y++)
                //    {
                //        pixelfarbe = Bild.GetPixel(x, y);
                //        farbebereitsvorhanden = false;
                //        foreach (Color listfarbe in genPalette)
                //        {
                //            if (colorsSimilar(listfarbe, pixelfarbe, FarbToleranz))
                //            {
                //                farbebereitsvorhanden = true;
                //            }
                //        }
                //        if (!farbebereitsvorhanden)
                //        {
                //            genPalette.Add(pixelfarbe);
                //        }
                //    }
                //} );

                

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception: " + e);
            }
            progressBar1.Visible = false;
            return genPalette;
            
        }

        private bool colorsSimilar(Color Color1, Color Color2, int farbToleranz)
        {
            return (ColorDifference(Color1, Color2) < farbToleranz);
        }

        public static Bitmap ResizeImage(Image image, String side, int pixelAmount, double Ratio)
        {
            int newWidth = 0;
            int newHeight= 0;

            if(side.Equals("kürzere Seite"))
            {
                if (image.Width < image.Height)
                {
                    side = "Breite";
                }
                else
                {
                    side = "Höhe";
                }
            }

            if (side.Equals("Breite"))
            {
                newWidth = pixelAmount;
                newHeight = (int)((((double)newWidth / (double)image.Width) * (double)image.Height) * Ratio);
            }
            else
            {
                newHeight = pixelAmount;
                newWidth = (int)((((double)newHeight / (double)image.Height) * (double)image.Width) / Ratio);

            }
            var destRect = new Rectangle(0, 0, newWidth, newHeight);
            var destImage = new Bitmap(newWidth, newHeight);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void button_Size_Apply_Click(object sender, EventArgs e)
        {
            DisplayRatioCorrection = false;
            double Ratio = 1;
            if (checkBoxRatio.Checked)
            {
                Ratio = double.Parse(textBox_Ratio.Text);
                DisplayRatioCorrection = true;
            }
            Vorschaubild = ResizeImage(Originalbild, comboBoxWunschseite.Text, int.Parse(textBox_Wunschbreite.Text), Ratio);
            
            displayImage(Vorschaubild);
        }

        private void button_Palette_Apply_Click(object sender, EventArgs e)
        {
            ImageColorstoPaletteColors(Vorschaubild, trackBar1.Value);
        }

        private void ImageColorstoPaletteColors(Bitmap Bild, int dithering_amount)
        {
            bool dithering = true;

            if(dithering_amount == 0)
            {
                dithering = false;
            }
            if(dithering_amount > 10)
            {
                dithering_amount = 10;
            }
            
            progressBar1.Maximum = Bild.Height;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            double minFarbabstand;
            double Farbabstand;
            Color Color_Zielfarbe = Color.White;
            CIELab LAB_Zielfarbe = new CIELab();
            Color Pixelfarbe;

            Double[,] Corr_L = new Double[Bild.Width+1, Bild.Height+1];
            Corr_L[0, 0] = 0;
            Double[,] Corr_A = new Double[Bild.Width+1, Bild.Height+1];
            Corr_A[0, 0] = 0;
            Double[,] Corr_B = new Double[Bild.Width+1, Bild.Height+1];
            Corr_B[0, 0] = 0;
            Double Error_L, Error_A, Error_B;
            
            List<CIELab> LAB_Palette = new List<CIELab>();
            List<Color> Color_Palette = new List<Color>();
           
            //Palette aus Listview als LAB und Color in Listen abbilden
            foreach (ListViewItem item in listView_Palette.Items)
            {
                Color_Palette.Add(HextoColor(item.SubItems[1].Text));
                LAB_Palette.Add(ColortoCIELAB(HextoColor(item.SubItems[1].Text)));
            }

            //Schleife durch alle Pixel
            for (int y = 0; y < Bild.Height; y++)
            {
                progressBar1.Value = y;

                for (int x = 0; x < Bild.Width; x++)
                {
                    minFarbabstand = double.MaxValue;
                    //für jedes Pixel schauen welcher Palettenfarbe es am nächsten kommt
                    Pixelfarbe = Bild.GetPixel(x, y);
                    CIELab LAB_Pixelfarbe = ColortoCIELAB(Pixelfarbe);

                    // vor dem Vergleich die Fehler der Fehlermatrix aufrechnen
                    if (dithering)
                    {
                        LAB_Pixelfarbe.L = LAB_Pixelfarbe.L + Corr_L[x, y];
                        LAB_Pixelfarbe.A = LAB_Pixelfarbe.A + Corr_A[x, y];
                        LAB_Pixelfarbe.B = LAB_Pixelfarbe.B + Corr_B[x, y];
                    }
                    
                    for(int i = 0; i < LAB_Palette.Count; i++)
                    {
                        CIELab LAB_Palettenfarbe = LAB_Palette[i];
                        Farbabstand = ColorDifferenceLAB(LAB_Pixelfarbe, LAB_Palettenfarbe);
                        if (Farbabstand < minFarbabstand)
                        {
                            minFarbabstand = Farbabstand;
                            Color_Zielfarbe = Color_Palette[i];
                            LAB_Zielfarbe = LAB_Palette[i];
                        }
                    }
                    
                    Bild.SetPixel(x, y, Color_Zielfarbe);

                    //Fehler berechnen fürs Dithering
                    if (dithering)
                    {
                        Error_L = LAB_Pixelfarbe.L - LAB_Zielfarbe.L;
                        Error_A = LAB_Pixelfarbe.A - LAB_Zielfarbe.A;
                        Error_B = LAB_Pixelfarbe.B - LAB_Zielfarbe.B;

                        Error_L = Error_L * ((double)dithering_amount / 10);
                        Error_A = Error_A * ((double)dithering_amount / 10);
                        Error_B = Error_B * ((double)dithering_amount / 10);

                        Corr_L[x + 1, y] = Error_L * 7 / 16;
                        Corr_A[x + 1, y] = Error_A * 7 / 16;
                        Corr_B[x + 1, y] = Error_B * 7 / 16;
                        if(x != 0)
                        {
                            Corr_L[x - 1, y + 1] = Error_L * 3 / 16;
                            Corr_A[x - 1, y + 1] = Error_A * 3 / 16;
                            Corr_B[x - 1, y + 1] = Error_B * 3 / 16;
                        }
                        Corr_L[x, y + 1] = Error_L * 5 / 16;
                        Corr_A[x, y + 1] = Error_A * 5 / 16;
                        Corr_B[x, y + 1] = Error_B * 5 / 16;
                        Corr_L[x + 1, y + 1] = Error_L * 1 / 16;
                        Corr_A[x + 1, y + 1] = Error_A * 1 / 16;
                        Corr_B[x + 1, y + 1] = Error_B * 1 / 16;
                    }
              
                }
            }
            progressBar1.Visible = false;
            displayImage(Bild);
        }

        private void button_ResetImage_Click(object sender, EventArgs e)
        {
            DisplayRatioCorrection = checkBox_DisplayRatioCorrection.Checked;
            Vorschaubild = Originalbild;
            displayImage(Vorschaubild);
        }

        private void button_loadRandomImage_Click(object sender, EventArgs e)
        {
            loadRandomImage();
        }

        private void loadRandomImage()
        {
            var request = System.Net.WebRequest.Create("https://source.unsplash.com/random");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Image myImage = Bitmap.FromStream(stream);
                Originalbild = new Bitmap(myImage);
            }

            DisplayRatioCorrection = checkBox_DisplayRatioCorrection.Checked;
            Vorschaubild = Originalbild;
            displayImage(Vorschaubild);
        }

        private void button_resizeAndreduce_Click(object sender, EventArgs e)
        {
            resizeAndreduce();
        }

        private void resizeAndreduce()
        {
            DisplayRatioCorrection = false;
            double Ratio = 1;
            if (checkBoxRatio.Checked)
            {
                Ratio = double.Parse(textBox_Ratio.Text);
                DisplayRatioCorrection = true;
            }
            Vorschaubild = ResizeImage(Originalbild, comboBoxWunschseite.Text, int.Parse(textBox_Wunschbreite.Text), Ratio);
            
            displayImage(Vorschaubild);
            ImageColorstoPaletteColors(Vorschaubild, trackBar1.Value);
        }

        private void button_SaveImage_Click(object sender, EventArgs e)
        {
            saveImagewithDialog();
        }

        private void saveImagewithDialog()
        {
            saveFileDialog_Picture.RestoreDirectory = true;
            saveFileDialog_Picture.Filter = "Bitmap (*.bmp)|*.bmp";
            saveFileDialog_Picture.FileName = "MeinPixelbild_ " + DateTime.Now.ToString("yyyyMMddHHmmssfff") +  ".bmp";
            DialogResult Result = saveFileDialog_Picture.ShowDialog();
            if (Result == DialogResult.OK)
            {
                String filePath = saveFileDialog_Picture.FileName;
                Vorschaubild.Save(saveFileDialog_Picture.FileName, ImageFormat.Bmp);
            }
        }

        private void button_automode_Click(object sender, EventArgs e)
        {
            if (!automode_on)
            {
                automode_on = true;
                timer_continueAutomode.Enabled = true;
            }
            else
            {
                automode_on = false;
            }
        }

        private void timer_continueAutomode_Tick(object sender, EventArgs e)
        {
            timer_continueAutomode.Enabled = false;
            if(automode_on)
            {
                loadRandomImage();
                resizeAndreduce();
                String Filename_Originalbild = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/AutoPixelbild_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_original.png";
                String Filename_Pixelbild = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/AutoPixelbild_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".bmp";
                Originalbild.Save(Filename_Originalbild, ImageFormat.Png);
                Vorschaubild.Save(Filename_Pixelbild, ImageFormat.Bmp);
                timer_continueAutomode.Enabled = true;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button_crop_Click(object sender, EventArgs e)
        {
            activate_cropmode();
            
        }

        private void activate_cropmode()
        {
            cropmode_on = true;
            groupBox_Color.Enabled = false;
            groupBox_File.Enabled = false;
            groupBox_Size.Enabled = false;
        }

        private void deactivate_cropmode()
        {
            groupBox_Color.Enabled = true;
            groupBox_File.Enabled = true;
            groupBox_Size.Enabled = true;
        }

        private void pictureBox_Display_MouseUp(object sender, MouseEventArgs e)
        {
            if (cropmode_on)
            {
                cropmode_on = false;
                crop_display_x2 = e.X;
                crop_display_y2 = e.Y;
                deactivate_cropmode();
                //MessageBox.Show(crop_display_x1 + "," + crop_display_y1 + "-" + crop_display_x2 + "," + crop_display_y2);
            }
            
        }

        private void pictureBox_Display_MouseDown(object sender, MouseEventArgs e)
        {
            if (cropmode_on)
            {
                crop_display_x1 = e.X;
                crop_display_y1 = e.Y;
            }
        }
    }
}
