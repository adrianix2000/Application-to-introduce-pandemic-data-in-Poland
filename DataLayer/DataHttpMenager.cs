using Covid_Data.DataLayer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Data.DataLayer
{
    public class DataHttpMenager
    {

        #region Deseralize To C# objects

        public async Task<List<CountryClass>> GetListOfCountries()
        {
            List<CountryClass> countries = new List<CountryClass>();
            var downloadedString = await DownloadJSONformatAsync();

            dynamic obj = JsonConvert.DeserializeObject(downloadedString);

            downloadedString = obj["Countries"].ToString();

            countries = JsonConvert.DeserializeObject<List<CountryClass>>(downloadedString);

            return countries;

        }


        public async Task<GlobalInfoClass> GetGlobalInfo()
        {
            GlobalInfoClass result = new GlobalInfoClass();
            var downloadedString = await DownloadJSONformatAsync();

            dynamic obj = JsonConvert.DeserializeObject(downloadedString);

            downloadedString = obj["Global"].ToString();

            result = JsonConvert.DeserializeObject<GlobalInfoClass>(downloadedString);

            return result;
        }


        #endregion 



        #region Downloading JSON String From Server Method

        public async Task<string> GetJSONString()
        {
            string result = await DownloadJSONformatAsync();

            dynamic obj = JsonConvert.DeserializeObject(result);
            result = obj.ToString();
        
            return result;
        }





        public async Task<string> DownloadJSONformatAsync()
        {
            string myRequest = string.Empty;

            string urlAddress = "https://api.covid19api.com/summary";

            try
            {
                var request = HttpWebRequest.CreateHttp(urlAddress);
                request.Method = WebRequestMethods.Http.Get;
                request.ContentType = "application/json; charset=utf-8";

                await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                    .ContinueWith(myTask =>
                    {
                        var response = (HttpWebResponse)myTask.Result;

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            StreamReader responseReader = new StreamReader(
                                response.GetResponseStream(),
                                System.Text.Encoding.UTF8);

                            string responseData = responseReader.ReadToEnd();

                            myRequest = responseData.ToString();
                            responseReader.Close();
                        }

                        response.Close();
                    });
            }
            catch (Exception) { }

            return myRequest;
        }


        #endregion

    }
}
