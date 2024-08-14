using HireSync.Application.Abstractions;

namespace HireSync.Application.Features.Queries.AdminQueries.GetAllAdmins;

public sealed record GetAllAdminsQuery
  () : IQuery<IQueryable<GetAllAdminsResponse>>;
