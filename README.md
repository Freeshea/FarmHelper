# FarmHelper
FarmHelper is a C#, WPF (Windows Presentation Foundation) application built using the MVVM (Model-View-ViewModel) design pattern. It helps players track farming rotations in World of Warcraft or similar games (mainly MMOs), where you have a percentage-based drop chance of looting specific items from mobs. 
The item drop chance in games like World of Warcraft is purely luck-based and independent for each kill, meaning the probability does not change for each individual kill. The app calculates the overall probability of whether you *should* have received the item by a given number of kills, or whether it's likely that you *won't* have it yet. 

The purpose of this application is to offer mental guidance in deciding whether to continue farming or take a break by providing a calculated probability based on the number of attempts. It does not alter or affect the in-game mechanics.


## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Prerequisites](#prerequisites)
- [Screenshots](#screenshots)
- [Acknowledgments](#acknowledgments)

## Features
- **Input Details Tab**: 
  - Allows users to input drop chance, mob count per run, and mob respawn time.
  - Calculates how many mobs you need to kill to reach a high probability (e.g., 99.9%) of getting the item.

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
<img src="(https://github.com/user-attachments/assets/570903d6-61ad-46b3-bae8-50996e5b67f4)" alt="FarmHelperDetailsTab"/>
<img src="(https://github.com/user-attachments/assets/c5bc6d22-8ec9-4fc0-afc0-1aaccc318bf7)" alt="FarmHelperCalculateTab"/>

- Used software:
  - Microsoft Visual Studio
