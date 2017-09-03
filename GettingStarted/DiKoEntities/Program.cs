using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DiKoEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FileSharingContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                // Add to database
                var file = new SharedFile { Name = name };
                db.SharedFiles.Add(file);
                db.SaveChanges();

                // Display all files from the database 
                var query = from b in db.SharedFiles
                            orderby b.Name
                            select b;

                // Display all files from the database
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    public class SharedFile
    {
        public int SharedFiletId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
    }

    public class WishedItem
    {
        public int WishedItemtId { get; set; }
        public string IPConnection { get; set; }
    }

    public class FileSharingContext : DbContext
    {
        public DbSet<SharedFile> SharedFiles { get; set; }
        public DbSet<WishedItem> WishList { get; set; }
    }
}
