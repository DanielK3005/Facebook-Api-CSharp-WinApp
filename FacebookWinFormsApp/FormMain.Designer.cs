namespace FacebookWinFormsApp
{
    partial class FormMain
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.circlePictureBoxProfile = new BasicFacebookFeatures.CirclePictureBox();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.comboBoxFetchPosts = new System.Windows.Forms.ComboBox();
            this.linkLabelFetchHistoricalEvents = new System.Windows.Forms.LinkLabel();
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.listBoxHistoricalEvents = new System.Windows.Forms.ListBox();
            this.listBoxUserInformation = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.buttonFetchLikedPages = new System.Windows.Forms.Button();
            this.comboBoxLikedPages = new System.Windows.Forms.ComboBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            captionLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBoxProfile)).BeginInit();
            this.panelPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(242, 7);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(66, 24);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(245, 144);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(49, 24);
            linkLabel.TabIndex = 6;
            linkLabel.Text = "Link:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(242, 56);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(109, 24);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(3, 165);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(129, 24);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(464, 7);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(92, 24);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(12, 7);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(79, 24);
            captionLabel.TabIndex = 0;
            captionLabel.Text = "Caption:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(239, 28);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(113, 24);
            likesCountLabel.TabIndex = 4;
            likesCountLabel.Text = "Likes Count:";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 770);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.circlePictureBoxProfile);
            this.tabPage1.Controls.Add(this.panelPosts);
            this.tabPage1.Controls.Add(this.pictureBoxLikedPages);
            this.tabPage1.Controls.Add(this.panelAlbums);
            this.tabPage1.Controls.Add(this.comboBoxFetchPosts);
            this.tabPage1.Controls.Add(this.linkLabelFetchHistoricalEvents);
            this.tabPage1.Controls.Add(this.buttonPlayGame);
            this.tabPage1.Controls.Add(this.checkBoxRememberMe);
            this.tabPage1.Controls.Add(this.listBoxHistoricalEvents);
            this.tabPage1.Controls.Add(this.listBoxUserInformation);
            this.tabPage1.Controls.Add(this.buttonFetchPosts);
            this.tabPage1.Controls.Add(this.buttonFetchAlbums);
            this.tabPage1.Controls.Add(this.buttonFetchLikedPages);
            this.tabPage1.Controls.Add(this.comboBoxLikedPages);
            this.tabPage1.Controls.Add(this.comboBoxAlbums);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // circlePictureBoxProfile
            // 
            this.circlePictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBoxProfile.Image")));
            this.circlePictureBoxProfile.Location = new System.Drawing.Point(23, 124);
            this.circlePictureBoxProfile.Name = "circlePictureBoxProfile";
            this.circlePictureBoxProfile.Size = new System.Drawing.Size(200, 200);
            this.circlePictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePictureBoxProfile.TabIndex = 84;
            this.circlePictureBoxProfile.TabStop = false;
            this.circlePictureBoxProfile.Visible = false;
            // 
            // panelPosts
            // 
            this.panelPosts.Controls.Add(likesCountLabel);
            this.panelPosts.Controls.Add(this.likesCountLabel1);
            this.panelPosts.Controls.Add(captionLabel);
            this.panelPosts.Controls.Add(this.captionTextBox);
            this.panelPosts.Controls.Add(messageLabel);
            this.panelPosts.Controls.Add(this.messageTextBox);
            this.panelPosts.Location = new System.Drawing.Point(305, 57);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(717, 148);
            this.panelPosts.TabIndex = 83;
            this.panelPosts.Visible = false;
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentsBindingSource, "LikesCount", true));
            this.likesCountLabel1.Location = new System.Drawing.Point(239, 46);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(134, 23);
            this.likesCountLabel1.TabIndex = 5;
            this.likesCountLabel1.Text = "label1";
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postBindingSource;
            // 
            // captionTextBox
            // 
            this.captionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Caption", true));
            this.captionTextBox.Location = new System.Drawing.Point(15, 28);
            this.captionTextBox.Multiline = true;
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(212, 108);
            this.captionTextBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(379, 28);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(331, 108);
            this.messageTextBox.TabIndex = 3;
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(759, 309);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(219, 183);
            this.pictureBoxLikedPages.TabIndex = 82;
            this.pictureBoxLikedPages.TabStop = false;
            this.pictureBoxLikedPages.Visible = false;
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.imageAlbumPictureBox);
            this.panelAlbums.Controls.Add(createdTimeLabel);
            this.panelAlbums.Controls.Add(this.createdTimeLabel1);
            this.panelAlbums.Controls.Add(descriptionLabel);
            this.panelAlbums.Controls.Add(this.descriptionTextBox);
            this.panelAlbums.Controls.Add(linkLabel);
            this.panelAlbums.Controls.Add(this.linkLinkLabel);
            this.panelAlbums.Controls.Add(nameLabel);
            this.panelAlbums.Controls.Add(this.nameLabel1);
            this.panelAlbums.Location = new System.Drawing.Point(299, 306);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(410, 196);
            this.panelAlbums.TabIndex = 81;
            this.panelAlbums.Visible = false;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(6, 7);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(204, 155);
            this.imageAlbumPictureBox.TabIndex = 85;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(110, 165);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 1;
            this.createdTimeLabel1.Text = "label1";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(245, 77);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(124, 64);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(216, 165);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(177, 23);
            this.linkLinkLabel.TabIndex = 7;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(242, 33);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(127, 23);
            this.nameLabel1.TabIndex = 9;
            this.nameLabel1.Text = "label1";
            // 
            // comboBoxFetchPosts
            // 
            this.comboBoxFetchPosts.DataSource = this.postBindingSource;
            this.comboBoxFetchPosts.DisplayMember = "Message";
            this.comboBoxFetchPosts.FormattingEnabled = true;
            this.comboBoxFetchPosts.Location = new System.Drawing.Point(299, 19);
            this.comboBoxFetchPosts.Name = "comboBoxFetchPosts";
            this.comboBoxFetchPosts.Size = new System.Drawing.Size(717, 30);
            this.comboBoxFetchPosts.TabIndex = 80;
            this.comboBoxFetchPosts.Visible = false;
            // 
            // linkLabelFetchHistoricalEvents
            // 
            this.linkLabelFetchHistoricalEvents.AutoSize = true;
            this.linkLabelFetchHistoricalEvents.Location = new System.Drawing.Point(189, 569);
            this.linkLabelFetchHistoricalEvents.Name = "linkLabelFetchHistoricalEvents";
            this.linkLabelFetchHistoricalEvents.Size = new System.Drawing.Size(483, 24);
            this.linkLabelFetchHistoricalEvents.TabIndex = 79;
            this.linkLabelFetchHistoricalEvents.TabStop = true;
            this.linkLabelFetchHistoricalEvents.Text = "show historical events that occured on your birthday year";
            this.linkLabelFetchHistoricalEvents.Visible = false;
            this.linkLabelFetchHistoricalEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchHistoricalEvents_LinkClicked);
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.checkersLogo;
            this.buttonPlayGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlayGame.Location = new System.Drawing.Point(34, 492);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(125, 125);
            this.buttonPlayGame.TabIndex = 78;
            this.buttonPlayGame.Text = "Play\r\nCheckers";
            this.buttonPlayGame.UseVisualStyleBackColor = true;
            this.buttonPlayGame.Visible = false;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(9, 96);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(159, 28);
            this.checkBoxRememberMe.TabIndex = 77;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.Visible = false;
            // 
            // listBoxHistoricalEvents
            // 
            this.listBoxHistoricalEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBoxHistoricalEvents.FormattingEnabled = true;
            this.listBoxHistoricalEvents.HorizontalScrollbar = true;
            this.listBoxHistoricalEvents.ItemHeight = 22;
            this.listBoxHistoricalEvents.Location = new System.Drawing.Point(184, 598);
            this.listBoxHistoricalEvents.Name = "listBoxHistoricalEvents";
            this.listBoxHistoricalEvents.Size = new System.Drawing.Size(835, 114);
            this.listBoxHistoricalEvents.TabIndex = 76;
            this.listBoxHistoricalEvents.Visible = false;
            // 
            // listBoxUserInformation
            // 
            this.listBoxUserInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBoxUserInformation.FormattingEnabled = true;
            this.listBoxUserInformation.ItemHeight = 22;
            this.listBoxUserInformation.Location = new System.Drawing.Point(23, 336);
            this.listBoxUserInformation.Name = "listBoxUserInformation";
            this.listBoxUserInformation.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxUserInformation.Size = new System.Drawing.Size(223, 136);
            this.listBoxUserInformation.TabIndex = 75;
            this.listBoxUserInformation.Visible = false;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(299, 220);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(191, 38);
            this.buttonFetchPosts.TabIndex = 73;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Visible = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(299, 508);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(138, 38);
            this.buttonFetchAlbums.TabIndex = 72;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Visible = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(759, 498);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(191, 38);
            this.buttonFetchLikedPages.TabIndex = 70;
            this.buttonFetchLikedPages.Text = "Fetch Liked Pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = true;
            this.buttonFetchLikedPages.Visible = false;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // comboBoxLikedPages
            // 
            this.comboBoxLikedPages.FormattingEnabled = true;
            this.comboBoxLikedPages.Location = new System.Drawing.Point(759, 277);
            this.comboBoxLikedPages.Name = "comboBoxLikedPages";
            this.comboBoxLikedPages.Size = new System.Drawing.Size(221, 30);
            this.comboBoxLikedPages.TabIndex = 66;
            this.comboBoxLikedPages.Visible = false;
            this.comboBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLikedPages_SelectedIndexChanged);
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.DataSource = this.albumBindingSource;
            this.comboBoxAlbums.DisplayMember = "Name";
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(299, 274);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(233, 30);
            this.comboBoxAlbums.TabIndex = 57;
            this.comboBoxAlbums.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(9, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(9, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 770);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fackbook App";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBoxProfile)).EndInit();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private BasicFacebookFeatures.CirclePictureBox circlePictureBoxProfile;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.TextBox captionTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.ComboBox comboBoxFetchPosts;
        private System.Windows.Forms.LinkLabel linkLabelFetchHistoricalEvents;
        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ListBox listBoxHistoricalEvents;
        private System.Windows.Forms.ListBox listBoxUserInformation;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.ComboBox comboBoxLikedPages;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
    }
}

