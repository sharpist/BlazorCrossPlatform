using BlazorClassLibrary;
using BlazorClassLibrary.Data;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BlazorWinForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly AppState _appState = new();

        public Form()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();

            serviceCollection.AddSingleton<AppState>(_appState);
            serviceCollection.AddSingleton<WeatherForecastService>();

            InitializeComponent();

            blazorWebView.HostPage = @"wwwroot\index.html";
            blazorWebView.Services = serviceCollection.BuildServiceProvider();
            blazorWebView.RootComponents.Add<App>("#app");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        private void showCounter_Click(object sender, EventArgs e) =>
            MessageBox.Show(
                owner:   this,
                text:    $"Current counter value is: {_appState.Counter}",
                caption: "Counter",
                buttons: MessageBoxButtons.OK,
                icon:    MessageBoxIcon.Asterisk);

        private void exit_Click(object sender, EventArgs e) => Application.Exit();
        private void Form_FormClosing(object sender, FormClosingEventArgs e) =>
            e.Cancel = MessageBox.Show(
                text:          "Do you want to close?",
                caption:       "Alert!",
                buttons:       MessageBoxButtons.YesNo,
                icon:          MessageBoxIcon.Question,
                defaultButton: MessageBoxDefaultButton.Button2) == DialogResult.No;

        private void description_Click(object sender, EventArgs e) =>
            MessageBox.Show(
                text:    "This demo shows how Blazor running on Windows.",
                caption: "About",
                buttons: MessageBoxButtons.OK,
                icon:    MessageBoxIcon.Information);
    }
}
