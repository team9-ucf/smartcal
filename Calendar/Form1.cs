using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Syd.ScheduleControls.Data;
using Syd.ScheduleControls.Region;
using Syd.ScheduleControls.Events;
using Calendar.Dialog;

namespace Calendar
{
    /// <summary>
    /// Form1
    /// </summary>
    public partial class Form1 : Form
    {
        AppointmentList appts = new AppointmentList();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        /// <summary>
        /// Create appointment
        /// </summary>
        /// <param name="startDate">Start dat and time of appointment</param>
        /// <param name="endDate">End date and time of appointment</param>
        /// <param name="title">Appointment title</param>
        /// <returns></returns>
        private Appointment CreateAppointment(DateTime startDate, DateTime endDate, string title)
        {
            List<Brush> brushes = new List<Brush>();
            brushes.Add(Brushes.LimeGreen);
            brushes.Add(Brushes.PowderBlue);
            brushes.Add(Brushes.DarkGreen);
            brushes.Add(Brushes.Green);
            brushes.Add(Brushes.DimGray);
            brushes.Add(Brushes.Red);
            brushes.Add(Brushes.Yellow);
            brushes.Add(Brushes.Aquamarine);
            brushes.Add(Brushes.Plum);
            brushes.Add(Brushes.Orange);
            brushes.Add(Brushes.Pink);

            DateTime timeStart = DateTime.Now;
            var rand = new Random();
            Brush brush = brushes[rand.Next(0, 10)];

            ExtendedAppointment app = new ExtendedAppointment();
            app.ColorBlockBrush = brush;
            app.Subject = title;
            app.DateStart = startDate;
            app.DateEnd = endDate;

            return app;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DoubleBuffered = true;

            try
            {
                if (!File.Exists("appointments.txt"))
                {
                    using (StreamWriter sw = File.CreateText("appointments.txt"))
                    {
                        sw.Close();
                    }
                }
                else if (File.Exists("appointments.txt"))
                {
                    using (StreamReader sr = File.OpenText("appointments.txt"))
                    {
                        string s = "";

                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] str = s.Split('|');
                            DateTime startDate = DateTime.Parse(str[0]);
                            DateTime endDate = DateTime.Parse(str[1]);
                            appts.Add(CreateAppointment(startDate, endDate, str[2]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DateTime weekstart = DateTime.Now;

            weekView1.Date = weekstart;
            monthView1.Date = weekstart;
            dayView1.Date = weekstart;
            dayView2.Date = weekstart;

            weekView1.AppointmentCreate += calendar_AppointmentAdd;
            monthView1.AppointmentCreate += calendar_AppointmentAdd;
            dayView1.AppointmentCreate += calendar_AppointmentAdd;
            dayView2.AppointmentCreate += calendar_AppointmentAdd;

            weekView1.AppointmentMove += calendar_AppointmentMove;
            monthView1.AppointmentMove += calendar_AppointmentMove;
            dayView1.AppointmentMove += calendar_AppointmentMove;
            dayView2.AppointmentMove += calendar_AppointmentMove;

            weekView1.AppointmentEdit += calendar_AppointmentEdit;
            monthView1.AppointmentEdit += calendar_AppointmentEdit;
            dayView1.AppointmentEdit += calendar_AppointmentEdit;
            dayView2.AppointmentEdit += calendar_AppointmentEdit;

            weekView1.AppointmentDelete += calendar_AppointmentDelete;
            monthView1.AppointmentDelete += calendar_AppointmentDelete;
            dayView1.AppointmentDelete += calendar_AppointmentDelete;
            dayView2.AppointmentDelete += calendar_AppointmentDelete;

            weekView1.Appointments = appts;
            monthView1.Appointments = appts;
            dayView1.Appointments = appts;
            dayView2.Appointments = appts;

            //have to tell the controls to refresh appointment display
            weekView1.RefreshAppointments();
            monthView1.RefreshAppointments();
            dayView1.RefreshAppointments();
            dayView2.RefreshAppointments();

            //get the controls to repaint 
            weekView1.Invalidate();
            monthView1.Invalidate();
            dayView1.Invalidate();
            dayView2.Invalidate();
        }

        /// <summary>
        /// Handles the AppointmentEdit event of the calendar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Syd.ScheduleControls.Events.AppointmentEditEventArgs"/> instance containing the event data.</param>
        private void calendar_AppointmentEdit(object sender, AppointmentEditEventArgs e)
        {
            //show a dialog to edit the appointment
            using (EditAppointment dialog = new EditAppointment())
            {
                dialog.AppointmentDateStart = e.Appointment.DateStart;
                dialog.AppointmentDateEnd = e.Appointment.DateEnd;
                dialog.AppointmentTitle = e.Appointment.Subject;

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //if the user clicked 'save', update the appointment dates and title
                    e.Appointment.DateStart = dialog.AppointmentDateStart;
                    e.Appointment.DateEnd = dialog.AppointmentDateEnd;
                    e.Appointment.Subject = dialog.AppointmentTitle;

                    //have to tell the controls to refresh appointment display
                    weekView1.RefreshAppointments();
                    monthView1.RefreshAppointments();
                    dayView1.RefreshAppointments();
                    dayView2.RefreshAppointments();

                    //get the controls to repaint 
                    weekView1.Invalidate();
                    monthView1.Invalidate();
                    dayView1.Invalidate();
                    dayView2.Invalidate();
                }
            }
        }


        /// <summary>
        /// Handles the AppointmentMove event of the calendar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Syd.ScheduleControls.Events.AppointmentMoveEventArgs"/> instance containing the event data.</param>
        private void calendar_AppointmentMove(object sender, AppointmentMoveEventArgs e)
        {
            //show a dialog to move the appointment date
            using (MoveAppointment dialog = new MoveAppointment())
            {
                dialog.AppointmentOldDateStart = e.Appointment.DateStart;
                dialog.AppointmentOldDateEnd = e.Appointment.DateEnd;
                dialog.AppointmentTitle = e.Appointment.Subject;

                if (e.NewDate != null)
                {
                    dialog.AppointmentDateStart = e.NewDate;
                    dialog.AppointmentDateEnd = new DateTime(e.NewDate.Ticks + (dialog.AppointmentOldDateEnd.Ticks - dialog.AppointmentOldDateStart.Ticks));
                }

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //if the user clicked 'save', update the appointment dates
                    e.Appointment.DateStart = dialog.AppointmentDateStart;
                    e.Appointment.DateEnd = dialog.AppointmentDateEnd;

                    //have to tell the controls to refresh appointment display
                    weekView1.RefreshAppointments();
                    monthView1.RefreshAppointments();
                    dayView1.RefreshAppointments();
                    dayView2.RefreshAppointments();

                    //get the controls to repaint 
                    weekView1.Invalidate();
                    monthView1.Invalidate();
                    dayView1.Invalidate();
                    dayView2.Invalidate();
                }
            }
        }

        /// <summary>
        /// Handles the AppointmentAdd event of the calendar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Syd.ScheduleControls.Events.AppointmentCreateEventArgs"/> instance containing the event data.</param>
        private void calendar_AppointmentAdd(object sender, AppointmentCreateEventArgs e)
        {
            //show a dialog to add an appointment
            using (NewAppointment dialog = new NewAppointment())
            {
                if (e.Date != null)
                {
                    dialog.AppointmentDateStart = e.Date.Value;
                    dialog.AppointmentDateEnd = e.Date.Value.AddMinutes(60);
                }

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    appts.Add(CreateAppointment(dialog.AppointmentDateStart, dialog.AppointmentDateEnd, dialog.AppointmentTitle));

                    using (StreamWriter sw = File.AppendText("appointments.txt"))
                    {
                        string s = dialog.AppointmentDateStart.ToString() +
                       "|" + dialog.AppointmentDateEnd.ToString() +
                       "|" + dialog.AppointmentTitle;
                        sw.WriteLine(s);
                    }

                    weekView1.Appointments = appts;
                    monthView1.Appointments = appts;
                    dayView1.Appointments = appts;
                    dayView2.Appointments = appts;

                    //have to tell the controls to refresh appointment display
                    weekView1.RefreshAppointments();
                    monthView1.RefreshAppointments();
                    dayView1.RefreshAppointments();
                    dayView2.RefreshAppointments();

                    //get the controls to repaint 
                    weekView1.Invalidate();
                    monthView1.Invalidate();
                    dayView1.Invalidate();
                    dayView2.Invalidate();
                }
            }
        }

        /// <summary>
        /// Handles the AppointmentDelete event of the calendar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Syd.ScheduleControls.Events.AppointmentDeleteEventArgs"/> instance containing the event data.</param>
        private void calendar_AppointmentDelete(object sender, AppointmentDeleteEventArgs e)
        {
            DateTime dateToDelete = e.Date.Value;

            Appointment appToDelete = appts.Find(
            delegate(Appointment a)
            {
                return (a.DateEnd >= dateToDelete && a.DateStart <= dateToDelete);
            }
            );

            appts.Remove(appToDelete);

            weekView1.Appointments = appts;
            monthView1.Appointments = appts;
            dayView1.Appointments = appts;
            dayView2.Appointments = appts;

            //have to tell the controls to refresh appointment display
            weekView1.RefreshAppointments();
            monthView1.RefreshAppointments();
            dayView1.RefreshAppointments();
            dayView2.RefreshAppointments();

            //get the controls to repaint 
            weekView1.Invalidate();
            monthView1.Invalidate();
            dayView1.Invalidate();
            dayView2.Invalidate();
        }

        /// <summary>
        /// Handles the DateSelected event of the MonthCalendar1 control.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DateRangeEventArgs"/> instance containing the event data.</param>
        void MonthCalendar1DateSelected(object sender, DateRangeEventArgs e)
        {
            weekView1.Date = e.Start;
            monthView1.Date = e.Start;
            dayView1.Date = e.Start;
            dayView2.Date = e.Start;

            weekView1.Invalidate();
            monthView1.Invalidate();
            dayView1.Invalidate();
            dayView2.Invalidate();
        }
    }
}
