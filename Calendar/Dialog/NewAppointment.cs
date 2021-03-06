﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar.Dialog
{
	/// <summary>
	/// Dialog for adding a new appointment.
	/// </summary>
	public partial class NewAppointment : Form
	{
		public NewAppointment()
		{
			InitializeComponent();
            this.txtTitle.Select();
		}

        /// <summary>
        /// Gets or sets the appointment title.
        /// </summary>
        /// <value>
        /// The appointment title.
        /// </value>
		public string AppointmentTitle {get{return this.txtTitle.Text;}set{this.txtTitle.Text=value;}}
        /// <summary>
        /// Gets or sets the appointment date end.
        /// </summary>
        /// <value>
        /// The appointment date end.
        /// </value>
		public DateTime AppointmentDateEnd {get{return this.dtpDateEnd.Value;}set{this.dtpDateEnd.Value=value;}}
        /// <summary>
        /// Gets or sets the appointment date start.
        /// </summary>
        /// <value>
        /// The appointment date start.
        /// </value>
		public DateTime AppointmentDateStart {get{return this.dtpDateStart.Value;}set{this.dtpDateStart.Value=value;}}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTitle.Text))
			{
				lblValidation.Text="Please enter a title.";
			}
			else if (dtpDateStart.Value >= dtpDateEnd.Value)
			{
				lblValidation.Text="End date must be after the start date.";
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		
		void DtpDateStartValueChanged(object sender, EventArgs e)
		{
			if (dtpDateEnd.Value <= dtpDateStart.Value)
			{
				dtpDateEnd.Value = dtpDateStart.Value.AddMinutes(15);
			}
		}
	}
}
