partial class ShoppingCartForm
{
    private System.Windows.Forms.ListBox itemsListBox;
    private System.Windows.Forms.TextBox totalTextBox;
    private System.Windows.Forms.Button removeItemButton;
    private System.Windows.Forms.Button confirmButton;

    private void InitializeComponent()
    {
        // code that displays all the clicked items
        this.itemsListBox = new System.Windows.Forms.ListBox();
        this.itemsListBox.FormattingEnabled = true;
        this.itemsListBox.Location = new System.Drawing.Point(12, 12);
        this.itemsListBox.Name = "itemsListBox";
        this.itemsListBox.Size = new System.Drawing.Size(200, 225);
        this.itemsListBox.TabIndex = 0;

        // 
        // a textbox that displays the total cost of everything
        // 
        this.totalTextBox = new System.Windows.Forms.TextBox();
        this.totalTextBox.Location = new System.Drawing.Point(12, 243);
        this.totalTextBox.Name = "totalTextBox";
        this.totalTextBox.ReadOnly = true;
        this.totalTextBox.Size = new System.Drawing.Size(200, 20);
        this.totalTextBox.TabIndex = 1;

        // 
        // button that removes stuff from the shopping cart
        // 
        this.removeItemButton = new System.Windows.Forms.Button();
        this.removeItemButton.Location = new System.Drawing.Point(218, 12);
        this.removeItemButton.Name = "removeItemButton";
        this.removeItemButton.Size = new System.Drawing.Size(94, 23);
        this.removeItemButton.TabIndex = 2;
        this.removeItemButton.Text = "Remove Item";
        this.removeItemButton.UseVisualStyleBackColor = true;
        this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);

        // 
        // add functionality later so that when the confirm button is clicked it updates the database
        // 
        this.confirmButton = new System.Windows.Forms.Button();
        this.confirmButton.Location = new System.Drawing.Point(218, 41);
        this.confirmButton.Name = "confirmButton";
        this.confirmButton.Size = new System.Drawing.Size(94, 23);
        this.confirmButton.TabIndex = 3;
        this.confirmButton.Text = "Confirm";
        this.confirmButton.UseVisualStyleBackColor = true;
        this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);

        // 
        // ShoppingCartForm
        // 
        this.ClientSize = new System.Drawing.Size(324, 275);
        this.Controls.Add(this.confirmButton);
        this.Controls.Add(this.removeItemButton);
        this.Controls.Add(this.totalTextBox);
        this.Controls.Add(this.itemsListBox);
    }
}
