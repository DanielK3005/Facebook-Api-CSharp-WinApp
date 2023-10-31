using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FetchCommands
{
    internal class FetchPosts: ICommand
    {
        private BindingSource m_PostBindingSource;
        private FacebookAppFacade m_AppFacade;


        public FetchPosts(BindingSource i_PostBindingSource, FacebookAppFacade i_AppFacade)
        {
            m_AppFacade = i_AppFacade;
            m_PostBindingSource = i_PostBindingSource;
        }

        public void Execute() 
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            m_PostBindingSource.DataSource = m_AppFacade.Posts;
        }
    }
}
