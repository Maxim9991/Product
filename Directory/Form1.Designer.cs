
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbNameProductAdd = new System.Windows.Forms.TextBox();
            this.tvProduct = new System.Windows.Forms.TreeView();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
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
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(503, 38);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(27, 23);
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
            // 
            // tvProduct
            // 
            this.tvProduct.Location = new System.Drawing.Point(6, 22);
            this.tvProduct.Name = "tvProduct";
            this.tvProduct.Size = new System.Drawing.Size(361, 398);
            this.tvProduct.TabIndex = 0;
            this.tvProduct.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvProduct_BeforeExpand);
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(373, 22);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(93, 15);
            this.lblNewCategory.TabIndex = 3;
            this.lblNewCategory.Text = "Додати продукт";
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
    }
}

