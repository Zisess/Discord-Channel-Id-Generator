      static void ChannelIdGenerator(string Id, string Message)
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discord.com/api/v8/users/@me/channels");
                Req.Method = "POST";
                Req.Headers.Add("Authorization", token);
                Req.ContentType = "application/json";
                using (var streamWriter = new StreamWriter(Req.GetRequestStream()))
                {
                    string json = "{\"recipient_id\":\"" + Id + "\"}";
                    streamWriter.Write(json);
                }
                var httpResponse = Req.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    channel_id = Substring(streamReader.ReadToEnd(), from: "{\"id\": \"", until: "\"");
                    Console.WriteLine("[Channel Id Generated] " + channel_id);
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString()); }
        }
