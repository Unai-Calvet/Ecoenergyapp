namespace EcoenergyApp.Models {
    public class Simulacio {
        public DateTime CreacioSimulacio { get; set; }
        public string? Tipus { get; set; }
        public int HoresVelocitatCabal { get; set; }
        public int Rati { get; set; }
        public double Energia { get; set; }
        public double CostKw { get; set; }
        public double PreuKw { get; set; }
        public double Cost { get; set; }
        public double Preu { get; set; }
    }
}
