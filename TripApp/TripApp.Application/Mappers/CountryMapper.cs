﻿using TripApp.Application.DTOs;
using TripApp.Core.Model;

namespace TripApp.Application.Mappers;

public static class CountryMapper
{
    public static CountryDto MapToCountryDto(this Country country)
    {
        return new CountryDto
        {
            Name = country.Name
        };
    }
}