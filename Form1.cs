using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class ShoppingCartForm : Form
{
    private List<Item> items;

    public ShoppingCartForm()
    {
        InitializeComponent();
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
        itemsListBox.Items.Add($"{item.Name} - {item.Price:C}");
        UpdateTotal();
    }

    private void RemoveItemButton_Click(object sender, EventArgs e)
    {
        if (itemsListBox.SelectedItem != null)
        {
            var selectedItem = itemsListBox.SelectedItem.ToString();
            var selectedItemName = selectedItem.Split('-')[0].Trim();
            var itemToRemove = items.FirstOrDefault(i => i.Name == selectedItemName);
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                itemsListBox.Items.Remove(itemsListBox.SelectedItem);
                UpdateTotal();
            }
        }
    }

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Purchase confirmed!");
        items.Clear();
        itemsListBox.Items.Clear();
        UpdateTotal();
    }

    private void UpdateTotal()
    {
        totalTextBox.Text = $"Total: {items.Sum(i => i.Price):C}";
    }
}

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
