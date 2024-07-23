namespace Gym_Management_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEquipName = new TextBox();
            txtCost = new TextBox();
            txtDescription = new RichTextBox();
            dateTimePickerDeliveryDate = new DateTimePicker();
            txtMusclesUsed = new TextBox();
            btnSave = new Button();
            btnReset = new Button();
            btnViewEq = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(282, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(280, 194);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 2;
            label3.Text = "Muscles Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(235, 270);
            label4.Name = "label4";
            label4.Size = new Size(175, 17);
            label4.TabIndex = 3;
            label4.Text = "Available for delivery from";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(302, 339);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 4;
            label5.Text = "Cost";
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(223, 40);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(191, 23);
            txtEquipName.TabIndex = 5;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(214, 366);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(211, 23);
            txtCost.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(214, 115);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(211, 60);
            txtDescription.TabIndex = 8;
            txtDescription.Text = "";
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDeliveryDate.Location = new Point(214, 304);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(211, 23);
            dateTimePickerDeliveryDate.TabIndex = 9;
            // 
            // txtMusclesUsed
            // 
            txtMusclesUsed.Location = new Point(214, 231);
            txtMusclesUsed.Name = "txtMusclesUsed";
            txtMusclesUsed.Size = new Size(211, 23);
            txtMusclesUsed.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(73, 437);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(286, 437);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnViewEq
            // 
            btnViewEq.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewEq.Location = new Point(451, 437);
            btnViewEq.Name = "btnViewEq";
            btnViewEq.Size = new Size(159, 23);
            btnViewEq.TabIndex = 13;
            btnViewEq.Text = "View Equipments";
            btnViewEq.UseVisualStyleBackColor = true;
            btnViewEq.Click += btnViewEq_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(632, 492);
            Controls.Add(btnViewEq);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(txtMusclesUsed);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(txtDescription);
            Controls.Add(txtCost);
            Controls.Add(txtEquipName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEquipName;
        private TextBox txtCost;
        private RichTextBox txtDescription;
        private DateTimePicker dateTimePickerDeliveryDate;
        private TextBox txtMusclesUsed;
        private Button btnSave;
        private Button btnReset;
        private Button btnViewEq;
    }
}