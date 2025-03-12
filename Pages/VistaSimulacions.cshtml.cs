using CsvHelper;
using EcoenergyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Formats.Asn1;
using System.Globalization;

namespace EcoenergyApp.Pages
{
    public class VistaSimulacionsModel : PageModel {
        public List<Simulacio>? Simulacions { get; set; }

		public string? Message { get; set; }
        public void OnGet() {
            Simulacions = null;
            Message = null;
            try {
                using (var reader = new StreamReader(@"\files\simulacions_energia.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {
                    Simulacions = new List<Simulacio>(csv.GetRecords<Simulacio>());
                }
            }
            catch (Exception) {
				Message = "No hi ha cap simulació desada";
			}
        }
    }
}
