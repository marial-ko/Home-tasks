using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private Pen drawingPen;
        private Color currentPenColor;
        private float penWidth;
        private bool isPenDown;
        private Point lastPoint = Point.Empty;
        private Image lastImage;
        public MainForm()
        {
            InitializeComponent();
            ColorPickerBtn.Click += SetNewColor;
            NewImageBtn.Click += CreateNewImage;
            ClearBtimapBtn.Click += ClearImage;
            OpenImageBtn.Click += OpenOpeningImageDialog;
            SaveImageBtn.Click += OpenSavingImageDialog;
            
            CanvasPB.MouseMove += CoordinatesSetter;
            CanvasPB.MouseMove += DrawByPressedPen;
            CanvasPB.MouseDown += OnMouseDown;
            CanvasPB.MouseUp += OnMouseUp;
            CanvasPB.MouseLeave += CoordinatesClearer;
            
            currentPenColor = Color.Black;
            penWidth = 10;
            PenSizeUD.Value = (decimal) penWidth;
            ColorPickerBtn.BackColor = currentPenColor;
            drawingPen = new Pen(currentPenColor, penWidth);
            drawingPen.StartCap = drawingPen.EndCap = LineCap.Round;
            lastImage = new Bitmap(607, 542);
            
            PenSizeUD.ValueChanged += UpdatePen;
            UpdateImage();
        }

        private void CreateNewImage(object sender, EventArgs eventArg)
        {
            var newBitmapScale = ShowCustomDialog();
            lastImage = new Bitmap(newBitmapScale.X, newBitmapScale.Y);
            UpdateImage();
        }

        private void ClearImage(object sender, EventArgs eventArg)
        {
            UpdateImage();
        }

        private void OpenOpeningImageDialog(object sender, EventArgs eventArg)
        {
            if (OpenNewImageDialog.ShowDialog() == DialogResult.Cancel) return;
            lastImage = new Bitmap(OpenNewImageDialog.FileName);
            UpdateImage();
        }

        private void OpenSavingImageDialog(object sender, EventArgs eventArg)
        {
            if (SaveNewImageDialog.ShowDialog() == DialogResult.Cancel) return;
            CanvasPB.Image?.Save(SaveNewImageDialog.FileName);   
        }
        
        private void CoordinatesSetter(object sender, MouseEventArgs eventArg)
        {
            CoordinatesLabel.Text = $@"({eventArg.X}, {eventArg.Y})";
        }
        
        private void CoordinatesClearer(object sender, EventArgs eventArg)
        {
            CoordinatesLabel.Text = "";
        }

        private void SetNewColor(object sender, EventArgs eventArg)
        {
            ColorPickerDialog.ShowDialog();
            currentPenColor = ColorPickerDialog.Color;
            ColorPickerBtn.BackColor = currentPenColor;
            drawingPen.Color = currentPenColor;
        }

        private void DrawByPressedPen(object sender, MouseEventArgs eventArg)
        {
            if (isPenDown && lastPoint != Point.Empty)
            {
                using (Graphics g = Graphics.FromImage(CanvasPB.Image))
                {
                    g.DrawLine(drawingPen, lastPoint, eventArg.Location);
                }
                CanvasPB.Invalidate();
                lastPoint = eventArg.Location;
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs eventArg)
        {
            isPenDown = true;
            lastPoint = eventArg.Location;
        }
        
        private void OnMouseUp(object sender, MouseEventArgs eventArg)
        {
            isPenDown = false;
            lastPoint = Point.Empty;
        }

        private void UpdateImage()
        {
            CanvasPB.Image = new Bitmap(lastImage);
            CanvasPB.Size = new Size(lastImage.Width, lastImage.Height);
        }
        
        private void UpdatePen(object sender, EventArgs e)
        {
            drawingPen.Color = currentPenColor;
            penWidth = (int)PenSizeUD.Value;
            drawingPen.Width = penWidth;
        }
        
        private Point ShowCustomDialog()
        {
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 150;
            prompt.Text = "New Image";            
            prompt.AutoSize = false;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            var widthLabel = new Label() { Left = 10, Top=20, Text="Width", Width = 60};
            var widthUD = new NumericUpDown () { Left = 100, Top=20, Width=70, Minimum = 0, Maximum = Decimal.MaxValue};
            
            var heightLabel = new Label() { Left = 10, Top=40, Text="Height", Width = 60 };
            var heightUD = new NumericUpDown () { Left = 100, Top=40, Width=70, Minimum = 0, Maximum = Decimal.MaxValue};
            
            var confirmation = new Button() { Text = "Ok", Left=40, Width=100, Top=70 };
            
            confirmation.Click += (sender, e) => { prompt.Close(); };
            
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(widthLabel);
            prompt.Controls.Add(heightLabel);
            prompt.Controls.Add(widthUD);
            prompt.Controls.Add(heightUD);
            prompt.ShowDialog();
            return new Point((int)widthUD.Value, (int)heightUD.Value);
        }
    }
}