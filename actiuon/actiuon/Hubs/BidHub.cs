using actiuon.DAL;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace actiuon.Hubs
{
    public class BidHub:Hub
    {
        private readonly AppDbContext dbContext;
        public BidHub(AppDbContext db) => dbContext = db;
        public async Task SendMessage (string user, string message)
        {
            await Clients.All.SendAsync("ReveiveMessage", user, message);
        }
    }
}
