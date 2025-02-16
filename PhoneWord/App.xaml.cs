namespace PhoneWord
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Editor();//new CalculatorGrid();//new Grid(); ///new AppShell();//
        }
    }
}