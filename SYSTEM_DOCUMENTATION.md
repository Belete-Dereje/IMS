# Inventory Management System (IMS) — System Documentation

## 1. What is this system?

The Inventory Management System (IMS) is a desktop application built with **C# Windows Forms**.
It helps a small business keep track of:

- Products (code, name, category, unit, supplier, cost, price, quantity, minimum stock)
- Categories (used to group products)
- Suppliers (contact details)
- Stock movements — goods received (**Stock In**) and goods issued/sold (**Stock Out**)
- Reports (stock status, low stock, stock movement history, profit)

All screens are designed in the **Visual Studio Windows Forms Designer**, 
so the layout lives in `*.Designer.cs` files and the behavior lives in `*.cs` code-behind files.

> **Important:** Data is stored **in memory only** (static lists). When the application closes, all products, suppliers, 
categories, and transactions are lost. There is no database or file storage yet.

---

## 2. Technology and architecture

| Item | Details |
|---|---|
| Language | C# |
| UI framework | Windows Forms (WinForms) |
| Target framework | `net10.0-windows` (see `IMS.csproj`) |
| Entry point | `Program.cs` → `Application.Run(new LoginForm())` |
| Design tool | Visual Studio Windows Forms Designer |
| Data storage | In-memory static lists (`InventoryData`) |

### Architectural style

The application uses a **single-window navigation** pattern:

1. `Program` starts `LoginForm`.
2. `LoginForm` opens either `RegisterForm` or `DashboardForm`.
3. `DashboardForm` acts as the shell. It has a sidebar and a content area (`pnlPageHost`).
4. Module screens (Products, Categories, Suppliers, Stock In, Stock Out, Transactions, Reports) 
    are **hosted inside** `pnlPageHost` as child forms, not opened as separate windows.

```
Program
  └── LoginForm
        ├── RegisterForm
        └── DashboardForm  (shell window)
              ├── ProductsForm
              ├── CatagoriesForm
              ├── SuppliersForm
              ├── StockInForm
              ├── StockOutForm
              ├── TransactionsForm
              └── ReportsForm
```

---

## 3. Project structure

| File | Purpose |
|---|---|
| `Program.cs` | Application entry point |
| `MainForm.cs` / `MainForm.Designer.cs` | Contains the `LoginForm` class (the file name is `MainForm`, the class is `LoginForm`) |
| `RegisterForm.cs` / `.Designer.cs` | Account registration screen |
| `DashboardForm.cs` / `.Designer.cs` | Main shell with sidebar, summary cards, low-stock list, and page host |
| `ProductsForm.cs` / `.Designer.cs` | Add, edit, delete, and search products |
| `CatagoriesForm.cs` / `.Designer.cs` | Add, edit, delete, and search categories (note the file spelling "Catagories") |
| `SuppliersForm.cs` / `.Designer.cs` | Add, edit, delete, and search suppliers |
| `StockInForm.cs` / `.Designer.cs` | Receive stock and record a Stock In transaction |
| `StockOutForm.cs` / `.Designer.cs` | Issue/sell stock and record a Stock Out transaction |
| `TransactionsForm.cs` / `.Designer.cs` | View and search the full transaction history |
| `ReportsForm.cs` / `.Designer.cs` | Generate filtered reports with summary cards |
| `InventoryData.cs` | Shared in-memory data store (static lists) |
| `Product.cs` | Product model |
| `Supplier.cs` | Supplier model |
| `StockTransaction.cs` | Stock movement model |

---

## 4. Data model (main classes)

### 4.1 `Product` (`Product.cs`)

Represents one item in inventory.

| Property | Type | Meaning |
|---|---|---|
| `ProductCode` | `string` | Unique code used to identify the product |
| `ProductName` | `string` | Display name |
| `Category` | `string` | Category name (linked to `InventoryData.Categories`) |
| `Unit` | `string` | Unit of measure (e.g. pcs, Kg) |
| `SupplierCode` | `string` | Code of the supplier that provides the product |
| `PurchaseCost` | `decimal` | Buying price per unit |
| `SellingPrice` | `decimal` | Selling price per unit |
| `Quantity` | `int` | Current stock on hand |
| `MinimumStock` | `int` | Threshold for low-stock warnings |

