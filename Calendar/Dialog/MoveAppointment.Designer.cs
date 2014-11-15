namespace Calendar.Dialog
{
	partial class MoveAppointment
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpOldDate = new System.Windows.Forms.DateTimePicker();
			this.lblValidation = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(113, 204);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
            this.AcceptButton = this.btnSave; // SCA
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(207, 204);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(13, 26);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(63, 23);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Title:";
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(82, 26);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(200, 23);
			this.lblTitle.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Old date:";
			// 
			// dtpOldDate
			// 
			this.dtpOldDate.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dtpOldDate.Enabled = false;
			this.dtpOldDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpOldDate.Location = new System.Drawing.Point(82, 65);
			this.dtpOldDate.Name = "dtpOldDate";
			this.dtpOldDate.Size = new System.Drawing.Size(200, 20);
			this.dtpOldDate.TabIndex = 6;
			// 
			// lblValidation
			// 
			this.lblValidation.ForeColor = System.Drawing.Color.Red;
			this.lblValidation.Location = new System.Drawing.Point(81, 172);
			this.lblValidation.Name = "lblValidation";
			this.lblValidation.Size = new System.Drawing.Size(222, 23);
			this.lblValidation.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Start date:";
			// 
			// dtpDateEnd
			// 
			this.dtpDateEnd.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateEnd.Location = new System.Drawing.Point(82, 150);
			this.dtpDateEnd.Name = "dtpDateEnd";
			this.dtpDateEnd.Size = new System.Drawing.Size(200, 20);
			this.dtpDateEnd.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "End date:";
			// 
			// dtpDateStart
			// 
			this.dtpDateStart.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateStart.Location = new System.Drawing.Point(82, 107);
			this.dtpDateStart.Name = "dtpDateStart";
			this.dtpDateStart.Size = new System.Drawing.Size(200, 20);
			this.dtpDateStart.TabIndex = 10;
			this.dtpDateStart.Value = new System.DateTime(2011, 4, 27, 0, 0, 0, 0);
			// 
			// MoveAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 250);
			this.Controls.Add(this.lblValidation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpDateEnd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpDateStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpOldDate);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "MoveAppointment";
			this.Text = "Move appointment";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.DateTimePicker dtpOldDate;
		private System.Windows.Forms.DateTimePicker dtpDateStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpDateEnd;
		private System.Windows.Forms.Label lblValidation;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
	}
}
