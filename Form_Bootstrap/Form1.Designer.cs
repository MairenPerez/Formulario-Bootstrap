using System;
using System.Windows.Forms;

namespace Form_Bootstrap
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combType = new System.Windows.Forms.ComboBox();
            this.lblCriticity = new System.Windows.Forms.Label();
            this.comboCriticity = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.comboPercent = new System.Windows.Forms.ComboBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmit = new System.Windows.Forms.Button();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.checkProd = new System.Windows.Forms.CheckBox();
            this.checkPreppod = new System.Windows.Forms.CheckBox();
            this.checkDemo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(15, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(322, 25);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(371, 17);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(68, 20);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 98);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Barcelona",
            "Madrid",
            "Sabadell",
            "Girona ",
            "Zaragoza",
            "Zamora",
            "Pamplona",
            "Málaga"});
            this.comboBox1.Location = new System.Drawing.Point(375, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combType
            // 
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "Incident",
            "Consulta",
            "Sugerencia"});
            this.combType.Location = new System.Drawing.Point(15, 121);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(180, 28);
            this.combType.TabIndex = 6;
            this.combType.Text = "Incident";
            // 
            // lblCriticity
            // 
            this.lblCriticity.AutoSize = true;
            this.lblCriticity.Location = new System.Drawing.Point(228, 98);
            this.lblCriticity.Name = "lblCriticity";
            this.lblCriticity.Size = new System.Drawing.Size(64, 20);
            this.lblCriticity.TabIndex = 7;
            this.lblCriticity.Text = "Criticity";
            // 
            // comboCriticity
            // 
            this.comboCriticity.FormattingEnabled = true;
            this.comboCriticity.Location = new System.Drawing.Point(232, 121);
            this.comboCriticity.Name = "comboCriticity";
            this.comboCriticity.Size = new System.Drawing.Size(188, 28);
            this.comboCriticity.TabIndex = 8;
            this.comboCriticity.Text = "Minor";
            this.comboCriticity.SelectedIndexChanged += new System.EventHandler(this.comboCriticity_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 234);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 258);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(613, 148);
            this.txtDescription.TabIndex = 14;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 423);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(81, 20);
            this.lblStartDate.TabIndex = 15;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = false;
            this.dtpStartDate.Location = new System.Drawing.Point(10, 446);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(327, 25);
            this.dtpStartDate.TabIndex = 16;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(356, 423);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(142, 20);
            this.lblDuration.TabIndex = 17;
            this.lblDuration.Text = "Duration (in hours)";
            // 
            // numDuration
            // 
            this.numDuration.DecimalPlaces = 2;
            this.numDuration.Location = new System.Drawing.Point(359, 446);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(264, 25);
            this.numDuration.TabIndex = 18;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 509);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(10, 534);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(324, 28);
            this.comboStatus.TabIndex = 20;
            this.comboStatus.Text = "Planned";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(359, 509);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(136, 20);
            this.lblPercent.TabIndex = 21;
            this.lblPercent.Text = "Percent Complete";
            // 
            // comboPercent
            // 
            this.comboPercent.FormattingEnabled = true;
            this.comboPercent.Location = new System.Drawing.Point(359, 534);
            this.comboPercent.Name = "comboPercent";
            this.comboPercent.Size = new System.Drawing.Size(264, 28);
            this.comboPercent.TabIndex = 22;
            this.comboPercent.Text = "0%";
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(11, 599);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(319, 24);
            this.checkEmail.TabIndex = 23;
            this.checkEmail.Text = "Check here if you want to send an email";
            this.checkEmail.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(423, 697);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(94, 41);
            this.butCancel.TabIndex = 24;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSubmit
            // 
            this.butSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butSubmit.Location = new System.Drawing.Point(524, 697);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(98, 41);
            this.butSubmit.TabIndex = 25;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Location = new System.Drawing.Point(465, 98);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(100, 20);
            this.lblEnvironment.TabIndex = 9;
            this.lblEnvironment.Text = "Environment";
            // 
            // checkProd
            // 
            this.checkProd.AutoSize = true;
            this.checkProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.checkProd.Location = new System.Drawing.Point(469, 124);
            this.checkProd.Name = "checkProd";
            this.checkProd.Size = new System.Drawing.Size(63, 24);
            this.checkProd.TabIndex = 26;
            this.checkProd.Text = "Prod";
            this.checkProd.UseVisualStyleBackColor = true;
            // 
            // checkPreppod
            // 
            this.checkPreppod.AutoSize = true;
            this.checkPreppod.Location = new System.Drawing.Point(469, 160);
            this.checkPreppod.Name = "checkPreppod";
            this.checkPreppod.Size = new System.Drawing.Size(81, 24);
            this.checkPreppod.TabIndex = 27;
            this.checkPreppod.Text = "Prepod";
            this.checkPreppod.UseVisualStyleBackColor = true;
            // 
            // checkDemo
            // 
            this.checkDemo.AutoSize = true;
            this.checkDemo.Location = new System.Drawing.Point(469, 196);
            this.checkDemo.Name = "checkDemo";
            this.checkDemo.Size = new System.Drawing.Size(71, 24);
            this.checkDemo.TabIndex = 28;
            this.checkDemo.Text = "Demo";
            this.checkDemo.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(634, 759);
            this.Controls.Add(this.checkDemo);
            this.Controls.Add(this.checkPreppod);
            this.Controls.Add(this.checkProd);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.comboPercent);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEnvironment);
            this.Controls.Add(this.comboCriticity);
            this.Controls.Add(this.lblCriticity);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Create new task";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example implementation
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                string selectedItem = comboBox.SelectedItem.ToString();
            }
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label lblCriticity;
        private System.Windows.Forms.ComboBox comboCriticity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ComboBox comboPercent;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.CheckBox checkProd;
        private System.Windows.Forms.CheckBox checkPreppod;
        private System.Windows.Forms.CheckBox checkDemo;
    }
}

