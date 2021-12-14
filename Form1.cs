using System.Runtime.InteropServices;

namespace ToungeTwisterGames
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        int sNo = 1;
        DateTime curTime;
        Label currLabel;
        TextBox currParticipate;
        Random r = new Random();
        String leaderBoardPath = Environment.CurrentDirectory + "\\Leader_Board.txt";
        String participantsPath = Environment.CurrentDirectory + "\\Participants.txt";
        String twistersPath = Environment.CurrentDirectory + "\\Tongue_Twisters.txt";
        String prevParticipant = "NotANamexD", prevTwister = "ObviouslyNotATwisterAgainxD";

        public double trimZeroes(String input)
        {
            Double temp = 0;
            Char[] tempChar = input.ToCharArray();
            tempChar.Reverse();
            double deci = 1;
            foreach (Char doubleChar in tempChar)
            {
                temp = temp + int.Parse(doubleChar.ToString()) * deci;
                deci = deci * 10;
            }
            return temp;
        }

        private void UpdateLeaderBoard()
        {
            String[] leaderBoardArray = File.ReadAllLines(leaderBoardPath);
            Array.Reverse(leaderBoardArray);
            Dictionary<String, Double> leaderBoardDictionary = new Dictionary<String, Double>();
            foreach (String str in leaderBoardArray)
            {
                if (str.Length == 0)
                    continue;
                String[] namesInArray = str.Split('@');
                if (namesInArray.Length != 2)
                    continue;
                String[] timer = namesInArray[1].Split(':');
                if (timer.Length != 3)
                    continue;
                double realTimer = int.Parse(timer[0]) * 60 + int.Parse(timer[1]) + int.Parse(timer[2]) * 0.01;


                if (!leaderBoardDictionary.ContainsKey(namesInArray[0]))
                {
                    leaderBoardDictionary.Add(namesInArray[0], realTimer);
                }
            }
            leaderBoardDictionary = leaderBoardDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }

            int rank = 1;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            Label rankLabelDum = new Label();
            rankLabelDum.Text = "Rank";
            rankLabelDum.Dock = DockStyle.Fill;
            rankLabelDum.Margin = new Padding(0);
            rankLabelDum.BackColor = Color.FromArgb(180, 180, 180);
            rankLabelDum.ForeColor = Color.Black;
            rankLabelDum.TextAlign = ContentAlignment.MiddleCenter;
            rankLabelDum.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Label nameLabelDum = new Label();
            nameLabelDum.Text = "Name";
            nameLabelDum.Dock = DockStyle.Fill;
            nameLabelDum.Margin = new Padding(0);
            nameLabelDum.BackColor = Color.FromArgb(180, 180, 180);
            nameLabelDum.ForeColor = Color.Black;
            nameLabelDum.TextAlign = ContentAlignment.MiddleCenter;
            nameLabelDum.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Label timerLabelDum = new Label();
            timerLabelDum.Text = "Time Before Twisted";
            timerLabelDum.Dock = DockStyle.Fill;
            timerLabelDum.Margin = new Padding(0);
            timerLabelDum.BackColor = Color.FromArgb(180, 180, 180);
            timerLabelDum.ForeColor = Color.Black;
            timerLabelDum.TextAlign = ContentAlignment.MiddleCenter;
            timerLabelDum.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            this.tableLayoutPanel1.Controls.Add(rankLabelDum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(nameLabelDum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(timerLabelDum, 2, 0);

            foreach (String keys in leaderBoardDictionary.Keys)
            {

                Label rankLabel = new Label();
                rankLabel.Text = rank.ToString();
                rankLabel.Dock = DockStyle.Fill;
                rankLabel.BackColor = Color.FromArgb(210, 210, 210);
                rankLabel.ForeColor = Color.Black;
                rankLabel.Margin = new Padding(0);
                rankLabel.TextAlign = ContentAlignment.MiddleCenter;
                rankLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                Label nameLabel = new Label();
                nameLabel.Text = keys;
                nameLabel.Dock = DockStyle.Fill;
                nameLabel.BackColor = Color.FromArgb(210, 210, 210);
                nameLabel.ForeColor = Color.Black;
                nameLabel.Margin = new Padding(0);
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                nameLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                int minutes = (int)leaderBoardDictionary[keys] / 60;
                double milliSecond = (int)leaderBoardDictionary[keys] % 60 + (leaderBoardDictionary[keys] - (int)leaderBoardDictionary[keys]);
                String timeTaken = "";
                if(minutes != 0)
                {
                    timeTaken = minutes + " min ";
                }
                timeTaken = timeTaken + milliSecond + " sec";
                Label timerLabel = new Label();
                timerLabel.Text = timeTaken;
                timerLabel.Dock = DockStyle.Fill;
                timerLabel.BackColor = Color.FromArgb(210, 210, 210);
                timerLabel.ForeColor = Color.Black;
                timerLabel.Margin = new Padding(0);
                timerLabel.TextAlign = ContentAlignment.MiddleCenter;
                timerLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                

                this.tableLayoutPanel1.Controls.Add(rankLabel, 0, rank);
                this.tableLayoutPanel1.Controls.Add(nameLabel, 1, rank);
                this.tableLayoutPanel1.Controls.Add(timerLabel, 2, rank);
                if (rank == 10)
                    break;
                rank++;
            }
        }

        public void AddNewChrono()
        {
            FlowLayoutPanel chronoFlowLayout = new FlowLayoutPanel();
            chronoFlowLayout.FlowDirection = FlowDirection.LeftToRight;
            chronoFlowLayout.BackColor = Color.FromArgb(240, 240, 240);
            chronoFlowLayout.Margin = new Padding(10,0,0,12);
            chronoFlowLayout.Size = new Size(725,39);
            chronoFlowLayout.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, chronoFlowLayout.Width, chronoFlowLayout.Height, 10, 10));

            Label sNoLabel = new Label();
            sNoLabel.Text = (sNo++).ToString() + ")";
            sNoLabel.Size = new Size(40,37);
            sNoLabel.BackColor = chronoFlowLayout.BackColor;
            sNoLabel.TextAlign = ContentAlignment.MiddleCenter;
            sNoLabel.Margin = new Padding(0, 2, 0, 0);
            sNoLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            sNoLabel.ForeColor = Color.Black;
            chronoFlowLayout.Controls.Add(sNoLabel);

            Label staticName = new Label();
            staticName.Text = "Name:";
            staticName.Size = new Size(70, 37);
            staticName.BackColor = chronoFlowLayout.BackColor;
            staticName.TextAlign = ContentAlignment.MiddleLeft;
            staticName.Margin = new Padding(0, 2, 0, 0);
            staticName.Font = new Font("Arial", 11, FontStyle.Bold);
            staticName.ForeColor = Color.Black;
            chronoFlowLayout.Controls.Add(staticName);

            TextBox nameBox = new TextBox();
            nameBox.Size = new Size(250, 30);
            nameBox.BackColor = chronoFlowLayout.BackColor;
            nameBox.Margin = new Padding(0, 4, 0, 0);
            nameBox.Font = new Font("Arial", 12, FontStyle.Regular);
            nameBox.Multiline = true;
            nameBox.ForeColor = Color.Black;
            chronoFlowLayout.Controls.Add(nameBox);

            Label staticTimer = new Label();
            staticTimer.Text = "Timer:";
            staticTimer.Size = new Size(75, 37);
            staticTimer.BackColor = chronoFlowLayout.BackColor;
            staticTimer.TextAlign = ContentAlignment.MiddleRight;
            staticTimer.Margin = new Padding(4, 2, 0, 0);
            staticTimer.Font = new Font("Arial", 11, FontStyle.Bold);
            staticTimer.ForeColor = Color.Black;
            chronoFlowLayout.Controls.Add(staticTimer);

            Label timerLabel = new Label();
            timerLabel.Text = "00:00:00";
            timerLabel.Size = new Size(90, 32);
            timerLabel.BackColor = Color.FromArgb(200,200,200);
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            timerLabel.Margin = new Padding(0, 4, 0, 0);
            timerLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            timerLabel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, timerLabel.Width, timerLabel.Height, 5, 5));
            timerLabel.ForeColor = Color.Black;
            chronoFlowLayout.Controls.Add(timerLabel);

            Button startButton = new Button();
            startButton.Text = "Start";
            startButton.Size = new Size(70, 30);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.BackColor = Color.FromArgb(89, 153, 255);
            startButton.FlatAppearance.BorderSize = 0;
            startButton.Margin = new Padding(3, 4, 0, 0);
            startButton.Font = new Font("Arial", 11, FontStyle.Regular);
            startButton.TextAlign = ContentAlignment.MiddleCenter;
            startButton.FlatAppearance.MouseOverBackColor = startButton.BackColor;
            startButton.MouseClick += (s, args) =>
            {
                currLabel = timerLabel;
                currParticipate = nameBox;
                if(startButton.Text == "Start")
                {
                    if (currParticipate.Text.Length == 0)
                    {
                        return;
                    }
                    startButton.Text = "Stop";
                    timer1.Enabled = true;
                    curTime = DateTime.Now;
                }
                else
                {
                    startButton.Text = "Start";
                    try
                    {
                        String leaderBoardContent = File.ReadAllText(leaderBoardPath);
                        if (currLabel.Text != "00:00:00")
                            File.WriteAllText(leaderBoardPath, leaderBoardContent + "\n" + currParticipate.Text + " @ " + currLabel.Text);

                        /*tableLayoutPanel1.Size = new Size(683, tableLayoutPanel1.Size.Height + 42);
                        tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));*/
                        
                        /*tableLayoutPanel1.Controls.Add(rankLabel,0,tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.Controls.Add(nameLabel, 1, tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.Controls.Add(timerLabel, 2, tableLayoutPanel1.RowCount - 1);*/
                    }
                    catch { }
                    timer1.Enabled = false;
                    UpdateLeaderBoard();
                }
            };
            chronoFlowLayout.Controls.Add(startButton);

            Button endButton = new Button();
            endButton.Text = "Reset";
            endButton.Size = new Size(70, 30);
            endButton.FlatStyle = FlatStyle.Flat;
            endButton.BackColor = Color.FromArgb(89, 153, 255);
            endButton.TextAlign = ContentAlignment.MiddleCenter;
            endButton.FlatAppearance.BorderSize = 0;
            endButton.Margin = new Padding(4, 4, 0, 0);
            endButton.FlatAppearance.MouseOverBackColor = startButton.BackColor;
            endButton.Font = new Font("Arial", 11, FontStyle.Regular);
            endButton.MouseClick += (s, args) =>
            {
                currLabel = timerLabel;
                if(currLabel.Text != "00:00:00")
                {
                    DialogResult dialog = MessageBox.Show("Are you sure?", "Reset Timer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialog == DialogResult.Yes)
                    {
                        startButton.Text = "Start";
                        timer1.Enabled = false;
                        timerLabel.Text = "00:00:00";
                    }
                }
            };
            chronoFlowLayout.Controls.Add(endButton);

            Button addChronoButton = new Button();
            addChronoButton.Size = new Size(33,33);
            addChronoButton.Image = global::ToungeTwisterGames.Properties.Resources.add;
            addChronoButton.BackColor = chronoFlowLayout.BackColor;
            addChronoButton.BackgroundImageLayout = ImageLayout.None;
            addChronoButton.FlatStyle = FlatStyle.Flat;
            addChronoButton.FlatAppearance.BorderSize = 0;
            addChronoButton.FlatAppearance.MouseDownBackColor = chronoFlowLayout.BackColor;
            addChronoButton.Margin = new Padding(10,2,0,0);
            addChronoButton.FlatAppearance.MouseOverBackColor = addChronoButton.BackColor;
            addChronoButton.MouseClick += (s, args) =>
            {
                AddNewChrono();
            };
            chronoFlowLayout.Controls.Add(addChronoButton);

            flowLayoutPanel1.Controls.Add(chronoFlowLayout);
        }

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(leaderBoardPath))
                using (var myFile = File.Create(leaderBoardPath)) { }
            if (!File.Exists(participantsPath))
                using (var myFile = File.Create(participantsPath)) { }
            if (!File.Exists(twistersPath))
                using (var myFile = File.Create(twistersPath)) { }
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 15, 15));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));
            twisterLabel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, twisterLabel.Width, twisterLabel.Height, 7, 7));
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 7, 7));
            randomTwister.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, randomTwister.Width, randomTwister.Height, 7, 7));
            namePicker.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, namePicker.Width, namePicker.Height, 7, 7));
            panelName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelName.Width, panelName.Height, 7, 7));
            twisterLabel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, twisterLabel.Width, twisterLabel.Height, 7, 7));
            nameBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, nameBox.Width, nameBox.Height, 7, 7));
            leaderBoard.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, leaderBoard.Width, leaderBoard.Height, 7, 7));
            resetLeaderBoard.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, resetLeaderBoard.Width, resetLeaderBoard.Height, 7, 7));
            resetBoard.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, resetBoard.Width, resetBoard.Height, 7, 7));
            addParticipants.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, addParticipants.Width, addParticipants.Height, 7, 7));
            addTwisters.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, addTwisters.Width, addTwisters.Height, 7, 7));
            AddNewChrono();
            UpdateLeaderBoard();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan dur = DateTime.Now - curTime;
            currLabel.Text = String.Format("{0:mm\\:ss\\:ff}", dur);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resetLeaderBoard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will remove all the entries, Are you sure?", "Reset New Entries", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                while (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls[0].Dispose();
                }
                sNo = 1;
                AddNewChrono();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will remove all old and new entries from Leader Board and Participants section, Are you sure?", "Reset Leader Board", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                File.WriteAllText("C:\\Users\\Public\\LeaderBoard.txt", "");
                UpdateLeaderBoard();
                while (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls[0].Dispose();
                }
                sNo = 1;
                AddNewChrono();

            }
        }

        private void addParticipants_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", participantsPath);
        }

        private void addTwisters_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", twistersPath);
        }

        private void namePicker_Click(object sender, EventArgs e)
        {
            String[] namesList = File.ReadAllLines(participantsPath);
            List<String> actualNames = new List<string>();
            for (int i=0; i< namesList.Length; i++)
            {
                if (namesList[i].Length == 0)
                    continue;
                else if (namesList.ElementAt(i).Equals(prevParticipant))
                    continue;

                actualNames.Add(namesList[i].Trim());
            }
            if (actualNames.Count == 0) return;
            prevParticipant = actualNames.ElementAt(r.Next(actualNames.Count));
            nameBox.Text = prevParticipant;
        }

        private void randomTwister_Click(object sender, EventArgs e)
        {
            String[] twistersList = File.ReadAllLines(twistersPath);
            List<String> actualNames = new List<string>();
            String singleTwister = "";
            for (int i = 0; i < twistersList.Length; i++)
            {
                if (twistersList[i].Length == 0)
                {
                    if(singleTwister.Length != 0)
                        actualNames.Add(singleTwister);
                    singleTwister = "";
                    continue;
                }

                singleTwister = singleTwister + twistersList[i].Trim() + "\n";
            }
            if (singleTwister.Length != 0)
                actualNames.Add(singleTwister);
            List<String> tempActualNames = actualNames;
            foreach (String twister in tempActualNames)
            {
                if (twister.Equals(prevTwister))
                {
                    actualNames.Remove(twister);
                    break;
                }
            }
            if (actualNames.Count == 0) return;
            prevTwister = actualNames.ElementAt(r.Next(actualNames.Count));
            twisterLabel.Text = prevTwister;
        }
    }
}