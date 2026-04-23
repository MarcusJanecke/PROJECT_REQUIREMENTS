# Ticket Application System

A professional C# Windows Forms application for calculating and managing passenger ticket prices based on category, distance, age, and gender.

## Overview

The **Ticket Application System** is a collaborative project developed using C# and Windows Forms. It allows users to calculate ticket prices with dynamic discount rules and display comprehensive ticket summaries.

## Features

- **User-Friendly Interface**: Professional Windows Forms UI with clear input fields and display panels
- **Dynamic Pricing**: Three ticket categories with different price rates per kilometer
- **Automatic Discounts**: 
  - Free tickets for children under 12 years
  - 50% discount for female passengers
- **Input Validation**: Comprehensive validation for all user inputs
- **Ticket Summary**: Detailed ticket information displayed after calculation
- **Responsive Controls**: Clear, Calculate, and Exit buttons for easy navigation

## Technical Stack

- **Language**: C# (.NET 6.0)
- **UI Framework**: Windows Forms
- **Testing**: xUnit
- **Version Control**: Git/GitHub

## System Requirements

- .NET 6.0 SDK or later
- Windows operating system
- Visual Studio 2022 (recommended)

## Installation & Setup

### Prerequisites
- Install [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Install [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later

### Clone Repository
```bash
git clone https://github.com/your-username/TicketApplicationSystem.git
cd TicketApplicationSystem
```

### Build the Project
```bash
dotnet build
```

### Run the Application
```bash
dotnet run --project TicketApplicationSystem.csproj
```

### Run Unit Tests
```bash
dotnet test TicketApplicationSystem.Tests/
```

## Pricing Structure

| Category | Price per km |
|----------|-------------|
| Category One | R20 |
| Category Two | R35 |
| Category Three | R50 |

## Discount Rules

### Age-Based Discount
- **Age < 12 years**: Ticket is **FREE**

### Gender-Based Discount
- **Female passengers**: 50% discount on calculated ticket price

## Business Logic

The ticket price calculation follows this logic:

1. **Check Age Rule**: If age < 12, ticket = R0
2. **Calculate Base Price**: price = category_rate × distance
3. **Check Gender Rule**: If female, apply 50% discount
4. **Return Final Price**

### Example Calculations

**Example 1**: Male, 25 years, Category One, 10 km
- Base Price: 20 × 10 = R200
- No discounts apply
- **Final Price: R200**

**Example 2**: Female, 30 years, Category Two, 20 km
- Base Price: 35 × 20 = R700
- Female discount (50%): 700 × 0.5 = R350
- **Final Price: R350**

**Example 3**: Child, 10 years, Category Three, 50 km
- Age < 12 rule applies
- **Final Price: FREE (R0)**

## Input Validation

The application validates the following:

- ✓ Passenger name is not empty
- ✓ Age is numeric and between 0-120
- ✓ Distance is numeric and greater than 0
- ✓ Travel category is selected
- ✓ Gender is selected (Male/Female)

## User Interface Components

### Input Fields
- **Passenger Name**: TextBox for entering the passenger's name
- **Gender**: RadioButtons for Male/Female selection
- **Age**: TextBox for entering numeric age
- **Travel Category**: ComboBox with three category options
- **Distance**: TextBox for entering travel distance in kilometers

### Buttons
- **Calculate Ticket Price**: Processes inputs and displays results
- **Clear Form**: Resets all fields to default state
- **Exit Application**: Closes the application with confirmation

### Output
- **Ticket Summary Panel**: Displays calculated ticket information including:
  - Passenger name
  - Gender
  - Age
  - Travel category
  - Distance
  - Final ticket price
  - Applied discount information

## GitHub Workflow

### Branch Naming Convention
- `Dev-ui-design-[YourName]`: UI development
- `Dev-logic-module-[YourName]`: Business logic development
- `Dev-testing-docs-[YourName]`: Testing and documentation

### Commit Message Guidelines
- ✓ "Created Windows Form layout"
- ✓ "Added gender selection controls"
- ✓ "Implemented category pricing logic"
- ✓ "Applied female discount rule"
- ✓ "Added validation for distance input"
- ✗ Avoid generic messages like "update", "changes", "fixed stuff"

## Project Structure

```
TicketApplicationSystem/
│
├── TicketApplicationSystem.csproj         # Main project file
├── Program.cs                              # Application entry point
├── TicketForm.cs                          # Main form logic
├── TicketForm.Designer.cs                 # Form UI design
├── TicketCalculator.cs                    # Business logic
│
├── TicketApplicationSystem.Tests/
│   ├── TicketApplicationSystem.Tests.csproj
│   └── TicketCalculatorTests.cs           # Unit tests
│
└── README.md                               # This file
```

## Testing

The application includes comprehensive unit tests covering:

- Category pricing calculations
- Gender-based discount application
- Age-based free ticket rule
- Boundary conditions (age < 12, age = 12)
- Decimal distance handling
- Input validation

### Running Tests

```bash
# Run all tests
dotnet test

# Run specific test class
dotnet test --filter "TicketCalculatorTests"

# Run with verbose output
dotnet test -v n
```

### Test Coverage

- **24+ unit tests** covering all pricing scenarios
- Tests for all three categories
- Tests for age and gender rules
- Edge case and boundary testing

## Troubleshooting

### Application won't start
- Ensure .NET 6.0 SDK is installed: `dotnet --version`
- Run `dotnet restore` to restore dependencies

### Tests fail to run
- Ensure test project dependencies are installed: `dotnet restore`
- Check that xUnit package is properly referenced

### Build errors
- Clean build folder: `dotnet clean`
- Rebuild: `dotnet build`

## Collaboration Roles

### Project Manager / GitHub Coordinator
- Repository setup and maintenance
- Branch management and merging
- README documentation
- Final integration

### UI Developer
- Windows Form interface design
- Control layout and styling
- Responsive user interface
- Professional appearance

### Logic Developer
- Ticket calculation algorithms
- Discount rule implementation
- Input validation
- Business logic testing

### Tester / Documentation Specialist
- Unit and integration testing
- Test case documentation
- Bug reporting and tracking
- Final quality assurance

## Development Guidelines

### Code Style
- Follow C# naming conventions (PascalCase for classes, camelCase for variables)
- Use meaningful variable names
- Include XML comments for public methods
- Keep methods focused and single-responsibility

### Documentation
- Add comments for complex logic
- Update README with changes
- Document test cases
- Maintain commit history clarity

## Future Enhancements

Possible improvements for future versions:

- [ ] Database integration for ticket history
- [ ] Multiple passenger batch processing
- [ ] Receipt printing functionality
- [ ] Payment integration
- [ ] Booking system
- [ ] Real-time availability checks
- [ ] Mobile application version

## License

This project is part of the CTU Training Solutions coursework.

## Support & Contact

For issues, questions, or suggestions, please create an issue on the GitHub repository.

## Contributors

- Project Manager / GitHub Coordinator: [Team Member Name]
- UI Developer: [Team Member Name]
- Logic Developer: [Team Member Name]
- Tester / Documentation Specialist: [Team Member Name]

## Acknowledgments

Developed as a collaborative project for CTU Training Solutions (PTY) Ltd.

---

**Last Updated**: 2026
**Version**: 1.0
