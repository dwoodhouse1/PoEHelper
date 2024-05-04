namespace PoEHelper
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            _mainMenu.OnClicked += SwitchForm;
            _optionMenu.OnClicked += SwitchForm;
            _usefulLinksMenu.OnClicked += SwitchForm;

            mainPanel.Controls.Add(_mainMenu);
            mainPanel.Controls.Add(_optionMenu);
            mainPanel.Controls.Add(_usefulLinksMenu);


            _mainMenu.Dock = DockStyle.Fill;
            _optionMenu.Dock = DockStyle.Fill;
            _usefulLinksMenu.Dock = DockStyle.Fill;
        }


        public void SwitchForm(ScreenNames screenToChangeTo)
        {
            switch (screenToChangeTo)
            {
                case ScreenNames.Homepage:
                    _optionMenu.Hide();
                    _mainMenu.Show();
                    MessageBox.Show("hehe");
                    break;

                case ScreenNames.Options:
                    _mainMenu.Hide();
                    _optionMenu.Show();

                    break;

                case ScreenNames.UsefulLinks:
                    _optionMenu.Hide();
                    _usefulLinksMenu.Show();
                    break;

            }

        }


        MainMenu _mainMenu = new MainMenu();
        Options _optionMenu = new Options();
        UsefulLinks _usefulLinksMenu = new UsefulLinks();

    }
}