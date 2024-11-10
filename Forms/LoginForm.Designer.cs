namespace Forms;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        usernameInput = new TextBox();
        passwordInput = new TextBox();
        passwordLabel = new Label();
        usernameLabel = new Label();
        signInButton = new Button();
        SuspendLayout();
        // 
        // usernameInput
        // 
        usernameInput.Location = new Point(137, 39);
        usernameInput.Name = "usernameInput";
        usernameInput.Size = new Size(100, 23);
        usernameInput.TabIndex = 0;
        // 
        // passwordInput
        // 
        passwordInput.Location = new Point(137, 118);
        passwordInput.Name = "passwordInput";
        passwordInput.Size = new Size(100, 23);
        passwordInput.TabIndex = 1;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(15, 121);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(57, 15);
        passwordLabel.TabIndex = 2;
        passwordLabel.Text = "Password";
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Location = new Point(12, 42);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(60, 15);
        usernameLabel.TabIndex = 3;
        usernameLabel.Text = "Username";
        // 
        // signInButton
        // 
        signInButton.Location = new Point(105, 186);
        signInButton.Name = "signInButton";
        signInButton.Size = new Size(75, 23);
        signInButton.TabIndex = 4;
        signInButton.Text = " Sign In";
        signInButton.UseVisualStyleBackColor = true;
        signInButton.Click += signInButton_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(307, 240);
        Controls.Add(signInButton);
        Controls.Add(usernameLabel);
        Controls.Add(passwordLabel);
        Controls.Add(passwordInput);
        Controls.Add(usernameInput);
        Name = "LoginForm";
        Text = "LoginForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox usernameInput;
    private TextBox passwordInput;
    private Label passwordLabel;
    private Label usernameLabel;
    private Button signInButton;
}
