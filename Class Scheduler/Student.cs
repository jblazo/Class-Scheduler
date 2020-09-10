using System;

[Serializable]
class Student{
    private string name;
    private BirthDate birthday;
    private Major majors;
    private GraduationDate graduationDate;

    public Student(string name, BirthDate birthDate, Major majors, GraduationDate graduationDate){
        this.name = name;
        this.birthday = birthDate;
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

    public BirthDate Birthday{
        get{
            return this.birthday;
        }
        set{
            this.birthday = value;
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

    public Major Major{
        get
        {
            return this.majors;
        }
        set
        {
            this.majors = value;
        }
    }

    public override string ToString()
    {
        return ("Name: " + this.name + "\nBirthday: " + this.birthday+ "\nMajor: " + this.majors.MajorName + "\nGradDate: " + this.graduationDate.Month + "/" + this.graduationDate.Year);
    }
}