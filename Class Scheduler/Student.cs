using System;

[Serializable]
class Student{
    private string name;
    private DateTime birthDate;
    private Major majors;
    private GraduationDate graduationDate;

    public Student(string name, DateTime birthDate, Major majors, GraduationDate graduationDate){
        this.name = name;
        this.birthDate = birthDate;
        this.majors = majors;
        this.graduationDate = graduationDate;
    }

    public string Name{
        get{
            return this.name;
        }
        set{
            this.name = value;
        }
    }

    public DateTime BirthDate{
        get{
            return this.birthDate;
        }
        set{
            this.birthDate = value;
        }
    }

    public GraduationDate GraduationDate{
        get{
            return this.graduationDate;
        }
        set{
            this.graduationDate = value;
        }
    }

    public override string ToString()
    {
        return ("Name: " + this.name + "\nBirthday: " + this.birthDate.ToString("MM/dd/yyyy")+ "\nMajor: " + this.majors.MajorName + "\nGradDate: " + this.graduationDate.Month + "/" + this.graduationDate.Year);
    }
}