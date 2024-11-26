using System;
using System.Collections.Generic;

namespace WebApp.Models.Movies;

public partial class MovieCompany
{
    public int? MovieId { get; set; }

    public int? CompanyId { get; set; }

    public virtual ProductionCompany? Company { get; set; }

    public virtual Movie? Movie { get; set; }
}
