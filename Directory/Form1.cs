using NickBuhro.Translit;
using Product.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

  
        public override void Refresh()
        {
            tvProduct.Nodes.Clear();

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
            parent.Nodes.Add(node);
        }

        private void tvProduct_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
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
                    AddChildParent(parent, item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var latin = Transliteration.CyrillicToLatin(tbNameProductAdd.Text, Language.Russian);

            Seeder.AddParent(context, latin, tbNameProductAdd.Text);

            tvProduct.Nodes.Add(tbNameProductAdd.Text);

            Refresh();

            tbNameProductAdd.Text = "";
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tvProduct.SelectedNode.Name);
            ProductAll t = context.Products
                .SingleOrDefault(x => x.Id == id);

            string urlSlug = t.UrlSlug;

            var latin = Transliteration.CyrillicToLatin(tbSelectedAddChild.Text, Language.Russian);

            Seeder.AddChildParent(context, urlSlug, latin, tbSelectedAddChild.Text);

            tvProduct.SelectedNode.Nodes.Add(tbSelectedAddChild.Text);

            Refresh();

            tbSelectedAddChild.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tvProduct.SelectedNode.Name);
            ProductAll t = context.Products
                .SingleOrDefault(x => x.Id == id);

            context.Products.Remove(t);
            context.SaveChanges();
            tvProduct.SelectedNode.Remove();

            Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tvProduct.SelectedNode.Name);
            ProductAll t = context.Products
                .SingleOrDefault(x => x.Id == id);


            t.Name = tbEdit.Text;


            tvProduct.SelectedNode.Text = tbEdit.Text;
            context.SaveChanges();

            Refresh();
        }

        private void tvProduct_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tbEdit.Text = tvProduct.SelectedNode.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<TreeNode> Tnode = new List<TreeNode>();
            void Find(TreeNodeCollection Nodes, string str)
            {

                foreach (TreeNode node in Nodes)
                {
                    if (node.Text.Contains(str) && node.Nodes.Count != 0)
                        Tnode.Add(node);
                    if (node.Nodes.Count > 0)
                        Find(node.Nodes, str);
                }

            }

            Tnode.Clear();
            Find(tvProduct.Nodes, tbSearch.Text);
            foreach (TreeNode treeNode in Tnode)
            {
                tvProduct.Focus();
                tvProduct.SelectedNode = treeNode;
            }
        }
    }
}
