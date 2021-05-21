namespace файловы_менеджер
{
    partial class Form_manager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.gobutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.listViewfiles = new System.Windows.Forms.ListView();
            this.iconlist = new System.Windows.Forms.ImageList(this.components);
            this.flename = new System.Windows.Forms.Label();
            this.filenamelabel = new System.Windows.Forms.Label();
            this.filetype = new System.Windows.Forms.Label();
            this.filetypelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(75, 14);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(611, 22);
            this.filePathTextBox.TabIndex = 1;
            // 
            // gobutton
            // 
            this.gobutton.Location = new System.Drawing.Point(692, 12);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(75, 33);
            this.gobutton.TabIndex = 2;
            this.gobutton.Text = "Go";
            this.gobutton.UseVisualStyleBackColor = true;
            this.gobutton.Click += new System.EventHandler(this.gobutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(0, 13);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // listViewfiles
            // 
            this.listViewfiles.HideSelection = false;
            this.listViewfiles.LargeImageList = this.iconlist;
            this.listViewfiles.Location = new System.Drawing.Point(0, 64);
            this.listViewfiles.Name = "listViewfiles";
            this.listViewfiles.Size = new System.Drawing.Size(767, 333);
            this.listViewfiles.SmallImageList = this.iconlist;
            this.listViewfiles.TabIndex = 5;
            this.listViewfiles.UseCompatibleStateImageBehavior = false;
            this.listViewfiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewfiles_ItemSelectionChanged);
            this.listViewfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewfiles_MouseDoubleClick);
            // 
            // iconlist
            // 
            this.iconlist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconlist.ImageSize = new System.Drawing.Size(48, 48);
            this.iconlist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flename
            // 
            this.flename.AutoSize = true;
            this.flename.Location = new System.Drawing.Point(29, 424);
            this.flename.Name = "flename";
            this.flename.Size = new System.Drawing.Size(61, 17);
            this.flename.TabIndex = 6;
            this.flename.Text = "filename";
            // 
            // filenamelabel
            // 
            this.filenamelabel.AutoSize = true;
            this.filenamelabel.Location = new System.Drawing.Point(106, 424);
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.Size = new System.Drawing.Size(18, 17);
            this.filenamelabel.TabIndex = 7;
            this.filenamelabel.Text = "--";
            // 
            // filetype
            // 
            this.filetype.AutoSize = true;
            this.filetype.Location = new System.Drawing.Point(562, 424);
            this.filetype.Name = "filetype";
            this.filetype.Size = new System.Drawing.Size(53, 17);
            this.filetype.TabIndex = 8;
            this.filetype.Text = "filetype";
            // 
            // filetypelabel
            // 
            this.filetypelabel.AutoSize = true;
            this.filetypelabel.Location = new System.Drawing.Point(651, 424);
            this.filetypelabel.Name = "filetypelabel";
            this.filetypelabel.Size = new System.Drawing.Size(18, 17);
            this.filetypelabel.TabIndex = 9;
            this.filetypelabel.Text = "--";
            // 
            // Form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filetypelabel);
            this.Controls.Add(this.filetype);
            this.Controls.Add(this.filenamelabel);
            this.Controls.Add(this.flename);
            this.Controls.Add(this.listViewfiles);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.gobutton);
            this.Controls.Add(this.filePathTextBox);
            this.Name = "Form_manager";
            this.Text = "Form_manager";
            this.Load += new System.EventHandler(this.Form_manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button gobutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.ListView listViewfiles;
        private System.Windows.Forms.Label flename;
        private System.Windows.Forms.Label filenamelabel;
        private System.Windows.Forms.Label filetype;
        private System.Windows.Forms.Label filetypelabel;
        private System.Windows.Forms.ImageList iconlist;
    }
}

