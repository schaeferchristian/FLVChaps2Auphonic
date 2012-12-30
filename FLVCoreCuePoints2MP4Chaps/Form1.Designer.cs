namespace FLVCoreCuePoints2MP4Chaps
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.buttonLoadXML = new System.Windows.Forms.Button();
            this.dataGridViewIN = new System.Windows.Forms.DataGridView();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.buttonSaveAuphonicChaps = new System.Windows.Forms.Button();
            this.dataGridViewOUT = new System.Windows.Forms.DataGridView();
            this.ColTimeFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIN)).BeginInit();
            this.groupBox_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOUT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.buttonLoadXML);
            this.groupBox_Input.Controls.Add(this.dataGridViewIN);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(480, 713);
            this.groupBox_Input.TabIndex = 0;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "IN";
            // 
            // buttonLoadXML
            // 
            this.buttonLoadXML.Location = new System.Drawing.Point(196, 19);
            this.buttonLoadXML.Name = "buttonLoadXML";
            this.buttonLoadXML.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadXML.TabIndex = 1;
            this.buttonLoadXML.Text = "Load XML";
            this.buttonLoadXML.UseVisualStyleBackColor = true;
            this.buttonLoadXML.Click += new System.EventHandler(this.buttonLoadXML_Click);
            // 
            // dataGridViewIN
            // 
            this.dataGridViewIN.AllowUserToAddRows = false;
            this.dataGridViewIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTimeFrame,
            this.ColText});
            this.dataGridViewIN.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewIN.Name = "dataGridViewIN";
            this.dataGridViewIN.Size = new System.Drawing.Size(468, 647);
            this.dataGridViewIN.TabIndex = 0;
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.buttonSaveAuphonicChaps);
            this.groupBox_Output.Controls.Add(this.dataGridViewOUT);
            this.groupBox_Output.Location = new System.Drawing.Point(772, 12);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(480, 713);
            this.groupBox_Output.TabIndex = 1;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "OUT";
            // 
            // buttonSaveAuphonicChaps
            // 
            this.buttonSaveAuphonicChaps.Location = new System.Drawing.Point(6, 19);
            this.buttonSaveAuphonicChaps.Name = "buttonSaveAuphonicChaps";
            this.buttonSaveAuphonicChaps.Size = new System.Drawing.Size(137, 23);
            this.buttonSaveAuphonicChaps.TabIndex = 2;
            this.buttonSaveAuphonicChaps.Text = "Save Auphonic Chapters";
            this.buttonSaveAuphonicChaps.UseVisualStyleBackColor = true;
            this.buttonSaveAuphonicChaps.Click += new System.EventHandler(this.buttonSaveAuphonicChaps_Click);
            // 
            // dataGridViewOUT
            // 
            this.dataGridViewOUT.AllowUserToAddRows = false;
            this.dataGridViewOUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOUT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewOUT.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewOUT.Name = "dataGridViewOUT";
            this.dataGridViewOUT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOUT.ShowEditingIcon = false;
            this.dataGridViewOUT.Size = new System.Drawing.Size(468, 647);
            this.dataGridViewOUT.TabIndex = 1;
            // 
            // ColTimeFrame
            // 
            this.ColTimeFrame.HeaderText = "Time (in ms)";
            this.ColTimeFrame.Name = "ColTimeFrame";
            // 
            // ColText
            // 
            this.ColText.HeaderText = "Chapter-Name";
            this.ColText.Name = "ColText";
            this.ColText.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Timecode (hh:mm:ss.ms)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Chapter-Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Input);
            this.Name = "Form1";
            this.Text = "FLVChapterXML2Auphonic";
            this.groupBox_Input.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIN)).EndInit();
            this.groupBox_Output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOUT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Button buttonLoadXML;
        private System.Windows.Forms.DataGridView dataGridViewIN;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.Button buttonSaveAuphonicChaps;
        private System.Windows.Forms.DataGridView dataGridViewOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

