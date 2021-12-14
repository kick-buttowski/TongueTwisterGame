namespace ToungeTwisterGames
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaderBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.Button();
            this.namePicker = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.randomTwister = new System.Windows.Forms.Button();
            this.twisterLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetLeaderBoard = new System.Windows.Forms.Button();
            this.resetBoard = new System.Windows.Forms.Button();
            this.addParticipants = new System.Windows.Forms.Button();
            this.addTwisters = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.leaderBoard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 783);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.leaderBoard);
            this.panel1.Controls.Add(this.panelName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(776, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 783);
            this.panel1.TabIndex = 1;
            // 
            // leaderBoard
            // 
            this.leaderBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.leaderBoard.Controls.Add(this.button3);
            this.leaderBoard.Controls.Add(this.tableLayoutPanel1);
            this.leaderBoard.Location = new System.Drawing.Point(10, 285);
            this.leaderBoard.Name = "leaderBoard";
            this.leaderBoard.Size = new System.Drawing.Size(690, 488);
            this.leaderBoard.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(690, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Leader Board";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.31818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.68182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rankLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 440);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(472, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Before Twisted";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankLabel
            // 
            this.rankLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rankLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rankLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rankLabel.Location = new System.Drawing.Point(1, 1);
            this.rankLabel.Margin = new System.Windows.Forms.Padding(0);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(90, 48);
            this.rankLabel.TabIndex = 0;
            this.rankLabel.Text = "Rank";
            this.rankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panelName.Controls.Add(this.nameBox);
            this.panelName.Controls.Add(this.namePicker);
            this.panelName.Location = new System.Drawing.Point(10, 210);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(690, 42);
            this.panelName.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameBox.FlatAppearance.BorderSize = 0;
            this.nameBox.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameBox.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(184, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(503, 34);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameBox.UseVisualStyleBackColor = false;
            // 
            // namePicker
            // 
            this.namePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.namePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.namePicker.FlatAppearance.BorderSize = 0;
            this.namePicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.namePicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.namePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namePicker.Location = new System.Drawing.Point(4, 3);
            this.namePicker.Name = "namePicker";
            this.namePicker.Size = new System.Drawing.Size(178, 35);
            this.namePicker.TabIndex = 1;
            this.namePicker.Text = "Name Picker";
            this.namePicker.UseVisualStyleBackColor = false;
            this.namePicker.Click += new System.EventHandler(this.namePicker_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.randomTwister);
            this.panel2.Controls.Add(this.twisterLabel);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 173);
            this.panel2.TabIndex = 1;
            // 
            // randomTwister
            // 
            this.randomTwister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.randomTwister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomTwister.FlatAppearance.BorderSize = 0;
            this.randomTwister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.randomTwister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.randomTwister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomTwister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.randomTwister.Location = new System.Drawing.Point(4, 4);
            this.randomTwister.Name = "randomTwister";
            this.randomTwister.Size = new System.Drawing.Size(178, 35);
            this.randomTwister.TabIndex = 1;
            this.randomTwister.Text = "Random Twister";
            this.randomTwister.UseVisualStyleBackColor = false;
            this.randomTwister.Click += new System.EventHandler(this.randomTwister_Click);
            // 
            // twisterLabel
            // 
            this.twisterLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.twisterLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twisterLabel.Location = new System.Drawing.Point(5, 43);
            this.twisterLabel.Margin = new System.Windows.Forms.Padding(0);
            this.twisterLabel.Name = "twisterLabel";
            this.twisterLabel.Size = new System.Drawing.Size(680, 125);
            this.twisterLabel.TabIndex = 0;
            this.twisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1442, -10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1389, -20);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "🗕";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetLeaderBoard
            // 
            this.resetLeaderBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resetLeaderBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetLeaderBoard.FlatAppearance.BorderSize = 0;
            this.resetLeaderBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resetLeaderBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resetLeaderBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetLeaderBoard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetLeaderBoard.Location = new System.Drawing.Point(10, -3);
            this.resetLeaderBoard.Name = "resetLeaderBoard";
            this.resetLeaderBoard.Size = new System.Drawing.Size(377, 33);
            this.resetLeaderBoard.TabIndex = 2;
            this.resetLeaderBoard.Text = "Reset Entries";
            this.resetLeaderBoard.UseVisualStyleBackColor = false;
            this.resetLeaderBoard.Click += new System.EventHandler(this.resetLeaderBoard_Click);
            // 
            // resetBoard
            // 
            this.resetBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resetBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBoard.FlatAppearance.BorderSize = 0;
            this.resetBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resetBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.resetBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBoard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBoard.Location = new System.Drawing.Point(393, -3);
            this.resetBoard.Name = "resetBoard";
            this.resetBoard.Size = new System.Drawing.Size(377, 33);
            this.resetBoard.TabIndex = 3;
            this.resetBoard.Text = "Reset Leader Board and Entries";
            this.resetBoard.UseVisualStyleBackColor = false;
            this.resetBoard.Click += new System.EventHandler(this.button4_Click);
            // 
            // addParticipants
            // 
            this.addParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addParticipants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addParticipants.FlatAppearance.BorderSize = 0;
            this.addParticipants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addParticipants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addParticipants.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addParticipants.Location = new System.Drawing.Point(776, -3);
            this.addParticipants.Name = "addParticipants";
            this.addParticipants.Size = new System.Drawing.Size(302, 33);
            this.addParticipants.TabIndex = 4;
            this.addParticipants.Text = "Add Participants";
            this.addParticipants.UseVisualStyleBackColor = false;
            this.addParticipants.Click += new System.EventHandler(this.addParticipants_Click);
            // 
            // addTwisters
            // 
            this.addTwisters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTwisters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTwisters.FlatAppearance.BorderSize = 0;
            this.addTwisters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTwisters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTwisters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTwisters.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTwisters.Location = new System.Drawing.Point(1084, -3);
            this.addTwisters.Name = "addTwisters";
            this.addTwisters.Size = new System.Drawing.Size(302, 33);
            this.addTwisters.TabIndex = 5;
            this.addTwisters.Text = "Add Tongue Twisters";
            this.addTwisters.UseVisualStyleBackColor = false;
            this.addTwisters.Click += new System.EventHandler(this.addTwisters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1496, 828);
            this.Controls.Add(this.addTwisters);
            this.Controls.Add(this.addParticipants);
            this.Controls.Add(this.resetBoard);
            this.Controls.Add(this.resetLeaderBoard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.leaderBoard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label twisterLabel;
        private Panel panel2;
        private Button randomTwister;
        private Panel panelName;
        private Button namePicker;
        private Button nameBox;
        private FlowLayoutPanel leaderBoard;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label rankLabel;
        private Label label1;
        private Label label2;
        private Button resetLeaderBoard;
        private Button resetBoard;
        private Button addParticipants;
        private Button addTwisters;
    }
}