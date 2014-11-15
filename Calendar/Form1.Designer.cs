using Syd.ScheduleControls;
namespace Calendar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dayView1 = new Syd.ScheduleControls.DayScheduleControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dayView2 = new Syd.ScheduleControls.DayScheduleControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.weekView1 = new Syd.ScheduleControls.WeekScheduleControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.monthView1 = new Syd.ScheduleControls.MonthScheduleControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(318, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 757);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dayView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(967, 728);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1 day";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dayView1
            // 
            this.dayView1.Date = new System.DateTime(((long)(0)));
            this.dayView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayView1.Location = new System.Drawing.Point(4, 4);
            this.dayView1.Margin = new System.Windows.Forms.Padding(4);
            this.dayView1.MinimumSize = new System.Drawing.Size(400, 369);
            this.dayView1.Name = "dayView1";
            this.dayView1.RenderWorkingHoursOnly = true;
            this.dayView1.SingleDay = true;
            this.dayView1.Size = new System.Drawing.Size(959, 720);
            this.dayView1.TabIndex = 1;
            this.dayView1.WorkEndHour = 20;
            this.dayView1.WorkStartHour = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dayView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(967, 728);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "5 day";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dayView2
            // 
            this.dayView2.Date = new System.DateTime(((long)(0)));
            this.dayView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayView2.Location = new System.Drawing.Point(4, 4);
            this.dayView2.Margin = new System.Windows.Forms.Padding(4);
            this.dayView2.MinimumSize = new System.Drawing.Size(400, 369);
            this.dayView2.Name = "dayView2";
            this.dayView2.RenderWorkingHoursOnly = true;
            this.dayView2.SingleDay = false;
            this.dayView2.Size = new System.Drawing.Size(959, 720);
            this.dayView2.TabIndex = 2;
            this.dayView2.WorkEndHour = 20;
            this.dayView2.WorkStartHour = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.weekView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(967, 728);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Week";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // weekView1
            // 
            this.weekView1.Date = new System.DateTime(2010, 10, 25, 19, 4, 39, 0);
            this.weekView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekView1.Location = new System.Drawing.Point(4, 4);
            this.weekView1.Margin = new System.Windows.Forms.Padding(4);
            this.weekView1.Name = "weekView1";
            this.weekView1.Size = new System.Drawing.Size(959, 720);
            this.weekView1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.monthView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(967, 728);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Month";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // monthView1
            // 
            this.monthView1.Date = new System.DateTime(2010, 11, 4, 17, 49, 16, 315);
            this.monthView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthView1.Location = new System.Drawing.Point(4, 4);
            this.monthView1.Margin = new System.Windows.Forms.Padding(4);
            this.monthView1.MinimumSize = new System.Drawing.Size(400, 369);
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(959, 720);
            this.monthView1.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(658, 356);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "test";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(658, 356);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "test 2";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(658, 356);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(658, 356);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(658, 356);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 5);
            this.monthCalendar1.Location = new System.Drawing.Point(9, 5);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1DateSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 763);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calendar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weekView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthView1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.MonthCalendar monthCalendar1;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private WeekScheduleControl weekView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MonthScheduleControl monthView1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private DayScheduleControl dayView1;
        private System.Windows.Forms.TabPage tabPage4;
        private DayScheduleControl dayView2;


    }
}

