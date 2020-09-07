using System;
[Serializable]
class Major{
     private string[] classes;
    private string majorName;
     public Major(string[] classes, string MajorName){
         this.classes = classes;
         this.majorName = MajorName;
     }

     public string[] Classes{
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
