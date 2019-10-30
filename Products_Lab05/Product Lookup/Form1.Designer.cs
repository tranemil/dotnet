namespace Product_Lookup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label units_On_HandLabel;
            this.productNumberListBox = new System.Windows.Forms.ListBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productDataSet = new Product_Lookup.ProductDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Product_Lookup.ProductDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Product_Lookup.ProductDataSetTableAdapters.TableAdapterManager();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.units_On_HandTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            units_On_HandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNumberListBox
            // 
            this.productNumberListBox.DataSource = this.productBindingSource;
            this.productNumberListBox.DisplayMember = "Product_Number";
            this.productNumberListBox.FormattingEnabled = true;
            this.productNumberListBox.Location = new System.Drawing.Point(15, 47);
            this.productNumberListBox.Name = "productNumberListBox";
            this.productNumberListBox.Size = new System.Drawing.Size(120, 95);
            this.productNumberListBox.TabIndex = 0;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(12, 9);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(126, 13);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Select a Product Number";
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = Product_Lookup.ProductDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(172, 50);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(241, 47);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(201, 119);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(241, 116);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // units_On_HandLabel
            // 
            units_On_HandLabel.AutoSize = true;
            units_On_HandLabel.Location = new System.Drawing.Point(155, 83);
            units_On_HandLabel.Name = "units_On_HandLabel";
            units_On_HandLabel.Size = new System.Drawing.Size(80, 13);
            units_On_HandLabel.TabIndex = 7;
            units_On_HandLabel.Text = "Units On Hand:";
            // 
            // units_On_HandTextBox
            // 
            this.units_On_HandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Units_On_Hand", true));
            this.units_On_HandTextBox.Location = new System.Drawing.Point(241, 80);
            this.units_On_HandTextBox.Name = "units_On_HandTextBox";
            this.units_On_HandTextBox.Size = new System.Drawing.Size(100, 20);
            this.units_On_HandTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 169);
            this.Controls.Add(units_On_HandLabel);
            this.Controls.Add(this.units_On_HandTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productNumberListBox);
            this.Name = "Form1";
            this.Text = "Product Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productNumberListBox;
        private System.Windows.Forms.Label productLabel;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private ProductDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox units_On_HandTextBox;
    }
}

