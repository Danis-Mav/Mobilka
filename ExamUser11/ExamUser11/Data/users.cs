using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace ExamUser11.Data
{
    public class users
    {
        public class passwords
        {
            [PrimaryKey, Column("_id"), AutoIncrement]
            [JsonProperty("build_id")]
            public int Id { get; set; }
            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("Password")]
            public string Description { get; set; }
        }
    }
}
