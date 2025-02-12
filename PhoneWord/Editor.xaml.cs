namespace PhoneWord;

public partial class Editor : ContentPage
{
    private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public Editor()
    {
        InitializeComponent();
        editor.Text = File.Exists(_fileName) ? File.ReadAllText(_fileName) : string.Empty;
    }

    private void Button_Clicked_Save(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    private void Button_Clicked_Delete(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}