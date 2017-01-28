using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Passwords_ASP.NET.Models
{
    public class SiteDbInitializer : CreateDatabaseIfNotExists<SiteContext>
    {
        protected override void Seed(SiteContext db)
        {
            db.Sites.Add(new Site { name = "vk.com", login = "vkLogin", password = "vkPassword" });
            db.Sites.Add(new Site { name = "ukr.net", login = "ukrLogin", password = "ukrPassword" });
            db.Sites.Add(new Site { name = "bigmir.net", login = "bigmirLogin", password = "bigmirPassword" });

            base.Seed(db);
        }
    }
}