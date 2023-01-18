using System.ComponentModel.DataAnnotations;

namespace GramPanchayat_MigrationProject.API.Models;
    public class PropertyTaxPaid
    {
    [Key]
    public int? BillNo { get; set; }
    public DateTime? Billdate { get; set; }
    public int? Year { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? PropertyNo { get; set; }
    public int? HomeTax { get; set; }
    public int? ElectrycityTax { get; set; }
    public int? SpecialWaterTax { get; set; }
    public int? EducationalSess { get; set; }
    public int? PanaltyCharge { get; set; }
    public int? Total { get; set; }
    }