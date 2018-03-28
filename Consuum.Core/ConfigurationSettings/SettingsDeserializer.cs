using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Consuum.Core.ConfigurationSettings
{
    public class SettingsDeserializer
    {
        public static ConsuumSettings Hydrate()
        {
            //1. Get string object from ConsuumSettins.json name it output
            //Open the file              
                //var stream = File.OpenText("json file.txt"); //Is this one from the project root?
            var stream = File.OpenText(@"ConsuumSettings.json");
            //Read the file              
            string output = stream.ReadToEnd();
                //2. Optionally accept a json string as a parameter


            ConsuumSettings deserializedProduct = JsonConvert.DeserializeObject<ConsuumSettings>(output);
            return deserializedProduct;
        }
    }
}
