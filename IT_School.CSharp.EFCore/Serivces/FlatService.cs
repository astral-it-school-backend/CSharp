using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IT_School.CSharp.EFCore.Serivces
{
    public class FlatService
    {
        private readonly DatabaseContext _context;

        public FlatService(DatabaseContext context)
        {
            _context = context;
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

//        public async Task RoomPerson(Guid addressId, string surname, string name, string patronymic)
//        {
//            var 
//        }
    }
}