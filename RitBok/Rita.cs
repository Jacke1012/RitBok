using System;
using System.Drawing;
using System.Windows.Forms;
using HistoryCollections;

namespace RitBok
{
    public partial class RitClass : Form
    {

        public enum Tools
        {
            Linje,
            Rektangel,
            Ellips,
            Penna
        }

        public enum ClickState
        {
            Non,
            First,
            Second
        }

        public enum MoveOrClick
        {
            Move,
            Click
        }

        delegate void DrawTool(object sender, MouseEventArgs e);

        public RitClass()
        {
            InitializeComponent();
        }

        Bitmap image;

        Bitmap origianlImage;

        DrawTool toolMethod;

        History<Bitmap> bitmapHistory = new History<Bitmap>(1000);

        ClickState currentClickState = ClickState.Non;
        MoveOrClick moveOrClick = MoveOrClick.Click;
        private void RitClass_Load(object sender, EventArgs e)
        {
            image = new Bitmap(692, 516);
            origianlImage = (Bitmap)image.Clone();
            tbxStorlek.Text = "15";
            tbxBrushSize.Text = "15";
            BtnLinje_Click(null, null);
        }


        Point[] points = new Point[2];
        Pen pen = new Pen(Color.Black);
        float size;
        public void ClickDetect(object sender, MouseEventArgs e)
        {
            size = float.Parse(tbxStorlek.Text);
            pen.Width = float.Parse(tbxBrushSize.Text);
            switch (currentClickState)
            {
                case ClickState.Non:
                    if (e.Button == MouseButtons.Left)
                    {
                        currentClickState = ClickState.First;
                    }
                    break;
                case ClickState.First:
                    if (e.Button == MouseButtons.Left)
                    {
                        currentClickState = ClickState.Second;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        currentClickState = ClickState.Non;
                    }
                    break;
                case ClickState.Second:
                    break;
                default:
                    break;
            }

            toolMethod.Invoke(this, e);
        }

        private void MoveDetect(object sender, MouseEventArgs e)
        {
            size = float.Parse(tbxStorlek.Text);
            pen.Width = float.Parse(tbxBrushSize.Text);
            switch (currentClickState)
            {
                case ClickState.Non:
                    if (e.Button == MouseButtons.Left)
                    {
                        currentClickState = ClickState.First;
                    }
                    break;
                case ClickState.First:
                    if (e.Button == MouseButtons.Left)
                    {
                        currentClickState = ClickState.First;
                    }
                    else
                    {
                        currentClickState = ClickState.Non;
                    }
                    break;
                case ClickState.Second:
                    break;
                default:
                    break;
            }
            DrawEllipse(sender, e);
        }

        public void DrawLine(object sender, MouseEventArgs e)
        {
            switch (currentClickState)
            {
                case ClickState.Non:
                    break;
                case ClickState.First:
                    points[0] = new Point(e.X, e.Y);
                    break;
                case ClickState.Second:
                    points[1] = new Point(e.X, e.Y);
                    Graphics g = Graphics.FromImage(image);
                    g.DrawLine(pen, points[0], points[1]);
                    UpdatePbx();
                    currentClickState = ClickState.Non;
                    break;
                default:
                    break;
            }
        }

        public void DrawEllipse(object sender, MouseEventArgs e)
        {
            switch (currentClickState)
            {
                case ClickState.First:
                    Graphics g = Graphics.FromImage(image);
                    g.DrawEllipse(pen, e.X - size/2, e.Y - size/2, size, size);
                    UpdatePbx();
                    currentClickState = ClickState.Non;
                    break;
                default:
                    break;
            }
        }

        private void DrawRectangle(object sender, MouseEventArgs e)
        {
            switch (currentClickState)
            {
                case ClickState.First:
                    Graphics g = Graphics.FromImage(image);
                    g.DrawRectangle(pen, e.X - size / 2, e.Y - size / 2, size, size);
                    UpdatePbx();
                    currentClickState = ClickState.Non;
                    break;
                default:
                    break;
            }
        }

        public void UpdatePbx()
        {
            pbxMain.Image = image;
            bitmapHistory.Add((Bitmap)image.Clone());
            //Console.WriteLine(bitmapHistory.current);
        }

        private void BtnBytFärg_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                pen.Color = SelectColor.Color;
            }
            pbxColorView.BackColor = SelectColor.Color;
        }

        private void BtnRektangel_Click(object sender, EventArgs e)
        {
            ChangeToClickDetect();
            toolMethod = DrawRectangle;
        }

        private void BtnLinje_Click(object sender, EventArgs e)
        {
            ChangeToClickDetect();
            toolMethod = DrawLine;
        }

        private void BtnEllips_Click(object sender, EventArgs e)
        {
            ChangeToClickDetect();
            toolMethod = DrawEllipse;
        }

        private void BtnPenna_Click(object sender, EventArgs e)
        {
            pbxMain.MouseClick -= ClickDetect;
            pbxMain.MouseMove += MoveDetect;
            moveOrClick = MoveOrClick.Move;
        }
        private void ChangeToClickDetect()
        {
            if (moveOrClick == MoveOrClick.Move)
            {
                pbxMain.MouseClick += ClickDetect;
                pbxMain.MouseMove -= MoveDetect;
                moveOrClick = MoveOrClick.Click;
            }
            currentClickState = ClickState.Non;//It unselected the current tool, eg. Linje tool
        }

        private void BtnÅngra_Click(object sender, EventArgs e)
        {
            Bitmap imageItem;
            if (bitmapHistory.Undo(out imageItem))
            {
                if (imageItem == null)
                {
                    image = origianlImage;
                }
                image = (Bitmap)imageItem.Clone();
                pbxMain.Image = image;
            }
            //Console.WriteLine(bitmapHistory.current);

        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            Bitmap imageItem;
            if (bitmapHistory.Redo(out imageItem))
            {
                image = (Bitmap)imageItem.Clone();
                pbxMain.Image = image;
            }
            //Console.WriteLine(bitmapHistory.current);

        }
    }
}
