using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Logic
{
    public class HistoricalEventApi
    {
        public static async Task<List<HistoricalEvent>> GetHistoricalEvents(string i_Year)
        {
            List<HistoricalEvent> result;
            string uriRequest = String.Format("https://api.api-ninjas.com/v1/historicalevents?year={0}", i_Year);
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uriRequest),
                Headers =
                                      {
                                          { "X-Api-Key", "8JcQFd1Hv/z+uKLYMmYoLw==5liur3ziCAeKXee7" }
                                      },
            };

            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                result = parseJson(body);
            }

            return result;
        }

        private static List<HistoricalEvent> parseJson(string i_Json)
        {
            int yearIndex = 3;
            int monthIndex = 7;
            int dayIndex = 11;
            int eventIndex = 15;
            List<HistoricalEvent> events = new List<HistoricalEvent>();
            i_Json = i_Json.Trim('[', ']').Replace("},", "}|");

            string[] eventStrings = i_Json.Split('|');

            foreach (string eventStr in eventStrings)
            {
                string[] parts = eventStr.Split('"');
                HistoricalEvent eventData = new HistoricalEvent
                {
                    Year = parts[yearIndex],
                    Month = parts[monthIndex],
                    Day = parts[dayIndex],
                    EventDescription = parts[eventIndex]
                };
                events.Add(eventData);
            }

            return events;
        }
    }
}
