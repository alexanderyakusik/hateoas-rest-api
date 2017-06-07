using Newtonsoft.Json;
using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class ChairRepresentation : Representation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public int FacultyId { get; set; }

        [JsonIgnore]
        public List<int> TeachersIds { get; set; }

        public override string Rel
        {
            get { return LinkTemplates.Chairs.Chair.Rel; }
            set { }
        }

        public override string Href
        {
            get { return LinkTemplates.Chairs.Chair.CreateLink(new { id = Id }).Href; }
            set { }
        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Chairs.UpdateChair.CreateLink(new { id = Id }));
            Links.Add(LinkTemplates.Chairs.DeleteChair.CreateLink(new { id = Id }));

            Links.Add(LinkTemplates.Faculties.Faculty.CreateLink(new { id = FacultyId }));

            if (TeachersIds != null && TeachersIds.Count > 0)
            {
                foreach (int teacherId in TeachersIds)
                {
                    Links.Add(LinkTemplates.Teachers.AttachedTeachers.CreateLink(new { id = teacherId }));
                }
            }
        }
    }
}