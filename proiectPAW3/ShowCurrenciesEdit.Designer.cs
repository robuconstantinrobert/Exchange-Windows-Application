
namespace proiectPAW3
{
    partial class ShowCurrenciesEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.textBoxEditType = new System.Windows.Forms.TextBox();
            this.textBoxEditAmount = new System.Windows.Forms.TextBox();
            this.textBoxEditChange = new System.Windows.Forms.TextBox();
            this.textBoxEditDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.errorProviderShowCurrenciesEdit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderShowCurrenciesEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edit amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edit change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edit date:";
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Location = new System.Drawing.Point(149, 95);
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditName.TabIndex = 5;
            this.textBoxEditName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEditName_Validating);
            this.textBoxEditName.Validated += new System.EventHandler(this.textBoxEditName_Validated);
            // 
            // textBoxEditType
            // 
            this.textBoxEditType.Location = new System.Drawing.Point(149, 130);
            this.textBoxEditType.Name = "textBoxEditType";
            this.textBoxEditType.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditType.TabIndex = 6;
            this.textBoxEditType.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEditType_Validating);
            this.textBoxEditType.Validated += new System.EventHandler(this.textBoxEditType_Validated);
            // 
            // textBoxEditAmount
            // 
            this.textBoxEditAmount.Location = new System.Drawing.Point(149, 164);
            this.textBoxEditAmount.Name = "textBoxEditAmount";
            this.textBoxEditAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditAmount.TabIndex = 7;
            this.textBoxEditAmount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEditAmount_Validating);
            this.textBoxEditAmount.Validated += new System.EventHandler(this.textBoxEditAmount_Validated);
            // 
            // textBoxEditChange
            // 
            this.textBoxEditChange.Location = new System.Drawing.Point(149, 198);
            this.textBoxEditChange.Name = "textBoxEditChange";
            this.textBoxEditChange.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditChange.TabIndex = 8;
            this.textBoxEditChange.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEditChange_Validating);
            this.textBoxEditChange.Validated += new System.EventHandler(this.textBoxEditChange_Validated);
            // 
            // textBoxEditDate
            // 
            this.textBoxEditDate.Location = new System.Drawing.Point(149, 231);
            this.textBoxEditDate.Name = "textBoxEditDate";
            this.textBoxEditDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditDate.TabIndex = 9;
            this.textBoxEditDate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEditDate_Validating);
            this.textBoxEditDate.Validated += new System.EventHandler(this.textBoxEditDate_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Currencies Edit";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(104, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // errorProviderShowCurrenciesEdit
            // 
            this.errorProviderShowCurrenciesEdit.ContainerControl = this;
            // 
            // ShowCurrenciesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(310, 313);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEditDate);
            this.Controls.Add(this.textBoxEditChange);
            this.Controls.Add(this.textBoxEditAmount);
            this.Controls.Add(this.textBoxEditType);
            this.Controls.Add(this.textBoxEditName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowCurrenciesEdit";
            this.Text = "ShowCurrenciesEdit";
            this.Load += new System.EventHandler(this.ShowCurrenciesEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderShowCurrenciesEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.TextBox textBoxEditType;
        private System.Windows.Forms.TextBox textBoxEditAmount;
        private System.Windows.Forms.TextBox textBoxEditChange;
        private System.Windows.Forms.TextBox textBoxEditDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ErrorProvider errorProviderShowCurrenciesEdit;
    }
}