Aqui está uma descrição para o repositório da aplicação no GitHub:

---

# C# Windows Forms .NET Core 8 - MySQL Database Connection Example

## Overview

This repository contains a C# Windows Forms application built with .NET Core 8, demonstrating how to connect to a local MySQL database. The application is designed to test database connectivity and update the user interface based on the connection status.

## Features

- **Connection Management:** Easily connect and disconnect from a local MySQL database.
- **Status Updates:** Real-time feedback on the connection status with visual cues.
- **User Interface:** Simple and intuitive UI with a status label and connect/disconnect buttons.

## Setup

1. **Install Laragon:** Ensure that Laragon is installed and running. Start all services, including MySQL.
2. **Install MySQL Data Connector:** Open Visual Studio, navigate to the NuGet Package Manager, search for `MySql.Data`, and install the package.
3. **Configuration:**
   - Open the `Form1.cs` file.
   - Update the connection string with your MySQL database details.
4. **Build and Run:**
   - Build the application in Visual Studio.
   - Run the application and use the 'Connect' and 'Disconnect' buttons to test the database connection.

## How to Use

1. **Start Laragon** and make sure MySQL is running.
2. **Open the Application** in Visual Studio.
3. **Click 'Connect'** to establish a connection to your MySQL database.
4. **Click 'Disconnect'** to close the connection.
