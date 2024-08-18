using System;

namespace countCourse.Entities
{
	public class Teacher 
	{

		public int Course { get; set; }
        public int IdCourse { get; set; }

        public Teacher(int course, int idCourse) 
        {
            Course = course;
            IdCourse = idCourse;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Teacher))
            {
                return false;
            }
            Teacher other = obj as Teacher;
            return IdCourse.Equals(other.IdCourse);
        }

        public override int GetHashCode()
        {
            return IdCourse.GetHashCode();
        }

        public Teacher()
		{
		}

        public Teacher(int idCourse)
        {
            IdCourse = idCourse;
        }
    }
}

