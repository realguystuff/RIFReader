namespace RIFReader
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
            pictureArea = new Panel();
            workingArea = new Panel();
            details = new Label();
            displayImg = new Label();
            stretch = new RadioButton();
            fit = new RadioButton();
            save = new Button();
            saveAs = new Button();
            open = new Button();
            saveFileDialog = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fileName = new Label();
            fileSize = new Label();
            workingArea.SuspendLayout();
            SuspendLayout();
            // 
            // pictureArea
            // 
            pictureArea.Location = new Point(12, 12);
            pictureArea.Name = "pictureArea";
            pictureArea.Size = new Size(776, 401);
            pictureArea.TabIndex = 0;
            // 
            // workingArea
            // 
            workingArea.Controls.Add(fileSize);
            workingArea.Controls.Add(fileName);
            workingArea.Controls.Add(details);
            workingArea.Controls.Add(displayImg);
            workingArea.Controls.Add(stretch);
            workingArea.Controls.Add(fit);
            workingArea.Controls.Add(save);
            workingArea.Controls.Add(saveAs);
            workingArea.Controls.Add(open);
            workingArea.Location = new Point(12, 419);
            workingArea.Name = "workingArea";
            workingArea.Size = new Size(776, 101);
            workingArea.TabIndex = 1;
            // 
            // details
            // 
            details.AutoSize = true;
            details.Location = new Point(290, 0);
            details.Name = "details";
            details.Size = new Size(42, 15);
            details.TabIndex = 6;
            details.Text = "Details";
            details.Click += label1_Click;
            // 
            // displayImg
            // 
            displayImg.AutoSize = true;
            displayImg.Location = new Point(0, 0);
            displayImg.Name = "displayImg";
            displayImg.Size = new Size(106, 15);
            displayImg.TabIndex = 5;
            displayImg.Text = "Display image by...";
            // 
            // stretch
            // 
            stretch.AutoSize = true;
            stretch.Location = new Point(0, 33);
            stretch.Name = "stretch";
            stretch.Size = new Size(62, 19);
            stretch.TabIndex = 4;
            stretch.TabStop = true;
            stretch.Text = "Stretch";
            stretch.UseVisualStyleBackColor = true;
            // 
            // fit
            // 
            fit.AutoSize = true;
            fit.Location = new Point(0, 15);
            fit.Name = "fit";
            fit.Size = new Size(38, 19);
            fit.TabIndex = 3;
            fit.TabStop = true;
            fit.Text = "Fit";
            fit.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(716, 17);
            save.Name = "save";
            save.Size = new Size(57, 23);
            save.TabIndex = 2;
            save.Text = "Save...";
            save.UseVisualStyleBackColor = true;
            // 
            // saveAs
            // 
            saveAs.Location = new Point(703, 46);
            saveAs.Name = "saveAs";
            saveAs.Size = new Size(70, 23);
            saveAs.TabIndex = 1;
            saveAs.Text = "Save as...";
            saveAs.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            open.Location = new Point(673, 75);
            open.Name = "open";
            open.Size = new Size(100, 23);
            open.TabIndex = 0;
            open.Text = "Open new file...";
            open.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.Location = new Point(290, 15);
            fileName.Name = "fileName";
            fileName.Size = new Size(64, 15);
            fileName.TabIndex = 7;
            fileName.Text = "File name: ";
            // 
            // fileSize
            // 
            fileSize.AutoSize = true;
            fileSize.Location = new Point(290, 30);
            fileSize.Name = "fileSize";
            fileSize.Size = new Size(53, 15);
            fileSize.TabIndex = 8;
            fileSize.Text = "File size: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(workingArea);
            Controls.Add(pictureArea);
            Name = "Form1";
            Text = "Form1";
            workingArea.ResumeLayout(false);
            workingArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pictureArea;
        private Panel workingArea;
        private Label displayImg;
        private RadioButton stretch;
        private RadioButton fit;
        private Button save;
        private Button saveAs;
        private Button open;
        private SaveFileDialog saveFileDialog;
        private Label details;
        private OpenFileDialog openFileDialog1;
        private Label fileName;
        private Label fileSize;
    }
}