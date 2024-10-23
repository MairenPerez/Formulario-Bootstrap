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
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.checkProd = new System.Windows.Forms.CheckBox();
            this.checkPrepod = new System.Windows.Forms.CheckBox();
            this.checkDemo = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(287, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(330, 13);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // combType
            // 
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "Incident"});
            this.combType.Location = new System.Drawing.Point(13, 97);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(160, 24);
            this.combType.TabIndex = 6;
            this.combType.Text = "Incident";
            // 
            // lblCriticity
            // 
            this.lblCriticity.AutoSize = true;
            this.lblCriticity.Location = new System.Drawing.Point(203, 78);
            this.lblCriticity.Name = "lblCriticity";
            this.lblCriticity.Size = new System.Drawing.Size(49, 16);
            this.lblCriticity.TabIndex = 7;
            this.lblCriticity.Text = "Criticity";
            // 
            // comboCriticity
            // 
            this.comboCriticity.FormattingEnabled = true;
            this.comboCriticity.Location = new System.Drawing.Point(206, 97);
            this.comboCriticity.Name = "comboCriticity";
            this.comboCriticity.Size = new System.Drawing.Size(168, 24);
            this.comboCriticity.TabIndex = 8;
            this.comboCriticity.Text = "Minor";
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Location = new System.Drawing.Point(413, 78);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(81, 16);
            this.lblEnvironment.TabIndex = 9;
            this.lblEnvironment.Text = "Environment";
            // 
            // checkProd
            // 
            this.checkProd.AutoSize = true;
            this.checkProd.Location = new System.Drawing.Point(416, 100);
            this.checkProd.Name = "checkProd";
            this.checkProd.Size = new System.Drawing.Size(58, 20);
            this.checkProd.TabIndex = 10;
            this.checkProd.Text = "Prod";
            this.checkProd.UseVisualStyleBackColor = true;
            // 
            // checkPrepod
            // 
            this.checkPrepod.AutoSize = true;
            this.checkPrepod.Location = new System.Drawing.Point(416, 127);
            this.checkPrepod.Name = "checkPrepod";
            this.checkPrepod.Size = new System.Drawing.Size(74, 20);
            this.checkPrepod.TabIndex = 11;
            this.checkPrepod.Text = "Prepod";
            this.checkPrepod.UseVisualStyleBackColor = true;
            // 
            // checkDemo
            // 
            this.checkDemo.AutoSize = true;
            this.checkDemo.Location = new System.Drawing.Point(416, 154);
            this.checkDemo.Name = "checkDemo";
            this.checkDemo.Size = new System.Drawing.Size(66, 20);
            this.checkDemo.TabIndex = 12;
            this.checkDemo.Text = "Demo";
            this.checkDemo.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 209);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(545, 128);
            this.txtDescription.TabIndex = 14;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 356);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(66, 16);
            this.lblStartDate.TabIndex = 15;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 375);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(288, 22);
            this.dtpStartDate.TabIndex = 16;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(319, 356);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(114, 16);
            this.lblDuration.TabIndex = 17;
            this.lblDuration.Text = "Duration (in hours)";
            // 
            // numDuration
            // 
            this.numDuration.DecimalPlaces = 2;
            this.numDuration.Location = new System.Drawing.Point(322, 375);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(235, 22);
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
            this.lblStatus.Location = new System.Drawing.Point(12, 425);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(12, 445);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(288, 24);
            this.comboStatus.TabIndex = 20;
            this.comboStatus.Text = "Planned";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(322, 425);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(114, 16);
            this.lblPercent.TabIndex = 21;
            this.lblPercent.Text = "Percent Complete";
            // 
            // comboPercent
            // 
            this.comboPercent.FormattingEnabled = true;
            this.comboPercent.Location = new System.Drawing.Point(322, 445);
            this.comboPercent.Name = "comboPercent";
            this.comboPercent.Size = new System.Drawing.Size(235, 24);
            this.comboPercent.TabIndex = 22;
            this.comboPercent.Text = "0%";
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(13, 497);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(262, 20);
            this.checkEmail.TabIndex = 23;
            this.checkEmail.Text = "Check here if you want to send an email";
            this.checkEmail.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(361, 589);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 24;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(479, 589);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(75, 23);
            this.butSubmit.TabIndex = 25;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 624);
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
            this.Controls.Add(this.checkDemo);
            this.Controls.Add(this.checkPrepod);
            this.Controls.Add(this.checkProd);
            this.Controls.Add(this.lblEnvironment);
            this.Controls.Add(this.comboCriticity);
            this.Controls.Add(this.lblCriticity);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPrincipal";
            this.Text = "Create new task";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.CheckBox checkProd;
        private System.Windows.Forms.CheckBox checkPrepod;
        private System.Windows.Forms.CheckBox checkDemo;
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
    }
}

