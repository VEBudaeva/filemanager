using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace файловы_менеджер
{ 
    public partial class Form_manager : Form
    {
        private string filePath = "";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form_manager()
        {
            InitializeComponent();
        }

        private void Form_manager_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();
        }
        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    filenamelabel.Text = fileDetails.Name;
                    filetypelabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listViewfiles.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        listViewfiles.Items.Add(files[i].Name);
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listViewfiles.Items.Add(dirs[i].Name);
                    }
                }
                else
                {
                    filenamelabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }
        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if(path.LastIndexOf("/")==path.Length-1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }


        }
        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listViewfiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if((fileAttr & FileAttributes.Directory)==FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listViewfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
    }
}
