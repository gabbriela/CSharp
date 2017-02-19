using System.Collections.Generic;
using System.Data;

namespace StudentSystem.Models
{
    public class Resources
    {
        private ICollection<License> licenses;

        public Resources()
        {
            this.licenses = new HashSet<License>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ResourceType ResourceType { get; set; }

        public string URL { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<License> Licenses
        {
            get { return this.licenses; }
            set { this.licenses = value; }
        }
    }
}
