using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StockApp.Models;
using System.Diagnostics;

namespace StockApp.Service
{
    public class HistoricalDataService : HistoricalData
    {
        private List<HistoricalData> historicalDataList;

        public List<HistoricalData> getHistDataBySymbolanDuration(String symbol, String duration)
        {
            var IEXTrading_API_PATH = "https://api.iextrading.com/1.0/stock/"+symbol+"/chart/"+duration;

            IEXTrading_API_PATH = string.Format(IEXTrading_API_PATH, symbol);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //For IP-API
                client.BaseAddress = new Uri(IEXTrading_API_PATH);
                HttpResponseMessage response = client.GetAsync(IEXTrading_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    historicalDataList = response.Content.ReadAsAsync<List<HistoricalData>>().GetAwaiter().GetResult();
                    /*foreach (var historicalData in historicalDataList)
                    {
                        if (historicalData != null)
                        {
                            Debug.WriteLine("Open: " + historicalData.open);
                            Debug.WriteLine("Close: " + historicalData.close);
                            Debug.WriteLine("Low: " + historicalData.low);
                            Debug.WriteLine("High: " + historicalData.high);
                            Debug.WriteLine("Change: " + historicalData.change);
                            Debug.WriteLine("Change Percentage: " + historicalData.changePercent);
                        }
                    }*/
                    Debug.WriteLine("Data get successful");
                }
            }
            return historicalDataList;
        }
        
    }
}