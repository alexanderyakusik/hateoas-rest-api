using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class FacultyListRepresentation : SimpleListRepresentation<FacultyRepresentation>
    {
        public FacultyListRepresentation(IList<FacultyRepresentation> faculties) : base(faculties)
        {

        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Faculties.AddFaculty);

            Href = LinkTemplates.Faculties.GetFaculties.Href;

            Links.Add(new Link { Href = Href, Rel = "self" });
        }
    }
}