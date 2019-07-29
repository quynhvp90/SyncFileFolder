using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncFileFolder.Model;
using MetadataExtractor;

namespace ViewerImage
{
    public partial class ImageViewer : Form
    {
        Image imgOriginal;
        string pathFolder = string.Empty;
        string currentPath = string.Empty;
        List<Images> lstImages = new List<Images>();
        public ImageViewer()
        {
            InitializeComponent();
            pictureViewer.PreviewKeyDown += PictureViewer_PreviewKeyDown;
        }

        private void PictureViewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureLeft_Click(null, null);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureRight_Click(null, null);
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                rotato_left_Click(null, null);
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                rotato_right_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                delete_Click(null, null);
            }
        }

        private void metroOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileImage = new OpenFileDialog();
            fileImage.Filter = "Image file|*.jpg;*.jpeg;*.png;*.bmp;";
            if (fileImage.ShowDialog() == DialogResult.OK)
            {
                currentPath = fileImage.FileName;
                pathFolder = currentPath.Replace("\\" + fileImage.SafeFileName, "");
                string[] fileFolders = System.IO.Directory.GetFiles(pathFolder, "*.*", SearchOption.TopDirectoryOnly);
                lstImages = fileFolders.Where(q => q.ToLower().EndsWith(".jpg") || q.ToLower().EndsWith(".png") || q.ToLower().EndsWith(".bmp")).Select(q => new Images()
                {
                    FileName = Path.GetFileName(q),
                    Path = q
                }).ToList();
                bindingImages.DataSource = lstImages;
                bindingImages.Position = lstImages.IndexOf(lstImages.FirstOrDefault(q => q.Path == currentPath));
                bindingImages.ResetCurrentItem();
                SetImage();
            }
        }
        public Images GetImage()
        {
            var image = (Images)bindingImages.Current;
            if (image == null)
            {
                return new Images();
            }
            return image;
        }
        public void SetImage()
        {
            var currentPath = GetImage().Path;
            if (string.IsNullOrEmpty(currentPath))
            {
                pictureViewer.Image = null;
                return;
            };
            if (imgOriginal != null) imgOriginal.Dispose();
            imgOriginal = Image.FromFile(currentPath);
            pictureViewer.Image = imgOriginal;
            ReadFileInfo(currentPath);
            pictureViewer.Select();
        }

        private void pictureLeft_Click(object sender, EventArgs e)
        {
            bindingImages.MovePrevious();
            bindingImages.ResetCurrentItem();
            SetImage();
        }

        private void pictureRight_Click(object sender, EventArgs e)
        {
            bindingImages.MoveNext();
            bindingImages.ResetCurrentItem();
            SetImage();
        }
        #region RotateImage



        private void rotato_left_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureViewer.Refresh();
            }
        }

        private void rotato_right_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureViewer.Refresh();
            }
        }


        #endregion

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure delete image: " + GetImage().FileName, "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var currentPath = GetImage().Path;
                    if (!string.IsNullOrEmpty(currentPath))
                    {
                        bindingImages.RemoveCurrent();
                        bindingImages.ResetCurrentItem();
                        var oldPath = currentPath;
                        currentPath = GetImage().Path;
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
        public void ReadFileInfo(string path)
        {
            var imageExif = ImageMetadataReader.ReadMetadata(path);
            labFileName.Text = imageExif[9].Tags[0].Description;
            labFileName.BackColor = Color.Transparent;

        }
    }
}
