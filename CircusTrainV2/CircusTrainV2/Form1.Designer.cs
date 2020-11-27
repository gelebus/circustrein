namespace CircusTrainV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCarnivore = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btHerbivore = new System.Windows.Forms.RadioButton();
            this.btSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLarge = new System.Windows.Forms.RadioButton();
            this.btMiddle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddAnimal = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCarnivore
            // 
            this.btCarnivore.AutoSize = true;
            this.btCarnivore.Checked = true;
            this.btCarnivore.Location = new System.Drawing.Point(0, 19);
            this.btCarnivore.Name = "btCarnivore";
            this.btCarnivore.Size = new System.Drawing.Size(70, 17);
            this.btCarnivore.TabIndex = 0;
            this.btCarnivore.TabStop = true;
            this.btCarnivore.Text = "Carnivore";
            this.btCarnivore.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btHerbivore);
            this.groupBox1.Controls.Add(this.btCarnivore);
            this.groupBox1.Location = new System.Drawing.Point(543, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diet";
            // 
            // btHerbivore
            // 
            this.btHerbivore.AutoSize = true;
            this.btHerbivore.Location = new System.Drawing.Point(0, 42);
            this.btHerbivore.Name = "btHerbivore";
            this.btHerbivore.Size = new System.Drawing.Size(71, 17);
            this.btHerbivore.TabIndex = 1;
            this.btHerbivore.Text = "Herbivore";
            this.btHerbivore.UseVisualStyleBackColor = true;
            // 
            // btSmall
            // 
            this.btSmall.AutoSize = true;
            this.btSmall.Checked = true;
            this.btSmall.Location = new System.Drawing.Point(6, 19);
            this.btSmall.Name = "btSmall";
            this.btSmall.Size = new System.Drawing.Size(50, 17);
            this.btSmall.TabIndex = 2;
            this.btSmall.TabStop = true;
            this.btSmall.Text = "Small";
            this.btSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLarge);
            this.groupBox2.Controls.Add(this.btMiddle);
            this.groupBox2.Controls.Add(this.btSmall);
            this.groupBox2.Location = new System.Drawing.Point(652, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // btLarge
            // 
            this.btLarge.AutoSize = true;
            this.btLarge.Location = new System.Drawing.Point(7, 65);
            this.btLarge.Name = "btLarge";
            this.btLarge.Size = new System.Drawing.Size(52, 17);
            this.btLarge.TabIndex = 4;
            this.btLarge.Text = "Large";
            this.btLarge.UseVisualStyleBackColor = true;
            // 
            // btMiddle
            // 
            this.btMiddle.AutoSize = true;
            this.btMiddle.Location = new System.Drawing.Point(7, 42);
            this.btMiddle.Name = "btMiddle";
            this.btMiddle.Size = new System.Drawing.Size(56, 17);
            this.btMiddle.TabIndex = 3;
            this.btMiddle.Text = "Middle";
            this.btMiddle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btAddAnimal
            // 
            this.btAddAnimal.Location = new System.Drawing.Point(409, 35);
            this.btAddAnimal.Name = "btAddAnimal";
            this.btAddAnimal.Size = new System.Drawing.Size(110, 82);
            this.btAddAnimal.TabIndex = 7;
            this.btAddAnimal.Text = "Add Animal";
            this.btAddAnimal.UseVisualStyleBackColor = true;
            this.btAddAnimal.Click += new System.EventHandler(this.btAddAnimal_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(543, 192);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(110, 82);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reset Train";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(543, 356);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(110, 82);
            this.btSort.TabIndex = 9;
            this.btSort.Text = "Sort Animals";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(12, 12);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(367, 433);
            this.lbAnimals.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btAddAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btCarnivore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btHerbivore;
        private System.Windows.Forms.RadioButton btSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btLarge;
        private System.Windows.Forms.RadioButton btMiddle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddAnimal;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAnimals;
    }
}

