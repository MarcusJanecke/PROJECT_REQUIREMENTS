namespace TicketApplicationSystem
{
    partial class TicketForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Form properties
            this.Text = "Ticket Application System";
            this.Size = new System.Drawing.Size(600, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.LightGray;

            // Title Label
            System.Windows.Forms.Label lblTitle = new System.Windows.Forms.Label();
            lblTitle.Text = "TICKET CALCULATION SYSTEM";
            lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(75, 20);
            lblTitle.Size = new System.Drawing.Size(450, 30);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Passenger Name Label
            System.Windows.Forms.Label lblName = new System.Windows.Forms.Label();
            lblName.Text = "Passenger Name:";
            lblName.Location = new System.Drawing.Point(30, 70);
            lblName.Size = new System.Drawing.Size(120, 25);
            lblName.Font = new System.Drawing.Font("Arial", 10);

            // Passenger Name TextBox
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtPassengerName.Location = new System.Drawing.Point(160, 70);
            this.txtPassengerName.Size = new System.Drawing.Size(380, 25);
            this.txtPassengerName.Font = new System.Drawing.Font("Arial", 10);

            // Gender Label
            System.Windows.Forms.Label lblGender = new System.Windows.Forms.Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new System.Drawing.Point(30, 110);
            lblGender.Size = new System.Drawing.Size(120, 25);
            lblGender.Font = new System.Drawing.Font("Arial", 10);

            // Male RadioButton
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbMale.Text = "Male";
            this.rbMale.Location = new System.Drawing.Point(160, 110);
            this.rbMale.Size = new System.Drawing.Size(100, 25);
            this.rbMale.Font = new System.Drawing.Font("Arial", 10);
            this.rbMale.Checked = true;

            // Female RadioButton
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbFemale.Text = "Female";
            this.rbFemale.Location = new System.Drawing.Point(270, 110);
            this.rbFemale.Size = new System.Drawing.Size(100, 25);
            this.rbFemale.Font = new System.Drawing.Font("Arial", 10);

            // Age Label
            System.Windows.Forms.Label lblAge = new System.Windows.Forms.Label();
            lblAge.Text = "Age:";
            lblAge.Location = new System.Drawing.Point(30, 150);
            lblAge.Size = new System.Drawing.Size(120, 25);
            lblAge.Font = new System.Drawing.Font("Arial", 10);

            // Age TextBox
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAge.Location = new System.Drawing.Point(160, 150);
            this.txtAge.Size = new System.Drawing.Size(380, 25);
            this.txtAge.Font = new System.Drawing.Font("Arial", 10);

            // Category Label
            System.Windows.Forms.Label lblCategory = new System.Windows.Forms.Label();
            lblCategory.Text = "Travel Category:";
            lblCategory.Location = new System.Drawing.Point(30, 190);
            lblCategory.Size = new System.Drawing.Size(120, 25);
            lblCategory.Font = new System.Drawing.Font("Arial", 10);

            // Category ComboBox
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbCategory.Location = new System.Drawing.Point(160, 190);
            this.cmbCategory.Size = new System.Drawing.Size(380, 25);
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 10);
            this.cmbCategory.Items.AddRange(new object[] { "Category One", "Category Two", "Category Three" });
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Distance Label
            System.Windows.Forms.Label lblDistance = new System.Windows.Forms.Label();
            lblDistance.Text = "Distance (km):";
            lblDistance.Location = new System.Drawing.Point(30, 230);
            lblDistance.Size = new System.Drawing.Size(120, 25);
            lblDistance.Font = new System.Drawing.Font("Arial", 10);

            // Distance TextBox
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtDistance.Location = new System.Drawing.Point(160, 230);
            this.txtDistance.Size = new System.Drawing.Size(380, 25);
            this.txtDistance.Font = new System.Drawing.Font("Arial", 10);

            // Calculate Button
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculate.Text = "Calculate Ticket Price";
            this.btnCalculate.Location = new System.Drawing.Point(30, 280);
            this.btnCalculate.Size = new System.Drawing.Size(150, 35);
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);

            // Clear Button
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClear.Text = "Clear Form";
            this.btnClear.Location = new System.Drawing.Point(220, 280);
            this.btnClear.Size = new System.Drawing.Size(150, 35);
            this.btnClear.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            // Exit Button
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExit.Text = "Exit Application";
            this.btnExit.Location = new System.Drawing.Point(410, 280);
            this.btnExit.Size = new System.Drawing.Size(150, 35);
            this.btnExit.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // Summary Panel
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.pnlSummary.Location = new System.Drawing.Point(30, 340);
            this.pnlSummary.Size = new System.Drawing.Size(530, 300);
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.BackColor = System.Drawing.Color.White;

            // Summary Title
            System.Windows.Forms.Label lblSummaryTitle = new System.Windows.Forms.Label();
            lblSummaryTitle.Text = "TICKET SUMMARY";
            lblSummaryTitle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            lblSummaryTitle.Location = new System.Drawing.Point(10, 10);
            lblSummaryTitle.Size = new System.Drawing.Size(500, 25);
            lblSummaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Summary Label
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSummary.Text = "No ticket calculated yet.";
            this.lblSummary.Location = new System.Drawing.Point(10, 45);
            this.lblSummary.Size = new System.Drawing.Size(500, 240);
            this.lblSummary.Font = new System.Drawing.Font("Arial", 10);
            this.lblSummary.AutoSize = false;

            // Add controls to panel
            this.pnlSummary.Controls.Add(lblSummaryTitle);
            this.pnlSummary.Controls.Add(this.lblSummary);

            // Add all controls to form
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(lblGender);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlSummary);
        }

        // Form Controls
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummary;
    }
}
