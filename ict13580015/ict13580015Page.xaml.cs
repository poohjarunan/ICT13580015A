using Xamarin.Forms;

namespace ict13580015
{
    public partial class ict13580015Page : ContentPage
    {
        public ict13580015Page()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;

            myStepper.ValueChanged += MyStepper_ValueChanged;


        }

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
