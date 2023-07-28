using System;
using System.Collections.Generic; 
using System.Net; 
using System.Text.Json;


namespace Api; 

public class NombresApi{

    
    public  string[] getNombres(){
        try
        {
             using (WebClient client = new WebClient()){
           string content=  client.DownloadString("http://dnd5eapi.co/api/monsters");
            JsonDocument json = JsonDocument.Parse(content);
                JsonElement results = json.RootElement.GetProperty("results"); 
                string [] names = new string [results.GetArrayLength()];
                int i = 0; 
                foreach (JsonElement resultado in results.EnumerateArray())
                {
                    names[i] = resultado.GetProperty("name").GetString();
                    i++;
                }
                return names;

        }
            
        }
        catch (System.Exception)
        { 
            Console.WriteLine("no se pudo acceder a la api");
        return null;
        }
       
    }


    
}