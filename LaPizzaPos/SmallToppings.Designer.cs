namespace LaPizzaPos
{
    partial class SmallToppings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallToppings));
            this.wholeToppingList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftHalfTopping = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rightHalfTopping = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wholeToppingList
            // 
            this.wholeToppingList.CheckOnClick = true;
            this.wholeToppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeToppingList.FormattingEnabled = true;
            this.wholeToppingList.Items.AddRange(new object[] {
            "Extra Cheese",
            "Anchovies",
            "Bacon",
            "Beef",
            "Capicola",
            "Ham",
            "Pepperoni",
            "Sausage",
            "Turkey",
            "Banana Pepper",
            "Black Olive",
            "Garlic",
            "Green Olive",
            "Green Pepper",
            "Mushroom",
            "Onion",
            "Pepperoncini",
            "Spinach",
            "Tomato",
            "Deluxe Veggie",
            "Deluxe Meat",
            "Roberto"});
            this.wholeToppingList.Location = new System.Drawing.Point(2, 32);
            this.wholeToppingList.Name = "wholeToppingList";
            this.wholeToppingList.Size = new System.Drawing.Size(277, 671);
            this.wholeToppingList.TabIndex = 0;
            this.wholeToppingList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Whole Topping";
            // 
            // leftHalfTopping
            // 
            this.leftHalfTopping.CheckOnClick = true;
            this.leftHalfTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftHalfTopping.ForeColor = System.Drawing.Color.Red;
            this.leftHalfTopping.FormattingEnabled = true;
            this.leftHalfTopping.Items.AddRange(new object[] {
            "Extra Cheese",
            "Anchovies",
            "Bacon",
            "Beef",
            "Capicola",
            "Ham",
            "Pepperoni",
            "Sausage",
            "Turkey",
            "Banana Pepper",
            "Black Olive",
            "Garlic",
            "Green Olive",
            "Green Pepper",
            "Mushroom",
            "Onion",
            "Pepperoncini",
            "Spinach",
            "Tomato",
            "Deluxe Veggie",
            "Deluxe Meat",
            "Roberto"});
            this.leftHalfTopping.Location = new System.Drawing.Point(319, 32);
            this.leftHalfTopping.Name = "leftHalfTopping";
            this.leftHalfTopping.Size = new System.Drawing.Size(277, 671);
            this.leftHalfTopping.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Left Half-Topping";
            // 
            // rightHalfTopping
            // 
            this.rightHalfTopping.CheckOnClick = true;
            this.rightHalfTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightHalfTopping.ForeColor = System.Drawing.Color.LimeGreen;
            this.rightHalfTopping.FormattingEnabled = true;
            this.rightHalfTopping.Items.AddRange(new object[] {
            "Extra Cheese",
            "Anchovies",
            "Bacon",
            "Beef",
            "Capicola",
            "Ham",
            "Pepperoni",
            "Sausage",
            "Turkey",
            "Banana Pepper",
            "Black Olive",
            "Garlic",
            "Green Olive",
            "Green Pepper",
            "Mushroom",
            "Onion",
            "Pepperoncini",
            "Spinach",
            "Tomato",
            "Deluxe Veggie",
            "Deluxe Meat",
            "Roberto"});
            this.rightHalfTopping.Location = new System.Drawing.Point(623, 32);
            this.rightHalfTopping.Name = "rightHalfTopping";
            this.rightHalfTopping.Size = new System.Drawing.Size(277, 671);
            this.rightHalfTopping.TabIndex = 4;
            this.rightHalfTopping.SelectedIndexChanged += new System.EventHandler(this.rightHalfTopping_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Right Half-Topping";
            // 
            // tBox
            // 
            this.tBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox.Location = new System.Drawing.Point(906, 126);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(202, 405);
            this.tBox.TabIndex = 6;
            this.tBox.Text = "14\" Cheese Pizza";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Red;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(927, 74);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(152, 33);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add To Pizza";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(906, 553);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(202, 41);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "Done - Add To Order";
            this.doneBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(919, 638);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 39);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel Pizza";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // SmallToppings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 717);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightHalfTopping);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leftHalfTopping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wholeToppingList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SmallToppings";
            this.Text = "SmallToppings";
            this.Load += new System.EventHandler(this.SmallToppings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox wholeToppingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox leftHalfTopping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox rightHalfTopping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}