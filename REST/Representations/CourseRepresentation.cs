using Newtonsoft.Json;
using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class CourseRepresentation : Representation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<int> TeachersIds { get; set; }

        public override string Rel
        {
            get { return LinkTemplates.Courses.Course.Rel; }
            set { }
        }

        public override string Href
        {
            get { return LinkTemplates.Courses.Course.CreateLink(new { id = Id }).Href; }
        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Courses.UpdateCourse.CreateLink(new { id = Id }));
            Links.Add(LinkTemplates.Courses.DeleteCourse.CreateLink(new { id = Id }));

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