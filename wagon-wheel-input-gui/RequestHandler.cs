using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;

namespace wagon_wheel_input_gui
{
    class RequestHandler:Program
    {
        public static void addShot(String playerID, String playerTeam, int playerSession, int scoreShot, int scoreX, int scoreY)
        {
/*
            HttpClient client = new HttpClient();
				.build();
            MediaType mediaType = MediaType.parse("application/x-www-form-urlencoded");
            RequestBody body = RequestBody.create(mediaType, "player=" + playerID + "&team=" + playerTeam + "&session=" + playerSession + "&score=" + scoreShot + "&x=" + scoreX + "&y=" + scoreY);
            Request request = new Request.Builder()
                .url("http://ec2-18-220-157-143.us-east-2.compute.amazonaws.com:4000/api/v1/score")
                .method("POST", body)
                .addHeader("Content-Type", "application/x-www-form-urlencoded")
                .build();
            Response response = client.newCall(request).execute();
    }

    public static ResponseBody playerList(String playerTeam)
    {
        /*OkHttpClient client = new OkHttpClient().newBuilder()
				.build();
    Request request = new Request.Builder()
            .url("http://ec2-18-220-157-143.us-east-2.compute.amazonaws.com:4000/api/v1/player/" + playerTeam)
            .method("GET", null)
            .build();
    Response response = client.newCall(request).execute();
		return response.body();*/
	}

public static void players()
{
   /* //Json get from the Response body
    System.out.println("Main Array : "+ playerList(pteam).string());
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
