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
            /*HttpClient client = new HttpClient();
				.build();
            MediaType mediaType = MediaType.parse("application/x-www-form-urlencoded");
            RequestBody body = RequestBody.create(mediaType, "player=" + playerID + "&team=" + playerTeam + "&session=" + playerSession + "&score=" + scoreShot + "&x=" + scoreX + "&y=" + scoreY);
            Request request = new Request.Builder()
                .url("http://ec2-18-220-157-143.us-east-2.compute.amazonaws.com:4000/api/v1/score")
                .method("POST", body)
                .addHeader("Content-Type", "application/x-www-form-urlencoded")
                .build();
            Response response = client.newCall(request).execute();*/

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

            var response = await client.PostAsync("https://reqres.in/api/users", content);

            var responseString = await response.Content.ReadAsStringAsync();

        }
        public static void playerList()
        {

            WebRequest request = WebRequest.Create("https://reqres.in/api/users?page=2");

            // If required by the server, set the credentials.

            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.

            WebResponse response = request.GetResponse();

            // Display the status.

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.

            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }

            // Close the response.
            response.Close();
        }

        public static void players()
        {
            /*
                //Json get from the Response body
                Console.WriteLine("Main Array : "+ playerList(pteam).string());
                //Add Response body to the Json Array
                JSONArray jarray=new JSONArray(playerList(pteam).string());
		            //Iterate on jArray to get Each players Details
		            for (int i = 0; i<jarray.length() ; i++) 
		            {	
			            //Get Each Player Object 
			            JSONObject jsonObject = jarray.getJSONObject(i);
                //Print Each players Details get from the object
                System.out.print(jsonObject.getString("_id"));
			            System.out.print("\t\t"+jsonObject.getString("name"));
				
			            playerlist[i]=jsonObject.getString("name");
			            playerlist2[i]=jsonObject.getString("_id");
			            //System.out.println(jsonObject.getString("name")+"llll");
					
			            System.out.println();			
			            //If you want you can create a Player Class and put all these details in to player type array list display those in the UI
		            }
		            //addShot(1,"RCG", 1, 6, 100, 20);
		            String jsonObject = playerList(pteam).string ();*/

            

	    }
    }
}
