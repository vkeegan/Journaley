﻿namespace DayOneWindowsClient
{
    partial class MainForm
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
            this.tabLeftPanel = new System.Windows.Forms.TabControl();
            this.tabPageAllEntries = new System.Windows.Forms.TabPage();
            this.tabPageStarred = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEntries = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelThisWeek = new System.Windows.Forms.Label();
            this.labelToday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShare = new System.Windows.Forms.Button();
            this.buttonEditSave = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.tabPageEntriesByYear = new System.Windows.Forms.TabPage();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.entryListBoxAll = new DayOneWindowsClient.EntryListBox();
            this.tabLeftPanel.SuspendLayout();
            this.tabPageAllEntries.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLeftPanel
            // 
            this.tabLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabLeftPanel.Controls.Add(this.tabPageAllEntries);
            this.tabLeftPanel.Controls.Add(this.tabPageStarred);
            this.tabLeftPanel.Controls.Add(this.tabPageEntriesByYear);
            this.tabLeftPanel.Controls.Add(this.tabPageCalendar);
            this.tabLeftPanel.Location = new System.Drawing.Point(12, 114);
            this.tabLeftPanel.Name = "tabLeftPanel";
            this.tabLeftPanel.SelectedIndex = 0;
            this.tabLeftPanel.Size = new System.Drawing.Size(259, 447);
            this.tabLeftPanel.TabIndex = 2;
            // 
            // tabPageAllEntries
            // 
            this.tabPageAllEntries.Controls.Add(this.entryListBoxAll);
            this.tabPageAllEntries.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllEntries.Name = "tabPageAllEntries";
            this.tabPageAllEntries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllEntries.Size = new System.Drawing.Size(251, 421);
            this.tabPageAllEntries.TabIndex = 0;
            this.tabPageAllEntries.Text = "All";
            this.tabPageAllEntries.UseVisualStyleBackColor = true;
            // 
            // tabPageStarred
            // 
            this.tabPageStarred.Location = new System.Drawing.Point(4, 22);
            this.tabPageStarred.Name = "tabPageStarred";
            this.tabPageStarred.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStarred.Size = new System.Drawing.Size(251, 421);
            this.tabPageStarred.TabIndex = 1;
            this.tabPageStarred.Text = "Starred";
            this.tabPageStarred.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(277, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 503);
            this.textBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "MMM d, yyyy hh:mm tt";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(522, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelEntries, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDays, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelThisWeek, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelToday, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelEntries
            // 
            this.labelEntries.AutoSize = true;
            this.labelEntries.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntries.Location = new System.Drawing.Point(0, 0);
            this.labelEntries.Margin = new System.Windows.Forms.Padding(0);
            this.labelEntries.Name = "labelEntries";
            this.labelEntries.Size = new System.Drawing.Size(0, 14);
            this.labelEntries.TabIndex = 0;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(64, 0);
            this.labelDays.Margin = new System.Windows.Forms.Padding(0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(0, 14);
            this.labelDays.TabIndex = 1;
            // 
            // labelThisWeek
            // 
            this.labelThisWeek.AutoSize = true;
            this.labelThisWeek.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThisWeek.Location = new System.Drawing.Point(128, 0);
            this.labelThisWeek.Margin = new System.Windows.Forms.Padding(0);
            this.labelThisWeek.Name = "labelThisWeek";
            this.labelThisWeek.Size = new System.Drawing.Size(0, 14);
            this.labelThisWeek.TabIndex = 2;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToday.Location = new System.Drawing.Point(192, 0);
            this.labelToday.Margin = new System.Windows.Forms.Padding(0);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(0, 14);
            this.labelToday.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "ENTRIES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "DAYS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "THIS WEEK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "TODAY";
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Image = global::DayOneWindowsClient.Properties.Resources.Plus_32x32;
            this.buttonAddEntry.Location = new System.Drawing.Point(12, 12);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(259, 40);
            this.buttonAddEntry.TabIndex = 0;
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = global::DayOneWindowsClient.Properties.Resources.Delete_32x32;
            this.buttonDelete.Location = new System.Drawing.Point(866, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(40, 40);
            this.buttonDelete.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonDelete, "Delete");
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonShare
            // 
            this.buttonShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShare.Image = global::DayOneWindowsClient.Properties.Resources.Copy_32x32;
            this.buttonShare.Location = new System.Drawing.Point(820, 12);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(40, 40);
            this.buttonShare.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonShare, "Share");
            this.buttonShare.UseVisualStyleBackColor = true;
            // 
            // buttonEditSave
            // 
            this.buttonEditSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditSave.Image = global::DayOneWindowsClient.Properties.Resources.Edit_32x32;
            this.buttonEditSave.Location = new System.Drawing.Point(728, 12);
            this.buttonEditSave.Name = "buttonEditSave";
            this.buttonEditSave.Size = new System.Drawing.Size(40, 40);
            this.buttonEditSave.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonEditSave, "Edit");
            this.buttonEditSave.UseVisualStyleBackColor = true;
            // 
            // buttonStar
            // 
            this.buttonStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStar.Image = global::DayOneWindowsClient.Properties.Resources.StarGray_32x32;
            this.buttonStar.Location = new System.Drawing.Point(774, 12);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(40, 40);
            this.buttonStar.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonStar, "Star");
            this.buttonStar.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::DayOneWindowsClient.Properties.Resources.Settings_32x32;
            this.buttonSettings.Location = new System.Drawing.Point(277, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(40, 40);
            this.buttonSettings.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonSettings, "Settings");
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // tabPageEntriesByYear
            // 
            this.tabPageEntriesByYear.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntriesByYear.Name = "tabPageEntriesByYear";
            this.tabPageEntriesByYear.Size = new System.Drawing.Size(251, 421);
            this.tabPageEntriesByYear.TabIndex = 2;
            this.tabPageEntriesByYear.Text = "Entries by Year";
            this.tabPageEntriesByYear.UseVisualStyleBackColor = true;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Size = new System.Drawing.Size(251, 421);
            this.tabPageCalendar.TabIndex = 3;
            this.tabPageCalendar.Text = "Calendar";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // entryListBoxAll
            // 
            this.entryListBoxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryListBoxAll.FormattingEnabled = true;
            this.entryListBoxAll.Location = new System.Drawing.Point(3, 3);
            this.entryListBoxAll.Name = "entryListBoxAll";
            this.entryListBoxAll.ScrollAlwaysVisible = true;
            this.entryListBoxAll.Size = new System.Drawing.Size(245, 415);
            this.entryListBoxAll.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 573);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonEditSave);
            this.Controls.Add(this.buttonShare);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddEntry);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabLeftPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day One Windows Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabLeftPanel.ResumeLayout(false);
            this.tabPageAllEntries.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLeftPanel;
        private System.Windows.Forms.TabPage tabPageAllEntries;
        private System.Windows.Forms.TabPage tabPageStarred;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEntries;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelThisWeek;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShare;
        private System.Windows.Forms.Button buttonEditSave;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TabPage tabPageEntriesByYear;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private EntryListBox entryListBoxAll;
    }
}

