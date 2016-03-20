using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
namespace Notes_Manager_Mobile
{
    public class NoteTag
    {
        string id;
        string designation;
        bool done;
        string tileColor;
        string description;
        string versionNo;


        [JsonProperty(PropertyName = "ID")]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "Designation")]
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        [JsonProperty(PropertyName = "Description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //[JsonProperty(PropertyName = "complete")]
        //public bool Status
        //{
        //    get { return done; }
        //    set { done = value; }
        //}

        [JsonProperty(PropertyName = "FlagNote")]
        public bool Flagnote
        {
            get { return done; }
            set { done = value; }
        }
        [Version]
        public string Version { get; set; }
    }
}
