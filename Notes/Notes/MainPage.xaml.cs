using System.IO;

namespace Notes;

public partial class MainPage : ContentPage
{
    // Dito ise-save yung notes mo
    string fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public MainPage()
    {
        InitializeComponent(); // Ito ang magbabasa ng XAML mo

        // Kapag binuksan ang app, iche-check kung may nakasave nang notes
        if (File.Exists(fileName))
        {
            editor.Text = File.ReadAllText(fileName);
        }
    }

    // Function kapag pinindot ang Save button
    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(fileName, editor.Text);
    }

    // Function kapag pinindot ang Delete button
    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        editor.Text = string.Empty; // Lilinisin yung text box
    }
}