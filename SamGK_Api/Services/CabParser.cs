using System.Collections;
using SamGK_Api.Interfaces.Cabs;
using SamGK_Api.Models.Cabs;

namespace SamGK_Api.Services;

public static class CabParser
{
    public static IEnumerable<ICabsResult>? Parse(Dictionary<string, string>? dataCabs)
    {
        if (dataCabs is null)
            return null;

        var data = dataCabs
            .Select(item => new CabResult() { name = item.Value })
            .Cast<ICabsResult>()
            .ToList();

        return data;
    } 
}