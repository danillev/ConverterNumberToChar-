using ConverterNumberToChar.BLL.Enums;
using ConverterNumberToChar.BLL.Services;
using System.Timers;
using Timer = System.Timers;

namespace ConverterNumberToChar
{
    public partial class MainForm : Form
    {

        private readonly ButtonPhoneConverterService _converter;
        private int _lastButtonNumber = -1;
        private DateTime _lastPressTime = DateTime.MinValue;
        private string _currentSequence = "";
        private readonly Timer.Timer _inputTimer;

        public MainForm(ButtonPhoneConverterService converter)
        {
            _converter = converter;
            InitializeComponent();
            InitializeButton();


            _inputTimer = new Timer.Timer(1000);
            _inputTimer.Elapsed += OnInputTimerElapsed;
            _inputTimer.AutoReset = false;
        }

        private void InitializeButton()
        {
            buttonOne.Tag = ButtonTypeEnum.ButtonOne;
            buttonTwo.Tag = ButtonTypeEnum.ButtonTwo;
            buttonThree.Tag = ButtonTypeEnum.ButtonThree;
            buttonFour.Tag = ButtonTypeEnum.ButtonFour;
            buttonFive.Tag = ButtonTypeEnum.ButtonFive;
            buttonSix.Tag = ButtonTypeEnum.ButtonSix;
            buttonSeven.Tag = ButtonTypeEnum.ButtonSeven;
            buttonEight.Tag = ButtonTypeEnum.ButtonEight;
            buttonNine.Tag = ButtonTypeEnum.ButtonNine;
            buttonStar.Tag = ButtonTypeEnum.ButtonStar;
            buttonHash.Tag = ButtonTypeEnum.ButtonHash;
            buttonZero.Tag = ButtonTypeEnum.ButtonZero;
        }

        private void OnInputTimerElapsed(object? sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (!string.IsNullOrEmpty(_currentSequence))
                {
                    displayTextBox.Text += _converter.ConvertToText(_currentSequence + "#");
                    _currentSequence = "";
                    _lastButtonNumber = -1;
                }
            });
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && (int)button.Tag is int buttonNumber)
            {
                _inputTimer.Stop();
                ProcessButtonPress(buttonNumber);
                _inputTimer.Start();
            }
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            _inputTimer.Stop();
            _currentSequence = "";
            displayTextBox.Clear();
        }
        
        private void btnHash_Click(object sender, EventArgs e)
        {
            _inputTimer.Stop();
            if (!string.IsNullOrEmpty(_currentSequence))
            {
                displayTextBox.Text += _converter.ConvertToText(_currentSequence + "#");
                _currentSequence = "";
            }
        }

        private void ProcessButtonPress(int buttonNumber)
        {
            DateTime now = DateTime.Now;
            
            if ((now - _lastPressTime).TotalSeconds > 1 || buttonNumber != _lastButtonNumber)
            {
                if (!string.IsNullOrEmpty(_currentSequence))
                {
                    displayTextBox.Text += _converter.ConvertToText(_currentSequence + "#");
                    _currentSequence = "";
                }
            }

            _currentSequence += buttonNumber.ToString();
            _lastButtonNumber = buttonNumber;
            _lastPressTime = now;
        }
    }
}
