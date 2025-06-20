# 🖥️ NeoFetch - Windows System Information Tool


[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

A lightweight, Neofetch-inspired system information tool for Windows, written in C#. Displays hardware/OS details with customizable ASCII art.

<!-- ![Example Output](docs/screenshot.png) -->

## ✨ Features

- **Blazing fast** system info retrieval (WMI + Registry optimized)
- **Minimal dependencies** (Only `System.Management`)
- **Customizable** ASCII art and color schemes
- **Cross-platform** ready (Windows/Linux/macOS support via fallbacks)
- **Extensible** modular architecture

## 📦 Installation

### Method 1: Binary Release
Download the latest executable from [Releases](https://github.com/yourusername/WinFetch/releases).

### Method 2: Build from Source
```bash
git clone https://github.com/yourusername/WinFetch.git
cd WinFetch
dotnet build -c Release
dotnet publish -c Release -r win-x64 --self-contained true