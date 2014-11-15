namespace Calendar.Dialog
{
	partial class NewAppointment
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
			this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lblValidation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(113, 157);
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
			this.btnCancel.Location = new System.Drawing.Point(207, 157);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// dtpDateStart
			// 
			this.dtpDateStart.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateStart.Location = new System.Drawing.Point(83, 66);
			this.dtpDateStart.Name = "dtpDateStart";
			this.dtpDateStart.Size = new System.Drawing.Size(200, 20);
			this.dtpDateStart.TabIndex = 2;
			this.dtpDateStart.Value = new System.DateTime(2011, 4, 27, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "End date:";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(13, 26);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(63, 23);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Title:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Start date:";
			// 
			// dtpDateEnd
			// 
			this.dtpDateEnd.CustomFormat = "MM/dd/yyyy HH:mm";
			this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateEnd.Location = new System.Drawing.Point(83, 109);
			this.dtpDateEnd.Name = "dtpDateEnd";
			this.dtpDateEnd.Size = new System.Drawing.Size(200, 20);
			this.dtpDateEnd.TabIndex = 6;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(83, 26);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(199, 20);
			this.txtTitle.TabIndex = 8;
			// 
			// lblValidation
			// 
			this.lblValidation.ForeColor = System.Drawing.Color.Red;
			this.lblValidation.Location = new System.Drawing.Point(82, 131);
			this.lblValidation.Name = "lblValidation";
			this.lblValidation.Size = new System.Drawing.Size(222, 23);
			this.lblValidation.TabIndex = 10;
			// 
			// NewAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 205);
			this.Controls.Add(this.lblValidation);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpDateEnd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.dtpDateStart);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "NewAppointment";
			this.Text = "New appointment";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblValidation;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.DateTimePicker dtpDateEnd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DateTimePicker dtpDateStart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
	}
}
