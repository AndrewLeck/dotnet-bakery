using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetBakery.Models
{
    //enumeration or enum
    public enum BreadType
    {
       Sourdough,       //0
       Rye,             //1
       MarbleRye,       //2 
       French,          //3
       HoneyWheat,      //4
    }
    
    public class Bread 
    {
        public int id {get; set;}
        public string name { get; set;}
        public string description { get; set;}
        
        // Need a bread type
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BreadType type {get; set;}

        public int count {get; set;}

        //relation to Baker
        [ForeignKey("bakeBy")]
        public int bakeById {get; set;}

        // the actual Baker object from DB (Join)
        public Baker bakeBy {get; set;}
    }
}
