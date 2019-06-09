﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncFileFolder.Adapter;
using SyncFileFolder.Model;

namespace SyncFileFolder
{
    public partial class syncfilefolder : Form
    {
        string currentPath = string.Empty;
        List<Images> lstImageSource = new List<Images>();
        public syncfilefolder()
        {
            InitializeComponent();
        }
        private Point firstPoint = new Point();

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
            // check url Origination and Destination
            if (Directory.Exists(metroTextBoxDestination.Text) && Directory.Exists(metroTextBoxOrigination.Text))
            {
                // get file on Originatio 
                var filesOriginations = Directory.GetFiles(metroTextBoxOrigination.Text, "*.*");
                var filesDestinations = Directory.GetFiles(metroTextBoxDestination.Text, "*.*");
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

        }

        private void metroGridListImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGridListImage.CurrentRow != null && metroGridListImage.CurrentRow.Cells[0] != null)
            {
                pictureViewer.ImageLocation = metroGridListImage.CurrentRow.Cells[0].Value.ToString(); 
                // current image selected
                currentPath = metroGridListImage.CurrentRow.Cells[0].Value.ToString();
                groupButtonAction.Enabled = true;
            }
        }

        private void metroButtonBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxShowPath.Text = folderBrowser.SelectedPath;
                Environment.SpecialFolder root = folderBrowser.RootFolder;
                lstImageSource = Core.GetListFile(metroTextBoxShowPath.Text);
                imagesBindingSource.DataSource = lstImageSource;
                currentPath = string.Empty;
            }
        }

        private void rotate_left_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.RotateFlip(RotateFlipType.Rotate90FlipXY); 
                pictureViewer.Refresh();
            }
        }

        private void rotate_right_Click(object sender, EventArgs e)
        {
            if (pictureViewer.Image != null)
            {
                pictureViewer.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureViewer.Refresh();
            }
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentPath))
            {
                File.Delete(metroGridListImage.CurrentRow.Cells[0].Value.ToString());
                lstImageSource.RemoveAt(metroGridListImage.CurrentRow.Index);
                imagesBindingSource.ResetBindings(true);
                pictureViewer.ImageLocation = "";
                pictureViewer.Refresh();
                groupButtonAction.Enabled = false;
            }
        }
    }
}