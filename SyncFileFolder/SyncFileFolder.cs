using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetadataExtractor;
using SyncFileFolder.Adapter;
using SyncFileFolder.Model;

namespace SyncFileFolder
{
    public partial class syncfilefolder : Form
    {

        List<Images> lstImageSource = new List<Images>();
        Image imgOriginal;
        int check = 0;
        System.Windows.Forms.Timer MyTimer;
        bool isInit = false;
        bool isKeyLoad = false;
        decimal defaultSize = 0;
        decimal pictureViewSizeDefault = 0;

        public syncfilefolder()
        {
            InitializeComponent();
            isInit = true;
            this.Text += " _ v" + Application.ProductVersion;
            //INITMoveImage();
            this.pictureViewer.MouseWheel += PictureViewer_MouseWheel;
            this.metroTabControl.SelectTab(0);
        }



        private Point firstPoint = new Point();

        #region SyncerTab


        private void metroButtonOrigination_Click(object sender, EventArgs e)
        {
            if (folderOrigination.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxOrigination.Text = folderOrigination.SelectedPath;
                Environment.SpecialFolder root = folderOrigination.RootFolder;
                //folderOrigination.ShowNewFolderButton = false;
            }
        }

        private void metroButtonDestination_Click(object sender, EventArgs e)
        {

            if (folderDestination.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxDestination.Text = folderDestination.SelectedPath;
                Environment.SpecialFolder root = folderDestination.RootFolder;
            }
        }

        private void metroButtonSync_Click(object sender, EventArgs e)
        {
            try
            {
                // check url Origination and Destination
                if (System.IO.Directory.Exists(metroTextBoxDestination.Text) && System.IO.Directory.Exists(metroTextBoxOrigination.Text))
                {
                    // get file on Originatio 
                    var filesOriginations = System.IO.Directory.GetFiles(metroTextBoxOrigination.Text, "*.*", SearchOption.TopDirectoryOnly);
                    var filesDestinations = System.IO.Directory.GetFiles(metroTextBoxDestination.Text, "*.*",SearchOption.TopDirectoryOnly);
                    var fileOriginPath = filesOriginations.Select(c => Path.GetFileNameWithoutExtension(c));
                    var fileDesPath = filesDestinations.Select(c => Path.GetFileNameWithoutExtension(c));
                    var fileDelete = fileDesPath.Where(c => !fileOriginPath.Contains(c));
                    foreach (var file in filesDestinations)
                    {
                        if (fileDelete.Contains(Path.GetFileNameWithoutExtension(file)))
                        {
                            File.Delete(file);
                        }
                    }
                    // get files on Destination
                    // delete files on Destination
                }
                MessageBox.Show("Successfully!", "Sync file in a folder", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        #region ViewImageTab

        public void SetImage()
        {
            try
            {
                if (metroGridListImage.CurrentRow != null && metroGridListImage.CurrentRow.Cells[0].Value != null)
                {
                    var currentPath = metroGridListImage.CurrentRow.Cells[0].Value.ToString();
                    if (string.IsNullOrEmpty(currentPath)) return;
                    ReadFileInfo(currentPath);
                    if (imgOriginal != null)
                        imgOriginal.Dispose();
                    imgOriginal = Image.FromFile(currentPath);
                    pictureViewSizeDefault = Math.Round(((decimal)pictureViewer.Height - (decimal)imgOriginal.Height) / imgOriginal.Height * 100, 0);
                    defaultSize = pictureViewSizeDefault;
                    Zoom();
                    firstPoint = pictureViewer.Location;
                    groupButtonAction.Enabled = true;
                    metroGridListImage.Select();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Set image fail", "LoadImage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #region ActionForm  
        private void metroGridListImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetImage();
        }

        private void metroButtonBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxShowPath.Text = folderBrowser.SelectedPath;
                Environment.SpecialFolder root = folderBrowser.RootFolder;
                lstImageSource = Core.GetListFile(metroTextBoxShowPath.Text);
                imagesBindingSource.DataSource = lstImageSource;
                if (lstImageSource.Count > 0)
                {
                    SetImage();
                }

            }
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure delete image: " + Path.GetFileName(metroGridListImage.CurrentRow.Cells[0].Value.ToString()), "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var currentPath = metroGridListImage.CurrentRow.Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(currentPath))
                    {
                        imagesBindingSource.RemoveCurrent();
                        imagesBindingSource.ResetCurrentItem();
                        var oldPath = currentPath;
                        currentPath = metroGridListImage.CurrentRow.Cells[0].Value.ToString();
                        SetImage();
                        File.Delete(oldPath);
                        //MessageBox.Show("Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (isKeyLoad)
            {
                SetImage();
                MyTimer.Stop();
                MyTimer.Dispose();
                isKeyLoad = false;
                return;
            }
            var lstImages = (List<Images>)imagesBindingSource.DataSource;
            if (lstImages != null && lstImages.IndexOf((Images)imagesBindingSource.Current) == 0)
            {
                imagesBindingSource.MovePrevious();
                imagesBindingSource.ResetCurrentItem();
                SetImage();
            }      
            isKeyLoad = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isKeyLoad)
            {
                SetImage();
                MyTimer.Stop();
                MyTimer.Dispose();
                isKeyLoad = false;
                return;
            }
            var lstImages = (List<Images>)imagesBindingSource.DataSource;
            if (lstImages != null && lstImages.IndexOf((Images)imagesBindingSource.Current) == lstImages.Count - 1)
            {
                imagesBindingSource.MoveNext();
                imagesBindingSource.ResetCurrentItem();
                SetImage();
            }               
            isKeyLoad = false;
        }
        #endregion
        #region RotateImage
        private void rotate_left_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                //pictureViewer.Image.Save(pictureViewer.ImageLocation, System.Drawing.Imaging.ImageFormat.Jpeg);
                pictureViewer.Refresh();
            }
        }

