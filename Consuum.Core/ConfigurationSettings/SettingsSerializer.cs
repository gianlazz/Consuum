using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Consuum.Core.ConfigurationSettings
{
    public class SettingsSerializer
    {
        public static void Dehydrate(ConsuumSettings settings)
        {
            //Need to write it to the local solution root

            File.WriteAllText(@"ConsuumSettings.json", JsonConvert.SerializeObject(settings, Formatting.Indented));

            //// serialize JSON directly to a file
            //using (StreamWriter file = File.CreateText(@"c:\ConsuumSettings.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, settings);
            //
        }
    }
}
