using Application.Interfaces.DbContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;
public class ApplicationSqlDbContext : DbContext, IApplicationDbContext
{
	public ApplicationSqlDbContext(DbContextOptions<ApplicationSqlDbContext> options) : base(options)
	{
		this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;
	}

	public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		return await base.SaveChangesAsync(cancellationToken);

	}

}
