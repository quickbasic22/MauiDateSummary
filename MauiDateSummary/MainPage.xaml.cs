

namespace MauiDateSummary;

public partial class MainPage : ContentPage
{
    private int daysleft;
	static int count = 0;
    private double yearpercentdone;
    private double yearpercentleft;

    public int DaysLeft 
	{
		get => daysleft; 
		set
		{
			if (daysleft != value)
				daysleft = value;
			OnPropertyChanged();
		}
	}
    public double YearPercentDone
    {
        get => yearpercentdone;
        set
        {
            if (yearpercentdone != value)
                yearpercentdone = value;
            OnPropertyChanged();
        }
    }
    public double YearPercentLeft
    {
        get => yearpercentleft;
        set
        {
            if (yearpercentleft != value)
                yearpercentleft = value;
            OnPropertyChanged();
        }
    }
    public MainPage()
	{
		InitializeComponent();
		DaysLeft = (365 - DateTime.Now.DayOfYear);
        double dayofy = Double.Parse(DateTime.Now.DayOfYear.ToString());
        double division = dayofy / 365;
        YearPercentDone = division * 100;
        YearPercentLeft = (1.0 - division) * 100;
        dayofweeklabel.Text = "Caption";
        BindingContext = this;
    }

    [Obsolete]
    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		count++;
		if (count == 0)
		{
			dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Caption, dayofweeklabel);
            dayofweeklabel.Text = "Caption";
		}
		else if (count == 1)
		{
			dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Default, dayofweeklabel);
            dayofweeklabel.Text = "Default";
        }
        else if (count == 2)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Body, dayofweeklabel);
            dayofweeklabel.Text = "Body";
        }
        else if (count == 3)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Micro, dayofweeklabel);
            dayofweeklabel.Text = "Micro";
        }
        else if (count == 4)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Small, dayofweeklabel);
            dayofweeklabel.Text = "Small";
        }
        else if (count == 5)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Subtitle, dayofweeklabel);
            dayofweeklabel.Text = "Subtitle";
        }
        else if (count == 6)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Medium, dayofweeklabel);
            dayofweeklabel.Text = "Medium";
        }
        else if (count == 7)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Title, dayofweeklabel);
            dayofweeklabel.Text = "Title";
        }
        else if (count == 8)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Large, dayofweeklabel);
            dayofweeklabel.Text = "Large";
        }
        else if (count == 9)
        {
            dayofweeklabel.FontSize = Device.GetNamedSize(NamedSize.Header, dayofweeklabel);
            dayofweeklabel.Text = "Header";
        }
        else if (count == 10)
        {
            count = -1;
        }
    }
}

