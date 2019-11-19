using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    public class ClassManagement
    {
        public CLASSS[] GetClasses()
        {
            var db = new CLASSEntities();
            var classes = db.CLASSS.ToArray();
            return classes;
        }

        public void AddClass(string name, string description)
        {
            var NewClass = new CLASSS();
            NewClass.NAME = name;
            NewClass.DESCRIP = description;

            var db = new CLASSEntities();
            db.CLASSS.Add(NewClass);
            db.SaveChanges();
        }

        public void EditClass(int id, string name, string description)
        {
            var db = new CLASSEntities();
            var oldClass = db.CLASSS.Find(id);

            oldClass.NAME = name;
            oldClass.DESCRIP= description;

            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var db = new CLASSEntities();
            var @class = db.CLASSS.Find(id);
            db.CLASSS.Remove(@class);
            db.SaveChanges();
        }
        public CLASSS GetClass(int id)
        {
            var db = new CLASSEntities();
            var @class = db.CLASSS.Find(id);
            return @class;
        }
    }
}
