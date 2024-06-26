﻿using AutoMapper;
using UnivaliMapas.Api.Entities;
using UnivaliMapas.Api.Features.Salas.Commands.CreateSala;
using UnivaliMapas.Api.Features.Salas.Queries.GetSala;
using UnivaliMapas.Api.Models;
using UnivaliMapas.Features.Salas.Commands.UpdateSala;

namespace UnivaliMapas.Api.Profiles;

public class SalaProfile : Profile
{
    public SalaProfile()
    {
        CreateMap<Sala, SalaDto>();
        CreateMap<SalaDto, Sala>();
        
        //CQRS
        CreateMap<SalaForCreationDto, Sala>();
        CreateMap<Sala, CreateSalaDto>();

        CreateMap<Sala, GetSalaDetailDto>();

        CreateMap<SalaForCreationDto, Sala>();
        CreateMap<UpdateSalaCommand, Sala>();
        CreateMap<Sala, UpdateSalaCommandDto>();
    }
}