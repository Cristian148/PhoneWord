namespace PhoneWord
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculatorGrid();//new Grid(); ///new AppShell();//new Editor();
        }
    }
}