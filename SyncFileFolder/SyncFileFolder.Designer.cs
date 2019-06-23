namespace SyncFileFolder
{
    partial class syncfilefolder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(syncfilefolder));
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageSync = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroButtonSync = new MetroFramework.Controls.MetroButton();
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxDestination = new MetroFramework.Controls.MetroTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroButtonDestination = new MetroFramework.Controls.MetroButton();
            this.groupOrigination = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTextBoxOrigination = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButtonOrigination = new MetroFramework.Controls.MetroButton();
            this.metroTabPageViewImage = new MetroFramework.Controls.MetroTabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureViewer = new System.Windows.Forms.PictureBox();
            this.groupBoxListFiles = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metroGridListImage = new MetroFramework.Controls.MetroGrid();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupButtonAction = new System.Windows.Forms.GroupBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pic_save = new System.Windows.Forms.PictureBox();
            this.rotate_left = new System.Windows.Forms.PictureBox();
            this.rotate_right = new System.Windows.Forms.PictureBox();
            this.groupHeader = new System.Windows.Forms.GroupBox();
            this.metroTextBoxShowPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonBrowser = new MetroFramework.Controls.MetroButton();
            this.folderOrigination = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.metroTabControl.SuspendLayout();
            this.metroTabPageSync.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxDestination.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupOrigination.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPageViewImage.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).BeginInit();
            this.groupBoxListFiles.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).BeginInit();
            this.groupButtonAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_right)).BeginInit();
            this.groupHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPageSync);
            this.metroTabControl.Controls.Add(this.metroTabPageViewImage);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(816, 404);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPageSync
            // 
            this.metroTabPageSync.Controls.Add(this.groupBox3);
            this.metroTabPageSync.Controls.Add(this.groupBoxDestination);
            this.metroTabPageSync.Controls.Add(this.groupOrigination);
            this.metroTabPageSync.HorizontalScrollbarBarColor = true;
            this.metroTabPageSync.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageSync.HorizontalScrollbarSize = 10;
            this.metroTabPageSync.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageSync.Name = "metroTabPageSync";
            this.metroTabPageSync.Size = new System.Drawing.Size(808, 362);
            this.metroTabPageSync.TabIndex = 0;
            this.metroTabPageSync.Text = "SyncFolder";
            this.metroTabPageSync.VerticalScrollbarBarColor = true;
            this.metroTabPageSync.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageSync.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroButtonSync);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(808, 85);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // metroButtonSync
            // 
            this.metroButtonSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonSync.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonSync.Location = new System.Drawing.Point(3, 16);
            this.metroButtonSync.Name = "metroButtonSync";
            this.metroButtonSync.Size = new System.Drawing.Size(802, 66);
            this.metroButtonSync.TabIndex = 0;
            this.metroButtonSync.Text = "Sync";
            this.metroButtonSync.UseSelectable = true;
            this.metroButtonSync.Click += new System.EventHandler(this.metroButtonSync_Click);
            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Controls.Add(this.groupBox4);
            this.groupBoxDestination.Controls.Add(this.groupBox5);
            this.groupBoxDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDestination.Location = new System.Drawing.Point(0, 62);
            this.groupBoxDestination.Name = "groupBoxDestination";
            this.groupBoxDestination.Size = new System.Drawing.Size(808, 62);
            this.groupBoxDestination.TabIndex = 6;
            this.groupBoxDestination.TabStop = false;
            this.groupBoxDestination.Text = "Destination";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.metroTextBoxDestination);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(41, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(764, 43);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // metroTextBoxDestination
            // 
            this.metroTextBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxDestination.Lines = new string[0];
            this.metroTextBoxDestination.Location = new System.Drawing.Point(3, 16);
            this.metroTextBoxDestination.MaxLength = 32767;
            this.metroTextBoxDestination.Name = "metroTextBoxDestination";
            this.metroTextBoxDestination.PasswordChar = '\0';
            this.metroTextBoxDestination.ReadOnly = true;
            this.metroTextBoxDestination.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDestination.SelectedText = "";
            this.metroTextBoxDestination.Size = new System.Drawing.Size(758, 24);
            this.metroTextBoxDestination.TabIndex = 0;
            this.metroTextBoxDestination.UseSelectable = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroButtonDestination);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(38, 43);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // metroButtonDestination
            // 
            this.metroButtonDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonDestination.Location = new System.Drawing.Point(3, 16);
            this.metroButtonDestination.Name = "metroButtonDestination";
            this.metroButtonDestination.Size = new System.Drawing.Size(32, 24);
            this.metroButtonDestination.TabIndex = 4;
            this.metroButtonDestination.Text = "...";
            this.metroButtonDestination.UseSelectable = true;
            this.metroButtonDestination.Click += new System.EventHandler(this.metroButtonDestination_Click);
            // 
            // groupOrigination
            // 
            this.groupOrigination.Controls.Add(this.groupBox2);
            this.groupOrigination.Controls.Add(this.groupBox1);
            this.groupOrigination.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOrigination.Location = new System.Drawing.Point(0, 0);
            this.groupOrigination.Name = "groupOrigination";
            this.groupOrigination.Size = new System.Drawing.Size(808, 62);
            this.groupOrigination.TabIndex = 5;
            this.groupOrigination.TabStop = false;
            this.groupOrigination.Text = "Origination";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.metroTextBoxOrigination);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(41, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 43);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // metroTextBoxOrigination
            // 
            this.metroTextBoxOrigination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxOrigination.Lines = new string[0];
            this.metroTextBoxOrigination.Location = new System.Drawing.Point(3, 16);
            this.metroTextBoxOrigination.MaxLength = 32767;
            this.metroTextBoxOrigination.Name = "metroTextBoxOrigination";
            this.metroTextBoxOrigination.PasswordChar = '\0';
            this.metroTextBoxOrigination.ReadOnly = true;
            this.metroTextBoxOrigination.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOrigination.SelectedText = "";
            this.metroTextBoxOrigination.Size = new System.Drawing.Size(758, 24);
            this.metroTextBoxOrigination.TabIndex = 0;
            this.metroTextBoxOrigination.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButtonOrigination);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(38, 43);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // metroButtonOrigination
            // 
            this.metroButtonOrigination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonOrigination.Location = new System.Drawing.Point(3, 16);
            this.metroButtonOrigination.Name = "metroButtonOrigination";
            this.metroButtonOrigination.Size = new System.Drawing.Size(32, 24);
            this.metroButtonOrigination.TabIndex = 4;
            this.metroButtonOrigination.Text = "...";
            this.metroButtonOrigination.UseSelectable = true;
            this.metroButtonOrigination.Click += new System.EventHandler(this.metroButtonOrigination_Click);
            // 
            // metroTabPageViewImage
            // 
            this.metroTabPageViewImage.Controls.Add(this.groupBox8);
            this.metroTabPageViewImage.Controls.Add(this.groupBoxListFiles);
            this.metroTabPageViewImage.Controls.Add(this.groupHeader);
            this.metroTabPageViewImage.HorizontalScrollbarBarColor = true;
            this.metroTabPageViewImage.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageViewImage.HorizontalScrollbarSize = 10;
            this.metroTabPageViewImage.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageViewImage.Name = "metroTabPageViewImage";
            this.metroTabPageViewImage.Size = new System.Drawing.Size(808, 362);
            this.metroTabPageViewImage.TabIndex = 1;
            this.metroTabPageViewImage.Text = "View Images";
            this.metroTabPageViewImage.VerticalScrollbarBarColor = true;
            this.metroTabPageViewImage.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageViewImage.VerticalScrollbarSize = 10;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureViewer);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(0, 46);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(642, 316);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Viewer";
            // 
            // pictureViewer
            // 
            this.pictureViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureViewer.Location = new System.Drawing.Point(3, 16);
            this.pictureViewer.Name = "pictureViewer";
            this.pictureViewer.Size = new System.Drawing.Size(636, 297);
            this.pictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureViewer.TabIndex = 0;
            this.pictureViewer.TabStop = false;
            // 
            // groupBoxListFiles
            // 
            this.groupBoxListFiles.Controls.Add(this.groupBox7);
            this.groupBoxListFiles.Controls.Add(this.groupButtonAction);
            this.groupBoxListFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxListFiles.Location = new System.Drawing.Point(642, 46);
            this.groupBoxListFiles.Name = "groupBoxListFiles";
            this.groupBoxListFiles.Size = new System.Drawing.Size(166, 316);
            this.groupBoxListFiles.TabIndex = 3;
            this.groupBoxListFiles.TabStop = false;
            this.groupBoxListFiles.Text = "Files";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.metroGridListImage);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox7.Location = new System.Drawing.Point(3, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(160, 253);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            // 
            // metroGridListImage
            // 
            this.metroGridListImage.AllowUserToAddRows = false;
            this.metroGridListImage.AllowUserToResizeRows = false;
            this.metroGridListImage.AutoGenerateColumns = false;
            this.metroGridListImage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridListImage.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.metroGridListImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridListImage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridListImage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridListImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metroGridListImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn});
            this.metroGridListImage.DataSource = this.imagesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridListImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridListImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridListImage.EnableHeadersVisualStyles = false;
            this.metroGridListImage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridListImage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListImage.Location = new System.Drawing.Point(3, 16);
            this.metroGridListImage.Name = "metroGridListImage";
            this.metroGridListImage.ReadOnly = true;
            this.metroGridListImage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridListImage.RowHeadersVisible = false;
            this.metroGridListImage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListImage.Size = new System.Drawing.Size(154, 234);
            this.metroGridListImage.TabIndex = 0;
            this.metroGridListImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridListImage_CellDoubleClick);
            this.metroGridListImage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridListImage_CellDoubleClick);
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagesBindingSource
            // 
            this.imagesBindingSource.DataSource = typeof(SyncFileFolder.Model.Images);
            // 
            // groupButtonAction
            // 
            this.groupButtonAction.BackColor = System.Drawing.Color.Transparent;
            this.groupButtonAction.Controls.Add(this.pic_delete);
            this.groupButtonAction.Controls.Add(this.pic_save);
            this.groupButtonAction.Controls.Add(this.rotate_left);
            this.groupButtonAction.Controls.Add(this.rotate_right);
            this.groupButtonAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupButtonAction.Enabled = false;
            this.groupButtonAction.ForeColor = System.Drawing.Color.Transparent;
            this.groupButtonAction.Location = new System.Drawing.Point(3, 269);
            this.groupButtonAction.Name = "groupButtonAction";
            this.groupButtonAction.Size = new System.Drawing.Size(160, 44);
            this.groupButtonAction.TabIndex = 1;
            this.groupButtonAction.TabStop = false;
            // 
            // pic_delete
            // 
            this.pic_delete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_delete.Image = ((System.Drawing.Image)(resources.GetObject("pic_delete.Image")));
            this.pic_delete.InitialImage = null;
            this.pic_delete.Location = new System.Drawing.Point(96, 9);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(25, 30);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_delete.TabIndex = 3;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pic_save
            // 
            this.pic_save.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_save.Image = ((System.Drawing.Image)(resources.GetObject("pic_save.Image")));
            this.pic_save.InitialImage = null;
            this.pic_save.Location = new System.Drawing.Point(65, 9);
            this.pic_save.Name = "pic_save";
            this.pic_save.Size = new System.Drawing.Size(25, 30);
            this.pic_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_save.TabIndex = 2;
            this.pic_save.TabStop = false;
            // 
            // rotate_left
            // 
            this.rotate_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rotate_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotate_left.Image = ((System.Drawing.Image)(resources.GetObject("rotate_left.Image")));
            this.rotate_left.InitialImage = null;
            this.rotate_left.Location = new System.Drawing.Point(3, 9);
            this.rotate_left.Name = "rotate_left";
            this.rotate_left.Size = new System.Drawing.Size(25, 30);
            this.rotate_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rotate_left.TabIndex = 0;
            this.rotate_left.TabStop = false;
            this.rotate_left.Click += new System.EventHandler(this.rotate_left_Click);
            // 
            // rotate_right
            // 
            this.rotate_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rotate_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotate_right.Image = ((System.Drawing.Image)(resources.GetObject("rotate_right.Image")));
            this.rotate_right.InitialImage = null;
            this.rotate_right.Location = new System.Drawing.Point(34, 9);
            this.rotate_right.Name = "rotate_right";
            this.rotate_right.Size = new System.Drawing.Size(25, 30);
            this.rotate_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rotate_right.TabIndex = 1;
            this.rotate_right.TabStop = false;
            this.rotate_right.Click += new System.EventHandler(this.rotate_right_Click);
            // 
            // groupHeader
            // 
            this.groupHeader.Controls.Add(this.metroTextBoxShowPath);
            this.groupHeader.Controls.Add(this.metroButtonBrowser);
            this.groupHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupHeader.Location = new System.Drawing.Point(0, 0);
            this.groupHeader.Name = "groupHeader";
            this.groupHeader.Size = new System.Drawing.Size(808, 46);
            this.groupHeader.TabIndex = 2;
            this.groupHeader.TabStop = false;
            this.groupHeader.Text = "Actions";
            // 
            // metroTextBoxShowPath
            // 
            this.metroTextBoxShowPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxShowPath.Lines = new string[0];
            this.metroTextBoxShowPath.Location = new System.Drawing.Point(69, 16);
            this.metroTextBoxShowPath.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.metroTextBoxShowPath.MaxLength = 32767;
            this.metroTextBoxShowPath.Name = "metroTextBoxShowPath";
            this.metroTextBoxShowPath.PasswordChar = '\0';
            this.metroTextBoxShowPath.PromptText = "Folder path";
            this.metroTextBoxShowPath.ReadOnly = true;
            this.metroTextBoxShowPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxShowPath.SelectedText = "";
            this.metroTextBoxShowPath.Size = new System.Drawing.Size(736, 27);
            this.metroTextBoxShowPath.TabIndex = 1;
            this.metroTextBoxShowPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxShowPath.UseSelectable = true;
            // 
            // metroButtonBrowser
            // 
            this.metroButtonBrowser.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroButtonBrowser.Location = new System.Drawing.Point(3, 16);
            this.metroButtonBrowser.Name = "metroButtonBrowser";
            this.metroButtonBrowser.Size = new System.Drawing.Size(66, 27);
            this.metroButtonBrowser.TabIndex = 0;
            this.metroButtonBrowser.Text = "Browser";
            this.metroButtonBrowser.UseSelectable = true;
            this.metroButtonBrowser.Click += new System.EventHandler(this.metroButtonBrowser_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // syncfilefolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 404);
            this.Controls.Add(this.metroTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "syncfilefolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sync file in a folder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPageSync.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxDestination.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupOrigination.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabPageViewImage.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewer)).EndInit();
            this.groupBoxListFiles.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).EndInit();
            this.groupButtonAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_right)).EndInit();
            this.groupHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPageSync;
        private System.Windows.Forms.GroupBox groupOrigination;
        private MetroFramework.Controls.MetroButton metroButtonOrigination;
        private MetroFramework.Controls.MetroTabPage metroTabPageViewImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOrigination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxDestination;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDestination;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton metroButtonDestination;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton metroButtonSync;
        private System.Windows.Forms.FolderBrowserDialog folderOrigination;
        private System.Windows.Forms.FolderBrowserDialog folderDestination;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBoxListFiles;
        private System.Windows.Forms.GroupBox groupHeader;
        private MetroFramework.Controls.MetroButton metroButtonBrowser;
        private MetroFramework.Controls.MetroTextBox metroTextBoxShowPath;
        private MetroFramework.Controls.MetroGrid metroGridListImage;
        private System.Windows.Forms.PictureBox pictureViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource imagesBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.GroupBox groupButtonAction;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.PictureBox pic_save;
        private System.Windows.Forms.PictureBox rotate_right;
        private System.Windows.Forms.PictureBox rotate_left;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

