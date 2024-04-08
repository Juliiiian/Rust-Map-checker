namespace Rust_Map_checker
{
    partial class Selection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            file_select = new Button();
            file_name = new Label();
            checking_progress = new ProgressBar();
            label2 = new Label();
            result = new Label();
            maps = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // file_select
            // 
            file_select.Location = new Point(11, 47);
            file_select.Name = "file_select";
            file_select.Size = new Size(75, 23);
            file_select.TabIndex = 1;
            file_select.Text = "Select file";
            file_select.UseVisualStyleBackColor = true;
            file_select.Click += file_select_Click;
            // 
            // file_name
            // 
            file_name.AutoSize = true;
            file_name.Location = new Point(92, 51);
            file_name.Name = "file_name";
            file_name.Size = new Size(0, 15);
            file_name.TabIndex = 2;
            file_name.Click += file_name_Click;
            // 
            // checking_progress
            // 
            checking_progress.Location = new Point(12, 79);
            checking_progress.Name = "checking_progress";
            checking_progress.Size = new Size(776, 23);
            checking_progress.TabIndex = 3;
            checking_progress.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(252, 15);
            label2.TabIndex = 4;
            label2.Text = "Select a file to check it with the RustWorld.SDK";
            label2.Click += label2_Click_1;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(11, 121);
            result.Name = "result";
            result.Size = new Size(42, 15);
            result.TabIndex = 5;
            result.Text = "Result:";
            result.Click += result_Click;
            // 
            // maps
            // 
            maps.AutoSize = true;
            maps.Location = new Point(12, 152);
            maps.Name = "maps";
            maps.Size = new Size(39, 15);
            maps.TabIndex = 6;
            maps.Text = "Maps:";
            maps.Click += maps_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maps);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(checking_progress);
            Controls.Add(file_name);
            Controls.Add(file_select);
            Controls.Add(button1);
            Name = "Selection";
            Text = "Rust Map checker";
            Load += Selection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button file_select;
        private Label file_name;
        private ProgressBar checking_progress;
        private Label label2;
        private Label result;
        private Label maps;
    }
}