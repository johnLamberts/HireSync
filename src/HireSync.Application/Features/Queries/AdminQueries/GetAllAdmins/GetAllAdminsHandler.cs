using HireSync.Application.Abstractions;
using HireSync.Application.Dapper.AdminQueries;
using HireSync.Domain.Shared;

namespace HireSync.Application.Features.Queries.AdminQueries.GetAllAdmins;

public sealed class GetAllAdminsHandler(IAdminQuery adminQuery)
  : IQueryHandler<GetAllAdminsQuery, IQueryable<GetAllAdminsResponse>>
{
  private readonly IAdminQuery _adminQuery = adminQuery;

  public async Task<Result<IQueryable<GetAllAdminsResponse>>> Handle(GetAllAdminsQuery request, CancellationToken cancellationToken)
  {
    var adminList = await _adminQuery.GetAll()!;

    var adminListResponse = adminList.Select(admin => new
      GetAllAdminsResponse(admin.Id, admin.AdminName));

    return Result.Ok(adminListResponse);
  }
}
