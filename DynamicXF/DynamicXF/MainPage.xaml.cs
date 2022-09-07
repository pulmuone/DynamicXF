using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicXF
{
    /// <summary>
    /// 참고 : https://github.com/xamarin/xamarin-forms-samples/blob/main/UserInterface/Layout/GridDemos/GridDemos/Views/Code/BasicGridPageCS.cs
    /// </summary>
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
        }

        void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            // Process changes
            if(e.DisplayInfo.Orientation == DisplayOrientation.Portrait)
            {
                //가로

            }
            else
            {
                //세로
            }
        }


        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
            {
                //가로
                //outerStack.Orientation = StackOrientation.Horizontal;
                HorizontalView();
            }
            else
            {
                //세로
                //outerStack.Orientation = StackOrientation.Vertical;
                VerticalView();
            }

        }

        private void HorizontalView()
        {
            this.Header2Row.Height = 160;
            this.Header2.RowDefinitions.Clear();
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });

            this.Header2.ColumnDefinitions.Clear();
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });


            this.Header2.Children.Clear();
            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 0, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 0, 1); //Column, Row


            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 1, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 1, 1); //Column, Row


            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 2, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 2, 1); //Column, Row


            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 3, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 3, 1); //Column, Row

            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 4, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 4, 1); //Column, Row


            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 0, 2); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 0, 3); //Column, Row

        }

        private void VerticalView()
        {
            this.Header2Row.Height = 160;
            this.Header2.RowDefinitions.Clear();
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            this.Header2.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });

            this.Header2.ColumnDefinitions.Clear();
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });
            this.Header2.ColumnDefinitions.Add(new ColumnDefinition { });

            this.Header2.Children.Clear();
            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 0, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 0, 1); //Column, Row


            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 1, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 1, 1); //Column, Row


            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 2, 0); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 2, 1); //Column, Row

            this.Header2.Children.Add(new Label
            {
                Text = "라벨",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center

            }, 0, 2); //Column, Row

            this.Header2.Children.Add(new Entry
            {
                Text = "입력라벨"
            }, 0, 3); //Column, Row
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}
