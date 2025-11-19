using System.ComponentModel;

namespace StaticEnumSourceOnPicker
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      BindingContext = new MainPageViewModel();
    }
  }

  public partial class MainPageViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler? PropertyChanged;

    public MyEnum Selected
    {
      get; set
      {
        field = value;
        PropertyChanged?.Invoke( this, new( nameof( Selected ) ) );
      }
    } = MyEnum.None;

    public static IReadOnlyList<MyEnum> EnumValues => Enum.GetValues<MyEnum>();
  }

  public enum MyEnum
  {
    None = 0,
    Green = 1,
    Blue = 2,
    Red = 3,
  }
}
