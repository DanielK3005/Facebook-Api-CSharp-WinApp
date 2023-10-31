using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacebookAppFacade
    {
        private LoginResult m_LoginResult;
        private SingeltonUserData m_UserData;
        private FacebookObjectProxy m_FacebookObjectProxy;

        private static readonly string[] s_Permissions = new string[] { "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"};

        public SingeltonUserData UserData { get { return m_UserData; } private set { m_UserData = value; } }

        public List<Album> Albums { get { return m_FacebookObjectProxy.GetAlbums(); } }

        public List<Post> Posts { get { return m_FacebookObjectProxy.GetPosts(); } }

        public List<Page> LikedPages { get { return m_FacebookObjectProxy.GetLikedPages(); } }

        public FacebookAppFacade()
        {
            FacebookService.s_CollectionLimit = 100;
            m_UserData = SingeltonUserData.StaticInstance;
            m_UserData.RememberMe = new RememberMeSaver();
            loadRememberMe();
        }

        private void loadRememberMe()
        {
            m_UserData.RememberMe = RememberMeSaver.LoadFromFile();
            if (IsRememberMeChecked())
            {
                connectUser();
            }
        }

        public bool IsRememberMeChecked()
        {
            return (m_UserData.RememberMe.IsRememberUser && !string.IsNullOrEmpty(m_UserData.RememberMe.LastAccessToken));
        }

        private void connectUser()
        {
            m_LoginResult = FacebookService.Connect(m_UserData.RememberMe.LastAccessToken);
            m_UserData.LoggedInUser = m_LoginResult.LoggedInUser;
            m_UserData.AccessToken = m_LoginResult.AccessToken;
        }

        public void LoginUser()
        {
            m_LoginResult = FacebookService.Login("1437878470334430", s_Permissions);
            if(IsLoginSucceeded())
            {
                m_UserData.LoggedInUser = m_LoginResult.LoggedInUser;
                m_UserData.AccessToken = m_LoginResult.AccessToken;
            }
        }

        public bool IsLoginSucceeded()
        {
            return (!string.IsNullOrEmpty(m_LoginResult.AccessToken));
        }

        public void InitializeFacebookObject()
        {
            m_FacebookObjectProxy = new FacebookObjectProxy(m_UserData);
        }

        public void LogOutUser(bool i_IsRememberMeChecked)
        {
            FacebookService.LogoutWithUI();
            FetchingRememberMeSaver(i_IsRememberMeChecked);
            m_LoginResult = null;
        }

        public void FetchingRememberMeSaver(bool i_IsRememberMeChecked)
        {
            if (i_IsRememberMeChecked)
            {
                m_UserData.RememberMe.IsRememberUser = i_IsRememberMeChecked;
                m_UserData.RememberMe.LastAccessToken = m_UserData.AccessToken;
                m_UserData.RememberMe.SaveToFile();
            }
            else
            {
                m_UserData.RememberMe.IsRememberUser = i_IsRememberMeChecked;
                m_UserData.RememberMe.LastAccessToken = null;
                m_UserData.RememberMe.SaveToFile();
            }
        }

        public void StartCheckersGame()
        {
            string player1Name = (m_UserData.LoggedInUser.FirstName + " " + m_UserData.LoggedInUser.LastName);
            FormGameBoard checkersMenu = new FormGameBoard(player1Name);
            checkersMenu.ShowDialog();
        }

        public async Task<List<HistoricalEvent>> GetHistoricalEventsAsync()
        {
            string year = extractYearFromBirthdate();
            return await HistoricalEventApi.GetHistoricalEvents(year);
        }

        private string extractYearFromBirthdate()
        {
            string[] dateParts = m_UserData.LoggedInUser.Birthday.Split('/');

            return dateParts[dateParts.Length - 1];
        }
    }
}
