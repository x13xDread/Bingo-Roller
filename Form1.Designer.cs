namespace BingoRoller
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rollButton = new System.Windows.Forms.Button();
            this.bingoRollerGif = new System.Windows.Forms.PictureBox();
            this.BingoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.outputLabel = new System.Windows.Forms.Label();
            this.lastValueLabel = new System.Windows.Forms.Label();
            this.gotBingoButton = new System.Windows.Forms.Button();
            this.valuesList = new System.Windows.Forms.Label();
            this.autoPlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bingoRollerGif)).BeginInit();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(287, 249);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(222, 95);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll Me";
            this.BingoToolTip.SetToolTip(this.rollButton, "Rolls a random remaining Bingo value");
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // bingoRollerGif
            // 
            this.bingoRollerGif.Enabled = false;
            this.bingoRollerGif.Image = global::BingoRoller.Properties.Resources.bingoRollerGif;
            this.bingoRollerGif.InitialImage = ((System.Drawing.Image)(resources.GetObject("bingoRollerGif.InitialImage")));
            this.bingoRollerGif.Location = new System.Drawing.Point(287, 36);
            this.bingoRollerGif.Name = "bingoRollerGif";
            this.bingoRollerGif.Size = new System.Drawing.Size(222, 189);
            this.bingoRollerGif.TabIndex = 1;
            this.bingoRollerGif.TabStop = false;
            this.bingoRollerGif.WaitOnLoad = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 8000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLabel.Location = new System.Drawing.Point(364, 199);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 2;
            // 
            // lastValueLabel
            // 
            this.lastValueLabel.AutoSize = true;
            this.lastValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastValueLabel.Location = new System.Drawing.Point(317, 4);
            this.lastValueLabel.Name = "lastValueLabel";
            this.lastValueLabel.Size = new System.Drawing.Size(136, 29);
            this.lastValueLabel.TabIndex = 3;
            this.lastValueLabel.Text = "Last Value: ";
            // 
            // gotBingoButton
            // 
            this.gotBingoButton.Location = new System.Drawing.Point(97, 155);
            this.gotBingoButton.Name = "gotBingoButton";
            this.gotBingoButton.Size = new System.Drawing.Size(107, 57);
            this.gotBingoButton.TabIndex = 4;
            this.gotBingoButton.Text = "Got Bingo!";
            this.gotBingoButton.UseVisualStyleBackColor = true;
            this.gotBingoButton.Click += new System.EventHandler(this.GotBingoButton_Click);
            // 
            // valuesList
            // 
            this.valuesList.AutoSize = true;
            this.valuesList.Location = new System.Drawing.Point(643, 36);
            this.valuesList.Name = "valuesList";
            this.valuesList.Size = new System.Drawing.Size(0, 13);
            this.valuesList.TabIndex = 5;
            // 
            // autoPlayButton
            // 
            this.autoPlayButton.Location = new System.Drawing.Point(341, 362);
            this.autoPlayButton.Name = "autoPlayButton";
            this.autoPlayButton.Size = new System.Drawing.Size(112, 36);
            this.autoPlayButton.TabIndex = 6;
            this.autoPlayButton.Text = "Start Auto Play";
            this.BingoToolTip.SetToolTip(this.autoPlayButton, "Turns the Autoplay feature on/off");
            this.autoPlayButton.UseVisualStyleBackColor = true;
            this.autoPlayButton.Click += new System.EventHandler(this.AutoPlayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoPlayButton);
            this.Controls.Add(this.valuesList);
            this.Controls.Add(this.gotBingoButton);
            this.Controls.Add(this.lastValueLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.bingoRollerGif);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bingoRollerGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox bingoRollerGif;
        private System.Windows.Forms.ToolTip BingoToolTip;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label lastValueLabel;
        private System.Windows.Forms.Button gotBingoButton;
        private System.Windows.Forms.Label valuesList;
        private System.Windows.Forms.Button autoPlayButton;
    }
}

