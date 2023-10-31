using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures;
using Logic;
using System.Threading;
using BasicFacebookFeatures.FetchCommands;

namespace FacebookWinFormsApp
{
    public partial class FormMain : Form
    {
        private FacebookAppFacade m_AppFacade;
        private Dictionary<string,FetchItemCommand> m_FetchItems;

        private List<IControlObserver> m_ControlsToChangeVisibility;
        public FormMain()
        {
            InitializeComponent();
            m_AppFacade = new FacebookAppFacade();
            checkBoxRememberMe.Checked = m_AppFacade.UserData.RememberMe.IsRememberUser;
            m_ControlsToChangeVisibility = new List<IControlObserver>();
            m_FetchItems = new Dictionary<string, FetchItemCommand>()
            {
                { "HistoricalEvents", new FetchItemCommand() { FetchMethod = new FetchHistoricalEvents(listBoxHistoricalEvents,m_AppFacade)} },
                { "LikedPages", new FetchItemCommand() { FetchMethod = new FetchLikedPages(comboBoxLikedPages,m_AppFacade)}},
                {"Posts", new FetchItemCommand() { FetchMethod = new FetchPosts(postBindingSource,m_AppFacade)} },
                {"Albums", new FetchItemCommand() { FetchMethod = new FethcAlbums(albumBindingSource,m_AppFacade)}
            } };
            initControlsObserverList();
        }

        private void initControlsObserverList()
        {
            foreach (Control controlInForm in tabPage1.Controls)
            {
                if (controlInForm is Button)
                {
                    if (controlInForm.Text == "Login")
                    {
                        continue;
                    }
                }
                m_ControlsToChangeVisibility.Add(new ControlObserver(controlInForm));
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!m_AppFacade.IsRememberMeChecked())
            {
                m_AppFacade.LoginUser();
                if (!m_AppFacade.IsLoginSucceeded())
                {
                    MessageBox.Show("Login Failed");
                    return;
                }
            }

            InitializeUIComponents();
        }

        private void InitializeUIComponents()
        {
            buttonLogin.Text = $"Logged in as {m_AppFacade.UserData.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            initializeUserInformation();
            changeComponentVisabilty();
            m_AppFacade.InitializeFacebookObject();
        }

        private void initializeUserInformation()
        {
            circlePictureBoxProfile.ImageLocation = m_AppFacade.UserData.LoggedInUser.PictureNormalURL;
            listBoxUserInformation.Items.Clear();
            listBoxUserInformation.Items.Add(m_AppFacade.UserData.LoggedInUser.FirstName);
            listBoxUserInformation.Items.Add(m_AppFacade.UserData.LoggedInUser.LastName);
            listBoxUserInformation.Items.Add(m_AppFacade.UserData.LoggedInUser.Birthday);
            listBoxUserInformation.Items.Add(m_AppFacade.UserData.LoggedInUser.Gender);
            listBoxUserInformation.Items.Add(m_AppFacade.UserData.LoggedInUser.Email);
        }

        private void changeComponentVisabilty()
        {
            foreach (ControlObserver control in m_ControlsToChangeVisibility)
            {
                control.Update();
            }
        }

        private void resetComponentsToInitialState()
        {
            resetButtonsAfterLogedOut();
            clearAllComboBoxs();
            clearAllPictureBox();
            clearAllListBoxs();
        }

        private void resetButtonsAfterLogedOut()
        {
            buttonLogin.Enabled = true;
        }

        private void clearAllComboBoxs()
        {
            comboBoxAlbums.Text = "Select your album";
            comboBoxLikedPages.Items.Clear();
            comboBoxLikedPages.Text = "Select your liked page";
            comboBoxFetchPosts.Text = "Select your post";
        }

        private void clearAllPictureBox()
        {
            circlePictureBoxProfile.Image = null;
        }

        private void clearAllListBoxs()
        {
            listBoxUserInformation.Items.Clear();
            listBoxHistoricalEvents.Items.Clear();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_AppFacade.LogOutUser(checkBoxRememberMe.Checked);
            resetComponentsToInitialState();
            changeComponentVisabilty();
        }

        protected override void OnFormClosing(FormClosingEventArgs i_e)
        {
            base.OnFormClosing(i_e);
            m_AppFacade.FetchingRememberMeSaver(checkBoxRememberMe.Checked);
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            m_FetchItems["Albums"].Selected();
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            m_FetchItems["Posts"].Selected();
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(m_FetchItems["LikedPages"].Selected).Start();
        }

        private void comboBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedLikedPage();
        }

        private void displaySelectedLikedPage()
        {
            Page selectedPage = m_AppFacade.LikedPages[comboBoxLikedPages.SelectedIndex];
            if (selectedPage.PictureNormalURL != null)
            {
                pictureBoxLikedPages.LoadAsync(selectedPage.PictureLargeURL);
            }
            else
            {
                pictureBoxLikedPages.Image = pictureBoxLikedPages.ErrorImage;
            }
        }

        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            m_AppFacade.StartCheckersGame();
        }

        private void linkLabelFetchHistoricalEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_FetchItems["HistoricalEvents"].Selected();
        }
    }
}
