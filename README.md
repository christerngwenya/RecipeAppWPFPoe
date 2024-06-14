# RecipeAppWPFPoe
### README
 
#### Project: RecipeAppWPF
 
#### Instructions for Compilation and Running the Software
 
1. **Clone the Repository**:
   Clone the repository to your local machine using Git or download the ZIP and extract it.
 
   ```sh
   git clone <repository-url>
   ```
 
2. **Open the Project in Visual Studio**:
   - Launch Visual Studio.
   - Select `File` -> `Open` -> `Project/Solution`.
   - Navigate to the project directory and select the `RecipeAppWPF.csproj` file.
 
3. **Build the Project**:
   - In Visual Studio, go to `Build` -> `Build Solution` or press `Ctrl+Shift+B`.
   - Ensure there are no build errors.
 
4. **Run the Application**:
   - Press `F5` or go to `Debug` -> `Start Debugging`.
 
#### Explanation of Changes
 
The initial version of the code was a console application where the user could input and manage recipes through textual commands. The main issues with the console application were:
1. **Repeated Options**: The options menu repeated after each user input, making it cumbersome to use.
2. **Lack of GUI**: The application was purely text-based, making it less user-friendly.
 
To resolve these issues, I transitioned the application to a WPF (Windows Presentation Foundation) application, which provides a graphical user interface (GUI) for better user interaction. Here are the key changes and improvements:
 
- **GUI Interface**: Implemented a graphical interface using WPF, allowing users to interact with buttons, textboxes, and windows.
- **Windows for Each Functionality**: Created separate windows for entering recipe details, displaying a specific recipe, and displaying all recipes. This separation enhances usability and prevents the options from repeating.
- **Data Management**: Used a singleton pattern for the `RecipeBook` class to manage recipes globally across different windows.
- **User Feedback**: Added messages to inform users about the success or failure of their actions (e.g., recipe saved successfully, invalid input).
 
The WPF application now provides a seamless and interactive way to manage recipes, enhancing the user experience significantly.
 
---
