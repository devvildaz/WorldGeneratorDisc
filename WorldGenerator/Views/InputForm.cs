using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WorldGenerator.Controller;

namespace WorldGenerator
{
    public partial class InputForm : Form
    {
        WorldState worldState;
        int squareSize;

        enum PanelStatus
        {
            IDLE = 0,
            LOADING = 1,
            PAINTING = 2
        }

        PanelStatus panelState;

        (Point Ini, Point Fin) points;

        Graphics g;
        Pen pen;
        SolidBrush brush;
        public InputForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            panelState = PanelStatus.IDLE;
            pen = new Pen(Color.Black, 1);
            brush = new SolidBrush(Color.Black);
            Size targetSize = Screen.FromControl(this).WorkingArea.Size;
            Size = new Size(
                Convert.ToInt32(targetSize.Width * 0.5), 
                Convert.ToInt32(targetSize.Height * 0.5)
            );

            Location = new Point(0, 0);
            g = WorldPreview.CreateGraphics();
            // SizeChanged += Windows_Changed;

            worldState = new WorldState();
            squareSize = 10;
        }

        private Point CoordToWindowsCoord(Point pRelatedO)
        {
            return new Point(
                pRelatedO.X + WorldPreview.Size.Width / 2,
                (pRelatedO.Y - WorldPreview.Size.Height / 2) * -1
            ) ;
        }

        private Point getXYCoord(Point pRelatedToWindow)
        {
            return  new Point(
                pRelatedToWindow.X - WorldPreview.Size.Width / 2, 
                - pRelatedToWindow.Y + WorldPreview.Size.Height/2
            );
        }

        private void WorldPreview_MouseDown(object sender, MouseEventArgs e)
        {
            if (panelState == PanelStatus.IDLE)
            {
                panelState = PanelStatus.PAINTING;
                points.Ini = new Point(e.Location.X, e.Location.Y);
                Point coordPoint = getXYCoord(points.Ini);
                Debug.WriteLine($"({coordPoint.X}, {coordPoint.Y})");
            }
        }

        private void WorldPreview_MouseUp(object sender, MouseEventArgs e)
        {
            if (panelState == PanelStatus.PAINTING)
            {
                panelState = PanelStatus.IDLE;
            }
            Matrix transform = new Matrix();
            transform.Translate(10, 10);
            g.Transform = transform;
        }

        private void WorldPreview_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouseCoord = new Point(e.Location.X, e.Location.Y);
            Point originCoord = getXYCoord(mouseCoord);
            if (panelState == PanelStatus.PAINTING)
            {
                points.Fin = mouseCoord;
                //g.DrawLine(this.pen, points.Ini, points.Fin);
                points.Ini = points.Fin;
            }
            
            xLabel.Text = originCoord.X.ToString();
            yLabel.Text = originCoord.Y.ToString();
            //Debug.WriteLine($"{e.Location.X.ToString()}, ${e.Location.Y.ToString()}");
        }

        private void Load_Map(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pen.Color = Color.DarkGray;
            //Point center = CoordToWindowsCoord(new Point(0, 0));
            //g.DrawRectangle(pen, center.X, center.Y, 5, 5);
            for (int i = 0; i < WorldPreview.Size.Width; i += squareSize)
            {
                for(int j = 0; j < WorldPreview.Size.Height ; j+= squareSize)
                {
                    switch((WorldState.AreaType)worldState.MapGrid[i, j])
                    {
                        case WorldState.AreaType.WATER: brush.Color = Color.LightBlue;  break;
                        case WorldState.AreaType.SAND: brush.Color = Color.IndianRed; break;
                        case WorldState.AreaType.VALLEY: brush.Color = Color.Green; break;
                        case WorldState.AreaType.HILL: brush.Color = Color.DarkGreen; break;
                        case WorldState.AreaType.MOUNTAIN: brush.Color = Color.WhiteSmoke; break;
                    }   
                    g.FillRectangle(brush, new Rectangle(i,j, squareSize, squareSize));
                    g.DrawRectangle(pen, new Rectangle(i, j, squareSize, squareSize));
                }
            }
        }

        private void Save_Image(object sender, EventArgs e)
        {
            int width = worldState.MapGrid.GetLength(0);
            int height = worldState.MapGrid.GetLength(1);
            Bitmap bmp = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    switch ((WorldState.AreaType)worldState.MapGrid[i, j])
                    {
                        case WorldState.AreaType.WATER:
                            bmp.SetPixel(i, j, Color.LightBlue);
                            break;
                        case WorldState.AreaType.SAND:
                            bmp.SetPixel(i, j, Color.IndianRed);
                            break;
                        case WorldState.AreaType.VALLEY:
                            bmp.SetPixel(i, j, Color.Green);
                            break;
                        case WorldState.AreaType.HILL:
                            bmp.SetPixel(i, j, Color.DarkGreen);
                            break;
                        case WorldState.AreaType.MOUNTAIN:
                            bmp.SetPixel(i, j, Color.White);
                            break;
                    }
                }
            }
            EncoderParameters codecParams = new EncoderParameters(1);
            ImageCodecInfo codec = GetEncoderInfo("image/bmp");
            codecParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
            bmp.Save($"{this.textBox1.Text}.bmp",codec, codecParams);
            bmp.Dispose();
        }

        private static ImageCodecInfo GetEncoderInfo(string mimetype)
        {
            foreach(ImageCodecInfo codec in ImageCodecInfo.GetImageEncoders())
            {
                if (codec.MimeType == mimetype)
                    return codec;
            }
            return null;
        }

        private void Windows_Changed(object sender, EventArgs e)
        {
            Load_Map(sender, e);
        }
        
        private void Generate_Click(object sender, EventArgs e)
        {
            worldState.generateMap(this.textBox1.Text);
            Load_Map(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save_Image(sender, e);
        }
    }
}
