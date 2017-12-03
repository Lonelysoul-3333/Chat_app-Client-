namespace View {
    partial class Main_Screen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing){
            if (disposing && (components != null)){
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.program_title = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.TableLayoutPanel();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // program_title
            // 
            this.program_title.AutoEllipsis = true;
            this.program_title.AutoSize = true;
            this.program_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program_title.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_title.Location = new System.Drawing.Point(65, 16);
            this.program_title.Name = "program_title";
            this.program_title.Size = new System.Drawing.Size(283, 57);
            this.program_title.TabIndex = 0;
            this.program_title.Text = "Chat App";
            this.program_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.register_button.Location = new System.Drawing.Point(65, 92);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(283, 51);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.AutoSize = true;
            this.login_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.login_button.Location = new System.Drawing.Point(65, 165);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(283, 51);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_panel.ColumnCount = 3;
            this.main_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.main_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.main_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.main_panel.Controls.Add(this.register_button, 1, 3);
            this.main_panel.Controls.Add(this.login_button, 1, 5);
            this.main_panel.Controls.Add(this.program_title, 1, 1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.RowCount = 7;
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.Size = new System.Drawing.Size(414, 239);
            this.main_panel.TabIndex = 3;
            this.main_panel.TabStop = true;
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(414, 239);
            this.Controls.Add(this.main_panel);
            this.Name = "Main_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Chatting System";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label program_title;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TableLayoutPanel main_panel;
    }
}

