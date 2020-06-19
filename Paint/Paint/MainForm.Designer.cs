using System.ComponentModel;
using System.Windows.Forms;

namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

                
        
        
        
        
        
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewImageBtn = new System.Windows.Forms.Button();
            this.OpenImageBtn = new System.Windows.Forms.Button();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.ClearBtimapBtn = new System.Windows.Forms.Button();
            this.PenSizeUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CoordinatesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.CanvasPB = new System.Windows.Forms.PictureBox();
            this.ColorPickerBtn = new System.Windows.Forms.Button();
            this.ColorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.OpenNewImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveNewImageDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize) (this.PenSizeUD)).BeginInit();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CanvasPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NewImageBtn
            // 
            this.NewImageBtn.Location = new System.Drawing.Point(28, 11);
            this.NewImageBtn.Name = "NewImageBtn";
            this.NewImageBtn.Size = new System.Drawing.Size(118, 48);
            this.NewImageBtn.TabIndex = 0;
            this.NewImageBtn.Text = "New";
            this.NewImageBtn.UseVisualStyleBackColor = true;
            // 
            // OpenImageBtn
            // 
            this.OpenImageBtn.Location = new System.Drawing.Point(28, 84);
            this.OpenImageBtn.Name = "OpenImageBtn";
            this.OpenImageBtn.Size = new System.Drawing.Size(118, 48);
            this.OpenImageBtn.TabIndex = 1;
            this.OpenImageBtn.Text = "Open";
            this.OpenImageBtn.UseVisualStyleBackColor = true;
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Location = new System.Drawing.Point(28, 156);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(118, 48);
            this.SaveImageBtn.TabIndex = 2;
            this.SaveImageBtn.Text = "Save";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtimapBtn
            // 
            this.ClearBtimapBtn.Location = new System.Drawing.Point(28, 228);
            this.ClearBtimapBtn.Name = "ClearBtimapBtn";
            this.ClearBtimapBtn.Size = new System.Drawing.Size(118, 48);
            this.ClearBtimapBtn.TabIndex = 3;
            this.ClearBtimapBtn.Text = "Clear";
            this.ClearBtimapBtn.UseVisualStyleBackColor = true;
            // 
            // PenSizeUD
            // 
            this.PenSizeUD.Location = new System.Drawing.Point(70, 471);
            this.PenSizeUD.Name = "PenSizeUD";
            this.PenSizeUD.Size = new System.Drawing.Size(76, 20);
            this.PenSizeUD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size:";
            // 
            // CoordinatesLabel
            // 
            this.CoordinatesLabel.Location = new System.Drawing.Point(28, 518);
            this.CoordinatesLabel.Name = "CoordinatesLabel";
            this.CoordinatesLabel.Size = new System.Drawing.Size(117, 19);
            this.CoordinatesLabel.TabIndex = 6;
            this.CoordinatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color:";
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImagePanel.Controls.Add(this.CanvasPB);
            this.ImagePanel.Location = new System.Drawing.Point(173, 11);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(609, 545);
            this.ImagePanel.TabIndex = 8;
            // 
            // CanvasPB
            // 
            this.CanvasPB.BackColor = System.Drawing.Color.White;
            this.CanvasPB.Location = new System.Drawing.Point(1, 2);
            this.CanvasPB.Name = "CanvasPB";
            this.CanvasPB.Size = new System.Drawing.Size(607, 542);
            this.CanvasPB.TabIndex = 0;
            this.CanvasPB.TabStop = false;
            // 
            // ColorPickerBtn
            // 
            this.ColorPickerBtn.BackColor = System.Drawing.Color.Black;
            this.ColorPickerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorPickerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ColorPickerBtn.Location = new System.Drawing.Point(70, 423);
            this.ColorPickerBtn.Name = "ColorPickerBtn";
            this.ColorPickerBtn.Size = new System.Drawing.Size(25, 25);
            this.ColorPickerBtn.TabIndex = 9;
            this.ColorPickerBtn.UseVisualStyleBackColor = false;
            // 
            // ColorPickerDialog
            // 
            this.ColorPickerDialog.AnyColor = true;
            // 
            // OpenNewImageDialog
            // 
            this.OpenNewImageDialog.Filter = "Images|*.png;*.jpg;*.gif;*.bmp";
            // 
            // SaveNewImageDialog
            // 
            this.SaveNewImageDialog.Filter = "Images|*.png";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.ColorPickerBtn);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoordinatesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PenSizeUD);
            this.Controls.Add(this.ClearBtimapBtn);
            this.Controls.Add(this.SaveImageBtn);
            this.Controls.Add(this.OpenImageBtn);
            this.Controls.Add(this.NewImageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize) (this.PenSizeUD)).EndInit();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.CanvasPB)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox CanvasPB;
        private System.Windows.Forms.Button ClearBtimapBtn;
        private System.Windows.Forms.Button ColorPickerBtn;
        private System.Windows.Forms.ColorDialog ColorPickerDialog;
        private System.Windows.Forms.Label CoordinatesLabel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewImageBtn;
        private System.Windows.Forms.Button OpenImageBtn;
        private System.Windows.Forms.OpenFileDialog OpenNewImageDialog;
        private System.Windows.Forms.NumericUpDown PenSizeUD;
        private System.Windows.Forms.Button SaveImageBtn;
        private System.Windows.Forms.SaveFileDialog SaveNewImageDialog;

        #endregion
    }
}