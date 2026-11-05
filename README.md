# Lab2App – C# Windows Forms Application

## Overview

**Lab2App** is a desktop application developed using C# and Windows Forms (WinForms) as part of a .NET programming project.

The application demonstrates object-oriented programming concepts and Windows desktop application development through multiple interactive forms and functionalities.

## Features

The application consists of the following main components:

### 1. Main Form
- Serves as the main interface of the application.
- Provides navigation to the different application modules.

### 2. Bicycle Rental Form
- Provides a dedicated interface for the bicycle rental module.
- Organizes the bicycle rental functionality through a Windows Forms interface.

### 3. Mushroom Identifier Form
- Provides an interface for the mushroom identification module.
- Demonstrates the implementation of application logic through a graphical user interface.

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework 4.7.2
- **Application Type:** Windows Forms (WinForms)
- **Development Environment:** Microsoft Visual Studio
- **Version Control:** Git and GitHub

## Project Structure

```text
Lab2App/
│
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   ├── Resources.Designer.cs
│   ├── Settings.settings
│   └── Settings.Designer.cs
│
├── MainForm.cs
├── MainForm.Designer.cs
│
├── BicycleRentalForm.cs
├── BicycleRentalForm.Designer.cs
│
├── MushroomIdentifierForm.cs
├── MushroomIdentifierForm.Designer.cs
│
├── Program.cs
├── App.config
├── Lab2App.csproj
└── README.md
```

## Prerequisites

Before running the application, ensure you have:

- Windows operating system.
- Microsoft Visual Studio.
- .NET Framework 4.7.2 Developer/Targeting Pack.
- .NET desktop development workload installed in Visual Studio.

## Installation and Setup

### 1. Clone the Repository

Open your terminal and execute:

```bash
git clone https://github.com/ManziHerve34/DotNetLab2.git
```

### 2. Navigate to the Project Directory

```bash
cd DotNetLab2
```

### 3. Open the Project

Open Microsoft Visual Studio and select:

**File → Open → Project/Solution**

Locate and open:

```text
Lab2App.csproj
```

### 4. Build and Run

- Set `Lab2App` as the startup project.
- Build the solution using `Ctrl + Shift + B`.
- Run the application using `F5` or `Ctrl + F5`.

## Building from the Command Line

You can also build the project using MSBuild from the Visual Studio Developer Command Prompt:

```bash
msbuild Lab2App.csproj /t:Build /p:Configuration=Debug
```

After a successful build, run the generated executable:

```bash
bin\Debug\Lab2App.exe
```

## Version Control

This project uses Git for version control and GitHub for remote source-code hosting.

Repository: https://github.com/ManziHerve34/DotNetLab2

## Below are the sample screenshots of the Windows Forms application showing the 3 forms: MainForm, BicycleRentalForm and MushroomIdentifierForm: 


<img width="1127" height="815" alt="winf3" src="https://github.com/user-attachments/assets/983a121d-a9bf-459a-b4ca-57eb55c18cc4" />
<img width="1077" height="790" alt="winf2" src="https://github.com/user-attachments/assets/0eb60169-137c-4194-8a6a-c9ee96e39a9d" />
<img width="1027" height="677" alt="Winf1" src="https://github.com/user-attachments/assets/b1afdc87-db5f-4934-84ce-47d6f122a4fd" />
