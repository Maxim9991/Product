
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
            this.tvProduct = new System.Windows.Forms.TreeView();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.tvProduct);
            this.gbProduct.Location = new System.Drawing.Point(12, 12);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(776, 426);
            this.gbProduct.TabIndex = 0;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Продукти";
            // 
            // tvProduct
            // 
            this.tvProduct.Location = new System.Drawing.Point(6, 22);
            this.tvProduct.Name = "tvProduct";
            this.tvProduct.Size = new System.Drawing.Size(361, 398);
            this.tvProduct.TabIndex = 0;
            this.tvProduct.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvProduct_BeforeExpand);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TreeView tvProduct;
    }
}

