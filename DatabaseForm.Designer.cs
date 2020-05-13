namespace SOFT562Week18
{
    partial class FacebookDatabase
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
            this.dataGridViewFriendship = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessage = new System.Windows.Forms.DataGridView();
            this.comboBoxQueryChoice = new System.Windows.Forms.ComboBox();
            this.dataGridViewEducation = new System.Windows.Forms.DataGridView();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessageDatabase = new System.Windows.Forms.DataGridView();
            this.dataGridViewWorkplace = new System.Windows.Forms.DataGridView();
            this.UsersText = new System.Windows.Forms.Label();
            this.friendshipText = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.Label();
            this.messageDatabaseText = new System.Windows.Forms.Label();
            this.workplace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessageDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFriendship
            // 
            this.dataGridViewFriendship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendship.Location = new System.Drawing.Point(11, 358);
            this.dataGridViewFriendship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFriendship.Name = "dataGridViewFriendship";
            this.dataGridViewFriendship.RowHeadersWidth = 51;
            this.dataGridViewFriendship.RowTemplate.Height = 24;
            this.dataGridViewFriendship.Size = new System.Drawing.Size(238, 301);
            this.dataGridViewFriendship.TabIndex = 0;
            // 
            // dataGridViewMessage
            // 
            this.dataGridViewMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessage.Location = new System.Drawing.Point(280, 25);
            this.dataGridViewMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMessage.Name = "dataGridViewMessage";
            this.dataGridViewMessage.RowHeadersWidth = 51;
            this.dataGridViewMessage.RowTemplate.Height = 24;
            this.dataGridViewMessage.Size = new System.Drawing.Size(238, 301);
            this.dataGridViewMessage.TabIndex = 1;
            this.dataGridViewMessage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // comboBoxQueryChoice
            // 
            this.comboBoxQueryChoice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQueryChoice.FormattingEnabled = true;
            this.comboBoxQueryChoice.Items.AddRange(new object[] {
            "Users",
            "Friendships",
            "Message",
            "Message Database",
            "Education",
            "Workplace"});
            this.comboBoxQueryChoice.Location = new System.Drawing.Point(11, 688);
            this.comboBoxQueryChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxQueryChoice.Name = "comboBoxQueryChoice";
            this.comboBoxQueryChoice.Size = new System.Drawing.Size(462, 29);
            this.comboBoxQueryChoice.TabIndex = 2;
            this.comboBoxQueryChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueryChoice_SelectedIndexChanged);
            // 
            // dataGridViewEducation
            // 
            this.dataGridViewEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEducation.Location = new System.Drawing.Point(554, 25);
            this.dataGridViewEducation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEducation.Name = "dataGridViewEducation";
            this.dataGridViewEducation.RowHeadersWidth = 51;
            this.dataGridViewEducation.RowTemplate.Height = 24;
            this.dataGridViewEducation.Size = new System.Drawing.Size(238, 301);
            this.dataGridViewEducation.TabIndex = 3;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(238, 301);
            this.dataGridViewUser.TabIndex = 4;
            // 
            // dataGridViewMessageDatabase
            // 
            this.dataGridViewMessageDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessageDatabase.Location = new System.Drawing.Point(281, 358);
            this.dataGridViewMessageDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMessageDatabase.Name = "dataGridViewMessageDatabase";
            this.dataGridViewMessageDatabase.RowHeadersWidth = 51;
            this.dataGridViewMessageDatabase.RowTemplate.Height = 24;
            this.dataGridViewMessageDatabase.Size = new System.Drawing.Size(238, 301);
            this.dataGridViewMessageDatabase.TabIndex = 5;
            // 
            // dataGridViewWorkplace
            // 
            this.dataGridViewWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkplace.Location = new System.Drawing.Point(554, 358);
            this.dataGridViewWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewWorkplace.Name = "dataGridViewWorkplace";
            this.dataGridViewWorkplace.RowHeadersWidth = 51;
            this.dataGridViewWorkplace.RowTemplate.Height = 24;
            this.dataGridViewWorkplace.Size = new System.Drawing.Size(238, 301);
            this.dataGridViewWorkplace.TabIndex = 6;
            // 
            // UsersText
            // 
            this.UsersText.AutoSize = true;
            this.UsersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersText.Location = new System.Drawing.Point(13, 328);
            this.UsersText.Name = "UsersText";
            this.UsersText.Size = new System.Drawing.Size(80, 25);
            this.UsersText.TabIndex = 7;
            this.UsersText.Text = "USERS";
            this.UsersText.Click += new System.EventHandler(this.label1_Click);
            // 
            // friendshipText
            // 
            this.friendshipText.AutoSize = true;
            this.friendshipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendshipText.Location = new System.Drawing.Point(13, 661);
            this.friendshipText.Name = "friendshipText";
            this.friendshipText.Size = new System.Drawing.Size(143, 25);
            this.friendshipText.TabIndex = 8;
            this.friendshipText.Text = "FRIENDSHIPS";
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.Location = new System.Drawing.Point(276, 328);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(112, 25);
            this.messageText.TabIndex = 9;
            this.messageText.Text = "MESSAGE";
            // 
            // messageDatabaseText
            // 
            this.messageDatabaseText.AutoSize = true;
            this.messageDatabaseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageDatabaseText.Location = new System.Drawing.Point(276, 661);
            this.messageDatabaseText.Name = "messageDatabaseText";
            this.messageDatabaseText.Size = new System.Drawing.Size(226, 25);
            this.messageDatabaseText.TabIndex = 10;
            this.messageDatabaseText.Text = "MESSAGE DATABASE";
            // 
            // workplace
            // 
            this.workplace.AutoSize = true;
            this.workplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workplace.Location = new System.Drawing.Point(559, 332);
            this.workplace.Name = "workplace";
            this.workplace.Size = new System.Drawing.Size(130, 25);
            this.workplace.TabIndex = 11;
            this.workplace.Text = "EDUCATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "WORKPLACE";
            // 
            // FacebookDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 804);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workplace);
            this.Controls.Add(this.messageDatabaseText);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.friendshipText);
            this.Controls.Add(this.UsersText);
            this.Controls.Add(this.dataGridViewWorkplace);
            this.Controls.Add(this.comboBoxQueryChoice);
            this.Controls.Add(this.dataGridViewMessageDatabase);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.dataGridViewEducation);
            this.Controls.Add(this.dataGridViewMessage);
            this.Controls.Add(this.dataGridViewFriendship);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FacebookDatabase";
            this.Text = "Facebook Database";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessageDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFriendship;
        private System.Windows.Forms.DataGridView dataGridViewMessage;
        private System.Windows.Forms.ComboBox comboBoxQueryChoice;
        private System.Windows.Forms.DataGridView dataGridViewEducation;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridView dataGridViewMessageDatabase;
        private System.Windows.Forms.DataGridView dataGridViewWorkplace;
        private System.Windows.Forms.Label UsersText;
        private System.Windows.Forms.Label friendshipText;
        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.Label messageDatabaseText;
        private System.Windows.Forms.Label workplace;
        private System.Windows.Forms.Label label1;
    }
}

