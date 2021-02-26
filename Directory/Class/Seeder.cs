using System;
using System.Collections.Generic;
using System.Text;
using Product.Class;
using System.Linq;

namespace Product.Class
{
    public static class Seeder
    {
        public static void SeedDatabase(MyContext context)
        {
            SeedProduct(context);
        }

        private static void SeedProduct(MyContext context)
        {
            if (context.Products.Count() == 0)
            {
                string urlSlug = "Fruts";
                AddParent(context, urlSlug, "Фрукти");
                AddChildParent(context, urlSlug, "banan", "Банан");
                AddChildParent(context, urlSlug, "apple", "Яблуко");
                AddChildParent(context, urlSlug, "orange", "Апельсин");

                urlSlug = "Vegetables";
                AddParent(context, urlSlug, "Овочі");
                AddChildParent(context, urlSlug, "carrot", "Морква");
                AddChildParent(context, urlSlug, "beet", "Буряк");
                AddChildParent(context, urlSlug, "potato", "Картопля");
            }           
        }

        public static void AddParent(MyContext context, string urlSlug, string name)
        {
            context.Products.Add(new ProductAll
            {
                Name = name,
                ParentId = null,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }

        public static void AddChildParent(MyContext context, string parentSlug, string urlSlug, string name)
        {
            var parent = context.Products.SingleOrDefault(x => x.UrlSlug == parentSlug);
            context.Products.Add(new ProductAll
            {
                Name = name,
                ParentId = parent.Id,
                UrlSlug = urlSlug
            });
            context.SaveChanges();
        }
    }
}
