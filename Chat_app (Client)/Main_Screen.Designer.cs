using System.Windows.Forms;

namespace View {
    partial class Main_Screen {

        // Custom variables declaration:
        private bool event_handler_added_to_main_page;
        private bool event_handler_added_to_register_gui;

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
            this.panels_stack = new System.Windows.Forms.TabControl();
            this.main_page = new System.Windows.Forms.TabPage();
            this.main_panel = new System.Windows.Forms.TableLayoutPanel();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.program_title = new System.Windows.Forms.Label();
            this.register_gui = new System.Windows.Forms.TabPage();
            this.register_panel = new System.Windows.Forms.TableLayoutPanel();
            this.full_user_name_label = new System.Windows.Forms.Label();
            this.user_account_id_label_0 = new System.Windows.Forms.Label();
            this.user_account_password_label_0 = new System.Windows.Forms.Label();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.full_user_name_field = new System.Windows.Forms.TextBox();
            this.user_account_id_field_0 = new System.Windows.Forms.TextBox();
            this.user_account_password_field_0 = new System.Windows.Forms.TextBox();
            this.confirm_password_field = new System.Windows.Forms.TextBox();
            this.submit_and_cancel_buttons_panel = new System.Windows.Forms.TableLayoutPanel();
            this.submit_register_button = new System.Windows.Forms.Button();
            this.cancel_register_button = new System.Windows.Forms.Button();
            this.login_gui = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.user_account_id_label_1 = new System.Windows.Forms.Label();
            this.user_account_password_label_1 = new System.Windows.Forms.Label();
            this.user_account_id_field_1 = new System.Windows.Forms.TextBox();
            this.user_account_password_field_1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.submit_login_button = new System.Windows.Forms.Button();
            this.cancel_login_button = new System.Windows.Forms.Button();
            this.panels_stack.SuspendLayout();
            this.main_page.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.register_gui.SuspendLayout();
            this.register_panel.SuspendLayout();
            this.submit_and_cancel_buttons_panel.SuspendLayout();
            this.login_gui.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panels_stack
            // 
            this.panels_stack.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.panels_stack.Controls.Add(this.main_page);
            this.panels_stack.Controls.Add(this.register_gui);
            this.panels_stack.Controls.Add(this.login_gui);
            this.panels_stack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panels_stack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panels_stack.ItemSize = new System.Drawing.Size(1, 1);
            this.panels_stack.Location = new System.Drawing.Point(0, 0);
            this.panels_stack.Name = "panels_stack";
            this.panels_stack.SelectedIndex = 0;
            this.panels_stack.Size = new System.Drawing.Size(425, 262);
            this.panels_stack.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.panels_stack.TabIndex = 4;
            this.panels_stack.TabStop = false;
            // 
            // main_page
            // 
            this.main_page.Controls.Add(this.main_panel);
            this.main_page.Location = new System.Drawing.Point(4, 5);
            this.main_page.Name = "main_page";
            this.main_page.Padding = new System.Windows.Forms.Padding(3);
            this.main_page.Size = new System.Drawing.Size(417, 253);
            this.main_page.TabIndex = 0;
            this.main_page.Text = "page_1";
            this.main_page.UseVisualStyleBackColor = true;
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
            this.main_panel.Location = new System.Drawing.Point(3, 3);
            this.main_panel.Name = "main_panel";
            this.main_panel.RowCount = 7;
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.main_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.main_panel.Size = new System.Drawing.Size(411, 247);
            this.main_panel.TabIndex = 4;
            this.main_panel.TabStop = true;
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.register_button.Location = new System.Drawing.Point(64, 96);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(281, 53);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.AutoSize = true;
            this.login_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.login_button.Location = new System.Drawing.Point(64, 172);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(281, 53);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // program_title
            // 
            this.program_title.AutoEllipsis = true;
            this.program_title.AutoSize = true;
            this.program_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program_title.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_title.Location = new System.Drawing.Point(64, 17);
            this.program_title.Name = "program_title";
            this.program_title.Size = new System.Drawing.Size(281, 59);
            this.program_title.TabIndex = 0;
            this.program_title.Text = "Chat App";
            this.program_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_gui
            // 
            this.register_gui.Controls.Add(this.register_panel);
            this.register_gui.Location = new System.Drawing.Point(4, 5);
            this.register_gui.Name = "register_gui";
            this.register_gui.Padding = new System.Windows.Forms.Padding(3);
            this.register_gui.Size = new System.Drawing.Size(417, 253);
            this.register_gui.TabIndex = 1;
            this.register_gui.Text = "page_2";
            this.register_gui.UseVisualStyleBackColor = true;
            // 
            // register_panel
            // 
            this.register_panel.ColumnCount = 3;
            this.register_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.75F));
            this.register_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.596107F));
            this.register_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.74453F));
            this.register_panel.Controls.Add(this.full_user_name_label, 0, 1);
            this.register_panel.Controls.Add(this.user_account_id_label_0, 0, 3);
            this.register_panel.Controls.Add(this.user_account_password_label_0, 0, 5);
            this.register_panel.Controls.Add(this.confirm_password_label, 0, 7);
            this.register_panel.Controls.Add(this.full_user_name_field, 2, 1);
            this.register_panel.Controls.Add(this.user_account_id_field_0, 2, 3);
            this.register_panel.Controls.Add(this.user_account_password_field_0, 2, 5);
            this.register_panel.Controls.Add(this.confirm_password_field, 2, 7);
            this.register_panel.Controls.Add(this.submit_and_cancel_buttons_panel, 2, 9);
            this.register_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register_panel.Location = new System.Drawing.Point(3, 3);
            this.register_panel.Name = "register_panel";
            this.register_panel.RowCount = 11;
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.910714F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51786F));
            this.register_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.803571F));
            this.register_panel.Size = new System.Drawing.Size(411, 247);
            this.register_panel.TabIndex = 0;
            // 
            // full_user_name_label
            // 
            this.full_user_name_label.AutoSize = true;
            this.full_user_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.full_user_name_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.full_user_name_label.Location = new System.Drawing.Point(3, 22);
            this.full_user_name_label.Name = "full_user_name_label";
            this.full_user_name_label.Size = new System.Drawing.Size(157, 22);
            this.full_user_name_label.TabIndex = 0;
            this.full_user_name_label.Text = "Full name:";
            this.full_user_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user_account_id_label_0
            // 
            this.user_account_id_label_0.AutoSize = true;
            this.user_account_id_label_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_account_id_label_0.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_id_label_0.Location = new System.Drawing.Point(3, 66);
            this.user_account_id_label_0.Name = "user_account_id_label_0";
            this.user_account_id_label_0.Size = new System.Drawing.Size(157, 22);
            this.user_account_id_label_0.TabIndex = 1;
            this.user_account_id_label_0.Text = "Login:";
            this.user_account_id_label_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user_account_password_label_0
            // 
            this.user_account_password_label_0.AutoSize = true;
            this.user_account_password_label_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_account_password_label_0.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_password_label_0.Location = new System.Drawing.Point(3, 110);
            this.user_account_password_label_0.Name = "user_account_password_label_0";
            this.user_account_password_label_0.Size = new System.Drawing.Size(157, 22);
            this.user_account_password_label_0.TabIndex = 2;
            this.user_account_password_label_0.Text = "Password:";
            this.user_account_password_label_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirm_password_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.confirm_password_label.Location = new System.Drawing.Point(3, 154);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(157, 22);
            this.confirm_password_label.TabIndex = 3;
            this.confirm_password_label.Text = "Re-Type password:";
            this.confirm_password_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // full_user_name_field
            // 
            this.full_user_name_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.full_user_name_field.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.full_user_name_field.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.full_user_name_field.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.full_user_name_field.Location = new System.Drawing.Point(188, 25);
            this.full_user_name_field.Name = "full_user_name_field";
            this.full_user_name_field.Size = new System.Drawing.Size(193, 23);
            this.full_user_name_field.TabIndex = 4;
            // 
            // user_account_id_field_0
            // 
            this.user_account_id_field_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.user_account_id_field_0.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.user_account_id_field_0.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.user_account_id_field_0.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_id_field_0.Location = new System.Drawing.Point(188, 69);
            this.user_account_id_field_0.Name = "user_account_id_field_0";
            this.user_account_id_field_0.Size = new System.Drawing.Size(155, 23);
            this.user_account_id_field_0.TabIndex = 5;
            // 
            // user_account_password_field_0
            // 
            this.user_account_password_field_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.user_account_password_field_0.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_password_field_0.Location = new System.Drawing.Point(188, 113);
            this.user_account_password_field_0.Name = "user_account_password_field_0";
            this.user_account_password_field_0.Size = new System.Drawing.Size(155, 23);
            this.user_account_password_field_0.TabIndex = 6;
            this.user_account_password_field_0.UseSystemPasswordChar = true;
            // 
            // confirm_password_field
            // 
            this.confirm_password_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confirm_password_field.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.confirm_password_field.Location = new System.Drawing.Point(188, 157);
            this.confirm_password_field.Name = "confirm_password_field";
            this.confirm_password_field.Size = new System.Drawing.Size(155, 23);
            this.confirm_password_field.TabIndex = 7;
            this.confirm_password_field.UseSystemPasswordChar = true;
            // 
            // submit_and_cancel_buttons_panel
            // 
            this.submit_and_cancel_buttons_panel.ColumnCount = 2;
            this.submit_and_cancel_buttons_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.80952F));
            this.submit_and_cancel_buttons_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.19048F));
            this.submit_and_cancel_buttons_panel.Controls.Add(this.submit_register_button, 0, 0);
            this.submit_and_cancel_buttons_panel.Controls.Add(this.cancel_register_button, 1, 0);
            this.submit_and_cancel_buttons_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit_and_cancel_buttons_panel.Location = new System.Drawing.Point(188, 191);
            this.submit_and_cancel_buttons_panel.Name = "submit_and_cancel_buttons_panel";
            this.submit_and_cancel_buttons_panel.RowCount = 1;
            this.submit_and_cancel_buttons_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.submit_and_cancel_buttons_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.submit_and_cancel_buttons_panel.Size = new System.Drawing.Size(220, 34);
            this.submit_and_cancel_buttons_panel.TabIndex = 8;
            // 
            // submit_register_button
            // 
            this.submit_register_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.submit_register_button.Location = new System.Drawing.Point(3, 3);
            this.submit_register_button.Name = "submit_register_button";
            this.submit_register_button.Size = new System.Drawing.Size(75, 28);
            this.submit_register_button.TabIndex = 0;
            this.submit_register_button.Text = "Register";
            this.submit_register_button.UseVisualStyleBackColor = true;
            // 
            // cancel_register_button
            // 
            this.cancel_register_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_register_button.Location = new System.Drawing.Point(99, 3);
            this.cancel_register_button.Name = "cancel_register_button";
            this.cancel_register_button.Size = new System.Drawing.Size(70, 28);
            this.cancel_register_button.TabIndex = 1;
            this.cancel_register_button.Text = "Cancel";
            this.cancel_register_button.UseVisualStyleBackColor = true;
            // 
            // login_gui
            // 
            this.login_gui.Controls.Add(this.tableLayoutPanel1);
            this.login_gui.Location = new System.Drawing.Point(4, 5);
            this.login_gui.Name = "login_gui";
            this.login_gui.Padding = new System.Windows.Forms.Padding(3);
            this.login_gui.Size = new System.Drawing.Size(417, 253);
            this.login_gui.TabIndex = 2;
            this.login_gui.Text = "page_3";
            this.login_gui.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.326034F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.99027F));
            this.tableLayoutPanel1.Controls.Add(this.user_account_id_label_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.user_account_password_label_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.user_account_id_field_1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.user_account_password_field_1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.93117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95547F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.59919F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53036F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // user_account_id_label_1
            // 
            this.user_account_id_label_1.AutoSize = true;
            this.user_account_id_label_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_account_id_label_1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_id_label_1.Location = new System.Drawing.Point(3, 26);
            this.user_account_id_label_1.Name = "user_account_id_label_1";
            this.user_account_id_label_1.Size = new System.Drawing.Size(116, 28);
            this.user_account_id_label_1.TabIndex = 0;
            this.user_account_id_label_1.Text = "Login:";
            this.user_account_id_label_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user_account_password_label_1
            // 
            this.user_account_password_label_1.AutoSize = true;
            this.user_account_password_label_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_account_password_label_1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_password_label_1.Location = new System.Drawing.Point(3, 79);
            this.user_account_password_label_1.Name = "user_account_password_label_1";
            this.user_account_password_label_1.Size = new System.Drawing.Size(116, 28);
            this.user_account_password_label_1.TabIndex = 1;
            this.user_account_password_label_1.Text = "Password:";
            this.user_account_password_label_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user_account_id_field_1
            // 
            this.user_account_id_field_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.user_account_id_field_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.user_account_id_field_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.user_account_id_field_1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_id_field_1.Location = new System.Drawing.Point(151, 29);
            this.user_account_id_field_1.Name = "user_account_id_field_1";
            this.user_account_id_field_1.Size = new System.Drawing.Size(230, 23);
            this.user_account_id_field_1.TabIndex = 2;
            // 
            // user_account_password_field_1
            // 
            this.user_account_password_field_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.user_account_password_field_1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user_account_password_field_1.Location = new System.Drawing.Point(151, 82);
            this.user_account_password_field_1.Name = "user_account_password_field_1";
            this.user_account_password_field_1.Size = new System.Drawing.Size(230, 23);
            this.user_account_password_field_1.TabIndex = 3;
            this.user_account_password_field_1.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.16327F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.83673F));
            this.tableLayoutPanel2.Controls.Add(this.submit_login_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancel_login_button, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(151, 141);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // submit_login_button
            // 
            this.submit_login_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.submit_login_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.submit_login_button.Location = new System.Drawing.Point(3, 3);
            this.submit_login_button.Name = "submit_login_button";
            this.submit_login_button.Size = new System.Drawing.Size(75, 28);
            this.submit_login_button.TabIndex = 0;
            this.submit_login_button.Text = "Login";
            this.submit_login_button.UseVisualStyleBackColor = true;
            // 
            // cancel_login_button
            // 
            this.cancel_login_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_login_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cancel_login_button.Location = new System.Drawing.Point(126, 3);
            this.cancel_login_button.Name = "cancel_login_button";
            this.cancel_login_button.Size = new System.Drawing.Size(75, 28);
            this.cancel_login_button.TabIndex = 1;
            this.cancel_login_button.Text = "Cancel";
            this.cancel_login_button.UseVisualStyleBackColor = true;
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(425, 262);
            this.Controls.Add(this.panels_stack);
            this.Name = "Main_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Chatting System";
            this.panels_stack.ResumeLayout(false);
            this.main_page.ResumeLayout(false);
            this.main_page.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.register_gui.ResumeLayout(false);
            this.register_panel.ResumeLayout(false);
            this.register_panel.PerformLayout();
            this.submit_and_cancel_buttons_panel.ResumeLayout(false);
            this.login_gui.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Variables declaration:
        private System.Windows.Forms.TabControl panels_stack;
        private System.Windows.Forms.TabPage main_page;
        private System.Windows.Forms.TableLayoutPanel main_panel;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label program_title;
        private System.Windows.Forms.TabPage register_gui;
        private System.Windows.Forms.TableLayoutPanel register_panel;
        private System.Windows.Forms.Label full_user_name_label;
        private System.Windows.Forms.Label user_account_id_label_0;
        private System.Windows.Forms.Label user_account_password_label_0;
        private System.Windows.Forms.Label confirm_password_label;
        private System.Windows.Forms.TextBox full_user_name_field;
        private System.Windows.Forms.TextBox user_account_id_field_0;
        private System.Windows.Forms.TextBox user_account_password_field_0;
        private System.Windows.Forms.TextBox confirm_password_field;
        private System.Windows.Forms.TableLayoutPanel submit_and_cancel_buttons_panel;
        private System.Windows.Forms.Button submit_register_button;
        private System.Windows.Forms.Button cancel_register_button;
        private TabPage login_gui;
        private TableLayoutPanel tableLayoutPanel1;
        private Label user_account_id_label_1;
        private Label user_account_password_label_1;
        private TextBox user_account_id_field_1;
        private TextBox user_account_password_field_1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button submit_login_button;
        private Button cancel_login_button;

        // Getters and setters:
        internal TabControl Panels_stack {
            get => panels_stack;
            set => panels_stack = value;
        }

        internal TabPage Register_gui {
            get => register_gui;
            set => register_gui = value;
        }

        internal Button Register_button {
            get => register_button;
            set => register_button = value;
        }

        internal TabPage Main_page {
            get => main_page;
            set => main_page = value;
        }

        internal bool Event_handler_added_to_main_page {
            get => event_handler_added_to_main_page;
            set => event_handler_added_to_main_page = value;
        }

        public TabPage Login_gui {
            get => login_gui;
            set => login_gui = value;
        }

        public Button Login_button {
            get => login_button;
            set => login_button = value;
        }

        public bool Event_handler_added_to_register_gui {
            get => event_handler_added_to_register_gui;
            set => event_handler_added_to_register_gui = value;
        }
    }
}

