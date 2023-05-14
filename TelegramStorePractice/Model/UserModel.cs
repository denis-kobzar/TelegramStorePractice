using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramStorePractice.Model
{
    internal class UserModel : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }

        public UserModel(int id, string name, string link, string description)
        {
            Id = id;
            Name = name;
            Link = link;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id: {Id} Name:{Name} Link: {Link} Description: {Description}";
        }
    }
}
