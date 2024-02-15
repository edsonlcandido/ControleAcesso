namespace ControleAcesso
{
    partial class FormMain
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
            panelSidePanel = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonShowRolesUser = new Button();
            panel1 = new Panel();
            dataGridViewUsers = new DataGridView();
            dataGridViewRoles = new DataGridView();
            buttonAddUser = new Button();
            textBoxAddUser = new TextBox();
            textBoxAddRole = new TextBox();
            buttonAddRole = new Button();
            panelSidePanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // panelSidePanel
            // 
            panelSidePanel.Controls.Add(flowLayoutPanel2);
            panelSidePanel.Controls.Add(flowLayoutPanel1);
            panelSidePanel.Controls.Add(panel1);
            panelSidePanel.Dock = DockStyle.Left;
            panelSidePanel.Location = new Point(0, 0);
            panelSidePanel.Margin = new Padding(3, 4, 3, 4);
            panelSidePanel.Name = "panelSidePanel";
            panelSidePanel.Size = new Size(167, 561);
            panelSidePanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.BackColor = Color.Salmon;
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 145);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(160, 340);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(3, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 43);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Bisque;
            flowLayoutPanel1.Controls.Add(buttonShowRolesUser);
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(160, 133);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonShowRolesUser
            // 
            buttonShowRolesUser.Location = new Point(3, 4);
            buttonShowRolesUser.Margin = new Padding(3, 4, 3, 4);
            buttonShowRolesUser.Name = "buttonShowRolesUser";
            buttonShowRolesUser.Size = new Size(86, 31);
            buttonShowRolesUser.TabIndex = 0;
            buttonShowRolesUser.Text = "button1";
            buttonShowRolesUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(3, 493);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 64);
            panel1.TabIndex = 0;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(466, 4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.Size = new Size(306, 239);
            dataGridViewUsers.TabIndex = 1;
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.AllowUserToAddRows = false;
            dataGridViewRoles.AllowUserToDeleteRows = false;
            dataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Location = new Point(466, 273);
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.ReadOnly = true;
            dataGridViewRoles.RowTemplate.Height = 25;
            dataGridViewRoles.Size = new Size(306, 276);
            dataGridViewRoles.TabIndex = 2;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(374, 8);
            buttonAddUser.Margin = new Padding(3, 4, 3, 4);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(86, 31);
            buttonAddUser.TabIndex = 3;
            buttonAddUser.Text = "Add user";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // textBoxAddUser
            // 
            textBoxAddUser.Location = new Point(173, 10);
            textBoxAddUser.Name = "textBoxAddUser";
            textBoxAddUser.Size = new Size(195, 27);
            textBoxAddUser.TabIndex = 4;
            // 
            // textBoxAddRole
            // 
            textBoxAddRole.Location = new Point(173, 275);
            textBoxAddRole.Name = "textBoxAddRole";
            textBoxAddRole.Size = new Size(195, 27);
            textBoxAddRole.TabIndex = 6;
            // 
            // buttonAddRole
            // 
            buttonAddRole.Location = new Point(374, 273);
            buttonAddRole.Margin = new Padding(3, 4, 3, 4);
            buttonAddRole.Name = "buttonAddRole";
            buttonAddRole.Size = new Size(86, 31);
            buttonAddRole.TabIndex = 5;
            buttonAddRole.Text = "Add role";
            buttonAddRole.UseVisualStyleBackColor = true;
            buttonAddRole.Click += buttonAddRole_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 561);
            Controls.Add(textBoxAddRole);
            Controls.Add(buttonAddRole);
            Controls.Add(textBoxAddUser);
            Controls.Add(buttonAddUser);
            Controls.Add(dataGridViewRoles);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panelSidePanel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            panelSidePanel.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidePanel;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button buttonShowRolesUser;
        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewRoles;
        private Button buttonAddUser;
        private TextBox textBoxAddUser;
        private TextBox textBoxAddRole;
        private Button buttonAddRole;
    }
}