using Product.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        MyContext context = new MyContext();
        public Form1()
        {
            InitializeComponent();
            Seeder.SeedDatabase(context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var categories = context.Products.Select(c => new ProductGroup
            {
                Id = c.Id,
                Name = c.Name,
                UrlName = c.UrlSlug,
                ParentId = c.ParentId
            }).ToList();

            var tree = categories.BuildTree();

            var list = context.Products.Where(x => x.ParentId == null).Select(x => new ProductView
            {
                Id = x.Id,
                Name = x.Name,
                UrlSlug = x.UrlSlug
            }).ToList();

            foreach (var item in list)
            {
                AddParent(item);
            }
            tvProduct.Focus();
        }

        private void AddParent(ProductView productView)
        {
            TreeNode node = new TreeNode();
            node.Text = productView.Name;
            node.Name = productView.Id.ToString();
            node.Tag = productView;
            node.Nodes.Add("");
            tvProduct.Nodes.Add(node);
        }

        private void AddChildParent(TreeNode parent, ProductView productView)
        {
            TreeNode node = new TreeNode();
            node.Text = productView.Name;
            node.Name = productView.Id.ToString();
            node.Tag = productView;
            //node.Nodes.Add("");
            parent.Nodes.Add(node);
        }

        private void tvProduct_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Nodes[0].Text == "")
            {
                var parent = e.Node;
                var parentId = (parent.Tag as ProductView).Id;
                parent.Nodes.Clear();

                var list = context.Products.Where(x => x.ParentId == parentId).Select(x => new ProductView
                {
                    Id = x.Id,
                    Name = x.Name,
                    UrlSlug = x.UrlSlug
                }).ToList();

                foreach (var item in list)
                {
                    AddChildParent(parent , item);
                }
            }
        }
    }
}
