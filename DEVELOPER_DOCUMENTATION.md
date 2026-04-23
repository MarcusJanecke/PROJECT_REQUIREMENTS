# Developer Documentation - Ticket Application System

## Table of Contents
1. [Architecture Overview](#architecture-overview)
2. [Code Structure](#code-structure)
3. [API Documentation](#api-documentation)
4. [How to Extend](#how-to-extend)
5. [Coding Standards](#coding-standards)
6. [Common Issues & Solutions](#common-issues--solutions)

---

## Architecture Overview

### Design Pattern: MVC (Model-View-Controller)

The Ticket Application System follows a simplified MVC pattern:

```
User Input (View)
       ↓
TicketForm.cs (Controller)
       ↓
TicketCalculator.cs (Model/Business Logic)
       ↓
Display Results (View)
```

### Component Breakdown

#### 1. **TicketForm.cs** - Controller & View
- Handles all UI interactions
- Manages form events (button clicks, text changes)
- Validates user inputs
- Calls business logic methods
- Displays results to the user

#### 2. **TicketForm.Designer.cs** - UI Design
- Contains all form control declarations
- Manages layout and positioning
- Defines control properties (colors, fonts, sizes)
- Should only be modified through UI design patterns

#### 3. **TicketCalculator.cs** - Business Logic
- Pure business logic for ticket calculations
- No UI dependencies
- Easily testable
- Handles all pricing rules and discounts

#### 4. **Program.cs** - Entry Point
- Application entry point
- Initializes the main form
- Handles application lifecycle

---

## Code Structure

### Directory Layout

```
TicketApplicationSystem/
├── Program.cs                    # Entry point
├── TicketForm.cs                # Main form logic
├── TicketForm.Designer.cs       # Form UI design
├── TicketCalculator.cs          # Business logic
├── TicketApplicationSystem.csproj # Project file
├── README.md                     # Project overview
├── TEST_DOCUMENTATION.md         # Test cases & results
└── DEVELOPER_DOCUMENTATION.md    # This file
```

### Class Diagram

```
┌─────────────────────────┐
│     TicketForm          │
├─────────────────────────┤
│ - txtPassengerName      │
│ - rbMale, rbFemale      │
│ - txtAge                │
│ - cmbCategory           │
│ - txtDistance           │
│ - btnCalculate, etc.    │
├─────────────────────────┤
│ + BtnCalculate_Click()  │
│ + BtnClear_Click()      │
│ + BtnExit_Click()       │
│ + ValidateInputs()      │
│ + DisplayTicketSummary()│
└─────────────────────────┘
           │ Uses
           ↓
┌─────────────────────────┐
│  TicketCalculator       │
├─────────────────────────┤
│ - CATEGORY_ONE_RATE: 20 │
│ - CATEGORY_TWO_RATE: 35 │
│ - CATEGORY_THREE_RATE:50│
│ - FEMALE_DISCOUNT: 0.5  │
├─────────────────────────┤
│ + CalculateTicketPrice()│
│ - GetCategoryRate()     │
└─────────────────────────┘
```

---

## API Documentation

### TicketCalculator Class

#### Public Methods

##### `CalculateTicketPrice(int age, string gender, string category, double distance)`

**Purpose**: Calculate the final ticket price based on all pricing rules.

**Parameters**:
- `age` (int): Passenger age in years (0-120)
- `gender` (string): "Male" or "Female"
- `category` (string): "Category One", "Category Two", or "Category Three"
- `distance` (double): Travel distance in kilometers (> 0)

**Returns**: `double` - Final ticket price in Rands

**Throws**: `ArgumentException` - If invalid category is provided

**Examples**:

```csharp
TicketCalculator calc = new TicketCalculator();

// Example 1: Adult male
double price1 = calc.CalculateTicketPrice(25, "Male", "Category One", 10);
// Returns: 200.0

// Example 2: Adult female (50% discount)
double price2 = calc.CalculateTicketPrice(30, "Female", "Category Two", 20);
// Returns: 350.0

// Example 3: Child under 12 (free)
double price3 = calc.CalculateTicketPrice(10, "Male", "Category Three", 50);
// Returns: 0.0
```

#### Private Methods

##### `GetCategoryRate(string category)`

**Purpose**: Get the price rate per kilometer for a given category.

**Parameters**:
- `category` (string): Travel category

**Returns**: `double` - Price per kilometer

**Throws**: `ArgumentException` - If invalid category

---

### TicketForm Class

#### Event Handlers

##### `BtnCalculate_Click(object sender, EventArgs e)`

**Purpose**: Handle Calculate button click event.

**Flow**:
1. Validates all user inputs
2. Retrieves input values
3. Calls TicketCalculator
4. Displays ticket summary
5. Shows error message if validation fails

##### `BtnClear_Click(object sender, EventArgs e)`

**Purpose**: Clear all form fields and reset summary.

**Flow**:
1. Clears all text boxes
2. Resets radio button to Male
3. Resets combo box selection
4. Resets summary display

##### `BtnExit_Click(object sender, EventArgs e)`

**Purpose**: Close application with confirmation.

**Flow**:
1. Show confirmation dialog
2. Close application if user confirms
3. Do nothing if user cancels

#### Private Methods

##### `ValidateInputs(out string errorMessage)`

**Purpose**: Validate all user inputs.

**Parameters**:
- `errorMessage` (out string): Validation error message

**Returns**: `bool` - true if all inputs valid, false otherwise

**Validation Rules**:
- Name: Not empty or whitespace
- Age: Numeric, between 0-120
- Distance: Numeric, greater than 0
- Category: Must be selected
- Gender: Automatically valid (always selected)

##### `DisplayTicketSummary(string name, string gender, int age, string category, double distance, double finalPrice)`

**Purpose**: Display ticket summary in the summary panel.

**Parameters**:
- `name` (string): Passenger name
- `gender` (string): Passenger gender
- `age` (int): Passenger age
- `category` (string): Travel category
- `distance` (double): Travel distance
- `finalPrice` (double): Final ticket price

**Output**: Updates lblSummary label with formatted ticket information

---

## How to Extend

### Adding a New Category

To add a new travel category (e.g., "Category Four" at R75/km):

**Step 1**: Update TicketCalculator.cs

```csharp
private const double CATEGORY_FOUR_RATE = 75;  // New rate

private double GetCategoryRate(string category)
{
    switch (category)
    {
        case "Category One":
            return CATEGORY_ONE_RATE;
        // ... existing cases ...
        case "Category Four":
            return CATEGORY_FOUR_RATE;
        default:
            throw new ArgumentException("Invalid category selected.");
    }
}
```

**Step 2**: Update TicketForm.Designer.cs

```csharp
this.cmbCategory.Items.AddRange(new object[] { 
    "Category One", 
    "Category Two", 
    "Category Three",
    "Category Four"  // Add new category
});
```

### Adding a New Discount Type

To add a senior citizen discount (age >= 65):

**Step 1**: Update TicketCalculator.cs

```csharp
private const double SENIOR_DISCOUNT = 0.25;  // 25% discount

public double CalculateTicketPrice(int age, string gender, string category, double distance)
{
    if (age < 12)
        return 0;

    double basePrice = GetCategoryRate(category) * distance;

    // Apply gender discount
    if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
        basePrice = basePrice * (1 - FEMALE_DISCOUNT);

    // NEW: Apply senior discount
    if (age >= 65)
        basePrice = basePrice * (1 - SENIOR_DISCOUNT);

    return basePrice;
}
```

**Step 2**: Update TicketForm.cs to reflect discount in summary

```csharp
if (age < 12)
    summary += "(FREE - Passenger under 12 years)\n";
else if (age >= 65)
    summary += "(25% senior discount applied)\n";
else if (gender == "Female")
    summary += "(50% discount applied - Female passenger)\n";
```

### Adding New Input Validation

To add maximum age validation (e.g., max 150 years):

In TicketForm.cs:

```csharp
if (!int.TryParse(txtAge.Text, out int age) || age < 0 || age > 150)
{
    errorMessage = "Please enter a valid age (0-150).";
    return false;
}
```

---

## Coding Standards

### Naming Conventions

**Classes**: PascalCase
```csharp
public class TicketCalculator { }
```

**Methods**: PascalCase
```csharp
public double CalculateTicketPrice(int age, ...) { }
```

**Properties**: PascalCase
```csharp
public string PassengerName { get; set; }
```

**Variables**: camelCase
```csharp
double finalPrice = 200.0;
int passengerAge = 25;
```

**Constants**: UPPER_SNAKE_CASE
```csharp
private const double CATEGORY_ONE_RATE = 20;
private const double FEMALE_DISCOUNT = 0.5;
```

### Documentation Standards

**XML Comments** for public methods:

```csharp
/// <summary>
/// Calculate the final ticket price based on pricing rules.
/// </summary>
/// <param name="age">Passenger age in years</param>
/// <param name="gender">Passenger gender</param>
/// <param name="category">Travel category</param>
/// <param name="distance">Travel distance in kilometers</param>
/// <returns>Final ticket price in Rands</returns>
public double CalculateTicketPrice(int age, string gender, string category, double distance)
{
    // Implementation
}
```

### Code Comments

Use comments for:
- Complex logic
- Business rule explanations
- Non-obvious decisions

Avoid:
- Over-commenting obvious code
- Comments that repeat code
- Out-of-date comments

```csharp
// Good: Explains WHY, not WHAT
if (age < 12)
    return 0;  // Business rule: Children under 12 travel free

// Bad: Obvious comment
age = int.Parse(txtAge.Text);  // Parse age
```

### Error Handling

Always validate inputs before processing:

```csharp
if (!ValidateInputs(out string error))
{
    MessageBox.Show(error, "Validation Error", 
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return;
}
```

### String Formatting

Use string formatting for currency:

```csharp
string formatted = $"Final Ticket Price: R{finalPrice:F2}";
// Output: "Final Ticket Price: R200.00"
```

---

## Common Issues & Solutions

### Issue 1: Build Fails - Missing Dependencies

**Error**: `CS0246: The type or namespace name 'Control' could not be found`

**Solution**:
```bash
dotnet restore
dotnet clean
dotnet build
```

### Issue 2: Form Controls Not Visible

**Problem**: Controls don't appear on form after modifications

**Solution**:
1. Check `InitializeComponent()` is called in form constructor
2. Verify controls are added to `this.Controls.Add(control)`
3. Check control positioning (Location and Size properties)

### Issue 3: Gender Discount Not Applied

**Problem**: Female passengers not getting 50% discount

**Debug**:
```csharp
// Add debug output
if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
{
    // This will handle "Female", "female", "FEMALE", etc.
    basePrice = basePrice * (1 - FEMALE_DISCOUNT);
}
```

**Check**: Ensure gender string matches exactly ("Female" with capital F)

### Issue 4: Validation Not Working

**Problem**: Invalid inputs accepted

**Solution**: Ensure `ValidateInputs()` is called before calculation

```csharp
private void BtnCalculate_Click(object sender, EventArgs e)
{
    // MUST validate first
    if (!ValidateInputs(out string error))
    {
        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;  // Don't continue if validation fails
    }

    // Safe to proceed
}
```

### Issue 5: Summary Panel Not Updating

**Problem**: Ticket summary doesn't show after calculation

**Solution**:
1. Verify `DisplayTicketSummary()` is called
2. Check `lblSummary` reference exists
3. Ensure panel is visible: `pnlSummary.Visible = true`

---

## Performance Considerations

### Optimization Tips

1. **Minimize Calculations**: Cache category rates if called frequently
2. **Input Validation**: Validate early, fail fast
3. **String Building**: Use `StringBuilder` for large text operations

```csharp
// Instead of multiple string concatenations:
StringBuilder sb = new StringBuilder();
sb.AppendLine($"Passenger Name: {name}");
sb.AppendLine($"Gender: {gender}");
string summary = sb.ToString();
```

---

## Testing Guidelines

### Unit Testing TicketCalculator

```csharp
// Test structure
[Fact]
public void TestCategoryOnePricing()
{
    // Arrange
    var calc = new TicketCalculator();
    int age = 25;
    double distance = 10;

    // Act
    double result = calc.CalculateTicketPrice(age, "Male", "Category One", distance);

    // Assert
    Assert.Equal(200.0, result);
}
```

---

## Debugging Tips

### Enable Debug Output

```csharp
#if DEBUG
    System.Diagnostics.Debug.WriteLine($"Calculated Price: {price}");
#endif
```

### Use Visual Studio Debugger

1. Set breakpoint: Click line number
2. Run in Debug mode (F5)
3. Inspect variables in Watch window
4. Step through code (F10 = Step Over, F11 = Step Into)

---

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0 | 2026 | Initial release |

---

## Support & Resources

- **Microsoft C# Documentation**: https://docs.microsoft.com/dotnet/csharp/
- **Windows Forms**: https://docs.microsoft.com/dotnet/desktop/winforms/
- **GitHub**: See repository for code examples

---

**Document Version**: 1.0  
**Last Updated**: 2026  
**Author**: Development Team
