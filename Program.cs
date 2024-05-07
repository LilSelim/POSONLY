using SalesAdminscreenfinal;
using System;
using System.Data;
using System.Windows.Forms;
static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        var shoppingCartForm = new ShoppingCartForm();
        Application.Run(new ProductCatalog(new DataTable(), shoppingCartForm));
    }
}
