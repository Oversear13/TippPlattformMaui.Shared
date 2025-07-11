namespace TippPlattform.Controllers.Api
{
    public class TippErinnerungDto
    {
        public string? SpielBezeichnung { get; set; } // z.B. TeamA vs TeamB
        public string? TippgruppeName { get; set; } // Name der Tippgruppe
        public DateTime? Datum { get; set; } // Spielbeginn
    }
}