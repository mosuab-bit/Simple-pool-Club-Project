namespace Pool_Club_Project
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
            this.ucPool4 = new Pool_Club_Project.UCPool();
            this.ucPool3 = new Pool_Club_Project.UCPool();
            this.ucPool2 = new Pool_Club_Project.UCPool();
            this.ucPool1 = new Pool_Club_Project.UCPool();
            this.SuspendLayout();
            // 
            // ucPool4
            // 
            this.ucPool4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPool4.HourlyRate = 10F;
            this.ucPool4.Location = new System.Drawing.Point(579, 320);
            this.ucPool4.Name = "ucPool4";
            this.ucPool4.PlayerName = "Player";
            this.ucPool4.Size = new System.Drawing.Size(580, 321);
            this.ucPool4.TabIndex = 3;
            this.ucPool4.TableTitle = "Table";
            this.ucPool4.GameEnd += new System.EventHandler<Pool_Club_Project.UCPool.PoolPlayEndEventArgs>(this.ucPool1_GameEnd);
            // 
            // ucPool3
            // 
            this.ucPool3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPool3.HourlyRate = 10F;
            this.ucPool3.Location = new System.Drawing.Point(2, 320);
            this.ucPool3.Name = "ucPool3";
            this.ucPool3.PlayerName = "Player";
            this.ucPool3.Size = new System.Drawing.Size(580, 321);
            this.ucPool3.TabIndex = 2;
            this.ucPool3.TableTitle = "Table";
            this.ucPool3.GameEnd += new System.EventHandler<Pool_Club_Project.UCPool.PoolPlayEndEventArgs>(this.ucPool1_GameEnd);
            // 
            // ucPool2
            // 
            this.ucPool2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPool2.HourlyRate = 10F;
            this.ucPool2.Location = new System.Drawing.Point(579, 2);
            this.ucPool2.Name = "ucPool2";
            this.ucPool2.PlayerName = "Player";
            this.ucPool2.Size = new System.Drawing.Size(580, 321);
            this.ucPool2.TabIndex = 1;
            this.ucPool2.TableTitle = "Table";
            this.ucPool2.GameEnd += new System.EventHandler<Pool_Club_Project.UCPool.PoolPlayEndEventArgs>(this.ucPool1_GameEnd);
            // 
            // ucPool1
            // 
            this.ucPool1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ucPool1.HourlyRate = 10F;
            this.ucPool1.Location = new System.Drawing.Point(2, 2);
            this.ucPool1.Name = "ucPool1";
            this.ucPool1.PlayerName = "Player";
            this.ucPool1.Size = new System.Drawing.Size(580, 321);
            this.ucPool1.TabIndex = 0;
            this.ucPool1.TableTitle = "Table";
            this.ucPool1.GameEnd += new System.EventHandler<Pool_Club_Project.UCPool.PoolPlayEndEventArgs>(this.ucPool1_GameEnd);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 644);
            this.Controls.Add(this.ucPool4);
            this.Controls.Add(this.ucPool3);
            this.Controls.Add(this.ucPool2);
            this.Controls.Add(this.ucPool1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPool ucPool1;
        private UCPool ucPool2;
        private UCPool ucPool3;
        private UCPool ucPool4;
    }
}

