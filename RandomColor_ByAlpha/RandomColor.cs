namespace RandomColor_ByBrightness;

public partial class RandomColor : Form
{
    private static readonly Random random = new();
    private const double _tolerance = 0; // �G�׮e�Խd��
    private float H, S, B; // ��� (Hue)�B���M�� (Saturation)�B�G�� (Brightness)
    private int minH, maxH;

    public RandomColor()
    {
        minH = 0;
        maxH = 45;
        InitializeComponent();
    }

    // KeyPress �����J�r��
    private void alphaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; // ����D�Ʀr��J
    }

    // TextChanged �T�O���e�X�k
    private void alphaTextBox_TextChanged(object sender, EventArgs e)
    {
        int.TryParse(alphaTextBox.Text, out var value);

        if (value >= 100)
        {
            alphaTextBox.Text = "100"; // �۰ʭץ����̤j��
            alphaTextBox.SelectionStart = alphaTextBox.Text.Length; // �N��Щ��̫�
        }

    }

    private void middleGrayButton_Click(object sender, EventArgs e)
    {
        alphaTextBox.Text = "50"; // �]�w�ؼЫG�׬�128
        var targetBrightness = 0.5f;
        GetHSB(targetBrightness);
    }

    private void buttonTransfer_Click(object sender, EventArgs e)
    {
        float.TryParse(alphaTextBox.Text, out var value);
        if (value >= 0)
        {
            float fBrightness = float.Parse(alphaTextBox.Text);
            var targetBrightness = fBrightness / 100f;
            GetHSB(targetBrightness);
        }
    }

    // �ھګ��w���G�׽վ��C��
    public void GetHSB(float targetBrightness)
    {
        Color color;

        do
        {
            // �H���ͦ� HSB ��
            H = random.Next(minH, maxH); // ��� (0-360�X)
            S = (float)random.NextDouble(); // ���M�� (0.0 - 1.0)
            B = (float)random.NextDouble(); // �G�� (0.0 - 1.0)

            // �N HSB �ഫ�� RGB
            color = HSBtoRGB(H, S, B);
        } while (Math.Abs(CalculateBrightness(color) - targetBrightness) > _tolerance); // �T�O�G�צb�e�Խd��

        // ��ܵ��G
        Console.WriteLine($"Generated HSB: H={H:F1}, S={S:F2}, B={B:F2}");
        Console.WriteLine($"Converted RGB: R={color.R}, G={color.G}, B={color.B}");

        resultLabel.Text = $"H={Math.Round(H, 1)}, S={Math.Round(S * 100, 1)}%, B={Math.Round(B * 100, 1)}%\n" +
                           $"R={color.R}, G={color.G}, B={color.B}";

        canvas.BackColor = color;

        // �Ы� Bitmap ��ø�s�C��
        using (var bmp = new Bitmap(canvas.Width, canvas.Height))
        {
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(canvas.BackColor); // ��R Panel ���I���C��
            }

            // �ƻs�Ϥ���ŶKï
            Clipboard.SetImage(bmp);
        }
    }

    // HSB �� RGB ��k
    public static Color HSBtoRGB(float h, float s, float b)
    {
        float r = 0, g = 0, blue = 0;

        if (s == 0)
        {
            // �Ƕ��C��]�L��ۡ^
            r = g = blue = b;
        }
        else
        {
            var sectorPos = h / 60f;
            var sectorNumber = (int)Math.Floor(sectorPos); // �Ҧb����۰Ϭq
            var fractionalSector = sectorPos - sectorNumber;

            var p = b * (1 - s);
            var q = b * (1 - s * fractionalSector);
            var t = b * (1 - s * (1 - fractionalSector));

            switch (sectorNumber)
            {
                case 0:
                    r = b;
                    g = t;
                    blue = p;
                    break;
                case 1:
                    r = q;
                    g = b;
                    blue = p;
                    break;
                case 2:
                    r = p;
                    g = b;
                    blue = t;
                    break;
                case 3:
                    r = p;
                    g = q;
                    blue = b;
                    break;
                case 4:
                    r = t;
                    g = p;
                    blue = b;
                    break;
                case 5:
                    r = b;
                    g = p;
                    blue = q;
                    break;
            }
        }

        // �N���G�ഫ�� 0-255 ���d��
        return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(blue * 255));
    }

    // �p�� RGB �C�⪺�G�ס]���ס^
    public static float CalculateBrightness(Color color)
    {
        return 0.299f * color.R / 255 + 0.587f * color.G / 255 + 0.114f * color.B / 255;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        minH = 0;
        maxH = 45;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        minH = 45;
        maxH = 75;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        minH = 75;
        maxH = 150;
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        minH = 150;
        maxH = 270;
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
        minH = 270;
        maxH = 330;
    }

    private void radioButton6_CheckedChanged(object sender, EventArgs e)
    {
        minH = 330;
        maxH = 345;
    }
}