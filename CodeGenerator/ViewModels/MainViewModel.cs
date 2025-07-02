namespace CodeGenerator.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private ActivePanel activePanel;
    public ActivePanel ActivePanel
    {
        get => activePanel;
        set => SetProperty(ref activePanel, value);
    }

    public MainViewModel()
    {
        ActivePanel = ActivePanel.Display;
    }
}
