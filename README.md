# How-to-remove-the-cards-from-Xamarin.Forms-CardView
It describes how to remove the cards from Xamarin.Forms CardView. For more reference please refer the below KB

[How to remove cards from card view collection in Xamarin.Forms](https://www.syncfusion.com/kb/11655/?utm_medium=listing&utm_source=github-examples)

The [SfCardView](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.142432434.1232783100.1593359517-1450022673.1574142796#sfcardview) is a Syncfusion UI component that helps organizing the content in UI views as cards. This section explains how to remove a card from Xamarin.Forms CardView collection. You can remove the cards by enabling the [SwipeToDismiss](https://github.com/SyncfusionExamples/shadow-effect-in-Xamarin.Forms-cards-SfCardView-/blob/master/README.md) property in CardView.

 
**Creating the previous UI**
 

You can achieve the previous UI using the following code snippets:

 
**[XAML]**

```


..
 
      <ListView   x:Name="EventListView"
                  RowHeight="100"
                  SeparatorVisibility="None"
                  ItemsSource="{Binding Items}">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <cards:SfCardView Dismissed="SfCardView_Dismissed" SwipeToDismiss="True"  Margin="10">
                            <Grid HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
                                <StackLayout Orientation="Horizontal" >
                                    <Image Margin="10,0,0,0" HeightRequest="40" WidthRequest="40"
                                                  Source="{Binding Image}"/>
                                    <Label FontAttributes="Bold" Margin="10,0,0,0"
                                           FontSize="16"
                                           MaxLines="1"
                                           Text="{Binding Title}"
                                           LineBreakMode="NoWrap"
                                           TextColor="Black"
                                           HorizontalOptions="Start"
                                           VerticalOptions="Center" />
                                </StackLayout>
                            </Grid>
                        </cards:SfCardView>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>
```
 
**[C#]**

```


public class CardModel
{
    public string Title {get; set;}
 
    public string Image {get; set;}
}

```

**[C#]**

```

public class CardViewModel
{
        public ObservableCollection<CardModel> Items { get; set; }
        public CardViewModel()
        {
            Items = new ObservableCollection<CardModel>()
            {
                new CardModel(){ Title = "Facebook" , Image = "FacebookFill.png"},
                new CardModel(){ Title = "Gmail" , Image = "GmailFill.png"},
                new CardModel(){ Title = "Instagram" , Image = "InstagramFill.png"},
                new CardModel(){ Title = "WhatsApp" , Image = "WhatsappFill.png"},
            };
        }
}

```

**[C#]**

```


public MainPage()
{
    InitializeComponent();
    items = (BindingContext as CardViewModel)?.Items;
}
```
 

Since, we have added that CardView in a ListView, even though it is been removed from CardView collection still exists in the ListView. So, to remove it thoroughly, we have removed that model in the Dismissed event as shown in the following code snippet.

 **[C#]**
```

private void SfCardView_Dismissed(object sender, DismissedEventArgs e)

{

            var item = (sender as SfCardView)?.BindingContext as CardModel;

            if (items != null && item != null && items.Contains(item))

            {

                items.Remove(item);

            }

 }
```
 
**See Also**


[How to dismiss the cards programmatically](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.118251401.1232783100.1593359517-1450022673.1574142796#dismiss-the-card-programmatically)

[Available customization in cards](https://help.syncfusion.com/xamarin/cards/customization?_ga=2.118251401.1232783100.1593359517-1450022673.1574142796)

[Notify events to visible index changed](https://help.syncfusion.com/xamarin/cards/events?_ga=2.118251401.1232783100.1593359517-1450022673.1574142796#visiblecardindexchanging)

# roubleshooting
## Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
