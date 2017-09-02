using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ANS_Library_Management_System
{
    class GenerateID
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int Student()
        {
            return Convert.ToInt32(db.sp_UserID());
        }

        public int Teacher()
        {
            return Convert.ToInt32(db.sp_UserID());
        }

        public void StudentID()
        {

        }
    }
}
