using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class TeacherListRepresentation : SimpleListRepresentation<TeacherRepresentation>
    {
        public TeacherListRepresentation(IList<TeacherRepresentation> teachers) : base(teachers)
        {

        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Teachers.AddTeacher);

            Href = LinkTemplates.Teachers.GetTeachers.Href;

            Links.Add(new Link { Href = Href, Rel = "self" });
        }
    }
}