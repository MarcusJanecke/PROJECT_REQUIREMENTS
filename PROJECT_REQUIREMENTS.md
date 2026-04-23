# Project Requirements Document - Ticket Application System

## Project Overview

**Project Name**: Ticket Application System  
**Type**: C# Windows Forms Desktop Application  
**Duration**: Week 2 Friday Project  
**Status**: Development Complete  
**Version**: 1.0

---

## Functional Requirements

### FR1: User Input Fields

The application must contain the following input controls:

#### FR1.1: Passenger Name Input
- **Control Type**: TextBox
- **Label**: "Passenger Name:"
- **Validation**: Non-empty
- **Max Length**: Unlimited (reasonable limit ~100 characters)
- **Required**: Yes

#### FR1.2: Gender Selection
- **Control Type**: RadioButton Group
- **Options**: 
  - Male (default selected)
  - Female
- **Required**: Yes
- **Mutually Exclusive**: Yes

#### FR1.3: Age Input
- **Control Type**: TextBox
- **Label**: "Age:"
- **Validation**: 
  - Must be numeric
  - Range: 0-120 years
  - Non-negative integer
- **Required**: Yes

#### FR1.4: Travel Category Selection
- **Control Type**: ComboBox
- **Options**:
  - Category One (R20/km)
  - Category Two (R35/km)
  - Category Three (R50/km)
- **Default**: None (must select)
- **Required**: Yes

#### FR1.5: Travel Distance Input
- **Control Type**: TextBox
- **Label**: "Distance (km):"
- **Validation**:
  - Must be numeric
  - Must be positive (> 0)
  - Decimal values allowed
- **Required**: Yes

### FR2: Control Buttons

#### FR2.1: Calculate Ticket Price Button
- **Text**: "Calculate Ticket Price"
- **Action**: 
  1. Validate all inputs
  2. Calculate ticket price
  3. Display summary
- **Error Handling**: Show validation error messages
- **Visual Feedback**: Green button with white text

#### FR2.2: Clear Form Button
- **Text**: "Clear Form"
- **Action**:
  1. Clear all text boxes
  2. Reset gender to "Male"
  3. Reset category selection
  4. Clear summary display
- **Visual Feedback**: Orange button with white text

#### FR2.3: Exit Application Button
- **Text**: "Exit Application"
- **Action**:
  1. Show confirmation dialog
  2. Close app if confirmed
  3. Do nothing if cancelled
- **Confirmation**: "Are you sure you want to exit?"
- **Visual Feedback**: Red button with white text

### FR3: Ticket Summary Output

#### FR3.1: Summary Display Method
- **Control Type**: Label within Panel
- **Display Format**: Text summary
- **Location**: Below input fields
- **Background**: White panel with border
- **Title**: "TICKET SUMMARY"

#### FR3.2: Summary Information
Must display:
- Passenger Name
- Gender (Male/Female)
- Age (in years)
- Travel Category
- Distance (in km)
- Final Ticket Price (formatted: R XX.XX)
- Discount Information (if applicable)

#### FR3.3: Discount Indication
- Show if ticket is FREE (age < 12)
- Show if 50% discount applied (female)
- Show which rule was applied

---

## Business Rules

### BR1: Category Pricing

| Category | Price per Kilometer |
|----------|-------------------|
| Category One | R20 |
| Category Two | R35 |
| Category Three | R50 |

**Formula**: `Base Price = Category Rate × Distance`

### BR2: Age-Based Discount

**Rule**: If passenger age < 12, ticket is FREE

**Implementation**:
```
if (age < 12)
    finalPrice = 0
```

**Priority**: Highest (applied before other rules)

### BR3: Gender-Based Discount

**Rule**: If passenger is Female, apply 50% discount to calculated price

**Implementation**:
```
if (gender == "Female" AND age >= 12)
    finalPrice = basePrice × 0.5
```

**Priority**: Applied after age rule

### BR4: Price Calculation Flow

```
Step 1: Check Age Rule
├─ if (age < 12) → return FREE (0)
└─ else → continue

Step 2: Calculate Base Price
├─ basePrice = categoryRate × distance
└─ continue

Step 3: Check Gender Rule
├─ if (gender == "Female") → apply 50% discount
│   finalPrice = basePrice × 0.5
└─ else → finalPrice = basePrice

Step 4: Return Final Price
```

---

## Non-Functional Requirements

### NFR1: User Interface

- **Professional Appearance**: Clean, organized layout
- **Responsiveness**: Buttons respond immediately
- **Font**: Arial throughout application
- **Colors**: 
  - Background: Light Gray
  - Calculate Button: Green text on white
  - Clear Button: Orange text on white
  - Exit Button: Red text on white
  - Summary Panel: White background
- **Accessibility**: Large enough text, clear labels
- **Window Size**: 600 × 700 pixels
- **Resizable**: No (fixed size for consistency)

### NFR2: Input Validation

**Validation Rules**:
- ✓ Passenger name: Not empty/whitespace
- ✓ Age: Numeric, 0-120 range
- ✓ Distance: Numeric, positive (> 0)
- ✓ Category: Must be selected
- ✓ Gender: Always valid (radio button)

**Error Messages**: Clear, specific error messages for each validation failure

**Timing**: Validation occurs on Calculate button click

### NFR3: Code Quality

- **Naming Conventions**: 
  - PascalCase for classes and methods
  - camelCase for variables
  - UPPER_SNAKE_CASE for constants
- **Comments**: 
  - XML comments on public methods
  - Inline comments for complex logic
  - No over-commenting obvious code
