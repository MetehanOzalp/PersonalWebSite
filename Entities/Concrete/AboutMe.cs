using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class AboutMe : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
