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
        groupBox1 = new GroupBox();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        radioButton4 = new RadioButton();
        radioButton5 = new RadioButton();
        radioButton6 = new RadioButton();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // buttonTransfer
        // 
        buttonTransfer.Location = new Point(83, 70);
        buttonTransfer.Name = "buttonTransfer";
        buttonTransfer.Size = new Size(75, 23);
        buttonTransfer.TabIndex = 0;
        buttonTransfer.Text = "轉換並複製";
        buttonTransfer.UseVisualStyleBackColor = true;
        buttonTransfer.Click += buttonTransfer_Click;
        // 
        // alphaTextBox
        // 
        alphaTextBox.Location = new Point(67, 41);
        alphaTextBox.Name = "alphaTextBox";
        alphaTextBox.Size = new Size(100, 23);
        alphaTextBox.TabIndex = 1;
        alphaTextBox.Text = "50";
        alphaTextBox.TextAlign = HorizontalAlignment.Center;
        alphaTextBox.TextChanged += alphaTextBox_TextChanged;
        alphaTextBox.KeyPress += alphaTextBox_KeyPress;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(64, 9);
        label1.Name = "label1";
        label1.Size = new Size(103, 15);
        label1.TabIndex = 2;
        label1.Text = "輸入想要的透明度";
        // 
        // middleGrayButton
        // 
        middleGrayButton.Location = new Point(173, 12);
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
        resultLabel.Location = new Point(67, 143);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(0, 15);
        resultLabel.TabIndex = 4;
        // 
        // canvas
        // 
        canvas.Location = new Point(182, 61);
        canvas.Name = "canvas";
        canvas.Size = new Size(49, 52);
        canvas.TabIndex = 5;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButton1);
        groupBox1.Controls.Add(radioButton2);
        groupBox1.Controls.Add(radioButton3);
        groupBox1.Controls.Add(radioButton4);
        groupBox1.Controls.Add(radioButton5);
        groupBox1.Controls.Add(radioButton6);
        groupBox1.Location = new Point(2, 9);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(59, 168);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "色系";
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Checked = true;
        radioButton1.Location = new Point(3, 19);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(49, 19);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "紅橙";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(3, 44);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(37, 19);
        radioButton2.TabIndex = 0;
        radioButton2.Text = "黃";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(3, 69);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(37, 19);
        radioButton3.TabIndex = 0;
        radioButton3.TabStop = true;
        radioButton3.Text = "綠";
        radioButton3.UseVisualStyleBackColor = true;
        radioButton3.CheckedChanged += radioButton3_CheckedChanged;
        // 
        // radioButton4
        // 
        radioButton4.AutoSize = true;
        radioButton4.Location = new Point(3, 94);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new Size(37, 19);
        radioButton4.TabIndex = 0;
        radioButton4.TabStop = true;
        radioButton4.Text = "藍";
        radioButton4.UseVisualStyleBackColor = true;
        radioButton4.CheckedChanged += radioButton4_CheckedChanged;
        // 
        // radioButton5
        // 
        radioButton5.AutoSize = true;
        radioButton5.Location = new Point(3, 119);
        radioButton5.Name = "radioButton5";
        radioButton5.Size = new Size(37, 19);
        radioButton5.TabIndex = 0;
        radioButton5.Text = "紫";
        radioButton5.UseVisualStyleBackColor = true;
        radioButton5.CheckedChanged += radioButton5_CheckedChanged;
        // 
        // radioButton6
        // 
        radioButton6.AutoSize = true;
        radioButton6.Location = new Point(3, 144);
        radioButton6.Name = "radioButton6";
        radioButton6.Size = new Size(37, 19);
        radioButton6.TabIndex = 0;
        radioButton6.TabStop = true;
        radioButton6.Text = "粉";
        radioButton6.UseVisualStyleBackColor = true;
        radioButton6.CheckedChanged += radioButton6_CheckedChanged;
        // 
        // RandomColor
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(253, 176);
        Controls.Add(groupBox1);
        Controls.Add(canvas);
        Controls.Add(resultLabel);
        Controls.Add(middleGrayButton);
        Controls.Add(label1);
        Controls.Add(alphaTextBox);
        Controls.Add(buttonTransfer);
        Name = "RandomColor";
        Text = "RandomColor";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
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
    private GroupBox groupBox1;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private RadioButton radioButton3;
    private RadioButton radioButton6;
    private RadioButton radioButton5;
    private RadioButton radioButton4;
}