### 4.2 `Supplier` (`Supplier.cs`)

| Property | Type | Meaning |
|---|---|---|
| `SupplierCode` | `string` | Unique supplier code |
| `SupplierName` | `string` | Supplier name |
| `Phone` | `string` | Phone number |
| `Email` | `string` | Email address |
| `Address` | `string` | Physical address |

### 4.3 `StockTransaction` (`StockTransaction.cs`)

Represents one movement of stock (in or out).

| Property | Type | Meaning |
|---|---|---|
| `ProductCode` | `string` | Product that moved |
| `ProductName` | `string` | Product name (copied for history) |
| `SupplierCode` | `string` | Supplier (used for Stock In) |
| `TransactionType` | `string` | `"Stock In"` or `"Stock Out"` |
| `Quantity` | `int` | Units moved |
| `Profit` | `decimal` | Profit earned (Stock Out only) |
| `Notes` | `string` | Optional note/reason |
| `TransactionDate` | `DateTime` | When the movement happened |

### 4.4 `InventoryData` (`InventoryData.cs`)

A `static` class that acts as the application's shared memory. Every form reads and writes these same lists.

| List | Type | Stores |
|---|---|---|
| `Products` | `List<Product>` | All products |
| `Suppliers` | `List<Supplier>` | All suppliers |
| `Categories` | `List<string>` | All category names |
| `StockTransactions` | `List<StockTransaction>` | All stock movements |

### Relationships

```
Category (string) ──────┐
                        ├── Product ── SupplierCode ──> Supplier
Supplier ───────────────┘

Product ── ProductCode ──> StockTransaction
```

- A product belongs to one category and one supplier.
- A stock transaction refers to one product (by code).
- Categories and suppliers are stored as simple lists; products reference them by name/code.

---

## 5. Application flow

### 5.1 Startup

```
Program.Main()
  → ApplicationConfiguration.Initialize()
  → Application.Run(new LoginForm())
```

### 5.2 Login / Register flow

```
LoginForm
  ├── [Login]    → hide Login, show DashboardForm
  │                (closing Dashboard closes the application)
  ├── [Register] → hide Login, show RegisterForm
  │                (closing Register shows Login again)
  └── closing Login → application ends

RegisterForm
  └── [Back to Login] → closes Register → Login reappears
```

> **Current behavior:** the Login button does **not** validate credentials, and the Register screen's **Register** button has no click handler yet. They are UI placeholders.

### 5.3 Dashboard navigation

`DashboardForm` uses `ShowPage(Form page)`:

1. Clears any previous page from `pnlPageHost`.
2. Sets the new form to `TopLevel = false`, `FormBorderStyle = None`, `Dock = Fill`.
3. Adds it to `pnlPageHost` and calls `page.Show()`.
4. When the page closes, the dashboard refreshes its summary and hides the page host.

Sidebar buttons:

| Button | Opens |
|---|---|
| Dashboard | Hides the page host and refreshes summary cards |
| Products | `ProductsForm` |
| Categories | `CatagoriesForm` |
| Suppliers | `SuppliersForm` |
| Stock In | `StockInForm` |
| Stock Out | `StockOutForm` |
| Transactions | `TransactionsForm` |
| Reports | `ReportsForm` |

### 5.4 Dashboard summary (`RefreshDashboard`)

The dashboard shows:

- **Total Products** — `InventoryData.Products.Count`
- **Total Categories** — distinct categories found on products
- **Today's Transactions** — transactions whose date is today
- **Low Stock Items** — products where `Quantity <= MinimumStock`
- **Low Stock Products list** — code, name, current quantity, minimum stock

---

## 6. Screens and main functions

