using eKino_PCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace eKino.Views.Film
{
    public class TrailerPage : ContentPage
    {

        public TrailerPage(string trailerUrl)
        {
            WebView myWebView = new WebView();
            myWebView.VerticalOptions = LayoutOptions.Fill;
            myWebView.HorizontalOptions = LayoutOptions.Fill;

            HtmlWebViewSource htmlSource = new HtmlWebViewSource();
            htmlSource.Html = "<iframe width='100%' height='100%' frameborder='0' allowfullscreen src='" + trailerUrl + "'" + "'></iframe>";

            myWebView.Source = htmlSource;

            Content = myWebView;
        }
    }
}