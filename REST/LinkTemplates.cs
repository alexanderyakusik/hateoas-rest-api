using WebApi.Hal;

namespace REST
{
    public static class LinkTemplates
    {
        public static class Faculties
        {
            public static Link GetFaculties { get { return new Link("faculties", "~/faculties"); } }

            public static Link Faculty { get { return new Link("faculty", "~/faculties/{id}"); } }

            public static Link UpdateFaculty { get { return new Link("update_faculty", "~/faculties/{id}"); } }

            public static Link AddFaculty { get { return new Link("add_faculty", "~/faculties/{id}"); } }

            public static Link DeleteFaculty { get { return new Link("delete_faculty", "~/faculties/{id}"); } }
        }

        public static class Chairs
        {
            public static Link GetChairs { get { return new Link("chairs", "~/chairs"); } }

            public static Link Chair { get { return new Link("chair", "~/chairs/{id}"); } }

            public static Link UpdateChair { get { return new Link("update_chair", "~/chairs/{id}"); } }

            public static Link AddChair { get { return new Link("add_chair", "~/chairs/{id}"); } }

            public static Link DeleteChair { get { return new Link("delete_chair", "~/chairs/{id}"); } }
        }

        public static class Teachers
        {
            public static Link GetTeachers { get { return new Link("teachers", "~/teachers"); } }

            public static Link Teacher { get { return new Link("teacher", "~/teachers/{id}"); } }

            public static Link UpdateTeacher { get { return new Link("update_teacher", "~/teachers/{id}"); } }

            public static Link AddTeacher { get { return new Link("add_teacher", "~/teachers/{id}"); } }

            public static Link DeleteTeacher { get { return new Link("delete_teacher", "~/teachers/{id}"); } }
        }

        public static class Courses
        {
            public static Link GetCourses { get { return new Link("courses", "~/courses"); } }

            public static Link Course { get { return new Link("course", "~/courses/{id}"); } }

            public static Link UpdateCourse { get { return new Link("update_course", "~/courses/{id}"); } }

            public static Link AddCourse { get { return new Link("add_course", "~/courses/{id}"); } }

            public static Link DeleteCourse { get { return new Link("delete_course", "~/courses/{id}"); } }
        }
    }
}