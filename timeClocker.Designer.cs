namespace TimeClocker
{
    partial class formTimeClocker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTimeClocker));
            this.lblTime = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.btnMoney = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblOt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblTime.Location = new System.Drawing.Point(5, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(174, 73);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblDate.Location = new System.Drawing.Point(12, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 36);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.Crimson;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMoney.Location = new System.Drawing.Point(72, 223);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(341, 88);
            this.btnMoney.TabIndex = 2;
            this.btnMoney.Text = "$ $ $";
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblHours.Location = new System.Drawing.Point(12, 140);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(95, 36);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(211, 189);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(0, 13);
            this.lblDebug.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(423, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(423, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblOt
            // 
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblOt.Location = new System.Drawing.Point(12, 177);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(111, 29);
            this.lblOt.TabIndex = 7;
            this.lblOt.Text = "Overtime";
            this.lblOt.Visible = false;
            // 
            // formTimeClocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 336);
            this.Controls.Add(this.lblOt);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTimeClocker";
            this.Text = "Time Clocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblOt;
    }
}

