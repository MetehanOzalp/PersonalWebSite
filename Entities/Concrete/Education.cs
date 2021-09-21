using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Education : IEntity
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string FieldOfStudy { get; set; }
        public string Degree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
