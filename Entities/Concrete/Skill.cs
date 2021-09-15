using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Skill : IEntity
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
    }
}
