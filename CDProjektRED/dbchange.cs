using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDProjektRED
{
    public class dbchange
    {
        public static List<CDtbl> CDList()
        {
            using (CDModel Cds = new CDModel())
            {
                var CDList = Cds.CDtbls;
                var db = CDList.ToList();
                return CDList.ToList();
            }
        }
        public static CDtbl searchDB(int id)//searches table for object with name equal to the string passed
        {
            using (CDModel context = new CDModel())
            {
                CDtbl CD = context.CDtbls.FirstOrDefault(r => r.id == id);
                return CD;
            }
        }
        public static void editRecord(int id, string artist, string album, int year)
        {
            using (CDModel db = new CDModel())
            {
                CDtbl CD = new CDtbl
                {
                    id = id,
                    Artist = artist,
                    Album = album,
                    Year = year
                };
                var original = db.CDtbls.Find(CD.id);
                if (original != null)
                {
                    db.Entry(original).CurrentValues.SetValues(CD);
                    db.SaveChanges();
                }
            }
        }
        public static void deleteRecord(int ID)//deletes record based on id passed
        {
            using (CDModel context = new CDModel())
            {
                CDtbl champion = new CDtbl { id = ID };
                var cdGone = searchDB(ID);
                context.CDtbls.Attach(cdGone);
                context.CDtbls.Remove(cdGone);
                context.SaveChanges();
            }
        }
        public static void addRecord(string Artist, string Album, int Year)
        {
            using (CDModel context = new CDModel())
            {

                CDtbl cd = new CDtbl()
                {
                    Artist = Artist,
                    Album = Album,
                    Year = Year,
                };

                context.CDtbls.Add(cd);
                context.SaveChanges();
            }
        }
    }
}