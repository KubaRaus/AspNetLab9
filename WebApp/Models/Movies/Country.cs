using System;
using System.Collections.Generic;

namespace WebApp.Models.Movies;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryIsoCode { get; set; }

    public string? CountryName { get; set; }
}
