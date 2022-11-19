namespace MauiDateSummary;

public partial class NamedFontSizesPage : ContentView
{
    [Obsolete]
    public NamedFontSizesPage()
	{
		InitializeComponent();
		FormattedString formattedString = new FormattedString();
		NamedSize[] namedSizes =
		{
			NamedSize.Default, NamedSize.Micro, NamedSize.Small, NamedSize.Medium, NamedSize.Large, NamedSize.Header, NamedSize.Caption, NamedSize.Body
		};

		foreach (NamedSize namedSize in  namedSizes)
		{
			double fontSize = Device.GetNamedSize(namedSize, typeof(Label));
			formattedString.Spans.Add(new Span
			{
				Text = String.Format("Named Size = {0} ({1:F2})", namedSize, fontSize),
				FontSize = fontSize
			});

			if (namedSize != namedSizes.Last())
			{
				formattedString.Spans.Add(new Span
				{
					Text = "\n\n"
				});
			}

			Content = new Label
			{
				FormattedText = formattedString,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
		}
	}
}