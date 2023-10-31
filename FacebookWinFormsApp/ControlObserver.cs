using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ControlObserver : IControlObserver
    {
        private Control m_ControlToChange;

        public ControlObserver(Control i_Control)
        {
            m_ControlToChange = i_Control;
        }

        public void Update()
        {
            if (m_ControlToChange != null)
            {
                m_ControlToChange.Visible = !m_ControlToChange.Visible;
            }
        }
    }
}
