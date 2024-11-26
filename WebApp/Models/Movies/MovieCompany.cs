using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.Movies;
[PrimaryKey(nameof(MovieId), nameof(CompanyId))]

public partial class MovieCompany
{
    public int? MovieId { get; set; }

    public int? CompanyId { get; set; }

    public virtual ProductionCompany? Company { get; set; }

    public virtual Movie? Movie { get; set; }
}
