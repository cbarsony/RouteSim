namespace GMap7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.myMap = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add30 = new System.Windows.Forms.ToolStripMenuItem();
            this.add50 = new System.Windows.Forms.ToolStripMenuItem();
            this.add90 = new System.Windows.Forms.ToolStripMenuItem();
            this.add130 = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMap
            // 
            this.myMap.Bearing = 0F;
            this.myMap.CanDragMap = true;
            this.myMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.myMap.GrayScaleMode = false;
            this.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.myMap.LevelsKeepInMemmory = 5;
            this.myMap.Location = new System.Drawing.Point(13, 13);
            this.myMap.MarkersEnabled = true;
            this.myMap.MaxZoom = 18;
            this.myMap.MinZoom = 2;
            this.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.myMap.Name = "myMap";
            this.myMap.NegativeMode = false;
            this.myMap.PolygonsEnabled = true;
            this.myMap.RetryLoadTile = 0;
            this.myMap.RoutesEnabled = true;
            this.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.myMap.ShowTileGridLines = false;
            this.myMap.Size = new System.Drawing.Size(895, 547);
            this.myMap.TabIndex = 0;
            this.myMap.Zoom = 13D;
            this.myMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myMap_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add30,
            this.add50,
            this.add90,
            this.add130,
            this.destinationMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // add30
            // 
            this.add30.Name = "add30";
            this.add30.Size = new System.Drawing.Size(152, 22);
            this.add30.Text = "30";
            this.add30.Click += new System.EventHandler(this.add30_Click);
            // 
            // add50
            // 
            this.add50.Name = "add50";
            this.add50.Size = new System.Drawing.Size(152, 22);
            this.add50.Text = "50";
            this.add50.Click += new System.EventHandler(this.add50_Click);
            // 
            // add90
            // 
            this.add90.Name = "add90";
            this.add90.Size = new System.Drawing.Size(152, 22);
            this.add90.Text = "90";
            this.add90.Click += new System.EventHandler(this.add90_Click);
            // 
            // add130
            // 
            this.add130.Name = "add130";
            this.add130.Size = new System.Drawing.Size(152, 22);
            this.add130.Text = "130";
            this.add130.Click += new System.EventHandler(this.add130_Click);
            // 
            // destinationMenuItem
            // 
            this.destinationMenuItem.Name = "destinationMenuItem";
            this.destinationMenuItem.Size = new System.Drawing.Size(152, 22);
            this.destinationMenuItem.Text = "cél";
            this.destinationMenuItem.Click += new System.EventHandler(this.destinationMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 582);
            this.Controls.Add(this.myMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl myMap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem add30;
        private System.Windows.Forms.ToolStripMenuItem add50;
        private System.Windows.Forms.ToolStripMenuItem add90;
        private System.Windows.Forms.ToolStripMenuItem add130;
        private System.Windows.Forms.ToolStripMenuItem destinationMenuItem;
    }
}

