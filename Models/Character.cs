using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JujutsuDle.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public List<string> Affiliations { get; set; }
    public Species Species { get; set; }
    public Classification Classification { get; set; }
    public CombatStyle CombatStyle { get; set; }
    public int DebutYear { get; set; }
    public string PhotoUrl { get; set; }
}