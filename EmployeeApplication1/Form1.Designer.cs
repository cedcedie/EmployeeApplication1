namespace EmployeeApplication1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lastName = new Label();
            firstName = new Label();
            department = new Label();
            job = new Label();
            ratePerHour = new Label();
            totalHours = new Label();
            salary = new Label();
            outputName = new Label();
            lastNameOutput = new Label();
            salaryOutput = new Label();
            compute = new Button();
            label1 = new Label();
            label2 = new Label();
            firstNametxt = new TextBox();
            departmenttxt = new TextBox();
            jobTitletxt = new TextBox();
            lastNametxt = new TextBox();
            ratePerHourtxt = new TextBox();
            totalHoursWorkedtxt = new TextBox();
            SuspendLayout();
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(313, 43);
            lastName.Name = "lastName";
            lastName.Size = new Size(63, 15);
            lastName.TabIndex = 0;
            lastName.Text = "Last Name";
            lastName.Click += lastName_Click;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(56, 43);
            firstName.Name = "firstName";
            firstName.Size = new Size(64, 15);
            firstName.TabIndex = 0;
            firstName.Text = "First Name";
            // 
            // department
            // 
            department.AutoSize = true;
            department.Location = new Point(56, 119);
            department.Name = "department";
            department.Size = new Size(70, 15);
            department.TabIndex = 0;
            department.Text = "Department";
            // 
            // job
            // 
            job.AutoSize = true;
            job.Location = new Point(313, 119);
            job.Name = "job";
            job.Size = new Size(50, 15);
            job.TabIndex = 0;
            job.Text = "Job Title";
            // 
            // ratePerHour
            // 
            ratePerHour.AutoSize = true;
            ratePerHour.Location = new Point(56, 195);
            ratePerHour.Name = "ratePerHour";
            ratePerHour.Size = new Size(80, 15);
            ratePerHour.TabIndex = 0;
            ratePerHour.Text = "Rate Per Hour";
            // 
            // totalHours
            // 
            totalHours.AutoSize = true;
            totalHours.Location = new Point(313, 195);
            totalHours.Name = "totalHours";
            totalHours.Size = new Size(111, 15);
            totalHours.TabIndex = 0;
            totalHours.Text = "Total Hours Worked";
            // 
            // salary
            // 
            salary.AutoSize = true;
            salary.Location = new Point(46, 402);
            salary.Name = "salary";
            salary.Size = new Size(68, 15);
            salary.TabIndex = 0;
            salary.Text = "Basic Salary";
            // 
            // outputName
            // 
            outputName.AutoSize = true;
            outputName.Location = new Point(139, 319);
            outputName.Name = "outputName";
            outputName.Size = new Size(38, 15);
            outputName.TabIndex = 0;
            outputName.Text = "label1";
            // 
            // lastNameOutput
            // 
            lastNameOutput.AutoSize = true;
            lastNameOutput.Location = new Point(139, 363);
            lastNameOutput.Name = "lastNameOutput";
            lastNameOutput.Size = new Size(38, 15);
            lastNameOutput.TabIndex = 0;
            lastNameOutput.Text = "label1";
            // 
            // salaryOutput
            // 
            salaryOutput.AutoSize = true;
            salaryOutput.Location = new Point(139, 402);
            salaryOutput.Name = "salaryOutput";
            salaryOutput.Size = new Size(38, 15);
            salaryOutput.TabIndex = 0;
            salaryOutput.Text = "label1";
            // 
            // compute
            // 
            compute.Location = new Point(182, 276);
            compute.Name = "compute";
            compute.Size = new Size(123, 23);
            compute.TabIndex = 1;
            compute.Text = "Compute Salary";
            compute.UseVisualStyleBackColor = true;
            compute.Click += compute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 319);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 363);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            label2.Click += lastName_Click;
            // 
            // firstNametxt
            // 
            firstNametxt.BorderStyle = BorderStyle.FixedSingle;
            firstNametxt.Location = new Point(56, 77);
            firstNametxt.Name = "firstNametxt";
            firstNametxt.Size = new Size(129, 23);
            firstNametxt.TabIndex = 2;
            // 
            // departmenttxt
            // 
            departmenttxt.BorderStyle = BorderStyle.FixedSingle;
            departmenttxt.Location = new Point(56, 153);
            departmenttxt.Name = "departmenttxt";
            departmenttxt.Size = new Size(121, 23);
            departmenttxt.TabIndex = 2;
            // 
            // jobTitletxt
            // 
            jobTitletxt.BorderStyle = BorderStyle.FixedSingle;
            jobTitletxt.Location = new Point(313, 153);
            jobTitletxt.Name = "jobTitletxt";
            jobTitletxt.Size = new Size(111, 23);
            jobTitletxt.TabIndex = 2;
            // 
            // lastNametxt
            // 
            lastNametxt.BorderStyle = BorderStyle.FixedSingle;
            lastNametxt.Location = new Point(313, 77);
            lastNametxt.Name = "lastNametxt";
            lastNametxt.Size = new Size(111, 23);
            lastNametxt.TabIndex = 2;
            // 
            // ratePerHourtxt
            // 
            ratePerHourtxt.BorderStyle = BorderStyle.FixedSingle;
            ratePerHourtxt.Location = new Point(56, 229);
            ratePerHourtxt.Name = "ratePerHourtxt";
            ratePerHourtxt.Size = new Size(121, 23);
            ratePerHourtxt.TabIndex = 2;
            // 
            // totalHoursWorkedtxt
            // 
            totalHoursWorkedtxt.BorderStyle = BorderStyle.FixedSingle;
            totalHoursWorkedtxt.Location = new Point(313, 229);
            totalHoursWorkedtxt.Name = "totalHoursWorkedtxt";
            totalHoursWorkedtxt.Size = new Size(111, 23);
            totalHoursWorkedtxt.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(totalHoursWorkedtxt);
            Controls.Add(ratePerHourtxt);
            Controls.Add(lastNametxt);
            Controls.Add(jobTitletxt);
            Controls.Add(departmenttxt);
            Controls.Add(firstNametxt);
            Controls.Add(compute);
            Controls.Add(label1);
            Controls.Add(firstName);
            Controls.Add(salaryOutput);
            Controls.Add(lastNameOutput);
            Controls.Add(outputName);
            Controls.Add(salary);
            Controls.Add(totalHours);
            Controls.Add(ratePerHour);
            Controls.Add(job);
            Controls.Add(department);
            Controls.Add(label2);
            Controls.Add(lastName);
            Name = "Form1";
            Text = "frmComputeSalary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lastName;
        private Label firstName;
        private Label department;
        private Label job;
        private Label ratePerHour;
        private Label totalHours;
        private Label salary;
        private Label outputName;
        private Label lastNameOutput;
        private Label salaryOutput;
        private Button compute;
        private Label label1;
        private Label label2;
        private TextBox firstNametxt;
        private TextBox departmenttxt;
        private TextBox jobTitletxt;
        private TextBox lastNametxt;
        private TextBox ratePerHourtxt;
        private TextBox totalHoursWorkedtxt;
    }
}
