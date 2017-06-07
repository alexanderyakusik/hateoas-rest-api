using Newtonsoft.Json;
using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class FacultyRepresentation : Representation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<int> ChairIds { get; set; }

        public override string Rel
        {
            get { return LinkTemplates.Faculties.Faculty.Rel; }
            set { }
        }

        public override string Href
        {
            get { return LinkTemplates.Faculties.Faculty.CreateLink(new { id = Id }).Href; }
            set { }
        }

        protected override void CreateHypermedia()
        {
            if (ChairIds != null && ChairIds.Count > 0)
            {
                foreach (int id in ChairIds)
                {
                    Links.Add(LinkTemplates.Chairs.Chair.CreateLink(new { id = Id }));
                }
            }
        }
    }
}