namespace DesignOfLibrary.forms
{
    partial class formSearchVisitor
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
            this.lableFind = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lableFind
            // 
            this.lableFind.AutoSize = true;
            this.lableFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableFind.Location = new System.Drawing.Point(281, 9);
            this.lableFind.Name = "lableFind";
            this.lableFind.Size = new System.Drawing.Size(304, 39);
            this.lableFind.TabIndex = 1;
            this.lableFind.Text = "Поиск посетителя";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(12, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(745, 30);
            this.tbSearch.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(763, 86);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(101, 30);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lvSearch
            // 
            this.lvSearch.HideSelection = false;
            this.lvSearch.Location = new System.Drawing.Point(12, 122);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(852, 325);
            this.lvSearch.TabIndex = 4;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.DoubleClick += new System.EventHandler(this.lvSearch_DoubleClick);
            // 
            // formSearchVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 459);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lableFind);
            this.Name = "formSearchVisitor";
            this.Text = "formSearchVisitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableFind;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ListView lvSearch;
    }
}