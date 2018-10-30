using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_VIDEOS.Models
{
    public class LastClientRentViewModel
    {
        public int GamesId { get; set; }
        public int GameTypeId { get; set; }
        public long Cedula { get; set; }
        public string ClientName { get; set; }
        public string ClientLastName { get; set; }
        public string Client => $"{ClientName} {ClientLastName}";
        public int Count { get; set; }
        public string Game { get; set; }
        public string GameDescription { get; set; }
        public string GameType { get; set; }
        public DateTime RentDate { get; set; }
    }
}