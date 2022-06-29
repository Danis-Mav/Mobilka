using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SQLite;
using Xamarin.Forms;

namespace ExamUser11.Data
{
    public class passwords
    {
        [PrimaryKey, Column("_id"), AutoIncrement]
        [JsonProperty("build_id")]
        public int Id { get; set; }
        [JsonProperty("URL")]
        public string Url { get; set; }
        [JsonProperty("Type")]
        public string Type { get; set; }    

        [JsonProperty("Password")]
        public string Description { get; set; }
    }
}
