using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using System;

namespace App1.Views.Login
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLoginPage
    {
        static string Password { get; set; }
        static string Login { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLoginPage" /> class.
        /// </summary>
        public SimpleLoginPage()
        {

            InitializeComponent();
            Password = PasswordEntry.Placeholder;
            Login = Login
            
        }
        public static void Login(object sender, EventArgs e)
        {
            
        }
    }
    
}