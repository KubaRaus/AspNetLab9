using System;
using System.Collections.Generic;

namespace WebApp.Models.Movies;

public partial class MovieLanguage
{
    public int? MovieId { get; set; }

    public int? LanguageId { get; set; }

    public int? LanguageRoleId { get; set; }

    public virtual Language? Language { get; set; }

    public virtual LanguageRole? LanguageRole { get; set; }

    public virtual Movie? Movie { get; set; }
}
