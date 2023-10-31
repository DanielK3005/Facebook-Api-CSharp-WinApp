using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FetchCommands
{
    internal class FetchHistoricalEvents: ICommand
    {
        private FacebookAppFacade m_AppFacade;
        private ListBox m_HistoricalEventsLB;

        public FetchHistoricalEvents(ListBox i_HistoricalEventsLB, FacebookAppFacade i_AppFacade)
        {
            m_AppFacade = i_AppFacade;
            m_HistoricalEventsLB = i_HistoricalEventsLB;
        }

        public void Execute()
        {
            fertchHistoricalEvents();
        }


        private async void fertchHistoricalEvents()
        {
            List<HistoricalEvent> hEvents = await m_AppFacade.GetHistoricalEventsAsync();

            foreach (HistoricalEvent h_event in hEvents)
            {
                m_HistoricalEventsLB.Items.Add(h_event.ToString());
                m_HistoricalEventsLB.Items.Add(h_event.EventDescription);
            }
        }
    }
}
