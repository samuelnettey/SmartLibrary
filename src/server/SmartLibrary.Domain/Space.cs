using System.Collections.Generic;

namespace SmartLibrary.Domain
{

    // http://ideas.demco.com/blog/space-planning-design-101-getting-started/

    public class Space
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Member> Members { get; set; }
    }
}
