using Class_Scheduler;
using System;
[Serializable]
class Major{
    private Course[] classes;
    private string majorName;
     public Major(Course[] classes, string MajorName){
         this.classes = classes;
         this.majorName = MajorName;
     }

     public Course[] Classes{
         get{
             return this.classes;
         }
         set{
             this.classes = value;
         }
     }

    public string MajorName
    {
        get
        {
            return this.majorName;
        }
        set
        {
            this.majorName = value;
        }
    }
}
