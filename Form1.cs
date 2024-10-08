namespace CashierApplication
{
    public partial class frmPurchaseDiscountItem : Form
    {
        public frmPurchaseDiscountItem()
        {
            InitializeComponent();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, discount);

                double discountedPrice = discountedItem.GetDiscountedPrice();
                double totalAmount = discountedPrice * quantity;

                lblTotalAmount.Text = $" {totalAmount:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string name, double price)
            {
                Name = name;
                Price = price;

            }
        }
        public class DiscountedItem : Item
        {
            public double Discount { get; set; }

            public DiscountedItem(string name, double price, double discount) : base(name, price)
            {
                Discount = discount;
            }

            public double GetDiscountedPrice()
            {
                double discountAmount = Discount * 0.01 * Price;
                return Price - discountAmount;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double payment = Convert.ToDouble(txtPayment.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, discount);

                double totalAmount = discountedItem.GetDiscountedPrice() * quantity;

                double change = payment - totalAmount;

                lblChange.Text = $"Change: {change:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

    }


}
    
