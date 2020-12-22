using System.Collections.Generic;


namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        //[Display(AnimalType = "Animal Type")]
        public string AnimalType { get; set; }
        //[Display(AnimalName = "Animal Name")]
        public string AnimalName { get; set; }
    }
}