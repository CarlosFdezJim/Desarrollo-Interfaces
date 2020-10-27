namespace PizzaOrder
{
    partial class pedidoPizza
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedidoPizza));
            this.logo = new System.Windows.Forms.PictureBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.largePizza = new System.Windows.Forms.RadioButton();
            this.smallPizza = new System.Windows.Forms.RadioButton();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.order = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.TextBox();
            this.theMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.sizeOptions.SuspendLayout();
            this.theMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "A slice of pizza";
            this.logo.AccessibleName = "Company logo";
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(50, 41);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(43, 39);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Company name";
            this.companyLabel.AccessibleName = "Company name";
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Blue;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(146, 41);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(272, 55);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Good Pizza";
            this.companyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AccessibleDescription = "Customer name label";
            this.customerLabel.AccessibleName = "Customer name label";
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(208, 127);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(57, 16);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "&Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sizeOptions);
            this.panel1.Controls.Add(this.toppingsLabel);
            this.panel1.Controls.Add(this.toppings);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.customerName);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.customerLabel);
            this.panel1.Controls.Add(this.companyLabel);
            this.panel1.Controls.Add(this.theMainMenu);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 379);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Pizza size options";
            this.sizeOptions.AccessibleName = "Pizza size options";
            this.sizeOptions.Controls.Add(this.largePizza);
            this.sizeOptions.Controls.Add(this.smallPizza);
            this.sizeOptions.Location = new System.Drawing.Point(29, 185);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Size = new System.Drawing.Size(200, 100);
            this.sizeOptions.TabIndex = 4;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Precio Pizza";
            // 
            // largePizza
            // 
            this.largePizza.AccessibleDescription = "Large pizza";
            this.largePizza.AccessibleName = "Large pizza";
            this.largePizza.AutoSize = true;
            this.largePizza.Location = new System.Drawing.Point(21, 56);
            this.largePizza.Name = "largePizza";
            this.largePizza.Size = new System.Drawing.Size(94, 20);
            this.largePizza.TabIndex = 1;
            this.largePizza.Text = "&Large    10€";
            this.largePizza.UseVisualStyleBackColor = true;
            // 
            // smallPizza
            // 
            this.smallPizza.AccessibleDescription = "Small pizza";
            this.smallPizza.AccessibleName = "Small pizza";
            this.smallPizza.AutoSize = true;
            this.smallPizza.Checked = true;
            this.smallPizza.Location = new System.Drawing.Point(21, 30);
            this.smallPizza.Name = "smallPizza";
            this.smallPizza.Size = new System.Drawing.Size(92, 20);
            this.smallPizza.TabIndex = 0;
            this.smallPizza.TabStop = true;
            this.smallPizza.Text = "&Small      6€";
            this.smallPizza.UseVisualStyleBackColor = true;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AccessibleDescription = "Toppings label";
            this.toppingsLabel.AccessibleName = "Toppings label";
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(285, 166);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(132, 16);
            this.toppingsLabel.TabIndex = 5;
            this.toppingsLabel.Text = "&Toopings         (0,75€)";
            // 
            // toppings
            // 
            this.toppings.AccessibleDescription = "Available toppings";
            this.toppings.AccessibleName = "Available toppings";
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "Pablo García",
            "Guillermo Santamaría",
            "Adrian Castillo"});
            this.toppings.Location = new System.Drawing.Point(285, 185);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(176, 106);
            this.toppings.TabIndex = 6;
            this.toppings.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // order
            // 
            this.order.AccessibleDescription = "Total the order";
            this.order.AccessibleName = "Total order";
            this.order.Location = new System.Drawing.Point(320, 310);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(75, 23);
            this.order.TabIndex = 7;
            this.order.Text = "&Pedir";
            this.order.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.AccessibleDescription = "Cancel the order";
            this.cancel.AccessibleName = "Cancel order";
            this.cancel.Location = new System.Drawing.Point(91, 310);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "&Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // customerName
            // 
            this.customerName.AccessibleDescription = "Customer name";
            this.customerName.AccessibleName = "Customer name";
            this.customerName.Location = new System.Drawing.Point(285, 127);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(176, 22);
            this.customerName.TabIndex = 3;
            // 
            // theMainMenu
            // 
            this.theMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands});
            this.theMainMenu.Location = new System.Drawing.Point(0, 0);
            this.theMainMenu.Name = "theMainMenu";
            this.theMainMenu.Size = new System.Drawing.Size(525, 24);
            this.theMainMenu.TabIndex = 9;
            this.theMainMenu.Text = "menuStrip1";
            // 
            // fileCommands
            // 
            this.fileCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApp});
            this.fileCommands.Name = "fileCommands";
            this.fileCommands.Size = new System.Drawing.Size(37, 20);
            this.fileCommands.Text = "&File";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(93, 22);
            this.exitApp.Text = "E&xit";
            // 
            // pedidoPizza
            // 
            this.AccessibleDescription = "Order form";
            this.AccessibleName = "Order form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 377);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.theMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pedidoPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            this.theMainMenu.ResumeLayout(false);
            this.theMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox toppings;
        private System.Windows.Forms.RadioButton largePizza;
        private System.Windows.Forms.RadioButton smallPizza;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.MenuStrip theMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCommands;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
    }
}

