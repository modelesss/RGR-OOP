namespace RGR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtPlaneName = new System.Windows.Forms.TextBox();
            this.txtDeparturePoint = new System.Windows.Forms.TextBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.txtDestinationPoint = new System.Windows.Forms.TextBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.listBoxFlights = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(234, 30);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(237, 22);
            this.txtFlightNumber.TabIndex = 0;
            this.txtFlightNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightNumber_KeyPress);
            // 
            // txtPlaneName
            // 
            this.txtPlaneName.Location = new System.Drawing.Point(234, 86);
            this.txtPlaneName.Name = "txtPlaneName";
            this.txtPlaneName.Size = new System.Drawing.Size(237, 22);
            this.txtPlaneName.TabIndex = 1;
            // 
            // txtDeparturePoint
            // 
            this.txtDeparturePoint.Location = new System.Drawing.Point(234, 139);
            this.txtDeparturePoint.Name = "txtDeparturePoint";
            this.txtDeparturePoint.Size = new System.Drawing.Size(237, 22);
            this.txtDeparturePoint.TabIndex = 2;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(234, 352);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(237, 22);
            this.txtTicketPrice.TabIndex = 4;
            this.txtTicketPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketPrice_KeyPress);
            // 
            // txtDestinationPoint
            // 
            this.txtDestinationPoint.Location = new System.Drawing.Point(234, 191);
            this.txtDestinationPoint.Name = "txtDestinationPoint";
            this.txtDestinationPoint.Size = new System.Drawing.Size(237, 22);
            this.txtDestinationPoint.TabIndex = 3;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Location = new System.Drawing.Point(234, 246);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(237, 22);
            this.dtpDepartureTime.TabIndex = 5;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Location = new System.Drawing.Point(234, 303);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(237, 22);
            this.dtpArrivalTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер рейсу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Назва літака:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пункт призначення:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пункт відправлення:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата прибуття:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата відправлення:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Вартість квитка:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 64);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Додати рейс";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 64);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Видалити рейс";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(345, 400);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(106, 64);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "Показати всі рейси";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // listBoxFlights
            // 
            this.listBoxFlights.FormattingEnabled = true;
            this.listBoxFlights.ItemHeight = 16;
            this.listBoxFlights.Location = new System.Drawing.Point(496, 12);
            this.listBoxFlights.Name = "listBoxFlights";
            this.listBoxFlights.Size = new System.Drawing.Size(700, 452);
            this.listBoxFlights.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 496);
            this.Controls.Add(this.listBoxFlights);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.txtDestinationPoint);
            this.Controls.Add(this.txtDeparturePoint);
            this.Controls.Add(this.txtPlaneName);
            this.Controls.Add(this.txtFlightNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtPlaneName;
        private System.Windows.Forms.TextBox txtDeparturePoint;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.TextBox txtDestinationPoint;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListBox listBoxFlights;
    }
}

