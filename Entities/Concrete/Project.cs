using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProjectThumbnail { get; set; }
        public string GithubLink { get; set; }
    }
}
