using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task
{
    class Student
    {
        string name;
        string surname;
        string group;
        int eventVisited;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
        public int EventVisited
        {
            get
            {
                return eventVisited;
            }
            set
            {
                eventVisited = value;
            }
        }
        public Student(string name, string surname, string group, int eventVisited)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.eventVisited = eventVisited;
        }
        public void VoluntaryVisit()
        {
            Random rnd = new Random();

            if (eventVisited == 0)
            {
                eventVisited++;
            }
            else
            {
                if (rnd.Next(0, 2) == 1)
                {
                    eventVisited++;
                }
                else
                {
                    eventVisited--;
                }
            }
        }
        public void ForcedVisit()
        {
            if (eventVisited != 3)
            {
                eventVisited++;
            }
        }
        public void RefuseVisit()
        {
            if (eventVisited != 0)
            {
                eventVisited--;
            }
        }
        public static List<Student> ReadAll(string path)
        {
            List<Student> students = new List<Student>();
            string[] read = File.ReadAllLines(path);
            foreach (string line in read)
            {
                string[] parseArray = line.Split('#');
                if (parseArray.Length == 7)
                {
                    if (!int.TryParse(parseArray[3], out int eventVisited))
                    {
                        continue;
                    }
                    Student student = new Student(parseArray[0], parseArray[1], parseArray[2], eventVisited);
                    students.Add(student);
                }
            }
            return students;
        }
        static public List<List<Student>> DivideStudents(List<Student> students)
        {
            int k = 0;
            List<List<Student>> studentsDivided = new List<List<Student>>();

            students = students.OrderBy(student => student.Group).ToList();

            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Group != students[i - 1].Group)
                {
                    List<Student> studentsInGroup = new List<Student>();

                    for (int j = k; j < i; j++)
                    {
                        studentsInGroup.Add(students[j]);
                    }

                    studentsDivided.Add(studentsInGroup);
                    k = i;
                }
            }
            if (students[students.Count - 1].Group == students[students.Count - 2].Group)
            {
                studentsDivided[studentsDivided.Count - 1].Add(students[students.Count - 1]);
            }
            else
            {
                List<Student> studentsInGroup = new List<Student> { students[students.Count - 1] };
                studentsDivided.Add(studentsInGroup);
            }

            return studentsDivided;
        }
    }
}