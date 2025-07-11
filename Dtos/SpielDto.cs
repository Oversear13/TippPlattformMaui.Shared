using System;

namespace TippPlattformMaui.Shared.Dtos
{
    public class SpielDto
    {
        public int Id { get; set; }

        // Namen der Teams
        public string HeimMannschaft { get; set; } = string.Empty;
        public string GastMannschaft { get; set; } = string.Empty;

        // Spielzeit
        public DateTime Datum { get; set; }

        // Zeitpunkt, bis wann man tippen kann
        public DateTime? Tipptermin { get; set; }

        // Ergebnis – sofern schon gespielt
        public int? ToreHeim { get; set; }
        public int? ToreGast { get; set; }

        // Dein Gewinn in Punkten (falls schon ausgewertet)
        public int? DeinGewinn { get; set; }

        // Der Tipp, den der User eingibt
        public TippDto Tipp { get; set; } = new TippDto();

        // Hilfs-Properties für die Anzeige
        public string TippterminText =>
            Tipptermin.HasValue
                ? Tipptermin.Value.ToString("dd.MM.yyyy HH:mm")
                : "bis Anpfiff";

        public string ErgebnisDisplay =>
            ToreHeim.HasValue && ToreGast.HasValue
                ? $"{ToreHeim}:{ToreGast}"
                : "-:-";

        public string GewinnDisplay =>
            DeinGewinn.HasValue
                ? DeinGewinn.Value.ToString()
                : "-";
    }

    public class TippDto
    {
        // die beiden Eingabefelder
        public int HeimTore { get; set; }
        public int GastTore { get; set; }
    }
}
