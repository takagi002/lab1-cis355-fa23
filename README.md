# Lab1-CIS355-FA23

This README file provides instructions for setting up, cloning, and running the Lab1-CIS355-FA23 project.

## Prerequisites

### 1. Install and Configure Docker Desktop

- Download Docker Desktop from the [official website](https://www.docker.com/products/docker-desktop).
- Install Docker Desktop by following the installation wizard.
- Once installed, run Docker Desktop to make sure it is properly set up.

### 2. Install and Configure VS Code

- Download Visual Studio Code from the [official website](https://code.visualstudio.com/).
- Install Visual Studio Code by following the installation instructions for your operating system.
- After installation, open VS Code to ensure it's correctly installed.

### 3. Ensure the VS Code Remote Development Extension is installed

- Open VS Code.
- Go to the Extensions Marketplace by clicking on the Extensions icon in the Activity Bar on the side of the window.
- Search for "Remote Development" and install the extension provided by Microsoft.

## Cloning the Repository

### Example using CLI

- Open your command prompt or terminal.
- Navigate to the directory where you want to clone the repository.
- Run the following command:

    ```
    git clone https://github.com/carlin010/lab1-cis355-fa23.git
    ```

### Example using VS Code

- Open VS Code.
- Click on the 'Source Control' icon in the Activity Bar on the side of the window.
- Click on 'Clone Repository'.
- Enter the URL of the repository and press 'Enter'.
- Choose the directory where you want to clone the repository.

## Running the Project

### Ensure Docker is Running in the Background

- Make sure Docker Desktop is running.
  - For Windows: Check the system tray to see if the Docker Desktop icon is visible and not showing any error.
  - For Mac: Check the top menu bar to see if the Docker Desktop icon is visible and not showing any error.

### Open the Folder Cloned from Git in VS Code

- Open VS Code.
- Go to 'File' > 'Open Folder' and navigate to the directory where the repository was cloned.
- Select the folder and click 'Open'.

### Select "Reopen in Container" from the Popup or by Using the Command Pallet

- A popup should appear in the lower right corner asking if you would like to reopen the folder in a container. Click "Reopen in Container".
  - Alternatively, you can click `View->Command Palette` to open the Command Palette, type `Remote-Containers: Reopen in Container` and press `Enter`.

### Building the Project Using the Run and Debug Menu

Visual Studio Code provides a built-in Run and Debug menu that makes it easy to build your project, allowing you to run or debug your application without having to rely solely on terminal commands. Follow the steps below to build your project using this feature:

- Click on the "Run" button (it looks like a play button) at the top of the Run and Debug pane.
- Alternatively, you can press `F5` to start the build and debugging process. 
