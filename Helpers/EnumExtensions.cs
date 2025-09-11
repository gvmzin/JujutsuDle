
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue)
    {
        // Tenta encontrar o atributo [Display] que coloquei no Enum
        var displayAttribute = enumValue.GetType()
                                        .GetMember(enumValue.ToString())
                                        .First()
                                        .GetCustomAttribute<DisplayAttribute>();

        // Se encontrou o atributo, retorna o nome definido nele.
        // Se não, simplesmente retorna o nome padrão do enum.
        return displayAttribute?.GetName() ?? enumValue.ToString();
    }
}