namespace Ranza_A_Randomizer_For_Everything_
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.G_ModeNumeric = new System.Windows.Forms.Panel();
            this.Generation = new System.Windows.Forms.Panel();
            this.Suffix = new System.Windows.Forms.Label();
            this.Choices = new System.Windows.Forms.ComboBox();
            this.Prefix = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Panel();
            this.Teaser = new System.Windows.Forms.Button();
            this.Complementary = new System.Windows.Forms.Button();
            this.Presentation = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.FileAccess = new System.Windows.Forms.Panel();
            this.O_ModeExport = new System.Windows.Forms.Panel();
            this.Signature = new System.Windows.Forms.Panel();
            this.Bernie = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Panel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.Description = new System.Windows.Forms.ToolTip(this.components);
            this.G_ModeName = new System.Windows.Forms.Panel();
            this.BernieName = new System.Windows.Forms.Label();
            this.Generation.SuspendLayout();
            this.Output.SuspendLayout();
            this.Signature.SuspendLayout();
            this.SuspendLayout();
            // 
            // G_ModeNumeric
            // 
            resources.ApplyResources(this.G_ModeNumeric, "G_ModeNumeric");
            this.G_ModeNumeric.Name = "G_ModeNumeric";
            // 
            // Generation
            // 
            this.Generation.Controls.Add(this.Suffix);
            this.Generation.Controls.Add(this.Choices);
            this.Generation.Controls.Add(this.Prefix);
            resources.ApplyResources(this.Generation, "Generation");
            this.Generation.Name = "Generation";
            // 
            // Suffix
            // 
            resources.ApplyResources(this.Suffix, "Suffix");
            this.Suffix.Name = "Suffix";
            // 
            // Choices
            // 
            this.Choices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Choices, "Choices");
            this.Choices.FormattingEnabled = true;
            this.Choices.Items.AddRange(new object[] {
            resources.GetString("Choices.Items"),
            resources.GetString("Choices.Items1"),
            resources.GetString("Choices.Items2"),
            resources.GetString("Choices.Items3"),
            resources.GetString("Choices.Items4"),
            resources.GetString("Choices.Items5"),
            resources.GetString("Choices.Items6"),
            resources.GetString("Choices.Items7"),
            resources.GetString("Choices.Items8"),
            resources.GetString("Choices.Items9")});
            this.Choices.Name = "Choices";
            // 
            // Prefix
            // 
            resources.ApplyResources(this.Prefix, "Prefix");
            this.Prefix.Name = "Prefix";
            // 
            // Output
            // 
            this.Output.Controls.Add(this.Teaser);
            this.Output.Controls.Add(this.Complementary);
            this.Output.Controls.Add(this.Presentation);
            this.Output.Controls.Add(this.Export);
            this.Output.Controls.Add(this.Display);
            resources.ApplyResources(this.Output, "Output");
            this.Output.Name = "Output";
            // 
            // Teaser
            // 
            resources.ApplyResources(this.Teaser, "Teaser");
            this.Teaser.Name = "Teaser";
            this.Teaser.UseVisualStyleBackColor = true;
            // 
            // Complementary
            // 
            resources.ApplyResources(this.Complementary, "Complementary");
            this.Complementary.Name = "Complementary";
            this.Complementary.UseVisualStyleBackColor = true;
            // 
            // Presentation
            // 
            resources.ApplyResources(this.Presentation, "Presentation");
            this.Presentation.Name = "Presentation";
            this.Presentation.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            resources.ApplyResources(this.Export, "Export");
            this.Export.Name = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            resources.ApplyResources(this.Display, "Display");
            this.Display.Name = "Display";
            // 
            // FileAccess
            // 
            resources.ApplyResources(this.FileAccess, "FileAccess");
            this.FileAccess.Name = "FileAccess";
            // 
            // O_ModeExport
            // 
            resources.ApplyResources(this.O_ModeExport, "O_ModeExport");
            this.O_ModeExport.Name = "O_ModeExport";
            // 
            // Signature
            // 
            this.Signature.BackColor = System.Drawing.SystemColors.Control;
            this.Signature.Controls.Add(this.BernieName);
            this.Signature.Controls.Add(this.Bernie);
            this.Signature.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.Signature, "Signature");
            this.Signature.Name = "Signature";
            // 
            // Bernie
            // 
            this.Bernie.BackColor = System.Drawing.Color.Transparent;
            this.Bernie.BackgroundImage = global::Ranza_A_Randomizer_For_Everything_.Properties.Resources.Avatar_Be;
            resources.ApplyResources(this.Bernie, "Bernie");
            this.Bernie.FlatAppearance.BorderSize = 0;
            this.Bernie.Name = "Bernie";
            this.Bernie.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // MenuBar
            // 
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // G_ModeName
            // 
            resources.ApplyResources(this.G_ModeName, "G_ModeName");
            this.G_ModeName.Name = "G_ModeName";
            // 
            // BernieName
            // 
            resources.ApplyResources(this.BernieName, "BernieName");
            this.BernieName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BernieName.Name = "BernieName";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ranza_A_Randomizer_For_Everything_.Properties.Resources.Ranza;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Signature);
            this.Controls.Add(this.O_ModeExport);
            this.Controls.Add(this.FileAccess);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.G_ModeNumeric);
            this.Controls.Add(this.G_ModeName);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Generation.ResumeLayout(false);
            this.Generation.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.Signature.ResumeLayout(false);
            this.Signature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G_ModeNumeric;
        private System.Windows.Forms.Panel Generation;
        private System.Windows.Forms.Panel Output;
        private System.Windows.Forms.Panel FileAccess;
        private System.Windows.Forms.Panel O_ModeExport;
        private System.Windows.Forms.Panel Signature;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolTip Description;
        private System.Windows.Forms.Label Prefix;
        private System.Windows.Forms.ComboBox Choices;
        private System.Windows.Forms.Label Suffix;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button Teaser;
        private System.Windows.Forms.Button Complementary;
        private System.Windows.Forms.Button Presentation;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Panel G_ModeName;
        private System.Windows.Forms.Button Bernie;
        private System.Windows.Forms.Label BernieName;
    }
}

