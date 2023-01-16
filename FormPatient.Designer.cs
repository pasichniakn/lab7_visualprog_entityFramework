
namespace lab7
{
    partial class FormPatient
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label allergiesLabel;
            System.Windows.Forms.Label bloodTypeLabel;
            System.Windows.Forms.Label dateBirthLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label nameLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.bloodTypeTextBox = new System.Windows.Forms.TextBox();
            this.dateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            allergiesLabel = new System.Windows.Forms.Label();
            bloodTypeLabel = new System.Windows.Forms.Label();
            dateBirthLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(7, 252);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // allergiesLabel
            // 
            allergiesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            allergiesLabel.AutoSize = true;
            allergiesLabel.Location = new System.Drawing.Point(6, 327);
            allergiesLabel.Name = "allergiesLabel";
            allergiesLabel.Size = new System.Drawing.Size(49, 13);
            allergiesLabel.TabIndex = 2;
            allergiesLabel.Text = "Allergies:";
            // 
            // bloodTypeLabel
            // 
            bloodTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            bloodTypeLabel.AutoSize = true;
            bloodTypeLabel.Location = new System.Drawing.Point(18, 98);
            bloodTypeLabel.Name = "bloodTypeLabel";
            bloodTypeLabel.Size = new System.Drawing.Size(37, 26);
            bloodTypeLabel.TabIndex = 4;
            bloodTypeLabel.Text = "Blood Type:";
            // 
            // dateBirthLabel
            // 
            dateBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dateBirthLabel.AutoSize = true;
            dateBirthLabel.Location = new System.Drawing.Point(22, 172);
            dateBirthLabel.Name = "dateBirthLabel";
            dateBirthLabel.Size = new System.Drawing.Size(33, 26);
            dateBirthLabel.TabIndex = 6;
            dateBirthLabel.Text = "Date Birth:";
            // 
            // fotoLabel
            // 
            fotoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(3, 286);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(254, 13);
            fotoLabel.TabIndex = 8;
            fotoLabel.Text = "Foto:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(61, 249);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(170, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.allergiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "Allergies", true));
            this.allergiesTextBox.Location = new System.Drawing.Point(61, 323);
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(170, 20);
            this.allergiesTextBox.TabIndex = 3;
            // 
            // bloodTypeTextBox
            // 
            this.bloodTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bloodTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "BloodType", true));
            this.bloodTypeTextBox.Location = new System.Drawing.Point(61, 101);
            this.bloodTypeTextBox.Name = "bloodTypeTextBox";
            this.bloodTypeTextBox.Size = new System.Drawing.Size(170, 20);
            this.bloodTypeTextBox.TabIndex = 5;
            // 
            // dateBirthDateTimePicker
            // 
            this.dateBirthDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource1, "DateBirth", true));
            this.dateBirthDateTimePicker.Location = new System.Drawing.Point(61, 175);
            this.dateBirthDateTimePicker.Name = "dateBirthDateTimePicker";
            this.dateBirthDateTimePicker.Size = new System.Drawing.Size(170, 20);
            this.dateBirthDateTimePicker.TabIndex = 7;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.patientBindingSource1, "Foto", true));
            this.fotoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(254, 265);
            this.fotoPictureBox.TabIndex = 9;
            this.fotoPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(61, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(498, 371);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fotoPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(fotoLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.addressTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(allergiesLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.allergiesTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateBirthDateTimePicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(addressLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(dateBirthLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(nameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bloodTypeTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(bloodTypeLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 371);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_ok, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_cancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 50);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_ok.Location = new System.Drawing.Point(3, 3);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(121, 44);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cancel.Location = new System.Drawing.Point(130, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(121, 44);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataSource = typeof(lab7.Patient);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 371);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPatient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.TextBox bloodTypeTextBox;
        private System.Windows.Forms.DateTimePicker dateBirthDateTimePicker;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.BindingSource patientBindingSource1;
    }
}