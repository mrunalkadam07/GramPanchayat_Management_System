using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GramPanchayat_MigrationProject.API.Models;
    public class MarriageRegModel
    {
        [Key]
        public int RegistrationNo { get; set; }
        public DateTime MerrageDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MerragePlace { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FullNameOFGroom  { get; set; }
        public int GroomAge { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string GroomReligion { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string GroomPlaceOfResidences { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string GroomAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MerrageTimeGroomDesignation { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FullNameOFBride { get; set; }
        public int BrideAge { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BrideReligion { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BridePlaceOfResidences { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BrideAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MerrageTimeBrideDesignation { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string GroomFatherAndMotherName { get; set; }
        public int GroomFatherMotherAge { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string GroomFateherMotherPLaceOfResidentes { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string GroomFatherMotherAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BrideFatherAndMotherName { get; set; }
        public int BrideFatherMotherAge { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BrideFatherMotherPlaceOfResidences { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BrideFatherAndMotherAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NameOfBrahMan { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstFullNameOfWitness { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstWitnessAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SecondFullNameOfWitness { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SecondWitnessAddress { get; set; }

        
    }
