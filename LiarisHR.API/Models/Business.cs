using System.Collections.Generic;

namespace LiarisHR.API.Models
{
    public class Business
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> User { get; set; }
    }
}