using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace actiuon.Models
{
    public class Bids: BaseEntity
    {
        public AppUser AppUser { get; set; }
        public decimal Message { get; set; }
        public DateTime BidingTime { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string AppUserId { get; set; }
        public string AppUserName { get; set; }
        public string UserPhoto { get; set; }



        public Bids()
        {
        }

        //public Bids(string user)
        //{

        //}
    }
}
