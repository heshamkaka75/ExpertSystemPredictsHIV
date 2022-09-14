using System.ComponentModel.DataAnnotations;

namespace ExpertSystemPredictsHIV.Models
{
    public class Patient
    {
        #region Persional information
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        #endregion

        #region common diseases and Symptoms
        public int Fever { get; set; }
        public int Headache { get; set; }
        public int Diarrhea { get; set; }
        public int WeightLoss { get; set; }
        public int Cough { get; set; }
        public int NightSweats { get; set; }
        public int Musclepain { get; set; }
        public int Constant { get; set; }
        public int SkinRash { get; set; }
        public int SorePainfulMouthUlcers { get; set; }
        public int SwollenLymphNodes { get; set; }
        public int WhiteSpotsOnTongue { get; set; }
        public int RashOrBlisters { get; set; }
        public int UlcerationInTheMouthOrGenitals { get; set; }
        public int SexualIntercourse { get; set; }
        public int SharingNeedles { get; set; }
        public int Transfusion { get; set; }
        public int BloodPressure { get; set; }
        public int Diabetes { get; set; }
        public int HeartDisease { get; set; }
        public int KidneyDisease { get; set; }
        public int StomachDisease { get; set; }
        public int? Total { get; set; }

        #endregion

    }
}
