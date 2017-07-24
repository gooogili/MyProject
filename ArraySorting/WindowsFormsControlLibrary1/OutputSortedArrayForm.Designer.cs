namespace ArraySorting
{
    partial class OutputSortedArrayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputSortedArrayForm));
            this.arraysShowTabControl = new System.Windows.Forms.TabControl();
            this.sortingArraysManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.startSortingButton = new System.Windows.Forms.Button();
            this.sortingArraysSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.sortingArraysManagementGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingArraysSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // arraysShowTabControl
            // 
            resources.ApplyResources(this.arraysShowTabControl, "arraysShowTabControl");
            this.arraysShowTabControl.Name = "arraysShowTabControl";
            this.arraysShowTabControl.SelectedIndex = 0;
            // 
            // sortingArraysManagementGroupBox
            // 
            resources.ApplyResources(this.sortingArraysManagementGroupBox, "sortingArraysManagementGroupBox");
            this.sortingArraysManagementGroupBox.Controls.Add(this.startSortingButton);
            this.sortingArraysManagementGroupBox.Controls.Add(this.sortingArraysSpeedTrackBar);
            this.sortingArraysManagementGroupBox.Name = "sortingArraysManagementGroupBox";
            this.sortingArraysManagementGroupBox.TabStop = false;
            // 
            // startSortingButton
            // 
            resources.ApplyResources(this.startSortingButton, "startSortingButton");
            this.startSortingButton.Name = "startSortingButton";
            this.startSortingButton.UseVisualStyleBackColor = true;
            this.startSortingButton.Click += new System.EventHandler(this.startSortingButton_Click);
            // 
            // sortingArraysSpeedTrackBar
            // 
            resources.ApplyResources(this.sortingArraysSpeedTrackBar, "sortingArraysSpeedTrackBar");
            this.sortingArraysSpeedTrackBar.Maximum = 20;
            this.sortingArraysSpeedTrackBar.Name = "sortingArraysSpeedTrackBar";
            this.sortingArraysSpeedTrackBar.ValueChanged += new System.EventHandler(this.sortingArraysSpeedTrackBar_ValueChanged);
            // 
            // OutputSortedArrayForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sortingArraysManagementGroupBox);
            this.Controls.Add(this.arraysShowTabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "OutputSortedArrayForm";
            this.sortingArraysManagementGroupBox.ResumeLayout(false);
            this.sortingArraysManagementGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingArraysSpeedTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl arraysShowTabControl;
        private System.Windows.Forms.GroupBox sortingArraysManagementGroupBox;
        private System.Windows.Forms.TrackBar sortingArraysSpeedTrackBar;
        private System.Windows.Forms.Button startSortingButton;
    }
}