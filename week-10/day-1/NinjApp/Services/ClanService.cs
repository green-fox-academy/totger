using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NinjApp.Models;
using NinjApp.Repositories;

namespace NinjApp.Services
{
    public class ClanSevice : IClanService
    {
        private IClanRepository clanRepository;
        public ClanSevice(IClanRepository clanRepository)
        {
            this.clanRepository = clanRepository;
        }

        public Task<Clan> CreateAsync(Clan clan)
        {
            clanRepository.CreateAsync(clan);
        }

        public Task<Clan> DeleteAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsClanExistsAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Clan>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Clan> ReadOneAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<Clan> UpdateAsync(Clan clan)
        {
            throw new NotImplementedException();
        }
    }
}
