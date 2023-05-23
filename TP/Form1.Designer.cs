
namespace TP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonLoadXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 286);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(193, 43);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(233, 286);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(193, 43);
            this.button.TabIndex = 2;
            this.button.Text = "Получить людей LINQ";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "LINQ c лямбда";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(233, 354);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(193, 43);
            this.buttonSaveXML.TabIndex = 4;
            this.buttonSaveXML.Text = "Сохранить в XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click_1);
            // 
            // buttonLoadXML
            // 
            this.buttonLoadXML.Location = new System.Drawing.Point(13, 423);
            this.buttonLoadXML.Name = "buttonLoadXML";
            this.buttonLoadXML.Size = new System.Drawing.Size(193, 43);
            this.buttonLoadXML.TabIndex = 5;
            this.buttonLoadXML.Text = "Загрузить из XML";
            this.buttonLoadXML.UseVisualStyleBackColor = true;
            this.buttonLoadXML.Click += new System.EventHandler(this.buttonLoadXML_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.buttonLoadXML);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Button buttonLoadXML;
    }
}

