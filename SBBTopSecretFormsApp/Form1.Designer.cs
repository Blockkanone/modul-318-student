﻿
namespace SBBTopSecretFormsApp
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
            this.depatureLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.dateSearch = new System.Windows.Forms.TextBox();
            this.timeSearch = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.depatureTimeLabel = new System.Windows.Forms.Label();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.searchTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.arrivalTimeSearchButton = new System.Windows.Forms.RadioButton();
            this.depatureTimeButton = new System.Windows.Forms.RadioButton();
            this.departurePanelButton = new System.Windows.Forms.Button();
            this.depatureStation = new System.Windows.Forms.ComboBox();
            this.arrivalStation = new System.Windows.Forms.ComboBox();
            this.historyLoad = new System.Windows.Forms.Button();
            this.historyDelete = new System.Windows.Forms.Button();
            this.searchTimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // depatureLabel
            // 
            this.depatureLabel.AutoSize = true;
            this.depatureLabel.Location = new System.Drawing.Point(117, 46);
            this.depatureLabel.Name = "depatureLabel";
            this.depatureLabel.Size = new System.Drawing.Size(26, 13);
            this.depatureLabel.TabIndex = 0;
            this.depatureLabel.Text = "Von";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Location = new System.Drawing.Point(348, 46);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(21, 13);
            this.arrivalLabel.TabIndex = 1;
            this.arrivalLabel.Text = "Bis";
            // 
            // dateSearch
            // 
            this.dateSearch.Location = new System.Drawing.Point(120, 109);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(100, 20);
            this.dateSearch.TabIndex = 4;
            // 
            // timeSearch
            // 
            this.timeSearch.Location = new System.Drawing.Point(226, 109);
            this.timeSearch.Name = "timeSearch";
            this.timeSearch.Size = new System.Drawing.Size(100, 20);
            this.timeSearch.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(117, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Datum";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(223, 93);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(40, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Uhrzeit";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(529, 107);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // depatureTimeLabel
            // 
            this.depatureTimeLabel.AutoSize = true;
            this.depatureTimeLabel.Location = new System.Drawing.Point(335, 111);
            this.depatureTimeLabel.Name = "depatureTimeLabel";
            this.depatureTimeLabel.Size = new System.Drawing.Size(62, 13);
            this.depatureTimeLabel.TabIndex = 9;
            this.depatureTimeLabel.Text = "Abfahrtszeit";
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Location = new System.Drawing.Point(458, 111);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(65, 13);
            this.arrivalTimeLabel.TabIndex = 10;
            this.arrivalTimeLabel.Text = "Ankunftszeit";
            // 
            // searchTimeGroupBox
            // 
            this.searchTimeGroupBox.Controls.Add(this.arrivalTimeSearchButton);
            this.searchTimeGroupBox.Controls.Add(this.depatureTimeButton);
            this.searchTimeGroupBox.Location = new System.Drawing.Point(404, 95);
            this.searchTimeGroupBox.Name = "searchTimeGroupBox";
            this.searchTimeGroupBox.Size = new System.Drawing.Size(48, 56);
            this.searchTimeGroupBox.TabIndex = 11;
            this.searchTimeGroupBox.TabStop = false;
            // 
            // arrivalTimeSearchButton
            // 
            this.arrivalTimeSearchButton.AutoSize = true;
            this.arrivalTimeSearchButton.Location = new System.Drawing.Point(26, 16);
            this.arrivalTimeSearchButton.Name = "arrivalTimeSearchButton";
            this.arrivalTimeSearchButton.Size = new System.Drawing.Size(14, 13);
            this.arrivalTimeSearchButton.TabIndex = 1;
            this.arrivalTimeSearchButton.TabStop = true;
            this.arrivalTimeSearchButton.UseVisualStyleBackColor = true;
            // 
            // depatureTimeButton
            // 
            this.depatureTimeButton.AutoSize = true;
            this.depatureTimeButton.Location = new System.Drawing.Point(6, 16);
            this.depatureTimeButton.Name = "depatureTimeButton";
            this.depatureTimeButton.Size = new System.Drawing.Size(14, 13);
            this.depatureTimeButton.TabIndex = 0;
            this.depatureTimeButton.TabStop = true;
            this.depatureTimeButton.UseVisualStyleBackColor = true;
            // 
            // departurePanelButton
            // 
            this.departurePanelButton.Location = new System.Drawing.Point(36, 59);
            this.departurePanelButton.Name = "departurePanelButton";
            this.departurePanelButton.Size = new System.Drawing.Size(75, 23);
            this.departurePanelButton.TabIndex = 12;
            this.departurePanelButton.Text = "Abfahrtstafel";
            this.departurePanelButton.UseVisualStyleBackColor = true;
            this.departurePanelButton.Click += new System.EventHandler(this.departurePanelButton_Click);
            // 
            // depatureStation
            // 
            this.depatureStation.FormattingEnabled = true;
            this.depatureStation.Location = new System.Drawing.Point(120, 61);
            this.depatureStation.Name = "depatureStation";
            this.depatureStation.Size = new System.Drawing.Size(206, 21);
            this.depatureStation.TabIndex = 13;
            this.depatureStation.TextUpdate += new System.EventHandler(this.depatureStation_TextUpdate);
            // 
            // arrivalStation
            // 
            this.arrivalStation.FormattingEnabled = true;
            this.arrivalStation.Location = new System.Drawing.Point(351, 61);
            this.arrivalStation.Name = "arrivalStation";
            this.arrivalStation.Size = new System.Drawing.Size(253, 21);
            this.arrivalStation.TabIndex = 14;
            this.arrivalStation.TextUpdate += new System.EventHandler(this.arrivalStation_TextUpdate);
            // 
            // historyLoad
            // 
            this.historyLoad.Location = new System.Drawing.Point(623, 59);
            this.historyLoad.Name = "historyLoad";
            this.historyLoad.Size = new System.Drawing.Size(121, 23);
            this.historyLoad.TabIndex = 15;
            this.historyLoad.Text = "Suchverlauf laden";
            this.historyLoad.UseVisualStyleBackColor = true;
            this.historyLoad.Click += new System.EventHandler(this.historyLoad_Click);
            // 
            // historyDelete
            // 
            this.historyDelete.Location = new System.Drawing.Point(623, 106);
            this.historyDelete.Name = "historyDelete";
            this.historyDelete.Size = new System.Drawing.Size(121, 23);
            this.historyDelete.TabIndex = 16;
            this.historyDelete.Text = "Suchverlauf löschen";
            this.historyDelete.UseVisualStyleBackColor = true;
            this.historyDelete.Click += new System.EventHandler(this.historyDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyDelete);
            this.Controls.Add(this.historyLoad);
            this.Controls.Add(this.arrivalStation);
            this.Controls.Add(this.depatureStation);
            this.Controls.Add(this.departurePanelButton);
            this.Controls.Add(this.searchTimeGroupBox);
            this.Controls.Add(this.arrivalTimeLabel);
            this.Controls.Add(this.depatureTimeLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeSearch);
            this.Controls.Add(this.dateSearch);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.depatureLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchTimeGroupBox.ResumeLayout(false);
            this.searchTimeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depatureLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.TextBox dateSearch;
        private System.Windows.Forms.TextBox timeSearch;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label depatureTimeLabel;
        private System.Windows.Forms.Label arrivalTimeLabel;
        private System.Windows.Forms.GroupBox searchTimeGroupBox;
        private System.Windows.Forms.RadioButton arrivalTimeSearchButton;
        private System.Windows.Forms.RadioButton depatureTimeButton;
        private System.Windows.Forms.Button departurePanelButton;
        private System.Windows.Forms.ComboBox depatureStation;
        private System.Windows.Forms.ComboBox arrivalStation;
        private System.Windows.Forms.Button historyLoad;
        private System.Windows.Forms.Button historyDelete;
    }
}

