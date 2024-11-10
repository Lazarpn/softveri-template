using Common.Models;
using Core;

namespace Forms;

public partial class LoginForm : Form
{
    private readonly UserManager userManager;

    public LoginForm()
    {
        InitializeComponent();
        userManager = new UserManager();
    }

    private void signInButton_Click(object sender, EventArgs e)
    {
        var userSignInModel = new UserSignInModel
        {
            UserName = usernameInput.Text,
            Password = passwordInput.Text,
        };

        var successfullSignIn = userManager.SignIn(userSignInModel);

        if (successfullSignIn)
        {
            MessageBox.Show("Uspesna prijava!");
        } else
        {
            MessageBox.Show("Neuspesna prijava!");
        }
    }
}
