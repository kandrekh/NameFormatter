namespace NameFormatter
{
    /**
     * @author: K-Andre Harris
     * @date: February 13, 2025,
     * Chapter 3 Problem 1
     * ----------------------------------------------------------------------
     * This program allows users to enter their full names
     * and the program formats the names by rearranging their placements
     * ----------------------------------------------------------------------
     */
    public partial class NameFormatterForm : Form
    {
        public NameFormatterForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
            lstResults.Items.Clear();
            
            string title = preferredTitle.SelectedItem?.ToString() ?? string.Empty;
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            
            string fullName = $"{title} {firstName} {middleName} {lastName}";
            lstResults.Items.Add(fullName);
            
            lstResults.Items.Add($"{firstName} {middleName} {lastName}".Trim()); 
            lstResults.Items.Add($"{firstName} {lastName}".Trim());
            lstResults.Items.Add($"{lastName}, {firstName} {middleName}, {title}".Trim());
           
            lstResults.Items.Add($"{lastName}, {firstName} {middleName}".Trim());
            lstResults.Items.Add($"{lastName}, {firstName}".Trim());
            lstResults.Visible = true;


        }
    }
}
