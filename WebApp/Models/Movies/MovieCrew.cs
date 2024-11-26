using System;
using System.Collections.Generic;

namespace WebApp.Models.Movies;

public partial class MovieCrew
{
    public int? MovieId { get; set; }

    public int? PersonId { get; set; }

    public int? DepartmentId { get; set; }

    public string? Job { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Movie? Movie { get; set; }

    public virtual Person? Person { get; set; }
}
