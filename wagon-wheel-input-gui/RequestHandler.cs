using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace wagon_wheel_input_gui
{
    class RequestHandler:Program
    {
        public static async void addShotAsync(String ID, String Team, int Session, int Shot, int X, int Y)
        {
            HttpClient client = new HttpClient();
            /*client.BaseAddress = new Uri("https://f4e6408cf1bd.ngrok.io");
            var request = new HttpRequestMessage(HttpMethod.Post, "/api/v1/score");
            var keyValues = new List<KeyValuePair<string, string>>();

            keyValues.Add(new KeyValuePair<string, string>("player",ID));
            keyValues.Add(new KeyValuePair<string, string>("team",Team));
            keyValues.Add(new KeyValuePair<string, string>("session",Convert.ToString(Session)));
            keyValues.Add(new KeyValuePair<string, string>("score",Convert.ToString(Shot)));
            keyValues.Add(new KeyValuePair<string, string>("x",Convert.ToString(X)));
            keyValues.Add(new KeyValuePair<string, string>("y",Convert.ToString(Y)));

            request.Content = new FormUrlEncodedContent(keyValues);
            var response = await client.SendAsync(request);*/

            var values = new Dictionary<string, string>
            {

                { "player", ID },
                { "team", Team },
                { "session", Convert.ToString(Session) },
                { "score", Convert.ToString(Shot) },
                { "x", Convert.ToString(X) },
                { "y", Convert.ToString(Y) }
            };

            /*var values = new Dictionary<string, string>
             {
                 { "email","eve.holt@reqres.in"},
                 { "password","cityslicka"}
                
             };*/

            //var content = new StringContent(values.ToString(), Encoding.UTF8, "application/json");
            var content = new FormUrlEncodedContent(values);
             var response = await client.PostAsync("https://f4e6408cf1bd.ngrok.io/api/v1/score", content);
             var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }
        public static void playerList()
        {
            WebRequest request = WebRequest.Create("https://f4e6408cf1bd.ngrok.io/api/v1/player/mcg");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer + "\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
            response.Close();
        }
    }
}
