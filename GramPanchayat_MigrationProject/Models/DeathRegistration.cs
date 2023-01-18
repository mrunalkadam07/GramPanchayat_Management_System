using System.ComponentModel.DataAnnotations;
namespace GramPanchayat_MigrationProject.API.Models;
    public class DeathRegistration
    {
        [Key]
        public int? RegistrationNo { get; set; }
        public int Year { get; set; }
        public string CityVillege {get; set;}
        public string Taluko {get; set;}
        public string Dist {get; set;}
        public DateTime RegistrationDate {get; set;}
        public DateTime DateOfDeath {get; set;}
        public string NameAndAddressOfDeathSenderPerson{get; set;}
        public string Sex {get; set;}
        public int AgeAtDeath {get; set;}
        public string PlaceOfDeath {get; set;}
        public string MotherFatherHusbandName {get; set;}
        public string PermentAddressOfDeathPerson {get; set;}
        public string NameOfDeathPerson{get; set;}
        public string NameOfRegistar {get; set;}

    }