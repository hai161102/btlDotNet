using ManagerCotrol.views.labels;
using ManagerCotrol.views.panels;
using ManagerCotrol.views.textbox;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerCotrol
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
        /// 

        private PanelView panelViewSignIn;
        private int windowWidth, windowHeight;
        public static string SIGN_IN = "sign_in";

        private void InitializeComponent()
        {
            

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Name = "Manager";
            this.Text = "Manager";
            this.WindowState = FormWindowState.Maximized;
            this.ResumeLayout(false);

            this.windowWidth = this.Width;
            this.windowHeight = this.Height;

            this.panelViewSignIn = new PanelView(0, 0, this.windowWidth, this.windowHeight);
            this.panelViewSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewSignIn.BackColor = Color.Aqua;

            setViewSignIn(panelViewSignIn, windowWidth / 2 - 400, windowHeight / 2 - 250, 800, 400);

            this.SuspendLayout();

            this.Controls.Add(this.panelViewSignIn);

        }

        private void setViewSignIn(Panel panel, int x, int y, int width, int height)
        {

            List<string> listLabelText = new List<string>();
            listLabelText.Add("Username");
            listLabelText.Add("Password");
            listLabelText.Add("Permission");

            PanelView panelView = new PanelView(x, y, width, height);
            panelView.BackColor = Color.White;

            LabelView labelView = new LabelView(panelView.PanelWidth / 2 - 100, 20, 200, 100, "Đăng nhập");
            labelView.TextAlign = ContentAlignment.MiddleCenter;
            labelView.Name = SIGN_IN;
            labelView.Font = new Font("Arial", 24, FontStyle.Bold);
            panelView.Controls.Add(labelView);

            for (int i = 0; i < 3; i++)
            {
                LabelView viewInfo = new LabelView(50, labelView.LabelY + labelView.LabelHeight + i * 50, 150, 50, listLabelText[i]);
                viewInfo.Name = listLabelText[i];
                viewInfo.Font = new Font("Arial", 10, FontStyle.Regular);
                panelView.Controls.Add(viewInfo);

                TextBoxView textBoxInfo = new TextBoxView(50 + viewInfo.Width, labelView.LabelY + labelView.LabelHeight + i * 50, panelView.PanelWidth - 50 - (50 + viewInfo.Width), viewInfo.Height);
                panelView.Controls.Add(textBoxInfo);

            }



            panel.Controls.Add(panelView);

        }

        #endregion
    }
}

