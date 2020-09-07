using System;
[Serializable]
class GraduationDate{
    private int month;
    private int year;
    
    
    public GraduationDate(int month, int year){
        this.month = month;
        this.year = year;
    }

    public int Month{
        get{
            return this.month;
        }

        set{
            this.month = value;
        }
    }

    public int Year{
        get{
            return this.year;
        }
        set{
            this.year = value;
        }
    }
}