### 6.1 `LoginForm` (`MainForm.cs`)

| Method | What it does |
|---|---|
| `LoginForm()` | Initializes the login UI |
| `btnRegister_Click` | Hides login, opens `RegisterForm`; re-shows login when it closes |
| `btnLogin_Click` | Hides login, opens `DashboardForm`; closes login when dashboard closes |

### 6.2 `RegisterForm` (`RegisterForm.cs`)

| Method | What it does |
|---|---|
| `RegisterForm()` | Initializes the registration UI |
| `RegisterForm_Load` | Empty placeholder |
| `btnBackToLogin_Click` | Closes the register form (login reappears) |

Fields: full name, username, email, password, confirm password. The **Register** button is not yet wired to logic.

### 6.3 `DashboardForm` (`DashboardForm.cs`)

| Method | What it does |
|---|---|
| `ShowPage(Form page)` | Embeds a module form inside `pnlPageHost` |
| `RefreshDashboard()` | Recomputes summary cards and the low-stock list |
| `btnProducts_Click` | Opens Products page |
| `btnCategories_Click` | Opens Categories page |
| `btnSuppliers_Click` | Opens Suppliers page |
| `btnStockIn_Click` | Opens Stock In page |
| `btnStockOut_Click` | Opens Stock Out page |
| `btnTransactions_Click` | Opens Transactions page |
| `btnReports_Click` | Opens Reports page |
| `btnDashboard_Click` | Returns to the dashboard overview |

### 6.4 `ProductsForm` (`ProductsForm.cs`)

Handles product CRUD.

| Method | What it does |
|---|---|
| `ProductsForm()` | Loads categories and suppliers into dropdowns, then refreshes the product list |
| `btnAddProduct_Click` | Validates input, then adds a new product or updates the one being edited |
| `btnEditProduct_Click` | Loads the selected product into the form for editing |
| `btnDeleteProduct_Click` | Confirms, then deletes the selected product |
| `btnClear_Click` | Clears the form and returns to "Add Product" mode |
| `txtSearchProducts_TextChanged` | Re-filters the list as the user types |
| `RefreshProductList()` | Rebuilds the `ListView` from `InventoryData.Products` |
| `btnBackToDashboard_Click` | Closes the page |

**Rules enforced:**

- Product code and name are required.
- Category, unit, and supplier must be selected.
- Product code must be unique (case-insensitive).
- When editing, the product is found by its original code and updated in place.
- Status column shows `Low Stock` when `Quantity <= MinimumStock`, otherwise `In Stock`.
- Search matches product code **or** product name.

### 6.5 `CatagoriesForm` (`CatagoriesForm.cs`)

| Method | What it does |
|---|---|
| `CatagoriesForm()` | Initializes and loads the category list |
| `RefreshCategoryList()` | Rebuilds the list, applying the search text |
| `btnAddCategory_Click` | Adds a new category or updates the one being edited |
| `btnEditCategory_Click` | Loads the selected category into the text box |
| `btnDeleteCategory_Click` | Deletes a category if no product is using it |
| `btnClearCategory_Click` | Clears the form |
| `ClearCategoryForm()` | Resets input, edit state, and selection |
| `txtSearchCategories_TextChanged` | Re-filters the list |
| `btnBackToDashboard_Click` | Closes the page |

**Rules enforced:**

- Category name is required.
- Duplicate categories are rejected (case-insensitive).
- Renaming a category also updates every product that used the old name.
- A category used by a product cannot be deleted.

### 6.6 `SuppliersForm` (`SuppliersForm.cs`)

| Method | What it does |
|---|---|
| `SuppliersForm()` | Initializes and loads the supplier list |
| `btnAddSupplier_Click` | Adds a new supplier or updates the one being edited |
| `btnEditSupplier_Click` | Loads the selected supplier into the form |
| `btnDeleteSupplier_Click` | Confirms, then deletes the selected supplier |
| `btnClearSupplier_Click` | Clears the form |
| `RefreshSupplierList()` | Rebuilds the list, applying the search text |
| `txtSearchSuppliers_TextChanged` | Re-filters the list |

