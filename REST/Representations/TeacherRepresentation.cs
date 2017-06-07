using Newtonsoft.Json;
using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class TeacherRepresentation : Representation
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        [JsonIgnore]
        public int ChairId { get; set; }

        [JsonIgnore]
        public List<int> CoursesIds { get; set; }

        public override string Rel
        {
            get { return LinkTemplates.Teachers.Teacher.Rel; }
            set { }
        }

        public override string Href
        {
            get { return LinkTemplates.Teachers.Teacher.CreateLink(new { id = Id }).Href; }
            set { }
        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Teachers.UpdateTeacher.CreateLink(new { id = Id }));
            Links.Add(LinkTemplates.Teachers.DeleteTeacher.CreateLink(new { id = Id }));

            Links.Add(LinkTemplates.Chairs.Chair.CreateLink(new { id = ChairId }));

            if (CoursesIds != null && CoursesIds.Count > 0)
            {
                foreach (int courseId in CoursesIds)
                {
                    Links.Add(LinkTemplates.Courses.AttachedCourses.CreateLink(new { id = courseId }));
                }
            }
        }
    }
}