using FacebookWrapper.ObjectModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacebookObjectProxy
    {
        private SingeltonUserData m_LoggedInUser;
        private List<Album> m_UserAlbums;
        private List<Post> m_UserPosts;
        private List<Page> m_UserLikedPages;
        private static int s_CountRequestsForFatchAlbums;
        private static int s_CuntRequestsForFatchPosts;
        private static int s_CountRequestsForFatchLikedPages;

        public FacebookObjectProxy(SingeltonUserData i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            s_CountRequestsForFatchAlbums = 0;
            s_CuntRequestsForFatchPosts = 0;
            s_CountRequestsForFatchLikedPages = 0;
        }

        public List<Album> GetAlbums()
        {
            if (s_CountRequestsForFatchAlbums % 5 == 0)
            {
                SortCollcetion<Album> sortAlbum;
                sortAlbum = new SortCollcetion<Album>((album1, album2) => album1.CreatedTime > album2.CreatedTime);
                m_UserAlbums = convertFacebookCollcetionToList(m_LoggedInUser.LoggedInUser.Albums);
                m_UserAlbums = sortAlbum.MergeSort(m_UserAlbums);
            }
            s_CountRequestsForFatchAlbums++;
            
            return m_UserAlbums;
        }

        public List<Post> GetPosts()
        {
            if (s_CuntRequestsForFatchPosts % 5 == 0)
            {
                SortCollcetion<Post> sortPost;
                sortPost = new SortCollcetion<Post>((post1, post2) => post1.CreatedTime > post2.CreatedTime);
                FacebookObjectCollection<Post> postsAfterRemoveWithOutMessages = removePostsWithoutMessages(m_LoggedInUser.LoggedInUser.Posts);
                m_UserPosts = convertFacebookCollcetionToList(postsAfterRemoveWithOutMessages);
                m_UserPosts = sortPost.MergeSort(m_UserPosts);
            }
            s_CuntRequestsForFatchPosts++;

            return m_UserPosts;
        }

        private FacebookObjectCollection<Post> removePostsWithoutMessages(FacebookObjectCollection<Post> i_Posts)
        {
            FacebookObjectCollection<Post> postsWithMessages = new FacebookObjectCollection<Post>();
            foreach (Post post in i_Posts)
            {
                if (post.Message != null)
                {
                    postsWithMessages.Add(post);
                }
            }
            return postsWithMessages;
        }

        public List<Page> GetLikedPages() 
        {
            if (s_CountRequestsForFatchLikedPages % 5 == 0)
            {
                SortCollcetion<Page> sortPage;
                sortPage = new SortCollcetion<Page>((page1, page2) => 0 > page1.Name.CompareTo(page2.Name));
                m_UserLikedPages = convertFacebookCollcetionToList(m_LoggedInUser.LoggedInUser.LikedPages);
                m_UserLikedPages = sortPage.MergeSort(m_UserLikedPages);
            }
            s_CountRequestsForFatchLikedPages++;

            return m_UserLikedPages;

        }

        private List<T> convertFacebookCollcetionToList<T>(FacebookObjectCollection<T> i_Collection)
        {
            List<T> listToReturn = new List<T>();
            foreach (T item in i_Collection)
            {
                listToReturn.Add(item);
            }
            return listToReturn;
        }
    }
}

