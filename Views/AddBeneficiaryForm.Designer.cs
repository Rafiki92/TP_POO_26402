namespace ThriftShopApp.Views
{
    partial class AddBeneficiaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBeneficiaryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Reference = new System.Windows.Forms.Label();
            this.FamilyNumber = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.Nationality = new System.Windows.Forms.Label();
            this.chkHasChildren = new System.Windows.Forms.CheckBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtFamilyNumber = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(905, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(305, 124);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 21);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(305, 163);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(53, 21);
            this.Name.TabIndex = 4;
            this.Name.Text = "Nome";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(305, 200);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(72, 21);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Contacto";
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reference.Location = new System.Drawing.Point(305, 239);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(83, 21);
            this.Reference.TabIndex = 6;
            this.Reference.Text = "Referência";
            // 
            // FamilyNumber
            // 
            this.FamilyNumber.AutoSize = true;
            this.FamilyNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNumber.Location = new System.Drawing.Point(305, 276);
            this.FamilyNumber.Name = "FamilyNumber";
            this.FamilyNumber.Size = new System.Drawing.Size(137, 21);
            this.FamilyNumber.TabIndex = 7;
            this.FamilyNumber.Text = "Agregado Familiar";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(305, 349);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(51, 21);
            this.Notes.TabIndex = 8;
            this.Notes.Text = "Notas";
            // 
            // Nationality
            // 
            this.Nationality.AutoSize = true;
            this.Nationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nationality.Location = new System.Drawing.Point(305, 388);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(109, 21);
            this.Nationality.TabIndex = 9;
            this.Nationality.Text = "Nacionalidade";
            // 
            // chkHasChildren
            // 
            this.chkHasChildren.AutoSize = true;
            this.chkHasChildren.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasChildren.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasChildren.Location = new System.Drawing.Point(306, 312);
            this.chkHasChildren.Name = "chkHasChildren";
            this.chkHasChildren.Size = new System.Drawing.Size(106, 25);
            this.chkHasChildren.TabIndex = 10;
            this.chkHasChildren.Text = "Tem filhos?";
            this.chkHasChildren.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.AccessibleName = "Data de Início";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(488, 424);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(160, 29);
            this.dtpStartDate.TabIndex = 11;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(305, 432);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(104, 21);
            this.StartDate.TabIndex = 12;
            this.StartDate.Text = "Data de Início";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(305, 474);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(93, 21);
            this.EndDate.TabIndex = 13;
            this.EndDate.Text = "Data de Fim";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.AccessibleName = "Data de Início";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(488, 466);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(160, 29);
            this.dtpEndDate.TabIndex = 14;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(306, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(488, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 44);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(488, 382);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(158, 33);
            this.txtNationality.TabIndex = 17;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(488, 343);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(158, 33);
            this.txtNotes.TabIndex = 18;
            // 
            // txtFamilyNumber
            // 
            this.txtFamilyNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyNumber.Location = new System.Drawing.Point(488, 264);
            this.txtFamilyNumber.Name = "txtFamilyNumber";
            this.txtFamilyNumber.Size = new System.Drawing.Size(158, 33);
            this.txtFamilyNumber.TabIndex = 19;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(488, 227);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(158, 33);
            this.txtReference.TabIndex = 20;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(488, 188);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(158, 33);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(488, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 33);
            this.txtName.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(488, 112);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 33);
            this.txtID.TabIndex = 23;
            // 
            // AddBeneficiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 572);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtFamilyNumber);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.chkHasChildren);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.FamilyNumber);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox1);
            this.Name.Text = "AddBeneficiaryForm";
            this.Text = "Sorrisos - SG Loja Social";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.Label FamilyNumber;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label Nationality;
        private System.Windows.Forms.CheckBox chkHasChildren;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtFamilyNumber;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
    }
}