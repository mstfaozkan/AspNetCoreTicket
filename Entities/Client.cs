using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Client
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public string IpAddress { get; set; }

        public List<AppUser> Users { get; set; }

    }
}
