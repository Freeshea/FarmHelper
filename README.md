# FarmHelper
FarmHelper is a WPF application built using the MVVM design pattern. It helps players track farming rotations in MMO games, where you have a percentage-based drop chance of looting specific items from mobs. 
Necessary disclaimer: the item drop chances in MMO games are purely luck-based and independent for each kill, meaning the probability does not change for each individual kill.
The app calculates and displays the overall probability of whether you *should* have received the item by a given number of kills, or whether it's likely that you *won't* have it yet. 

The purpose of this application is to offer mental guidance in deciding whether to continue farming or take a break by providing a calculated probability based on the number of attempts. It does not alter or affect the in-game mechanics.


## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Prerequisites](#prerequisites)
- [Screenshots](#screenshots)

## Features
- **Input Details Tab**: 
  - Allows users to input drop chance and mob count per run.
  - Calculates how many mobs you need to kill to reach a high probability (e.g., 90.0%) of getting the item.

- **Input checks**: 
  - The input fields enforce strict validation: only numbers can be entered (and decimal point are allowed in the double-type field). If you enter a value that exceeds the allowed range, it will automatically be adjusted to the nearest valid limit (either the maximum or minimum value).

- **Help Window**: 
  - Explains how to use the application, available via a help button.

- **Unit Tests**: 
  - Unit tests are included to verify the accuracy of calculations.

## Installation
1. Clone the repository: `git clone https://github.com/Freeshea/FarmHelper.git`
2. Open the project in Microsoft Visual Studio
3. Install NUnit NuGet package for unit tests (If it isn't installed already)
4. Build the project
5. If you encounter issues building the project, try moving the `FarmHelper.Tests` folder to a separate location, as it may cause compile errors. Afterward, add the tests back to the solution as an existing project, and they should be able to run correctly.

### Prerequisites
- Visual Studio 2022 or later
- .NET 8.0 SDK or later
- NUnit Framework for running unit tests

## Screenshots
![FarmHelper1](https://github.com/user-attachments/assets/5ef88a24-e563-4cd3-b4f3-98da1f6f5235)
![FarmHelper2](https://github.com/user-attachments/assets/be274422-dad1-4708-9549-94b420969e35)

- Used software:
  - Microsoft Visual Studio
