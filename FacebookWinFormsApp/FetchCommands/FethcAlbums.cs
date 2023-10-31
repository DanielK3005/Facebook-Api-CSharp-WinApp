using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FetchCommands
{
    internal class FethcAlbums: ICommand
    {
        private BindingSource m_AlbumBindingSource;
        private FacebookAppFacade m_AppFacade;

        public FethcAlbums(BindingSource i_AlbumBindingSource, FacebookAppFacade i_AppFacade)
        {
            m_AlbumBindingSource = i_AlbumBindingSource;
            m_AppFacade = i_AppFacade;
        }

        public void Execute()
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            m_AlbumBindingSource.DataSource = m_AppFacade.Albums;
        }
    }
}
