# Inventory Management System (IMS)

A desktop inventory management application built with C# and Windows Forms for tracking products, suppliers, categories, stock movements, and reports.

## Features

- Product management with stock quantity and minimum stock alerts
- Category management
- Supplier management
- Stock-in and stock-out transactions
- Dashboard summary cards and low-stock monitoring
- Transaction history and reporting
- Windows Forms-based user interface

## Demo Video

<p align="center">
  <a href="https://youtu.be/52ZLYhCdoaI" target="_blank" rel="noopener noreferrer">
    <img src="https://img.youtube.com/vi/52ZLYhCdoaI/maxresdefault.jpg" alt="IMS demo video preview" width="800" />
  </a>
</p>

## Project Overview

This project is designed for small businesses that need a simple way to manage inventory and monitor stock movement. It includes the main user management flow, inventory dashboard, product controls, and reporting screens.

## Technology Stack

- C#
- .NET Windows Forms
- Visual Studio Windows Forms Designer

## Project Structure

- `Program.cs` – application entry point
- `DashboardForm.cs` – main dashboard screen
- `ProductsForm.cs` – product management
- `CatagoriesForm.cs` – category management
- `SuppliersForm.cs` – supplier management
- `StockInForm.cs` – stock-in entries
- `StockOutForm.cs` – stock-out entries
- `TransactionsForm.cs` – transaction history
- `ReportsForm.cs` – reports and summary views
- `InventoryData.cs` – in-memory data store
- `SYSTEM_DOCUMENTATION.md` – technical documentation

## Getting Started

1. Open the project in Visual Studio.
2. Restore NuGet packages if needed.
3. Set the project to build for Windows.
4. Run the application.

## Documentation

For more technical details about the system architecture, data model, and application flow, see [SYSTEM_DOCUMENTATION.md](SYSTEM_DOCUMENTATION.md).

## Notes

This application currently uses in-memory data storage, so data is reset when the program closes.
