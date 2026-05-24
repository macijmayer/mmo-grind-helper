```csharp
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace LostArkGrindHelper
{
    public partial class MainForm : Form
    {
        private const string GameProcessName = "LostArk"; // Change this to your game's process name
        private Timer processCheckTimer;
        private bool isGameRunning;

        public MainForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeComponent()
        {
            this.StartButton = new Button();
            this.StopButton = new Button();
            this.StatusLabel = new Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(30, 30);
            this.StartButton.Size = new System.Drawing.Size(120, 30);
            this.StartButton.Text = "Start Grind";
            this.StartButton.Click += new EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(30, 80);
            this.StopButton.Size = new System.Drawing.Size(120, 30);
            this.StopButton.Text = "Stop Grind";
            this.StopButton.Click += new EventHandler(this.StopButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(30, 130);
            this.StatusLabel.Size = new System.Drawing.Size(300, 30);
            this.StatusLabel.Text = "Status: Idle";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(360, 200);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StatusLabel);
            this.ResumeLayout(false);
        }

        private void InitializeTimer()
        {
            processCheckTimer = new Timer();
            processCheckTimer.Interval = 1000; // Check every second
            processCheckTimer.Tick += CheckGameProcess;
            processCheckTimer.Start();
        }

        private void CheckGameProcess(object sender, EventArgs e)
        {
            isGameRunning = Process.GetProcessesByName(GameProcessName).Any();
            StatusLabel.Text = isGameRunning ? "Status: Game Running" : "Status: Game Not Running";
            StartButton.Enabled = isGameRunning;
            StopButton.Enabled = isGameRunning;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                // Code to initiate grind helper tasks
                StatusLabel.Text = "Status: Grinding Started";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Code to halt grind helper tasks
            StatusLabel.Text = "Status: Grinding Stopped";
        }

        private Button StartButton;
        private Button StopButton;
        private Label StatusLabel;
    }
}
```