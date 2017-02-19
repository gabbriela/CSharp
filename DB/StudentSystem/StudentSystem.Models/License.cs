
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public class License
    {
        private ICollection<Resources> resourceses;

        public License()
        {
            this.resourceses = new HashSet<Resources>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Resources> Resourceses
        {
            get { return this.resourceses; }
            set { this.resourceses = value; }
        }
    }
}
