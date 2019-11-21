using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT_School.CSharp.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IT_School.CSharp.EFCore.Serivces
{
    public class FlatService
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<FlatService> _logger;

        public FlatService(DatabaseContext context, ILogger<FlatService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Address> GetAddressInfo(Guid addressId)
        {
            return await _context.Addresses
                .AsNoTracking()
                .SingleAsync(a => a.Id == addressId);
        }

        public async Task<List<Person>> GetRoomers(Guid addressId, int offset, int count)
        {
            var result = await _context.Persons
                .Include(a => a.Address)
                .Where(a => a.AddressId == addressId)
                .Skip(offset).Take(count)
                .OrderBy(a => a.Name)
                .ToListAsync();
            
            result.ForEach(a => a.Address.Roomers = null);

            return result;
        }

        public async Task ShowRoomers(Guid addressId)
        {
            var roomers = await _context.Persons
                .Where(a => a.AddressId == addressId)
                .ToListAsync();
            foreach (var roomer in roomers)
            {
                Console.WriteLine($"{roomer.Surname} {roomer.Name} {roomer.Patronymic}");
            }
        }

        public async Task RoomPerson(Guid addressId, string surname, string name, string patronymic)
        {
            var person = new Person(name, surname, patronymic, addressId);
            _context.Persons.Add(person);

            await _context.SaveChangesAsync();
        }

        public async Task ResettlePerson(Guid personId, Guid addressId)
        {
            var person = await _context.Persons.SingleAsync(a => a.Id == personId);

            person.AddressId = addressId;

            await _context.SaveChangesAsync();
        }
    }
}