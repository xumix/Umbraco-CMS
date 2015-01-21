﻿using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Core.Persistence.Repositories
{
    public interface IDomainRepository : IRepositoryQueryable<int, IDomain>
    {
        IEnumerable<IDomain> GetAll(bool includeWildcards);
        IEnumerable<IDomain> GetDomainsForContent(int contentId, bool includeWildcards);
    }
}