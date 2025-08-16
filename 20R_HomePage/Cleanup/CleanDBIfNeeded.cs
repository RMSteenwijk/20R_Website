using Piranha.Data.EF.SQLite;

namespace _20R_HomePage.Cleanup
{
    public class CleanDBIfNeeded
    {
        public static void Clean(SQLiteDb db)
        {
            var currentSiteTypeId = db.Sites.FirstOrDefault(x => x.Title == "20R Gaming").SiteTypeId ?? "";
            
        }
    }
}
