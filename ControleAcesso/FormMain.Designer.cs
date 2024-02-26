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
            flowLayoutPanelAdminControls = new FlowLayoutPanel();
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
            buttonUserDetails = new Button();
            button1 = new Button();
            flowLayoutPanelUserRoles = new FlowLayoutPanel();
            flowLayoutPanelUserByRole = new FlowLayoutPanel();
            buttonAddRoleToUser = new Button();
            panelSidePanel.SuspendLayout();
            flowLayoutPanelAdminControls.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // panelSidePanel
            // 
            panelSidePanel.Controls.Add(flowLayoutPanelAdminControls);
            panelSidePanel.Controls.Add(flowLayoutPanel1);
            panelSidePanel.Controls.Add(panel1);
            panelSidePanel.Dock = DockStyle.Left;
            panelSidePanel.Location = new Point(0, 0);
            panelSidePanel.Margin = new Padding(3, 4, 3, 4);
            panelSidePanel.Name = "panelSidePanel";
            panelSidePanel.Size = new Size(167, 561);
            panelSidePanel.TabIndex = 0;
            // 
            // flowLayoutPanelAdminControls
            // 
            flowLayoutPanelAdminControls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelAdminControls.BackColor = Color.Salmon;
            flowLayoutPanelAdminControls.Controls.Add(button2);
            flowLayoutPanelAdminControls.Controls.Add(button3);
            flowLayoutPanelAdminControls.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelAdminControls.Location = new Point(3, 145);
            flowLayoutPanelAdminControls.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelAdminControls.Name = "flowLayoutPanelAdminControls";
            flowLayoutPanelAdminControls.Size = new Size(160, 340);
            flowLayoutPanelAdminControls.TabIndex = 2;
            flowLayoutPanelAdminControls.Visible = false;
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
            dataGridViewUsers.Size = new Size(229, 239);
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
            dataGridViewRoles.Size = new Size(229, 276);
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
            // buttonUserDetails
            // 
            buttonUserDetails.Location = new Point(701, 4);
            buttonUserDetails.Name = "buttonUserDetails";
            buttonUserDetails.Size = new Size(86, 31);
            buttonUserDetails.TabIndex = 7;
            buttonUserDetails.Text = "Roles v";
            buttonUserDetails.UseVisualStyleBackColor = true;
            buttonUserDetails.Click += buttonUserDetails_Click;
            // 
            // button1
            // 
            button1.Location = new Point(701, 275);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Users v";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelUserRoles
            // 
            flowLayoutPanelUserRoles.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelUserRoles.Location = new Point(701, 41);
            flowLayoutPanelUserRoles.Name = "flowLayoutPanelUserRoles";
            flowLayoutPanelUserRoles.Size = new Size(303, 202);
            flowLayoutPanelUserRoles.TabIndex = 9;
            // 
            // flowLayoutPanelUserByRole
            // 
            flowLayoutPanelUserByRole.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelUserByRole.Location = new Point(701, 312);
            flowLayoutPanelUserByRole.Name = "flowLayoutPanelUserByRole";
            flowLayoutPanelUserByRole.Size = new Size(303, 202);
            flowLayoutPanelUserByRole.TabIndex = 10;
            // 
            // buttonAddRoleToUser
            // 
            buttonAddRoleToUser.Location = new Point(339, 47);
            buttonAddRoleToUser.Margin = new Padding(3, 4, 3, 4);
            buttonAddRoleToUser.Name = "buttonAddRoleToUser";
            buttonAddRoleToUser.Size = new Size(121, 31);
            buttonAddRoleToUser.TabIndex = 11;
            buttonAddRoleToUser.Text = "Add Role to->";
            buttonAddRoleToUser.UseVisualStyleBackColor = true;
            buttonAddRoleToUser.Click += buttonAddRoleToUser_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 561);
            Controls.Add(buttonAddRoleToUser);
            Controls.Add(flowLayoutPanelUserByRole);
            Controls.Add(flowLayoutPanelUserRoles);
            Controls.Add(button1);
            Controls.Add(buttonUserDetails);
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
            Text = "Controle de usuários";
            Load += Form1_Load;
            Shown += Form1_Shown;
            panelSidePanel.ResumeLayout(false);
            flowLayoutPanelAdminControls.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidePanel;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelAdminControls;
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
        private Button buttonUserDetails;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanelUserRoles;
        private FlowLayoutPanel flowLayoutPanelUserByRole;
        private Button buttonAddRoleToUser;
    }
}