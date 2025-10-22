using System.Collections;

namespace _03.GenericsAndCollections.Collections
{
    //Challenge:
    /* 
     * Write a program that will iterate through each element of the Students array and insert them into a hashtable.
     * If a student with the same ID already exists in the hashtable skip it and display the following error:
     * "Sorry, A student with the same ID already exists".
     * Hint: Use the method ContainsKey() to check whether a student with the same ID already exists
     */
    public class HashTableChallenge
    {
        public void ChallengeAnswer()
        {
            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[5];

            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ranger", 65);
            students[3] = new Student(1, "Luis", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach (Student student in students)
            {
                if (studentsTable.ContainsKey(student.Id))
                {
                    Console.WriteLine("Sorry, A student with the same ID already exists");
                }
                else
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("Student with ID {0} was added.", student.Id);
                }
            }
        }
    }
}
