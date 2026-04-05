# Inventory Management Desktop Application (C# WinForms)

## Overview

This project is a **Windows Forms Desktop Application** developed in **C#** that connects to a Flask REST API to display and manage inventory data.

The application allows users to view products, suppliers, and units through a graphical user interface. The desktop application communicates with the backend API via HTTP requests and processes JSON responses.

This project was developed as part of an internship project together with the Flask API backend.

---

## Technologies Used

* C#
* .NET Framework
* Windows Forms (WinForms)
* REST API
* HTTP Client
* JSON
* Visual Studio

---

## Application Features

* List all products
* Search products
* View product details
* List suppliers
* List units (branches)
* Display data from API in DataGridView
* Connect to REST API using HTTP requests
* JSON data parsing and display
* Desktop user interface for inventory system

---

## How the Application Works

1. The WinForms application sends HTTP requests to the Flask API.
2. The Flask API queries the Oracle database.
3. The API returns data in JSON format.
4. The WinForms application parses the JSON data.
5. Data is displayed in tables and forms.

### System Flow

```
WinForms App → HTTP Request → Flask API → Oracle Database
WinForms App ← JSON Response ← Flask API ← Oracle Database
```

---

## Example API Request in C#

Example of sending a GET request to the API:

```csharp
HttpClient client = new HttpClient();
var response = await client.GetStringAsync("http://127.0.0.1:5000/api/urun/");
```

---

## How to Run the Project

1. Open the project in **Visual Studio**
2. Make sure the Flask API is running
3. Run the WinForms project
4. The application will fetch data from the API and display it

---

## What I Learned

With this project I gained experience in:

* Desktop application development
* C# Windows Forms
* REST API integration
* HTTP requests in C#
* JSON parsing
* Client–server architecture
* Backend + Frontend integration
* Database-driven applications

---

## Project Purpose

This project demonstrates:

* Backend API development
* Desktop application development
* Database integration
* REST API usage
* Full system architecture

This project can be considered a **full-stack desktop + backend system**.

---

## Author

Developed as part of an internship project.
