using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class CourseListRepresentation : SimpleListRepresentation<CourseRepresentation>
    {
        public CourseListRepresentation(IList<CourseRepresentation> courses) : base(courses)
        {

        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Courses.AddCourse);

            Href = LinkTemplates.Courses.GetCourses.Href;

            Links.Add(new Link { Href = Href, Rel = "self" });
        }
    }
}