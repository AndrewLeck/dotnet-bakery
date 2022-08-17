using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// nerver write code outside of a class. It will not run
// This file will 
namespace DotnetBakery.Models
{
    public class Baker 
    {
        // Primary Key, serial
        public int id {get; set;}

        [Required] // C# attribute, aka NOT NULL (in postico)
        public string name {get; set;}

    }
}
