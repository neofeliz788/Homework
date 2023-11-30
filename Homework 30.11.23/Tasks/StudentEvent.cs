using System;
using System.Collections.Generic;
using System.IO;

namespace Task
{
    class StudentEvent
    {
        string eventName;
        DateTime eventDate;
        int numberOfStudents;
        public string EventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
            }
        }
        public DateTime EventDate
        {
            get
            {
                return eventDate;
            }
        }
        public int NumberOfStudents
        {
            get
            {
                return numberOfStudents;
            }
            set
            {
                numberOfStudents = value;
            }
        }
        public StudentEvent(string eventName, DateTime eventDate, int numberOfStudents)
        {
            this.eventName = eventName;
            this.eventDate = eventDate;
            this.numberOfStudents = numberOfStudents;
        }
        public void ToFile(string path)
        {
            File.AppendAllText(path, $"Мероприятие: {eventName} | Дата: {eventDate} | Участников: {numberOfStudents}\n");
        }S
        public void SelectionParticipants(List<List<Student>> studentsDivided, string path)
        {
            int[] Registrants = new int[studentsDivided.Count];
            List<Student> registeredStudents = new List<Student>();

            for (int i = 0; i < studentsDivided.Count; i++)
            {
                for (int j = 0; j < studentsDivided[i].Count; j++)
                {
                    if ((Registrants[i] + 1) < (numberOfStudents / 2))
                    {
                        studentsDivided[i][j].VoluntaryVisit();
                        Registrants[i]++;
                        registeredStudents.Add(studentsDivided[i][j]);
                        File.AppendAllText(path, $"{studentsDivided[i][j].Surname} {studentsDivided[i][j].Name}\n");
                    }
                }
                for (int j = 0; j < studentsDivided[i].Count; j++)
                {
                    if (!registeredStudents.Contains(studentsDivided[i][j]) && Registrants[i] + 1 <= numberOfStudents)
                    {
                        Registrants[i]++;
                        studentsDivided[i][j].ForcedVisit();
                        registeredStudents.Add(studentsDivided[i][j]);
                        File.AppendAllText(path, $"{studentsDivided[i][j].Surname} {studentsDivided[i][j].Name}\n");
                    }
                }
                for (int j = 0; j < studentsDivided[i].Count; j++)
                {
                    if (!registeredStudents.Contains(studentsDivided[i][j]))
                    {
                        studentsDivided[i][j].RefuseVisit();
                    }
                }
            }
        }
    }
}