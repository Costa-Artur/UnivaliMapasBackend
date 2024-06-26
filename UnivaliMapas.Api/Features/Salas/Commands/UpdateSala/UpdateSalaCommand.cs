using MediatR;
using UnivaliMapas.Api.Models;


namespace UnivaliMapas.Features.Salas.Commands.UpdateSala;

public class UpdateSalaCommand : IRequest<UpdateSalaCommandDto>
{
    public int SalaId { get; set; }
    public int Number { get; set; }
    //public SalaForUpdateDto Dto { get; set; } = new();
}