        private void rotate_right_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                //pictureViewer.Image.Save(pictureViewer.ImageLocation, System.Drawing.Imaging.ImageFormat.Jpeg);
                pictureViewer.Refresh();
            }
        }
        #endregion

        #region ZoomImage
        public void Zoom()
        {
            try
            {
                decimal moresise = defaultSize;
                Bitmap bmp = new Bitmap(imgOriginal, (int)(imgOriginal.Width + (imgOriginal.Width * moresise / 100)), (int)(imgOriginal.Height + (imgOriginal.Height * moresise / 100)));
                Graphics g = Graphics.FromImage(bmp);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                //pictureViewer = new PictureBox();
                pictureViewer.Image = bmp;
                pictureViewer.Refresh();
            }
            catch (Exception ex)
            {

            }

        }
        private void PictureViewer_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
                // check level zoom out
                if (check == 20) return;
                check++;
                defaultSize += 10;
                Thread taskZoom = new Thread(new ThreadStart(Zoom));
                taskZoom.Start();

            }
            else
            {   // check level zoom out
                if (check == 0) return;

                check--;
                defaultSize -= 10;
                if (defaultSize < pictureViewSizeDefault) defaultSize = pictureViewSizeDefault;
                Thread taskZoom = new Thread(new ThreadStart(Zoom));
                taskZoom.Start();
            }
        }
        private void pictureViewer_ClientSizeChanged(object sender, EventArgs e)
        {
            SetImage();
        }
        public void INITMoveImage()
        {
            if (!isInit) return;
            pictureViewer.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureViewer.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);
                    pictureViewer.Location = new Point(pictureViewer.Location.X - res.X, pictureViewer.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
            isInit = false;
        }
        private void pictureViewer_DoubleClick(object sender, EventArgs e)
        {
            defaultSize = pictureViewSizeDefault;
            Zoom();
        }

        #endregion

        #endregion


        private void metroGridListImage_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Down)
                {
                    isKeyLoad = true;
                    MyTimer = new System.Windows.Forms.Timer();
                    MyTimer.Interval = 1; // 1 s
                    MyTimer.Tick += new EventHandler(btnNext_Click);
                    MyTimer.Start();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    isKeyLoad = true;
                    MyTimer = new System.Windows.Forms.Timer();
                    MyTimer.Interval = 1; // 0.5s
                    MyTimer.Tick += new EventHandler(btnPre_Click);
                    MyTimer.Start();
                }
                else if (e.KeyCode == Keys.Left)
                {
                    rotate_left_Click(null, null);
                }
                else if (e.KeyCode == Keys.Right)
                {
                    rotate_right_Click(null, null);
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    pic_delete_Click(null, null);
                }
                else if (e.KeyCode == Keys.F1)
                {
                    infoGroup.Visible = !infoGroup.Visible;
                }
            }
        }

        private void pictureViewer_Click(object sender, EventArgs e)
        {
            infoGroup.Visible = false;
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoGroup.Visible = true;
        }
        public void ReadFileInfo(string path)
        {   
            var imageExif = ImageMetadataReader.ReadMetadata(path); 
            labFileName.Text = imageExif[9].Tags[0].Description;
            labDate.Text = imageExif[9].Tags[2].Description;    
            labFileSize.Text = Math.Round(float.Parse(imageExif[9].Tags[1].Description.Split(' ')[0])/1024/1024, 2) + " MB";
            labImageSize.Text = imageExif[0].Tags[3].Description.Split(' ')[0] + " x " + imageExif[0].Tags[2].Description.Split(' ')[0];
            labShot.Text = imageExif[2].Tags[0].Description + " "+ imageExif[2].Tags[1].Description + " " + imageExif[3].Tags[24].Description.Split(' ')[0];
            labISO.Text = imageExif[2].Tags[3].Description;
            labDevice.Text = imageExif[1].Tags[1].Description;

        }
    }
}
