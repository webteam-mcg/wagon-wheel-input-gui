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
            var values = new Dictionary<string, string>
            {

                { "player", ID },
                { "team", Team },
                { "session", Convert.ToString(Session) },
                { "score", Convert.ToString(Shot) },
                { "x", Convert.ToString(X) },
                { "y", Convert.ToString(Y) }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://localhost:4000/api/v1/score", content);
            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }
        public static void playerList()
        {
            WebRequest request = WebRequest.Create("http://localhost:4000/api/v1/player/mcg");
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