**Rules enforced:**

- Supplier code and name are required.
- Supplier code must be unique (case-insensitive).
- Search matches supplier code **or** supplier name.
- Note: `btnAddSupplier_Click_1` exists but is empty and unused.

### 6.7 `StockInForm` (`StockInForm.cs`)

Used when new stock is received from a supplier.

| Method | What it does |
|---|---|
| `StockInForm()` | Loads products and suppliers into dropdowns |
| `btnStockIn_Click` | Validates selection, increases product quantity, records a `"Stock In"` transaction |

**Flow:**

1. User selects a product and supplier.
2. User enters quantity and optional notes.
3. The product's `Quantity` is increased.
4. A `StockTransaction` is added with type `"Stock In"`, date `DateTime.Now`, and profit `0`.
5. Quantity resets to 1 and notes are cleared.

**Rules enforced:**

- A product must be selected.
- A supplier must be selected.
- The resulting quantity must not exceed 1,000,000.

### 6.8 `StockOutForm` (`StockOutForm.cs`)

Used when stock is issued or sold.

| Method | What it does |
|---|---|
| `StockOutForm()` | Loads products into the dropdown |
| `btnStockOut_Click` | Validates quantity, reduces stock, records a `"Stock Out"` transaction with profit |

**Flow:**

1. User selects a product and enters quantity and optional notes.
2. The system checks that enough stock exists.
3. `Quantity` is reduced.
4. A `StockTransaction` is added with type `"Stock Out"` and:
   ```
   Profit = (SellingPrice - PurchaseCost) × QuantitySold
   ```
5. Quantity resets to 1 and notes are cleared.

**Rules enforced:**

- A product must be selected.
- Quantity to remove cannot exceed current stock.

### 6.9 `TransactionsForm` (`TransactionsForm.cs`)

Read-only transaction history.

| Method | What it does |
|---|---|
| `TransactionsForm()` | Loads the transaction list |
| `RefreshTransactionList()` | Rebuilds the list from `InventoryData.StockTransactions` |
| `txtSearchTransactions_TextChanged` | Re-filters by product code or product name |

Columns: Date, Transaction Type, Product Code, Product Name, Supplier, Quantity, Notes.

### 6.10 `ReportsForm` (`ReportsForm.cs`)

The reporting screen. It has filters, four summary cards, and a report list.

**Filters:**

- Report Type dropdown
- From date
- To date
- Generate Report button
- Clear button

**Summary cards (always shown):**

| Card | Calculation |
|---|---|
| Total Products | `InventoryData.Products.Count` |
| Stock Value | Sum of `Quantity × PurchaseCost` for all products |
| Low Stock Items | Count of products where `Quantity <= MinimumStock` |
| Total Transactions | `InventoryData.StockTransactions.Count` |

> **Why Stock Value instead of Total Stock?** Adding quantities across different units (e.g. 20 laptops + 100 Kg mangoes = 120) is meaningless. Valuing stock at purchase cost gives a useful total.

**Report types:**

| Index | Report Type | Uses date filter? | Columns |
|---|---|---|---|
| 0 | Stock Status | No | Product Code, Product Name, Category, Quantity, Unit, Minimum Stock, Status |
| 1 | Low Stock Products | No | Same as Stock Status, filtered to low-stock items |
| 2 | Stock In History | Yes | Date, Product Code, Product Name, Supplier, Quantity, Notes |
| 3 | Stock Out History | Yes | Date, Product Code, Product Name, Quantity, Profit, Notes |
| 4 | All Transactions | Yes | Date, Transaction Type, Product Code, Product Name, Supplier, Quantity, Profit, Notes |

For **All Transactions**, the Profit column shows the profit for Stock Out rows and `-` for Stock In rows.

**Report methods:**

