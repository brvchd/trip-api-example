﻿using TripApp.Core.Models;

namespace TripApp.Core.Repository;

public interface ITripRepository
{
    Task<PaginatedResult<Trip>> GetPaginatedTripsAsync(int page = 1, int pageSize = 10);
    Task<List<Trip>> GetAllTripsAsync();
}