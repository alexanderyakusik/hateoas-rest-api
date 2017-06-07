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
        public List<int> ChairsIds { get; set; }

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
            Links.Add(LinkTemplates.Faculties.UpdateFaculty.CreateLink(new { id = Id }));
            Links.Add(LinkTemplates.Faculties.DeleteFaculty.CreateLink(new { id = Id }));

            if (ChairsIds != null && ChairsIds.Count > 0)
            {
                foreach (int chairId in ChairsIds)
                {
                    Links.Add(LinkTemplates.Chairs.AttachedChairs.CreateLink(new { id = chairId }));
                }
            }
        }
    }
}