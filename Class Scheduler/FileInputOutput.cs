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
            Console.WriteLine(Directory.GetCurrentDirectory());
            string dir = @"..\..\";
            string serializationFile = Path.Combine(dir, "StudentsFile.txt");
            List<Student> studentList = new List<Student>();
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(serializationFile))
            {
                FileStream fs = new FileStream(serializationFile, FileMode.Open);
                try
                {
                    studentList = (List<Student>)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    fs.Close();
                }
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
            FileStream fs = new FileStream(serializationFile, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                studentList = (List<Student>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }

            return studentList;
        }
    }
}
