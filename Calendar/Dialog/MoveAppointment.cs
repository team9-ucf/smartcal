using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar.Dialog
{
    /// <summary>
    /// The dialog shown when an appointment is moved.
    /// </summary>
	public partial class MoveAppointment : Form
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveAppointment"/> class.
        /// </summary>
		public MoveAppointment()
		{
			InitializeComponent();
	}

        /// <summary>
        /// Gets or sets the appointment title.
        /// </summary>
        /// <value>
        /// The appointment title.
        /// </value>
		public string AppointmentTitle {get{return this.lblTitle.Text;}set{this.lblTitle.Text=value;}}
        /// <summary>
        /// Gets or sets the old appointment date start.
        /// </summary>
        /// <value>
        /// The old appointment date start.
        /// </value>
		public DateTime AppointmentOldDateStart {get{return this.dtpOldDate.Value;}set{this.dtpOldDate.Value=value;}}
        /// <summary>
        /// Gets or sets the old appointment date end.
        /// </summary>
        /// <value>
        /// The old appointment date end.
        /// </value>
		public DateTime AppointmentOldDateEnd {get;set;}
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

        /// <summary>
        /// Save button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (dtpDateStart.Value >= dtpDateEnd.Value)
			{
				lblValidation.Text="End date must be after the start date.";
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

        /// <summary>
        /// Cancel button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

	}
}