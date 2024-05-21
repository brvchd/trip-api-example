﻿using TripApp.Application.DTOs;
using TripApp.Core.Model;

namespace TripApp.Application.Mappers;

public static class ClientMapper
{
    public static ClientDto MapToCountryDto(this Client client)
    {
        return new ClientDto
        {
            FirstName = client.FirstName,
            LastName = client.LastName
        };
    }
}