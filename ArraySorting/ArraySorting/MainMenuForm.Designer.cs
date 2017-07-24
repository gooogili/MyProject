using System;

namespace ArraySorting
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLanguageToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.selectSortersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.mainMenuTabControl = new ArraySorting.CustomTabControl();
            this.selectMethodForGettingAnArrayTabPage = new System.Windows.Forms.TabPage();
            this.fromDataBaseArrayLoadingButton = new System.Windows.Forms.Button();
            this.fromFileArrayLoadingButton = new System.Windows.Forms.Button();
            this.fromKeyboardInputArrayButton = new System.Windows.Forms.Button();
            this.randomArrayGenerateButton = new System.Windows.Forms.Button();
            this.randomGenerationArrayTabPage = new System.Windows.Forms.TabPage();
            this.numberOfColumnsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfRowsTextBox = new System.Windows.Forms.TextBox();
            this.maxArrayValueLabel = new System.Windows.Forms.Label();
            this.numberOfRowsLabel = new System.Windows.Forms.Label();
            this.minArrayValueLabel = new System.Windows.Forms.Label();
            this.numberOfColumnsLabel = new System.Windows.Forms.Label();
            this.maxArrayValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmForRandomArrayButton = new System.Windows.Forms.Button();
            this.minArrayValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manuallyInputtingArrayTabPage = new System.Windows.Forms.TabPage();
            this.fieldForArrayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmForManuallyInputingButton = new System.Windows.Forms.Button();
            this.numberOfRowsInManuallyTextBox = new System.Windows.Forms.TextBox();
            this.numberOfColumnsInManuallyTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.mainMenuTabControl.SuspendLayout();
            this.selectMethodForGettingAnArrayTabPage.SuspendLayout();
            this.randomGenerationArrayTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxArrayValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minArrayValueNumericUpDown)).BeginInit();
            this.manuallyInputtingArrayTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.selectLanguageToolStripComboBox});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // selectLanguageToolStripComboBox
            // 
            this.selectLanguageToolStripComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectLanguageToolStripComboBox.Name = "selectLanguageToolStripComboBox";
            resources.ApplyResources(this.selectLanguageToolStripComboBox, "selectLanguageToolStripComboBox");
            this.selectLanguageToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.selectLanguageToolStripComboBox_SelectedIndexChanged);
            // 
            // selectSortersCheckedListBox
            // 
            this.selectSortersCheckedListBox.CheckOnClick = true;
            resources.ApplyResources(this.selectSortersCheckedListBox, "selectSortersCheckedListBox");
            this.selectSortersCheckedListBox.FormattingEnabled = true;
            this.selectSortersCheckedListBox.Name = "selectSortersCheckedListBox";
            // 
            // mainMenuTabControl
            // 
            this.mainMenuTabControl.Controls.Add(this.selectMethodForGettingAnArrayTabPage);
            this.mainMenuTabControl.Controls.Add(this.randomGenerationArrayTabPage);
            this.mainMenuTabControl.Controls.Add(this.manuallyInputtingArrayTabPage);
            resources.ApplyResources(this.mainMenuTabControl, "mainMenuTabControl");
            this.mainMenuTabControl.Name = "mainMenuTabControl";
            this.mainMenuTabControl.SelectedIndex = 0;
            // 
            // selectMethodForGettingAnArrayTabPage
            // 
            this.selectMethodForGettingAnArrayTabPage.Controls.Add(this.fromDataBaseArrayLoadingButton);
            this.selectMethodForGettingAnArrayTabPage.Controls.Add(this.fromFileArrayLoadingButton);
            this.selectMethodForGettingAnArrayTabPage.Controls.Add(this.fromKeyboardInputArrayButton);
            this.selectMethodForGettingAnArrayTabPage.Controls.Add(this.randomArrayGenerateButton);
            resources.ApplyResources(this.selectMethodForGettingAnArrayTabPage, "selectMethodForGettingAnArrayTabPage");
            this.selectMethodForGettingAnArrayTabPage.Name = "selectMethodForGettingAnArrayTabPage";
            this.selectMethodForGettingAnArrayTabPage.UseVisualStyleBackColor = true;
            // 
            // fromDataBaseArrayLoadingButton
            // 
            resources.ApplyResources(this.fromDataBaseArrayLoadingButton, "fromDataBaseArrayLoadingButton");
            this.fromDataBaseArrayLoadingButton.Name = "fromDataBaseArrayLoadingButton";
            this.fromDataBaseArrayLoadingButton.UseVisualStyleBackColor = true;
            this.fromDataBaseArrayLoadingButton.Click += new System.EventHandler(this.fromDataBaseArrayLoadingButton_Click);
            // 
            // fromFileArrayLoadingButton
            // 
            resources.ApplyResources(this.fromFileArrayLoadingButton, "fromFileArrayLoadingButton");
            this.fromFileArrayLoadingButton.Name = "fromFileArrayLoadingButton";
            this.fromFileArrayLoadingButton.UseVisualStyleBackColor = true;
            // 
            // fromKeyboardInputArrayButton
            // 
            resources.ApplyResources(this.fromKeyboardInputArrayButton, "fromKeyboardInputArrayButton");
            this.fromKeyboardInputArrayButton.Name = "fromKeyboardInputArrayButton";
            this.fromKeyboardInputArrayButton.UseVisualStyleBackColor = true;
            this.fromKeyboardInputArrayButton.Click += new System.EventHandler(this.fromKeyboardInputArrayButton_Click);
            // 
            // randomArrayGenerateButton
            // 
            resources.ApplyResources(this.randomArrayGenerateButton, "randomArrayGenerateButton");
            this.randomArrayGenerateButton.Name = "randomArrayGenerateButton";
            this.randomArrayGenerateButton.UseVisualStyleBackColor = true;
            this.randomArrayGenerateButton.Click += new System.EventHandler(this.randomArrayGenerateButton_Click);
            // 
            // randomGenerationArrayTabPage
            // 
            this.randomGenerationArrayTabPage.Controls.Add(this.numberOfColumnsTextBox);
            this.randomGenerationArrayTabPage.Controls.Add(this.numberOfRowsTextBox);
            this.randomGenerationArrayTabPage.Controls.Add(this.maxArrayValueLabel);
            this.randomGenerationArrayTabPage.Controls.Add(this.numberOfRowsLabel);
            this.randomGenerationArrayTabPage.Controls.Add(this.minArrayValueLabel);
            this.randomGenerationArrayTabPage.Controls.Add(this.numberOfColumnsLabel);
            this.randomGenerationArrayTabPage.Controls.Add(this.maxArrayValueNumericUpDown);
            this.randomGenerationArrayTabPage.Controls.Add(this.confirmForRandomArrayButton);
            this.randomGenerationArrayTabPage.Controls.Add(this.minArrayValueNumericUpDown);
            resources.ApplyResources(this.randomGenerationArrayTabPage, "randomGenerationArrayTabPage");
            this.randomGenerationArrayTabPage.Name = "randomGenerationArrayTabPage";
            this.randomGenerationArrayTabPage.UseVisualStyleBackColor = true;
            // 
            // numberOfColumnsTextBox
            // 
            resources.ApplyResources(this.numberOfColumnsTextBox, "numberOfColumnsTextBox");
            this.numberOfColumnsTextBox.Name = "numberOfColumnsTextBox";
            // 
            // numberOfRowsTextBox
            // 
            resources.ApplyResources(this.numberOfRowsTextBox, "numberOfRowsTextBox");
            this.numberOfRowsTextBox.Name = "numberOfRowsTextBox";
            // 
            // maxArrayValueLabel
            // 
            resources.ApplyResources(this.maxArrayValueLabel, "maxArrayValueLabel");
            this.maxArrayValueLabel.Name = "maxArrayValueLabel";
            // 
            // numberOfRowsLabel
            // 
            resources.ApplyResources(this.numberOfRowsLabel, "numberOfRowsLabel");
            this.numberOfRowsLabel.Name = "numberOfRowsLabel";
            // 
            // minArrayValueLabel
            // 
            resources.ApplyResources(this.minArrayValueLabel, "minArrayValueLabel");
            this.minArrayValueLabel.AutoEllipsis = true;
            this.minArrayValueLabel.Name = "minArrayValueLabel";
            // 
            // numberOfColumnsLabel
            // 
            resources.ApplyResources(this.numberOfColumnsLabel, "numberOfColumnsLabel");
            this.numberOfColumnsLabel.Name = "numberOfColumnsLabel";
            // 
            // maxArrayValueNumericUpDown
            // 
            resources.ApplyResources(this.maxArrayValueNumericUpDown, "maxArrayValueNumericUpDown");
            this.maxArrayValueNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.maxArrayValueNumericUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.maxArrayValueNumericUpDown.Name = "maxArrayValueNumericUpDown";
            this.maxArrayValueNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // confirmForRandomArrayButton
            // 
            resources.ApplyResources(this.confirmForRandomArrayButton, "confirmForRandomArrayButton");
            this.confirmForRandomArrayButton.Name = "confirmForRandomArrayButton";
            this.confirmForRandomArrayButton.UseVisualStyleBackColor = true;
            this.confirmForRandomArrayButton.Click += new System.EventHandler(this.confirmForRandomArrayButton_Click);
            // 
            // minArrayValueNumericUpDown
            // 
            resources.ApplyResources(this.minArrayValueNumericUpDown, "minArrayValueNumericUpDown");
            this.minArrayValueNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.minArrayValueNumericUpDown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.minArrayValueNumericUpDown.Name = "minArrayValueNumericUpDown";
            this.minArrayValueNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            // 
            // manuallyInputtingArrayTabPage
            // 
            this.manuallyInputtingArrayTabPage.Controls.Add(this.fieldForArrayTextBox);
            this.manuallyInputtingArrayTabPage.Controls.Add(this.label1);
            this.manuallyInputtingArrayTabPage.Controls.Add(this.label2);
            this.manuallyInputtingArrayTabPage.Controls.Add(this.label4);
            this.manuallyInputtingArrayTabPage.Controls.Add(this.confirmForManuallyInputingButton);
            this.manuallyInputtingArrayTabPage.Controls.Add(this.numberOfRowsInManuallyTextBox);
            this.manuallyInputtingArrayTabPage.Controls.Add(this.numberOfColumnsInManuallyTextBox);
            resources.ApplyResources(this.manuallyInputtingArrayTabPage, "manuallyInputtingArrayTabPage");
            this.manuallyInputtingArrayTabPage.Name = "manuallyInputtingArrayTabPage";
            this.manuallyInputtingArrayTabPage.UseVisualStyleBackColor = true;
            // 
            // fieldForArrayTextBox
            // 
            resources.ApplyResources(this.fieldForArrayTextBox, "fieldForArrayTextBox");
            this.fieldForArrayTextBox.Name = "fieldForArrayTextBox";
            this.fieldForArrayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fieldForArrayTextBox_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // confirmForManuallyInputingButton
            // 
            resources.ApplyResources(this.confirmForManuallyInputingButton, "confirmForManuallyInputingButton");
            this.confirmForManuallyInputingButton.Name = "confirmForManuallyInputingButton";
            this.confirmForManuallyInputingButton.UseVisualStyleBackColor = true;
            this.confirmForManuallyInputingButton.Click += new System.EventHandler(this.confirmForManuallyInputingButton_Click);
            // 
            // numberOfRowsInManuallyTextBox
            // 
            resources.ApplyResources(this.numberOfRowsInManuallyTextBox, "numberOfRowsInManuallyTextBox");
            this.numberOfRowsInManuallyTextBox.Name = "numberOfRowsInManuallyTextBox";
            // 
            // numberOfColumnsInManuallyTextBox
            // 
            resources.ApplyResources(this.numberOfColumnsInManuallyTextBox, "numberOfColumnsInManuallyTextBox");
            this.numberOfColumnsInManuallyTextBox.Name = "numberOfColumnsInManuallyTextBox";
            this.numberOfColumnsInManuallyTextBox.TextChanged += new System.EventHandler(this.numberOfColumnsInManuallyTextBox_TextChanged);
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.mainMenuTabControl);
            this.Controls.Add(this.selectSortersCheckedListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainMenuTabControl.ResumeLayout(false);
            this.selectMethodForGettingAnArrayTabPage.ResumeLayout(false);
            this.randomGenerationArrayTabPage.ResumeLayout(false);
            this.randomGenerationArrayTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxArrayValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minArrayValueNumericUpDown)).EndInit();
            this.manuallyInputtingArrayTabPage.ResumeLayout(false);
            this.manuallyInputtingArrayTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.CheckedListBox selectSortersCheckedListBox;
        private System.Windows.Forms.Label numberOfColumnsLabel;
        private System.Windows.Forms.Label numberOfRowsLabel;
        private System.Windows.Forms.Button confirmForRandomArrayButton;
        private System.Windows.Forms.NumericUpDown minArrayValueNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxArrayValueNumericUpDown;
        private System.Windows.Forms.Label minArrayValueLabel;
        private System.Windows.Forms.Label maxArrayValueLabel;
        //private CustomTabControl mainMenuTabControl;
        private System.Windows.Forms.TabPage selectMethodForGettingAnArrayTabPage;
        private System.Windows.Forms.TabPage randomGenerationArrayTabPage;
        //private System.Windows.Forms.Button randomArrayGenerateButton;
        //private System.Windows.Forms.Button fromKeyboardInputArrayButton;
        //private System.Windows.Forms.Button fromFileArrayLoadingButton;
        //private System.Windows.Forms.Button fromDataBaseArrayLoadingButton;
        private CustomTabControl mainMenuTabControl;
        private System.Windows.Forms.Button fromDataBaseArrayLoadingButton;
        private System.Windows.Forms.Button fromFileArrayLoadingButton;
        private System.Windows.Forms.Button fromKeyboardInputArrayButton;
        private System.Windows.Forms.Button randomArrayGenerateButton;
        private System.Windows.Forms.ToolStripComboBox selectLanguageToolStripComboBox;
        private System.Windows.Forms.TabPage manuallyInputtingArrayTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmForManuallyInputingButton;
        private System.Windows.Forms.TextBox numberOfRowsInManuallyTextBox;
        private System.Windows.Forms.TextBox numberOfColumnsInManuallyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfColumnsTextBox;
        private System.Windows.Forms.TextBox numberOfRowsTextBox;
        private System.Windows.Forms.TextBox fieldForArrayTextBox;
        //private System.Windows.Forms.TabPage randomGenerationArrayTabPage;
    }
}

