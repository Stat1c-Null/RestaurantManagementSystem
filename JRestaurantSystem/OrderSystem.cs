using JRestaurantSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tsunami
{
    public partial class OrderSystem : Form
    {
        /// <summary>
        /// The main form of the Tsunami application.
        /// </summary>
        private enum Page { Menu, Items, Detail, Confirm }
        private Page currentPage, prevPage;

        private string[] confirmedItems;

        private ListBox lstOrder;

        private string currentCategory, currentItem;

        private string waiterName;

        public KitchenForm kitchenForm;

        /// <summary>
        /// Menu categories and items
        /// </summary>
        private readonly Dictionary<string, List<string>> menu = new()
        {
            ["Appetizers"] = new() { "Buffalo Blue Chips", "Catfish Bites", "Fried Veggies", "Fried Cheese" },
            ["Burgers"] = new() { "Bacon Cheeseburger", "Mushroom Swiss Burger", "Carolina Burger", "Portobello Burger (V)" },
            ["Sandwiches"] = new() { "Meatball Sub", "Cordon Bleu", "Club", "Grilled Cheese (V)" },
            ["Sides"] = new() { "Curly", "Wing Chips", "Creamy Cabbage", "Mashed Potatoes", "Broccoli" },
            ["Salads"] = new() { "House Salad", "Wedge Salad", "Caesar Salad", "Sweet Potato Chicken Salad" },
            ["Beverages"] = new() { "Coke", "Sweet Tea", "Lemonade", "Water" }
        };
        private readonly Dictionary<string, string> descriptions = new()
        {
            // Appetizers 
            ["Buffalo Blue Chips"] = "House‑made chips tossed in buffalo sauce, topped with blue cheese crumbles. Choice of ranch or blue cheese on top.",
            ["Catfish Bites"] = "Cornmeal‑battered catfish pieces fried golden. Served with lemon wedges and spicy cocktail sauce.",
            ["Fried Veggies"] = "Choice of okra, zucchini, squash or mix‑and‑match. Served with a side of spicy ranch.",
            ["Fried Cheese"] = "Choice of mac & cheese bites, pimento cheese or mozzarella cheese.",

            // Burgers
            ["Bacon Cheeseburger"] = "8‑ounce burger topped with bacon & your choice of American, cheddar, Swiss, provolone, pepper jack, blue cheese or pimento cheese on a brioche bun.",
            ["Mushroom Swiss Burger"] = "8‑ounce burger topped with sautéed mushrooms & Swiss cheese on a brioche bun.",
            ["Carolina Burger"] = "8‑ounce burger topped with chili, diced onions & slaw on a brioche bun. Lettuce, tomato & onion available upon request.",
            ["Portobello Burger (V)"] = "Marinated Portobello mushroom cap topped with mango salsa, lettuce, tomato & onion on a telera bun.",

            // Sandwiches 
            ["Meatball Sub"] = "House‑made meatballs topped with marinara & mozzarella cheese. Sautéed peppers & onions available upon request.",
            ["Cordon Bleu"] = "Grilled chicken topped with ham, Swiss cheese, lettuce & tomato on a pretzel bun.",
            ["Club"] = "Ham, turkey, Swiss, cheddar, lettuce, tomato, mayo & bacon on multigrain bread.",
            ["Grilled Cheese (V)"] = "American cheese served on multigrain or white bread.",

            // Sides
            ["Curly"] = "Crispy curly fries seasoned with sea salt.",
            ["Wing Chips"] = "Crispy seasoned potato chips.",
            ["Creamy Cabbage"] = "House‑made creamy cabbage slaw.",
            ["Mashed Potatoes"] = "Buttery mashed potatoes.",
            ["Broccoli"] = "Steamed broccoli.",

            // Salads
            ["House Salad"] = "Mixed greens topped with bacon, tomato & blue cheese crumbles.",
            ["Wedge Salad"] = "Iceberg lettuce wedge topped with bacon, tomato & blue cheese crumbles.",
            ["Caesar Salad"] = "Romaine lettuce, shredded Parmesan & croutons tossed in Caesar dressing.",
            ["Sweet Potato Chicken Salad"] = "Mixed greens with red onion, dried cranberries & goat cheese, topped with sweet potato‑crusted chicken.",

            // Beverages 
            ["Coke"] = "Chilled Coca‑Cola soda.",
            ["Sweet Tea"] = "Fresh‑brewed sweet tea.",
            ["Lemonade"] = "Refreshing house‑made lemonade.",
            ["Water"] = "Bottled water."

        };
        private readonly Dictionary<string, decimal> prices = new()
        {
            // Appetizers
            ["Buffalo Blue Chips"] = 6.00m,
            ["Catfish Bites"] = 6.50m,
            ["Fried Veggies"] = 6.50m,
            ["Fried Cheese"] = 7.50m,

            // Burgers
            ["Bacon Cheeseburger"] = 11.00m,
            ["Mushroom Swiss Burger"] = 11.00m,
            ["Carolina Burger"] = 11.00m,
            ["Portobello Burger (V)"] = 8.50m,

            // Sandwiches
            ["Meatball Sub"] = 10.00m,
            ["Cordon Bleu"] = 11.00m,
            ["Club"] = 10.00m,
            ["Grilled Cheese (V)"] = 5.50m,

            // Sides 
            ["Curly"] = 2.50m,
            ["Wing Chips"] = 2.50m,
            ["Creamy Cabbage"] = 2.50m,
            ["Mashed Potatoes"] = 2.50m,
            ["Broccoli"] = 2.50m,

            // Salads
            ["House Salad"] = 7.50m,
            ["Wedge Salad"] = 7.50m,
            ["Caesar Salad"] = 7.50m,
            ["Sweet Potato Chicken Salad"] = 11.50m,

            // Beverages
            ["Coke"] = 2.00m,
            ["Sweet Tea"] = 2.00m,
            ["Lemonade"] = 2.00m,
            ["Water"] = 2.00m

        };

        public OrderSystem(string waiterName, string tableNumber, KitchenForm kitchenForm)
        {
            InitializeComponent();

            // grab controls that Designer created:
            pnlContent = this.pnlContent;
            lstOrder = this.lstOrder;


            // handle clicks on the “✕” buttons
            dgvOrder.CellClick += DgvOrder_CellClick;
            UpdateTotal();



            ShowPage(Page.Menu);
            this.waiterName = waiterName;
            lblEmp.Text = waiterName;

            lblTitle.Text = tableNumber;
            this.kitchenForm = kitchenForm;
        }

        /// <summary>
        /// Shows the specified page in the main content area.
        /// </summary>
        /// <param name="target"></param>
        private void ShowPage(Page target)
        {
            prevPage = currentPage;
            currentPage = target;
            pnlContent.Controls.Clear();

            switch (target)
            {
                case Page.Menu: DrawMenuCategories(); break;
                case Page.Items: DrawCategoryItems(); break;
                case Page.Detail: DrawItemDetail(); break;
                case Page.Confirm: DrawConfirmation(); break;
            }

        }





        /// <summary>
        /// Draws the menu categories, including a header label
        /// </summary>
        private void DrawMenuCategories()
        {
            pnlContent.Controls.Clear();

            /// (Optional) Add a header label
            var lbl = new Label
            {
                Text = "Menu",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            pnlContent.Controls.Add(lbl);

            var flow = new FlowLayoutPanel
            {
                Location = new Point(20, 80),
                Size = new Size(pnlContent.Width - 60, 400),
                AutoScroll = true
            };
            pnlContent.Controls.Add(flow);

            foreach (var catKey in menu.Keys)
            {
                /// capture into a fresh local each iteration
                var category = catKey;

                var btn = new Button
                {
                    Text = category,
                    Size = new Size(200, 60),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    BackColor = Color.LightBlue,
                    Margin = new Padding(10)
                };
                btn.Click += (s, e) =>
                {
                    currentCategory = category;
                    ShowPage(Page.Items);
                };
                flow.Controls.Add(btn);
            }
        }

        /// <summary>
        /// Draws the items in the selected category, including a header label
        /// </summary>
        private void DrawCategoryItems()
        {
            pnlContent.Controls.Clear();

            /// guard: if somehow currentCategory is null or invalid, bail back  
            if (string.IsNullOrEmpty(currentCategory) || !menu.ContainsKey(currentCategory))
            {
                MessageBox.Show("Please pick a category first.", "Oops");
                ShowPage(Page.Menu);
                return;
            }

            /// Category header
            var lblCat = new Label
            {
                Text = currentCategory,
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            pnlContent.Controls.Add(lblCat);

            var flow = new FlowLayoutPanel
            {
                Location = new Point(20, 80),
                Size = new Size(pnlContent.Width - 60, 400),
                AutoScroll = true
            };
            pnlContent.Controls.Add(flow);

            foreach (var item in menu[currentCategory])
            {
                var menuItem = item;
                var btn = new Button
                {
                    Text = menuItem,
                    Size = new Size(200, 60),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    BackColor = Color.LightBlue,
                    Margin = new Padding(10)
                };
                btn.Click += (s, e) =>
                {
                    currentItem = menuItem;
                    ShowPage(Page.Detail);
                };
                flow.Controls.Add(btn);
            }
        }


        /// <summary>
        /// Draws the item detail page, including a description, notes textbox,
        /// </summary>
        private void DrawItemDetail()
        {
            pnlContent.Controls.Clear();

            // guard
            if (string.IsNullOrEmpty(currentItem))
            {
                MessageBox.Show("No item selected.", "Oops");
                ShowPage(Page.Menu);
                return;
            }

            // Item title at top
            var lblItem = new Label
            {
                Text = currentItem,
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            pnlContent.Controls.Add(lblItem);

            var lblDesc = new Label
            {
                Text = descriptions.TryGetValue(currentItem, out var d) ? d : "",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.White,
                Location = new Point(20, 80),

                AutoSize = true,
                MaximumSize = new Size(pnlContent.ClientSize.Width - 40, 0)
            };
            pnlContent.Controls.Add(lblDesc);

            var lblQty = new Label
            {
                Text = "Qty:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 160),
                AutoSize = true
            };
            pnlContent.Controls.Add(lblQty);

            var numQty = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 20,
                Value = 1,
                Location = new Point(80, 158),
                Size = new Size(60, 28),
                Font = new Font("Segoe UI", 12)
            };
            pnlContent.Controls.Add(numQty);

            var btnAdd = new Button
            {
                Text = "ADD ITEM",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Size = new Size(180, 60),
                Location = new Point(20, 220),
                BackColor = Color.White,
                ForeColor = ColorTranslator.FromHtml("#08203E"),
                FlatStyle = FlatStyle.Flat
            };
            btnAdd.Click += (s, e) =>
            {
                int qty = (int)numQty.Value;
                for (int i = 0; i < qty; i++)
                    dgvOrder.Rows.Add(currentItem);

                UpdateTotal();
                ShowPage(Page.Menu);
            };
            pnlContent.Controls.Add(btnAdd);
        }



        /// <summary>
        /// Builds a modal dialog to confirm the order.
        /// </summary>
        private void DrawConfirmation()
        {
            /// Build a modal dialog
            var dlg = new Form
            {
                Size = new Size(500, 300),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                BackColor = ColorTranslator.FromHtml("#15304A"),
                Text = "Confirm Order"
            };

            /// Title bar
            var lblTitle = new Label
            {
                Text = "CONFIRMATION",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 60,
                TextAlign = ContentAlignment.MiddleCenter
            };
            dlg.Controls.Add(lblTitle);

            /// Question
            var lblQ = new Label
            {
                Text = $"Submit this order ({lstOrder.Items.Count} lines)?",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.White,
                Location = new Point(20, 80),
                AutoSize = true
            };
            dlg.Controls.Add(lblQ);

            /// YES button
            var btnYes = new Button
            {
                Text = "YES",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(100, 50),
                Location = new Point(80, 180),
                BackColor = ColorTranslator.FromHtml("#15304A"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnYes.Click += (s, e) =>
            {
                /// Here you’d send the order off to your backend…
                MessageBox.Show("Order submitted!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                /// Clear for next order
                lstOrder.Items.Clear();
                dlg.Close();
            };
            dlg.Controls.Add(btnYes);

            /// NO button
            var btnNo = new Button
            {
                Text = "NO",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(100, 50),
                Location = new Point(300, 180),
                BackColor = Color.LightBlue,
                FlatStyle = FlatStyle.Flat
            };
            btnNo.Click += (s, e) => dlg.Close();
            dlg.Controls.Add(btnNo);

            /// Show it
            dlg.ShowDialog(this);

            /// After closing, always go back to the main menu
            ShowPage(Page.Menu);
        }

        private void DgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// If they clicked the “✕” column, remove that row
            if (e.RowIndex >= 0 && dgvOrder.Columns[e.ColumnIndex].Name == "colRemove")
            {
                dgvOrder.Rows.RemoveAt(e.RowIndex);
                UpdateTotal();
            }
        }

        /// <summary>
        /// Recomputes the sum of all item prices in the grid
        /// and updates lblTotal.Text accordingly.
        /// </summary>
        private void UpdateTotal()
        {
            decimal total = 0m;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                var name = row.Cells["colItem"].Value?.ToString();
                if (name != null && prices.TryGetValue(name, out var price))
                {
                    total += price;
                }
            }
            lblTotal.Text = $"Total: {total:C}";
        }



        /// <summary>
        /// Handle button clicks to navigate back to the previous page
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e) => ShowPage(prevPage);
        private void btnHome_Click(object sender, EventArgs e) => ShowPage(Page.Menu);

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
