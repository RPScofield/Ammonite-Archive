namespace AmmoniteArchive;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Text = "Ammonite Archive";
        this.Size = new Size(800, 600);
        
        // Add welcome message
        var welcomeLabel = new Label
        {
            Text = "Welcome to Ammonite Archive!\n\nThis is a demonstration interface for archiving and managing ammonite fossils.",
            Location = new Point(50, 50),
            Size = new Size(700, 80),
            Font = new Font("Arial", 12, FontStyle.Bold)
        };
        this.Controls.Add(welcomeLabel);
        
        // Add description
        var descLabel = new Label
        {
            Text = "Ammonites are extinct marine mollusks that lived millions of years ago.\nThis application helps catalog and preserve information about these ancient fossils.",
            Location = new Point(50, 150),
            Size = new Size(700, 60),
            Font = new Font("Arial", 10)
        };
        this.Controls.Add(descLabel);
        
        // Add a simple list box
        var listBox = new ListBox
        {
            Location = new Point(50, 230),
            Size = new Size(700, 250)
        };
        listBox.Items.Add("Sample Ammonite 1 - Cretaceous Period");
        listBox.Items.Add("Sample Ammonite 2 - Jurassic Period");
        listBox.Items.Add("Sample Ammonite 3 - Triassic Period");
        this.Controls.Add(listBox);
        
        // Add a button
        var button = new Button
        {
            Text = "View Details",
            Location = new Point(50, 500),
            Size = new Size(150, 40)
        };
        button.Click += (sender, e) => 
        {
            if (listBox.SelectedIndex >= 0)
            {
                MessageBox.Show($"Details for: {listBox.SelectedItem}", "Ammonite Details");
            }
            else
            {
                MessageBox.Show("Please select an ammonite from the list.", "No Selection");
            }
        };
        this.Controls.Add(button);
    }
}
