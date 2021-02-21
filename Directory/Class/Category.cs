using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.Class
{
    public static    class Category
    {
        public static IList<ProductGroup> BuildTree(this IEnumerable<ProductGroup> source)
        {
            var groups = source.GroupBy(i => i.ParentId);

            var roots = groups.FirstOrDefault(g => g.Key.HasValue == false).ToList();

            if (roots.Count > 0)
            {
                var dict = groups.Where(g => g.Key.HasValue).ToDictionary(g => g.Key.Value, g => g.ToList());
                for (int i = 0; i < roots.Count; i++)
                    AddChildren(roots[i], dict);
            }

            return roots;
        }

        private static void AddChildren(ProductGroup node, IDictionary<int, List<ProductGroup>> source)
        {
            if (source.ContainsKey(node.Id))
            {
                node.Child = source[node.Id];
                for (int i = 0; i < node.Child.Count; i++)
                    AddChildren(node.Child[i], source);
            }
            else
            {
                node.Child = new List<ProductGroup>();
            }
        }
    }
}
