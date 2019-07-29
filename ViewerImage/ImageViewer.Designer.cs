namespace ViewerImage
{
    partial class ImageViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewer));
            this.groupAction = new System.Windows.Forms.GroupBox();
            this.groupViewer = new System.Windows.Forms.GroupBox();
            this.metroOpen = new MetroFramework.Controls.MetroButton();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.pictureViewer = new System.Windows.Forms.PictureBox();
            this.rotato_left = new System.Windows.Forms.PictureBox();
            this.rotato_right = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.bindingImages = new System.Windows.Forms.BindingSource(this.components);
            this.labFileName = new System.Windows.Forms.Label();
            this.groupAction.SuspendLayout();
            this.groupViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotato_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotato_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingImages)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAction
            // 
            this.groupAction.Controls.Add(this.rotato_left);
            this.groupAction.Controls.Add(this.rotato_right);
            this.groupAction.Controls.Add(this.delete);
            this.groupAction.Controls.Add(this.metroOpen);
            this.groupAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupAction.Location = new System.Drawing.Point(0, 401);
            this.groupAction.Name = "groupAction";
            this.groupAction.Size = new System.Drawing.Size(800, 49);
            this.groupAction.TabIndex = 0;
            this.groupAction.TabStop = false;
            this.groupAction.Text = "Action";
            // 
            // groupViewer
            // 
            this.groupViewer.Controls.Add(this.labFileName);
            this.groupViewer.Controls.Add(this.pictureRight);
            this.groupViewer.Controls.Add(this.pictureLeft);
            this.groupViewer.Controls.Add(this.pictureViewer);
            this.groupViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupViewer.Location = new System.Drawing.Point(0, 0);
            this.groupViewer.Name = "groupViewer";
            this.groupViewer.Size = new System.Drawing.Size(800, 401);
            this.groupViewer.TabIndex = 0;
            this.groupViewer.TabStop = false;
            this.groupViewer.Text = "Viewer";
            // 
            // metroOpen
            // 
            this.metroOpen.Location = new System.Drawing.Point(6, 16);
            this.metroOpen.Name = "metroOpen";
            this.metroOpen.Size = new System.Drawing.Size(79, 30);
            this.metroOpen.TabIndex = 1;
            this.metroOpen.Text = "Open Image";
            this.metroOpen.UseSelectable = true;
            this.metroOpen.Click += new System.EventHandler(this.metroOpen_Click);
            // 
            // pictureRight
            // 
            this.pictureRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureRight.Image")));
            this.pictureRight.Location = new System.Drawing.Point(779, 16);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(18, 382);
            this.pictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRight.TabIndex = 0;
            this.pictureRight.TabStop = false;
            this.pictureRight.Click += new System.EventHandler(this.pictureRight_Click);
            // 
            // pictureLeft
            // 
            this.pictureLeft.BackColor = System.Drawing.Color.Transparent;
            this.pictureLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureLeft.Image")));
            this.pictureLeft.InitialImage = null;
            this.pictureLeft.Location = new System.Drawing.Point(3, 16);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(19, 382);
            this.pictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLeft.TabIndex = 0;
            this.pictureLeft.TabStop = false;
            this.pictureLeft.Click += new System.EventHandler(this.pictureLeft_Click);
            // 
            // pictureViewer
            // 
            this.pictureViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureViewer.Image = ((System.Drawing.Image)(resources.GetObject("pictureViewer.Image")));
            this.pictureViewer.Location = new System.Drawing.Point(3, 16);
            this.pictureViewer.Name = "pictureViewer";
            this.pictureViewer.Size = new System.Drawing.Size(794, 382);
            this.pictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureViewer.TabIndex = 0;
            this.pictureViewer.TabStop = false;
            // 
            // rotato_left
            // 
            this.rotato_left.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.rotato_left.Dock = System.Windows.Forms.DockStyle.Right;
            this.rotato_left.Image = global::ViewerImage.Properties.Resources.Rotate_left;
            this.rotato_left.Location = new System.Drawing.Point(677, 16);
            this.rotato_left.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.rotato_left.Name = "rotato_left";
            this.rotato_left.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.rotato_left.Size = new System.Drawing.Size(39, 30);
            this.rotato_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotato_left.TabIndex = 2;
            this.rotato_left.TabStop = false;
            this.rotato_left.Click += new System.EventHandler(this.rotato_left_Click);
            // 
            // rotato_right
            // 
            this.rotato_right.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.rotato_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.rotato_right.Image = global::ViewerImage.Properties.Resources.Rotate_right;
            this.rotato_right.Location = new System.Drawing.Point(716, 16);
            this.rotato_right.Name = "rotato_right";
            this.rotato_right.Size = new System.Drawing.Size(39, 30);
            this.rotato_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotato_right.TabIndex = 2;
            this.rotato_right.TabStop = false;
            this.rotato_right.Click += new System.EventHandler(this.rotato_right_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete.Image = global::ViewerImage.Properties.Resources.delete;
            this.delete.Location = new System.Drawing.Point(755, 16);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(42, 30);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete.TabIndex = 2;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // labFileName
            // 
            this.labFileName.AutoSize = true;
            this.labFileName.BackColor = System.Drawing.Color.Transparent;
            this.labFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFileName.Location = new System.Drawing.Point(28, 16);
            this.labFileName.Name = "labFileName";
            this.labFileName.Size = new System.Drawing.Size(76, 20);
            this.labFileName.TabIndex = 1;
            this.labFileName.Text = "FileName";
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupViewer);
            this.Controls.Add(this.groupAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer [_NguyenQuynh-Email:quynhvpit@outlook.om_]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupAction.ResumeLayout(false);
            this.groupViewer.ResumeLayout(false);
            this.groupViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotato_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotato_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAction;
        private System.Windows.Forms.GroupBox groupViewer;
        private MetroFramework.Controls.MetroButton metroOpen;
        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.PictureBox pictureViewer;
        private System.Windows.Forms.BindingSource bindingImages;
        private System.Windows.Forms.PictureBox rotato_left;
        private System.Windows.Forms.PictureBox rotato_right;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.Label labFileName;
    }
}