# README

## Folder Structure Explanation

This repository contains a C# solution with multiple projects organized using Visual Studio's **virtual folders** (also known as "solution folders"). Here's why you might not see these folders when browsing the repository in GitHub:

### Virtual Folders vs. Physical Folders

1. **Virtual Folders** (Solution Folders):
   - These are organizational containers that exist only within the Visual Studio solution
   - They help group related projects without requiring a matching physical directory structure
   - They appear in Solution Explorer but don't correspond to actual folders on disk

2. **Physical Folders**:
   - These are actual directories in the file system
   - They appear both in Solution Explorer and in GitHub's file browser

### Why Virtual Folders Don't Appear on GitHub

GitHub displays the actual file system structure, not the Visual Studio solution's organizational view. The virtual folder hierarchy you see in Visual Studio is stored in the `.sln` file, but it doesn't create corresponding physical directories.

### How to Verify This

1. In Visual Studio's Solution Explorer:
   - Virtual folders appear with a special folder icon
   - You can right-click → "Open Folder in File Explorer" to see if it's physical

2. In your local repository:
   - The virtual folder structure won't appear in Windows Explorer/Finder
   - Only the actual project folders will be visible

### Solution Structure Example

What you see in VS Solution Explorer:
```
Solution 'DesignPatterns'
├─── Creational Patterns (virtual folder)
│    ├── Singleton Project
│    ├── Factory Method Project
├─── Structural Patterns (virtual folder)
│    ├── Adapter Project
│    ├── Decorator Project
└─── Behavioral Patterns (virtual folder)
     ├── Observer Project
     ├── Strategy Project
```

What you see on GitHub:
```
/DesignPatterns
├── Singleton/
├── FactoryMethod/
├── Adapter/
├── Decorator/
├── Observer/
├── Strategy/
├── DesignPatterns.sln
```
