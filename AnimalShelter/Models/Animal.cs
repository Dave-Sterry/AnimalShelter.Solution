using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System;
using System.ComponentModel.DataAnnotations;



namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [DisplayName("Animal Type")]
        public string AnimalType { get; set; }

        [DisplayName("Animal Name")]
        public string AnimalName { get; set; }

        [DisplayName("Intake Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public string IntakeDate { get; set; }

        // public void InputIntakeDate()
        // {
        //     DateTime dateInput = IntakeDate;
        //     // string parsedDate = dateInput.ToString("d", DateTimeFormatInfo.InvariantInfo);
        //     string parsedDate = dateInput.ToString("MM/dd/yyyy");
        //     IntakeDate = parsedDate;
        // }
    }

}
// ToLongDateString();
// (date1.ToString("d", DateTimeFormatInfo.InvariantInfo));

