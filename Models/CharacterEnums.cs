using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JujutsuDle.Models;

public enum Gender { Masculino, Feminino, Outro }
public enum Species
{
    Humano,
    Maldição,
    Híbrido,
    
    [Display(Name = "Corpo Amaldiçoado")]
    CorpoAmaldiçoado
}
public enum Classification
{
    Feiticeiro,

    [Display(Name = "Usuário De Maldição")]
    UsuárioDeMaldição,

    [Display(Name = "Mestre De Maldição")]
    MestreDeMaldição,

    Civil
}
public enum CombatStyle {
    [Display(Name = "Corpo a Corpo")]
    CorpoACorpo,

    [Display(Name = "Arma Amaldiçoada")]
    ArmaAmaldiçoada,

    [Display(Name = "Técnica Inata")]
    TécnicaInata,

    Shikigami }