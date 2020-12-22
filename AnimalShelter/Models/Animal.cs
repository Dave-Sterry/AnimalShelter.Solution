using System.Collections.Generic;
using System.ComponentModel;


namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [DisplayName("Animal Type")]
        public string AnimalType { get; set; }

        [DisplayName("Animal Name")]
        public string AnimalName { get; set; }
    }
}