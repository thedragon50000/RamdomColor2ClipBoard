namespace RandomColor_ByBrightness;

partial class RandomColor
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
        buttonTransfer = new Button();
        alphaTextBox = new TextBox();
        label1 = new Label();
        middleGrayButton = new Button();
        resultLabel = new Label();
        canvas = new Panel();
        SuspendLayout();
        // 
        // buttonTransfer
        // 
        buttonTransfer.Location = new Point(93, 70);
        buttonTransfer.Name = "buttonTransfer";
        buttonTransfer.Size = new Size(75, 23);
        buttonTransfer.TabIndex = 0;
        buttonTransfer.Text = "轉換並複製";
        buttonTransfer.UseVisualStyleBackColor = true;
        buttonTransfer.Click += buttonTransfer_Click;
        // 
        // alphaTextBox
        // 
        alphaTextBox.Location = new Point(77, 41);
        alphaTextBox.Name = "alphaTextBox";
        alphaTextBox.Size = new Size(100, 23);
        alphaTextBox.TabIndex = 1;
        alphaTextBox.Text = "128";
        alphaTextBox.TextAlign = HorizontalAlignment.Center;
        alphaTextBox.TextChanged += alphaTextBox_TextChanged;
        alphaTextBox.KeyPress += alphaTextBox_KeyPress;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(74, 9);
        label1.Name = "label1";
        label1.Size = new Size(103, 15);
        label1.TabIndex = 2;
        label1.Text = "輸入想要的透明度";
        // 
        // middleGrayButton
        // 
        middleGrayButton.Location = new Point(183, 12);
        middleGrayButton.Name = "middleGrayButton";
        middleGrayButton.Size = new Size(68, 23);
        middleGrayButton.TabIndex = 3;
        middleGrayButton.Text = "設定50%";
        middleGrayButton.UseVisualStyleBackColor = true;
        middleGrayButton.Click += middleGrayButton_Click;
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(22, 152);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(0, 15);
        resultLabel.TabIndex = 4;
        // 
        // canvas
        // 
        canvas.Location = new Point(192, 61);
        canvas.Name = "canvas";
        canvas.Size = new Size(49, 52);
        canvas.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(253, 176);
        Controls.Add(canvas);
        Controls.Add(resultLabel);
        Controls.Add(middleGrayButton);
        Controls.Add(label1);
        Controls.Add(alphaTextBox);
        Controls.Add(buttonTransfer);
        Name = "RandomColor";
        Text = "RandomColor";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonTransfer;
    private TextBox alphaTextBox;
    private Label label1;
    private Button middleGrayButton;
    private Label resultLabel;
    private Panel canvas;
}