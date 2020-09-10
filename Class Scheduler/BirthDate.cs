using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[Serializable]
    public class BirthDate
    {
        private DateTime birthday;

        public BirthDate(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                this.birthday = value;
            }
        }

        public override string ToString()
        {
            return this.birthday.ToString("MM/dd/yyyy");
        }
    }

