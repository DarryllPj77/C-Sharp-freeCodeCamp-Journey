# Contributing to C# freeCodeCamp Journey

Thank you for your interest in contributing to this project! This document provides guidelines for contributing improvements, bug fixes, and enhancements.

## ?? Code of Conduct

- Be respectful and constructive
- Focus on code quality and clarity
- Help others learn and grow
- Report issues professionally

## ?? Reporting Issues

If you find a bug or have a suggestion:

1. Check if the issue already exists on GitHub
2. Provide a clear description of the problem
3. Include:
   - Which project the issue affects
   - Steps to reproduce (if applicable)
   - Expected vs. actual behavior
   - Your environment (Visual Studio version, .NET version)

## ? Making Contributions

### For Bug Fixes:
1. Fork the repository
2. Create a branch: `git checkout -b fix/bug-description`
3. Fix the bug and test thoroughly
4. Commit with clear message: `git commit -m 'Fix: description of fix'`
5. Push to your fork and create a Pull Request

### For New Projects:
1. Create a new folder with a descriptive name
2. Follow the existing project structure
3. Include comments explaining the concept
4. Add a small `README.md` in the project folder (optional)
5. Test to ensure the project runs without errors

### For Improvements:
1. Create a branch: `git checkout -b feature/improvement-description`
2. Make improvements to existing code
3. Ensure backward compatibility
4. Commit with clear messages
5. Create a Pull Request with detailed explanation

## ?? Code Style Guidelines

### Naming Conventions
```csharp
// Classes - PascalCase
public class AgeValidator { }

// Methods - PascalCase
public int ValidateAge() { }

// Variables - camelCase
int userAge = 0;
string userName = "";

// Constants - UPPER_SNAKE_CASE
const int MAX_AGE = 120;
const string DEFAULT_NAME = "User";
```

### Code Formatting
```csharp
// Use meaningful variable names
int age; // Good ?
int a;   // Bad ?

// Keep lines reasonably short
// Use braces even for single statements
if (age > 18)
{
    Console.WriteLine("Adult");
}

// Use appropriate spacing
int result = value1 + value2;  // Good ?
int result=value1+value2;      // Bad ?
```

## ?? Project Structure

```
ProjectName/
??? ProjectName.csproj
??? Program.cs
??? README.md (optional)
```

## ?? Testing Before Submission

Before submitting a pull request:

1. **Build the project:**
   ```bash
   dotnet build
   ```

2. **Run the project:**
   ```bash
   dotnet run
   ```

3. **Test with various inputs** to ensure robustness

4. **Check for compilation warnings**

## ?? Pull Request Process

1. Update the README.md if you're adding new projects
2. Ensure all code compiles without errors or warnings
3. Add a clear description of changes in the PR
4. Link any related issues
5. Request review from maintainers

### PR Title Format:
- `Add: [project-name] - brief description`
- `Fix: [project-name] - brief description`
- `Improve: [project-name] - brief description`

### PR Description Template:
```markdown
## Description
Brief explanation of changes

## Related Issues
Closes #(issue number) if applicable

## Type of Change
- [ ] New Project
- [ ] Bug Fix
- [ ] Feature Addition
- [ ] Documentation Update

## Testing Done
Describe what testing was performed

## Checklist
- [ ] Code compiles without errors
- [ ] Code follows style guidelines
- [ ] Project has been tested
- [ ] README updated (if applicable)
```

## ?? Documentation Standards

### For New Projects:
Include comments in your code explaining:
- What the program does
- Key concepts being demonstrated
- Any important functions or logic

### Example:
```csharp
// AgeValidator.cs
// This program demonstrates input validation using int.TryParse()
// It validates that user input is a valid age (0-150)

using System;

class Program
{
    static void Main()
    {
        // Get user input
        Console.Write("Enter your age: ");

        // Try to parse the input as an integer
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // Validate the age is within acceptable range
            if (age >= 0 && age <= 150)
            {
                Console.WriteLine($"Valid age: {age}");
            }
        }
    }
}
```

## ?? Commit Message Guidelines

Use clear, descriptive commit messages:

```bash
# Good commit messages
git commit -m "Add: Age Validator project with input validation"
git commit -m "Fix: Incorrect loop condition in PyramidStars"
git commit -m "Update: README with new project descriptions"

# Bad commit messages
git commit -m "Update"
git commit -m "Fix stuff"
git commit -m "asdf"
```

## ? Questions?

Feel free to open an issue for questions or discussions about contributing.

## ?? Thank You!

Your contributions help make this learning repository better for everyone!

---

**Happy Contributing!** ??
