using System.Reflection.Emit;

namespace RandomColor_ByBrightness;

public partial class RandomColor : Form
{
    private static readonly Random random = new Random();
    private double _brightness;
    private const double _tolerance = 0; // �G�׮e�Խd��
    private int R, G, B;

    public RandomColor()
    {
        InitializeComponent();
    }

    // KeyPress �����J�r��
    private void alphaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // ����D�Ʀr��J
        }
    }

    // TextChanged �T�O���e�X�k
    private void alphaTextBox_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(alphaTextBox.Text, out int value))
        {
            if (value >= 256)
            {
                alphaTextBox.Text = "255"; // �۰ʭץ����̤j��
                alphaTextBox.SelectionStart = alphaTextBox.Text.Length; // �N��Щ��̫�
            }
        }
        else if (!string.IsNullOrEmpty(alphaTextBox.Text))
        {
            alphaTextBox.Text = string.Empty; // �D�k��J�M��
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
            // �H���ͦ� R�BG�BB ��
            R = random.Next(0, 256);
            G = random.Next(0, 256);
            B = random.Next(0, 256);

            // �p��G��
            _brightness = 0.299 * R + 0.587 * G + 0.114 * B;
        } while (_brightness < _targetBrightness - _tolerance || _brightness > _targetBrightness + _tolerance);

        // ��ܵ��G
        Console.WriteLine($"Generated RGB: R={R}, G={G}, B={B}, Brightness={_brightness}");
        resultLabel.Text = $"R={R}, G={G}, B={B}, Brightness={Math.Round(_brightness, 1)}";

        canvas.BackColor = Color.FromArgb(R, G, B);
        // �Ы� Bitmap ��ø�s�C��
        using (Bitmap bmp = new Bitmap(canvas.Width, canvas.Height))
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(canvas.BackColor); // ��R Panel ���I���C��
            }

            // �ƻs�Ϥ���ŶKï
            Clipboard.SetImage(bmp);
            //MessageBox.Show("�C��Ϥ��w�ƻs��ŶKï�I");
        }
    }

}