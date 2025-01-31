### **README for Console Application**


# Compression App (Console)

This project is a *Console Application* that allows users to *compress* and *decompress* strings of repeating characters. The compression format is a simple form where the number of repeated characters is represented by a number followed by the character itself (e.g., 4a for aaaa). The decompression restores the original string.

## Features
- *Compress*: Reduces repeating characters into a shorter format.
- *Decompress*: Restores compressed strings to their original format.
- *Console Interface*: Provides a terminal-based interaction with the user.

## Prerequisites
Before you begin, make sure you have the following installed:
- *.NET SDK 8+* – [Download here](https://dotnet.microsoft.com/en-us/download/dotnet).
- *Visual Studio Code* – [Download here](https://code.visualstudio.com/).
- *C# Extension for VS Code* – Install from Extensions (Ctrl+Shift+X in VS Code).
- *Command Line Interface* (CLI): You will need access to the terminal or command prompt.

## Getting Started

### 1. Clone the Repository
Clone this repository to your local machine.

```sh
git clone https://github.com/puramsri/CompressionGUI
cd CompressionConsole

2. Open the Project in Visual Studio Code

Launch Visual Studio Code and open the CompressionConsole project folder.

3. Restore Dependencies

Run the following command in the integrated terminal to restore the project dependencies:

dotnet restore

4. Build and Run the Application

To build and run the application, open the integrated terminal and execute:

dotnet build
dotnet run

This will launch the Console application. You will be prompted to:
	1.	Enter the string you want to compress or decompress.
	2.	Choose whether to Compress or Decompress the string by typing the corresponding option.

How It Works

Compression

The compression method converts strings of repeating characters into a more compact form. For example:
	•	Input: aaaa
	•	Compressed: 4a

Decompression

The decompression method restores the compressed format back to the original string. For example:
	•	Input: 4a
	•	Decompressed: aaaa

Troubleshooting

If you encounter any issues running the application, ensure that:
	•	You have the correct version of .NET SDK installed.
	•	You have access to the command-line interface (CLI) on your system.
	•	All dependencies are restored (dotnet restore).

Contributing

If you would like to contribute to this project, feel free to fork the repository and submit a pull request. Your contributions are always welcome!

License

This project is licensed under the MIT License – see the LICENSE file for details.

Acknowledgments
	•	Thanks to the .NET community for creating great frameworks like .NET Core, which makes app development easy.
	•	Special thanks to the contributors and open-source projects that helped in this development.
