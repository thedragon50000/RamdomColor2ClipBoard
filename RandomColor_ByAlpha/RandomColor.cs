using System.Reflection.Emit;

namespace RandomColor_ByBrightness;

public partial class RandomColor : Form
{
    private static readonly Random random = new Random();
    private double _brightness;
    private const double _tolerance = 0; // 亮度容忍範圍
    private int R, G, B;

    public RandomColor()
    {
        InitializeComponent();
    }

    // KeyPress 限制輸入字元
    private void alphaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // 阻止非數字輸入
        }
    }

    // TextChanged 確保內容合法
    private void alphaTextBox_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(alphaTextBox.Text, out int value))
        {
            if (value >= 256)
            {
                alphaTextBox.Text = "255"; // 自動修正為最大值
                alphaTextBox.SelectionStart = alphaTextBox.Text.Length; // 將游標放到最後
            }
        }
        else if (!string.IsNullOrEmpty(alphaTextBox.Text))
        {
            alphaTextBox.Text = string.Empty; // 非法輸入清空
        }
    }

    private void middleGrayButton_Click(object sender, EventArgs e)
    {
        alphaTextBox.Text = "128";
        int i = int.Parse(alphaTextBox.Text);
        GetRGB(i);

    }

    private void buttonTransfer_Click(object sender, EventArgs e)
    {
        int i = int.Parse(alphaTextBox.Text);
        GetRGB(i);
    }

    public void GetRGB(double _targetBrightness)
    {
        do
        {
            // 隨機生成 R、G、B 值
            R = random.Next(0, 256);
            G = random.Next(0, 256);
            B = random.Next(0, 256);

            // 計算亮度
            _brightness = 0.299 * R + 0.587 * G + 0.114 * B;
        } while (_brightness < _targetBrightness - _tolerance || _brightness > _targetBrightness + _tolerance);

        // 顯示結果
        Console.WriteLine($"Generated RGB: R={R}, G={G}, B={B}, Brightness={_brightness}");
        resultLabel.Text = $"R={R}, G={G}, B={B}, Brightness={Math.Round(_brightness, 1)}";

        canvas.BackColor = Color.FromArgb(R, G, B);
        // 創建 Bitmap 並繪製顏色
        using (Bitmap bmp = new Bitmap(canvas.Width, canvas.Height))
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(canvas.BackColor); // 填充 Panel 的背景顏色
            }

            // 複製圖片到剪貼簿
            Clipboard.SetImage(bmp);
            //MessageBox.Show("顏色圖片已複製到剪貼簿！");
        }
    }

}