- **Code Organization**:
  - Separation of concerns (UI vs Logic)
  - Single responsibility principle
  - Reusable methods
- **Documentation**:
  - README.md with project overview
  - Developer documentation
  - Test documentation
  - Code comments

### NFR4: Testing

- **Unit Testing Ready**: Business logic easily testable
- **Manual Testing**: All features tested before submission
- **Test Cases**: Documented in TEST_DOCUMENTATION.md
- **Coverage**: All pricing rules, validations, edge cases

### NFR5: GitHub Collaboration

- **Repository**: Properly structured
- **Branches**: Each member creates own branch
- **Commits**: Clear, descriptive commit messages
- **Documentation**: README, test docs, developer docs
- **Collaboration**: Evidence of team contributions

---

## User Stories

### US1: Calculate Simple Ticket Price
**As a** passenger  
**I want to** calculate my ticket price  
**So that** I know how much to pay

**Acceptance Criteria**:
- [x] Enter passenger information
- [x] Select travel category
- [x] Enter distance
- [x] View calculated price
- [x] Price is accurate

### US2: Get Free Ticket as Child
**As a** parent with a child under 12  
**I want** my child to travel free  
**So that** I save money on fares

**Acceptance Criteria**:
- [x] Enter child age < 12
- [x] System shows FREE ticket
- [x] Price displayed as R0

### US3: Apply Female Discount
**As a** female passenger  
**I want** a 50% discount on my ticket  
**So that** I get a reduced fare

**Acceptance Criteria**:
- [x] Select Female gender
- [x] 50% discount applied to price
- [x] Discount shown in summary

### US4: Validate Inputs
**As a** user  
**I want** the system to validate my input  
**So that** I don't get incorrect calculations

**Acceptance Criteria**:
- [x] Invalid name rejected
- [x] Invalid age rejected
- [x] Invalid distance rejected
- [x] Clear error messages shown

### US5: Clear and Recalculate
**As a** user  
**I want** to clear the form and enter new data  
**So that** I can make another calculation

**Acceptance Criteria**:
- [x] Clear button clears all fields
- [x] Summary resets
- [x] Can enter new data immediately

### US6: Exit Application
**As a** user  
**I want** to exit the application safely  
**So that** I can close the program

**Acceptance Criteria**:
- [x] Exit button asks for confirmation
- [x] App closes on confirmation
- [x] App stays open on cancel

---

## Calculation Examples

### Example 1: Adult Male Standard Price
**Input**:
- Name: John Smith
- Gender: Male
- Age: 30
- Category: Category One
- Distance: 15 km

**Calculation**:
1. Age check: 30 ≥ 12 → Not free, continue
2. Base price: 20 × 15 = R300
3. Gender check: Male → No discount
4. Final price: R300.00

---

### Example 2: Adult Female with Discount
**Input**:
- Name: Jane Doe
- Gender: Female
- Age: 28
- Category: Category Two
- Distance: 20 km

**Calculation**:
1. Age check: 28 ≥ 12 → Not free, continue
2. Base price: 35 × 20 = R700
3. Gender check: Female → Apply 50% discount
4. Final price: 700 × 0.5 = R350.00

---

### Example 3: Child Under 12 (Free)
**Input**:
- Name: Tommy Junior
- Gender: Male
- Age: 8
- Category: Category Three
- Distance: 100 km

**Calculation**:
1. Age check: 8 < 12 → FREE
2. Final price: R0.00 (Age rule takes precedence)

---

### Example 4: Young Girl (Age Rule Takes Precedence)
**Input**:
- Name: Sarah Johnson
- Gender: Female
- Age: 10
- Category: Category Two
- Distance: 50 km

**Calculation**:
1. Age check: 10 < 12 → FREE
2. Final price: R0.00 (Age rule applies, gender rule doesn't apply)

---

## Success Criteria

### Functional Success
- [x] All input fields present and functional
- [x] All buttons present and functional
- [x] Category pricing accurate
- [x] Age discount (free) works correctly
- [x] Gender discount (50%) works correctly
- [x] Validation prevents invalid entries
- [x] Ticket summary displays correctly

### Non-Functional Success
- [x] Professional appearance
- [x] Code follows naming conventions
- [x] Code includes comments
- [x] All features tested
- [x] GitHub properly used
- [x] Documentation complete

### Team Success
- [x] All members contributed
- [x] Proper branch usage
- [x] Clear commit messages
- [x] README maintained
- [x] Code merged successfully
- [x] Final submission complete

---

## Out of Scope

The following features are NOT included in this version:

- ❌ Database storage of tickets
- ❌ Receipt printing
- ❌ Multiple passenger batch processing
- ❌ Payment gateway integration
- ❌ Real-time availability checks
- ❌ Mobile application version
- ❌ Web-based version
- ❌ Multi-language support
- ❌ Ticket history/logging
- ❌ User accounts/authentication

---

## Constraints

- **Technology**: C# .NET 6.0 Windows Forms
- **Team Size**: Minimum 4 members
- **Timeline**: Week 2 Friday
- **Collaboration**: GitHub required
- **Platform**: Windows operating system

---

## Sign-Off

| Role | Name | Student # | Date | Signature |
|------|------|-----------|------|-----------|
| Project Manager | [Name] | [#] | 2026 | _____ |
| UI Developer | [Name] | [#] | 2026 | _____ |
| Logic Developer | [Name] | [#] | 2026 | _____ |
| Tester | [Name] | [#] | 2026 | _____ |

---

**Document Version**: 1.0  
**Last Updated**: 2026  
**Status**: Approved for Development
