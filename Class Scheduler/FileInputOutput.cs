using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Class_Scheduler
{
    class FileInputOutput
    {
        public static void SerializeStudent(Student student)
        {
            //Console.WriteLine(Directory.GetCurrentDirectory());
            string dir = @"..\..\";
            string serializationFile = Path.Combine(dir, "StudentsFile.txt");
            List<Student> studentList = new List<Student>();
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(serializationFile))
            {
                studentList = DeserializeStudents();
            }
            

            FileStream stream = new FileStream(serializationFile, FileMode.Create);
            studentList.Add(student);
            try
            {
                formatter.Serialize(stream, studentList);
            }
            catch(SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }
            
            
            

        }

        public static List<Student> DeserializeStudents()
        {
            List<Student> studentList = new List<Student>();
            string dir = @"..\..\";
            string serializationFile = Path.Combine(dir, "StudentsFile.txt");
            if (File.Exists(serializationFile))
            {
                FileStream fs = new FileStream(serializationFile, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                if (fs.Length != 0)
                {
                    try
                    {
                        studentList = (List<Student>)formatter.Deserialize(fs);
                    }
                    catch (SerializationException e)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                        throw;
                    }
                }
                fs.Close();
                

                /*foreach (Student student in studentList)
                {
                    Console.WriteLine(student);
                }*/

            }
            return studentList;
            
        }

        public static List<Course> DeserializeCourses()
        {
            List<Course> courseList = new List<Course>();
            string dir = @"..\..\";
            string serializationFile = Path.Combine(dir, "CoursesFile.txt");
            if (File.Exists(serializationFile))
            {
                FileStream fs = new FileStream(serializationFile, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                if (fs.Length != 0)
                {
                    try
                    {
                        courseList = (List<Course>)formatter.Deserialize(fs);
                    }
                    catch (SerializationException e)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                        throw;
                    }
                }
                fs.Close();
            }
            return courseList;

        }

        public static void SerializeCourses(Course course)
        {
            string dir = @"..\..\";
            string serializationFile = Path.Combine(dir, "CoursesFile.txt");
            List<Course> courseList = new List<Course>();
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(serializationFile))
            {
                courseList = DeserializeCourses();
            }


            FileStream stream = new FileStream(serializationFile, FileMode.Create);
            courseList.Add(course);
            try
            {
                formatter.Serialize(stream, courseList);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
