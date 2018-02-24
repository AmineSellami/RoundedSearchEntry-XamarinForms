# RoundedSearchEntry-XamarinForms

This is a demo for a custom search entry for Xamarin Forms.

### Core Project
I have added some bindable properties like :  
* BorderColor
* BorderRadius
* BorderWidth
* Image
* ImageHeight
* ImageWidth
* ImageAlignement (Left, Right)
* Color (for the background)

This is an exemple for a BindableProperty : 
```cs
public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(RoundedSearchEntry), Color.White);
public Color BorderColor
{
    get { return (Color)GetValue(BorderColorProperty); }
    set { SetValue(BorderColorProperty, value); }
}
```
XAML CODE
```XAML
<controls:RoundedSearchEntry Margin="20,0" FontSize="Small" HeightRequest="30"
        Image="searchsmall" ImageHeight="30" ImageWidth="30"
        Placeholder="SEARCH: Parking, POI" PlaceholderColor="#003975"
        TextColor="#003975" VerticalOptions="Center" />
```

### Screenshot 
![GitHub Logo](/Screenshots/searchEntry.png?)
