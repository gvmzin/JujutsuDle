using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JujutsuDle.Models;

public enum ComparisonResult { Correct, Partial, Incorrect }

public class GuessResultViewModel
{
    public string GuessedName { get; set; }
    public string PhotoUrl { get; set; }
    public ComparisonResult Gender { get; set; }
    public string GenderValue { get; set; }
    public ComparisonResult Affiliations { get; set; }
    public string AffiliationsValue { get; set; }
    public ComparisonResult Species { get; set; }
    public string SpeciesValue { get; set; }
    public ComparisonResult Classification { get; set; }
    public string ClassificationValue { get; set; }
    public ComparisonResult CombatStyle { get; set; }
    public string CombatStyleValue { get; set; }
    public ComparisonResult DebutYear { get; set; }
    public int DebutYearValue { get; set; }
    public string DebutYearArrow { get; set; } = "";
}