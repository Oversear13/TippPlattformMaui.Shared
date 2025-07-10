using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippPlattformMaui.Shared.Dtos;

/// <summary>
/// DTO für die Tippabgabe, das an die API gesendet wird.
/// </summary>
public class TippabgabeDto
{
    public int SpielId { get; set; }
    public string TeamA { get; set; } = string.Empty;
    public string TeamB { get; set; } = string.Empty;
    public DateTime? Datum { get; set; } = DateTime.Now;
    public string? Ergebnis { get; set; }
    public int? TippA { get; set; }
    public int? TippB { get; set; }
    public int? Gewinn { get; set; }
}
/// <summary>
/// DTO für die Tippabgabe, das an die API gesendet wird.
/// </summary>
public class TippAbgebenDto
{
    public int SpielId { get; set; }
    public string TeamA { get; set; } = string.Empty;
    public string TeamB { get; set; } = string.Empty;
    public DateTime Datum { get; set; } = DateTime.Now;
    public string? Ergebnis { get; set; }
    public int? TippA { get; set; }
    public int? TippB { get; set; }
    public string? Gewinn { get; set; }
}
