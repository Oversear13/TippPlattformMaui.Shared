using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippPlattformMaui.Shared.Dtos;

public class TippGruppeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SportArt { get; set; }
    public int AnzahlSpiele { get; set; }
    public DateTime? Tipptermin { get; set; }
    public bool IstAdmin { get; set; }
}
