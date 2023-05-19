﻿using BikeRental.Domain;

namespace BikeRental.Tests;

public class BikeRentalFixture
{
    private readonly List<BikeType> _bikeTypes;

    private readonly List<Bike> _bikes;

    private readonly List<Client> _clients;

    private readonly List<RentRecord> _records;

    public BikeRentalFixture()
    {
        _bikeTypes = new List<BikeType>
        {
             new BikeType { Id = 1, TypeName = "горный", RentCost = 300 },
             new BikeType { Id = 2, TypeName = "прогулочный", RentCost = 100 },
             new BikeType { Id = 3, TypeName = "спортивный", RentCost = 200 }
        };

        _bikes = new List<Bike>
        {
            new Bike { Id = 1, SerialNumber = 12345, Model = "Model1", Color = "green", Type = BikeTypes[0] },
            new Bike { Id = 2, SerialNumber = 23451, Model = "Model2", Color = "red", Type = BikeTypes[1] },
            new Bike { Id = 3, SerialNumber = 34512, Model = "Model3", Color = "purple", Type = BikeTypes[2] },
            new Bike { Id = 4, SerialNumber = 45123, Model = "Model4", Color = "green", Type = BikeTypes[0] },
            new Bike { Id = 5, SerialNumber = 51234, Model = "Model5", Color = "blue", Type = BikeTypes[2] },
            new Bike { Id = 6, SerialNumber = 01234, Model = "Model6", Color = "purple", Type = BikeTypes[2] }
        };

        _clients = new List<Client>
        {
            new Client { Id = 1, FullName = "Ivan Ivanov", BirthYear = 1995, PhoneNumber = "+7(927)123-45-67" },
            new Client { Id = 2, FullName = "Petr Petrov", BirthYear = 1992, PhoneNumber = "+7(927)123-45-68" },
            new Client { Id = 3, FullName = "Kuznec Kuznecov", BirthYear = 1986, PhoneNumber = "+7(927)123-45-69" },
            new Client { Id = 4, FullName = "Andrey Andreev", BirthYear = 2000, PhoneNumber = "+7(927)123-45-60" },
            new Client { Id = 5, FullName = "Ignat Ignatiev", BirthYear = 2001, PhoneNumber = "+7(927)123-45-61" }
        };

        _records = new List<RentRecord>
        {
            new RentRecord { Id = 1, ClientId = 1, BikeId = 1, RentStartTime = DateTime.Parse("2023-01-1 13:45"), RentEndTime = DateTime.Parse("2023-01-1 14:45") },
            new RentRecord { Id = 2, ClientId = 2, BikeId = 2, RentStartTime = DateTime.Parse("2023-01-1 15:45"), RentEndTime = DateTime.Parse("2023-01-1 16:45") },
            new RentRecord { Id = 3, ClientId = 3, BikeId = 3, RentStartTime = DateTime.Parse("2023-01-1 10:45"), RentEndTime = DateTime.Parse("2023-01-1 11:45") },
            new RentRecord { Id = 4, ClientId = 4, BikeId = 4, RentStartTime = DateTime.Parse("2023-01-1 8:45"), RentEndTime = DateTime.Parse("2023-01-1 9:45") },
            new RentRecord { Id = 5, ClientId = 5, BikeId = 2, RentStartTime = DateTime.Parse("2023-01-1 19:45"), RentEndTime = DateTime.Parse("2023-01-1 20:45") },
            new RentRecord { Id = 6, ClientId = 1, BikeId = 1, RentStartTime = DateTime.Parse("2023-01-1 15:45"), RentEndTime = DateTime.Parse("2023-01-1 16:45") },
            new RentRecord { Id = 7, ClientId = 1, BikeId = 6, RentStartTime = DateTime.Parse("2023-01-1 17:45"), RentEndTime = DateTime.Parse("2023-01-1 19:48") }
        };
    }

    public List<BikeType> BikeTypes => _bikeTypes;

    public List<Bike> Bikes => _bikes;

    public List<Client> Clients => _clients;

    public List<RentRecord> Records => _records;
}
