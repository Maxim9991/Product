
namespace Product
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblChildAdd = new System.Windows.Forms.Label();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.tbSelectedAddChild = new System.Windows.Forms.TextBox();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbNameProductAdd = new System.Windows.Forms.TextBox();
            this.tvProduct = new System.Windows.Forms.TreeView();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.btnSearch);
            this.gbProduct.Controls.Add(this.tbSearch);
            this.gbProduct.Controls.Add(this.tbEdit);
            this.gbProduct.Controls.Add(this.btnEdit);
            this.gbProduct.Controls.Add(this.btnDel);
            this.gbProduct.Controls.Add(this.lblChildAdd);
            this.gbProduct.Controls.Add(this.btnAddChild);
            this.gbProduct.Controls.Add(this.tbSelectedAddChild);
            this.gbProduct.Controls.Add(this.lblNewCategory);
            this.gbProduct.Controls.Add(this.btnAddProduct);
            this.gbProduct.Controls.Add(this.tbNameProductAdd);
            this.gbProduct.Controls.Add(this.tvProduct);
            this.gbProduct.Location = new System.Drawing.Point(12, 12);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(776, 426);
            this.gbProduct.TabIndex = 0;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Продукти";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(503, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(373, 370);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(124, 23);
            this.tbSearch.TabIndex = 10;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(373, 177);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(124, 23);
            this.tbEdit.TabIndex = 9;
            this.tbEdit.TextChanged += new System.EventHandler(this.tbEdit_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(503, 177);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(373, 243);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Видалити";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblChildAdd
            // 
            this.lblChildAdd.AutoSize = true;
            this.lblChildAdd.Location = new System.Drawing.Point(373, 93);
            this.lblChildAdd.Name = "lblChildAdd";
            this.lblChildAdd.Size = new System.Drawing.Size(105, 15);
            this.lblChildAdd.TabIndex = 6;
            this.lblChildAdd.Text = "Add Product Child";
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(503, 111);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(23, 23);
            this.btnAddChild.TabIndex = 5;
            this.btnAddChild.Text = "+";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // tbSelectedAddChild
            // 
            this.tbSelectedAddChild.Location = new System.Drawing.Point(373, 111);
            this.tbSelectedAddChild.Name = "tbSelectedAddChild";
            this.tbSelectedAddChild.Size = new System.Drawing.Size(124, 23);
            this.tbSelectedAddChild.TabIndex = 4;
            this.tbSelectedAddChild.TextChanged += new System.EventHandler(this.tbSelectedAddChild_TextChanged);
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(373, 22);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(74, 15);
            this.lblNewCategory.TabIndex = 3;
            this.lblNewCategory.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(503, 38);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "+";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNameProductAdd
            // 
            this.tbNameProductAdd.Location = new System.Drawing.Point(373, 38);
            this.tbNameProductAdd.Name = "tbNameProductAdd";
            this.tbNameProductAdd.Size = new System.Drawing.Size(124, 23);
            this.tbNameProductAdd.TabIndex = 1;
            this.tbNameProductAdd.TextChanged += new System.EventHandler(this.tbNameProductAdd_TextChanged);
            // 
            // tvProduct
            // 
            this.tvProduct.Location = new System.Drawing.Point(6, 22);
            this.tvProduct.Name = "tvProduct";
            this.tvProduct.Size = new System.Drawing.Size(361, 398);
            this.tvProduct.TabIndex = 0;
            this.tvProduct.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvProduct_BeforeExpand);
            this.tvProduct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProduct_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbProduct);
            this.Name = "Form1";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TreeView tvProduct;
        private System.Windows.Forms.TextBox tbNameProductAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.TextBox tbSelectedAddChild;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Label lblChildAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

