using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FetchCommands
{
    internal class FetchLikedPages: ICommand
    {
        private FacebookAppFacade m_AppFacade;
        private ComboBox m_LikedPagesCB;

        public FetchLikedPages(ComboBox i_LikedPagesCB, FacebookAppFacade i_AppFacade)
        {
            m_AppFacade = i_AppFacade;
            m_LikedPagesCB = i_LikedPagesCB;
        }

        public void Execute()
        {
            fetchLikedPages();
        }


        private void fetchLikedPages()
        {
            m_LikedPagesCB.Invoke(new Action(() => m_LikedPagesCB.Items.Clear()));
            foreach (Page page in m_AppFacade.LikedPages)
            {
                if (page != null)
                {
                    m_LikedPagesCB.Invoke(new Action(() => m_LikedPagesCB.Items.Add(page.Name)));
                }
            }
        }
    }
}
