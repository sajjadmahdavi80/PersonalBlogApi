﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DbContext;
public interface IApplicationDbContext
{

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