| Method | What it does |
|---|---|
| `ReportsForm()` | Sets the default date range (last 30 days) and opens on All Transactions |
| `cmbReportType_SelectedIndexChanged` | Regenerates when the report type changes |
| `dtpFrom_ValueChanged` / `dtpTo_ValueChanged` | Regenerate automatically when dates change |
| `btnGenerateReport_Click` | Regenerates manually |
| `btnClearFilters_Click` | Resets dates and report type |
| `ValidateDateRange()` | Rejects a From date later than the To date |
| `GenerateReport()` | Chooses the correct report builder and updates the status line |
| `UpdateSummary()` | Recomputes the four summary cards |
| `GenerateStockStatusReport()` | Builds the Stock Status / Low Stock list |
| `GenerateTransactionReport()` | Builds Stock In / Stock Out / All Transactions lists |
| `SetReportColumns(...)` | Rebuilds the ListView columns for the selected report |
| `GetSupplierName(code)` | Converts a supplier code into a supplier name (or `-`) |

**Date filtering:** a transaction is included when its `TransactionDate` is on or after the From date and before the day after the To date. This makes the To date inclusive.

---

## 7. Business rules summary

| Area | Rule |
|---|---|
| Product code | Required and unique (case-insensitive) |
| Product name | Required |
| Product category/unit/supplier | Required |
| Low stock | `Quantity <= MinimumStock` |
| Category name | Required and unique |
| Category deletion | Blocked if any product uses it |
| Category rename | Updates all products using that category |
| Supplier code | Required and unique |
| Supplier name | Required |
| Stock In | Product and supplier required; resulting quantity ≤ 1,000,000 |
| Stock Out | Product required; cannot exceed available stock |
| Profit | `(SellingPrice - PurchaseCost) × QuantitySold`, captured at sale time |
| Stock Value | `Quantity × PurchaseCost`, summed over all products |
| Transactions | Searchable by product code or product name |

---

## 8. How to build and run

### Visual Studio

1. Open `IMS.csproj` (or the solution) in Visual Studio.
2. Build the solution (`Build > Build Solution`).
3. Run with `F5` or `Ctrl+F5`.

### Command line

```powershell
dotnet build IMS.csproj
dotnet run --project IMS.csproj
```

The application starts on the **Login** screen.

---

## 9. Current limitations and notes

1. **No persistence.** All data lives in `InventoryData` static lists and disappears when the app closes. A database (SQL Server, SQLite) or JSON file storage would be needed for real use.
2. **No authentication.** Login does not check a username or password. The Register button is not wired to save accounts.
3. **No user/account model.** There is no `User` class or credentials store.
4. **Supplier deletion does not check product references.** Products may still point to a deleted supplier code (they will show "Not assigned" in the product list).
5. **Product deletion does not remove past transactions.** This is usually desirable for history, but reports will still show the old product code/name.
6. **Profit uses the prices at the time of sale.** Later price edits do not rewrite historical profit.
7. **File-name quirks:** `MainForm.cs` contains `LoginForm`, and `CatagoriesForm` is misspelled. `ReportsForm.resx` exists with the report form.
8. **In-memory only means reports reflect the current session.** Starting fresh gives empty reports.

---

## 10. Quick reference — where to change things

| I want to... | Edit |
|---|---|
| Add a field to a product | `Product.cs`, then `ProductsForm.cs` and its designer |
| Change how profit is calculated | `StockOutForm.cs` (`btnStockOut_Click`) |
| Change the stock value formula | `ReportsForm.cs` (`UpdateSummary`) |
| Add a new report type | `ReportsForm.Designer.cs` (combo items) and `ReportsForm.cs` (`GenerateReport`, `GenerateTransactionReport`) |
| Add a new dashboard page | Create a form, then add a button handler in `DashboardForm.cs` and wire it in the designer |
| Replace in-memory data with a database | `InventoryData.cs` and the forms that read/write its lists |
| Change application startup | `Program.cs` |
