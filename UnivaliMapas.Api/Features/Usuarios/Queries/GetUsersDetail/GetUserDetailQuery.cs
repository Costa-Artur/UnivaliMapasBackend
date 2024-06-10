using MediatR;

namespace UnivaliMapas.Features.Usuarios.Queries.GetUsersDetail;

public class GetUserDetailQuery : IRequest<GetUserDetailDto>
{
    public string CodigoPessoa { get; set; }
}