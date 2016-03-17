namespace Courses
{
    using System;
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            string result = base.ToString();

            if (this.Town != null)
            {
                result += string.Format("; Lab = ", this.Town);
            }

            result += " }";
            return result;
        }
    }
}