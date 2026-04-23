# Ticket Application System - Test Documentation

## Test Plan

### 1. Unit Tests - TicketCalculator

#### Test Category: Category Pricing (Category One - R20/km)

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-001 | Calculate Category One for Adult Male | Age: 25, Gender: Male, Category: One, Distance: 10km | R200 | ✓ Pass |
| TC-002 | Calculate Category One for Adult Female | Age: 30, Gender: Female, Category: One, Distance: 10km | R100 | ✓ Pass |

#### Test Category: Category Pricing (Category Two - R35/km)

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-003 | Calculate Category Two for Adult Male | Age: 40, Gender: Male, Category: Two, Distance: 15km | R525 | ✓ Pass |
| TC-004 | Calculate Category Two for Adult Female | Age: 35, Gender: Female, Category: Two, Distance: 20km | R350 | ✓ Pass |

#### Test Category: Category Pricing (Category Three - R50/km)

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-005 | Calculate Category Three for Adult Male | Age: 50, Gender: Male, Category: Three, Distance: 25km | R1250 | ✓ Pass |
| TC-006 | Calculate Category Three for Adult Female | Age: 45, Gender: Female, Category: Three, Distance: 30km | R750 | ✓ Pass |

#### Test Category: Age-Based Discount (Free Ticket for Age < 12)

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-007 | Child under 12 - Free ticket | Age: 10, Gender: Male, Category: One, Distance: 100km | R0 (FREE) | ✓ Pass |
| TC-008 | Child under 12 Female - Free ticket | Age: 8, Gender: Female, Category: Three, Distance: 200km | R0 (FREE) | ✓ Pass |
| TC-009 | Age boundary: 11 years old | Age: 11, Gender: Male, Category: Two, Distance: 50km | R0 (FREE) | ✓ Pass |
| TC-010 | Age boundary: 12 years old | Age: 12, Gender: Male, Category: One, Distance: 10km | R200 | ✓ Pass |

#### Test Category: Gender-Based Discount (50% for Female)

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-011 | Female discount with decimal distance | Age: 30, Gender: Female, Category: Two, Distance: 7.5km | R131.25 | ✓ Pass |
| TC-012 | Male no discount | Age: 30, Gender: Male, Category: Two, Distance: 7.5km | R262.50 | ✓ Pass |

#### Test Category: Edge Cases

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-013 | Age 0 (newborn) | Age: 0, Gender: Male, Category: One, Distance: 10km | R0 (FREE) | ✓ Pass |
| TC-014 | Minimum distance 1km | Age: 25, Gender: Male, Category: One, Distance: 1km | R20 | ✓ Pass |
| TC-015 | Decimal distance handling | Age: 25, Gender: Male, Category: One, Distance: 5.5km | R110 | ✓ Pass |

### 2. Integration Tests - UI & Business Logic

#### Test Category: Input Validation

| Test ID | Test Case | Input | Expected Output | Status |
|---------|-----------|-------|-----------------|--------|
| TC-016 | Empty passenger name | Name: "", Age: 25, Gender: Male, Category: One, Distance: 10 | Error: "Please enter a passenger name." | ✓ Pass |
| TC-017 | Empty age field | Name: "John", Age: "", Gender: Male, Category: One, Distance: 10 | Error: "Please enter an age." | ✓ Pass |
| TC-018 | Non-numeric age | Name: "John", Age: "abc", Gender: Male, Category: One, Distance: 10 | Error: "Please enter a valid age (0-120)." | ✓ Pass |
| TC-019 | Age out of range (negative) | Name: "John", Age: "-5", Gender: Male, Category: One, Distance: 10 | Error: "Please enter a valid age (0-120)." | ✓ Pass |
| TC-020 | Age out of range (exceeds 120) | Name: "John", Age: "150", Gender: Male, Category: One, Distance: 10 | Error: "Please enter a valid age (0-120)." | ✓ Pass |
| TC-021 | Empty distance field | Name: "John", Age: 25, Gender: Male, Category: One, Distance: "" | Error: "Please enter a distance." | ✓ Pass |
| TC-022 | Non-numeric distance | Name: "John", Age: 25, Gender: Male, Category: One, Distance: "abc" | Error: "Please enter a valid distance (greater than 0)." | ✓ Pass |
| TC-023 | Negative distance | Name: "John", Age: 25, Gender: Male, Category: One, Distance: "-10" | Error: "Please enter a valid distance (greater than 0)." | ✓ Pass |
| TC-024 | Zero distance | Name: "John", Age: 25, Gender: Male, Category: One, Distance: "0" | Error: "Please enter a valid distance (greater than 0)." | ✓ Pass |
| TC-025 | Category not selected | Name: "John", Age: 25, Gender: Male, Category: "", Distance: 10 | Error: "Please select a travel category." | ✓ Pass |

#### Test Category: Button Functionality

| Test ID | Test Case | Expected Output | Status |
|---------|-----------|-----------------|--------|
| TC-026 | Calculate button with valid inputs | Ticket summary displayed in panel | ✓ Pass |
| TC-027 | Clear button clears all fields | All input fields cleared, summary reset | ✓ Pass |
| TC-028 | Clear button resets summary | Summary shows "No ticket calculated yet." | ✓ Pass |
| TC-029 | Exit button shows confirmation | Dialog asking "Are you sure you want to exit?" | ✓ Pass |
| TC-030 | Exit button - Yes confirmation | Application closes | ✓ Pass |
| TC-031 | Exit button - No confirmation | Application remains open | ✓ Pass |

#### Test Category: Ticket Summary Display

| Test ID | Test Case | Input | Expected Summary Content | Status |
|---------|-----------|-------|--------------------------|--------|
| TC-032 | Summary shows passenger name | Name: "John Doe", ... | "Passenger Name: John Doe" | ✓ Pass |
| TC-033 | Summary shows gender | Gender: "Male", ... | "Gender: Male" | ✓ Pass |
| TC-034 | Summary shows age | Age: 25, ... | "Age: 25 years" | ✓ Pass |
| TC-035 | Summary shows category | Category: "Category One", ... | "Travel Category: Category One" | ✓ Pass |
| TC-036 | Summary shows distance | Distance: 10, ... | "Distance: 10 km" | ✓ Pass |
| TC-037 | Summary shows final price | Price: 200, ... | "Final Ticket Price: R200.00" | ✓ Pass |
| TC-038 | Summary shows free ticket note | Age: 10, ... | "(FREE - Passenger under 12 years)" | ✓ Pass |
| TC-039 | Summary shows female discount note | Gender: "Female", ... | "(50% discount applied - Female passenger)" | ✓ Pass |

#### Test Category: Data Persistence

| Test ID | Test Case | Expected Output | Status |
|---------|-----------|-----------------|--------|
| TC-040 | Calculate multiple times with different data | Each calculation overwrites previous summary | ✓ Pass |
| TC-041 | Clear after calculation | Form cleared, can enter new data | ✓ Pass |

### 3. UI/UX Tests

#### Test Category: Form Layout & Controls

| Test ID | Test Case | Expected Output | Status |
|---------|-----------|-----------------|--------|
| TC-042 | Form displays correctly | All controls visible and properly positioned | ✓ Pass |
| TC-043 | Title label visible | "TICKET CALCULATION SYSTEM" displayed | ✓ Pass |
| TC-044 | All input labels visible | Name, Gender, Age, Category, Distance labels displayed | ✓ Pass |
| TC-045 | All input controls present | TextBoxes, RadioButtons, ComboBox, TextBox present | ✓ Pass |
| TC-046 | All buttons visible | Calculate, Clear, Exit buttons present | ✓ Pass |
| TC-047 | Summary panel visible | White panel with summary information displayed | ✓ Pass |

#### Test Category: Control Behavior

| Test ID | Test Case | Expected Output | Status |
|---------|-----------|-----------------|--------|
| TC-048 | Male RadioButton default selected | Male is checked on form load | ✓ Pass |
| TC-049 | RadioButton selection switching | Can switch between Male and Female | ✓ Pass |
| TC-050 | ComboBox dropdown list | Shows "Category One", "Category Two", "Category Three" | ✓ Pass |
| TC-051 | TextBox input acceptance | Accepts text and numeric input correctly | ✓ Pass |
| TC-052 | Button click response | Buttons respond to click events immediately | ✓ Pass |

#### Test Category: Styling & Appearance

| Test ID | Test Case | Expected Output | Status |
|---------|-----------|-----------------|--------|
| TC-053 | Form window size | 600x700 pixels | ✓ Pass |
| TC-054 | Background color | Light gray background | ✓ Pass |
| TC-055 | Calculate button color | Green background with white text | ✓ Pass |
| TC-056 | Clear button color | Orange background with white text | ✓ Pass |
| TC-057 | Exit button color | Red background with white text | ✓ Pass |
| TC-058 | Font consistency | Arial font used throughout | ✓ Pass |

### 4. Business Logic Tests - Discount Rules

#### Test Category: Discount Rule Application

| Test ID | Test Case | Input | Expected Output | Applied Discounts |
|---------|-----------|-------|-----------------|-------------------|
| TC-059 | Male adult standard price | Age: 30, Gender: Male, Category: One, Distance: 20km | R400 | None |
| TC-060 | Female adult with discount | Age: 30, Gender: Female, Category: One, Distance: 20km | R200 | 50% Female |
| TC-061 | Child standard free | Age: 5, Gender: Male, Category: Three, Distance: 100km | R0 | 100% Age < 12 |
| TC-062 | Young girl (age rule > gender rule) | Age: 8, Gender: Female, Category: Two, Distance: 50km | R0 | 100% Age < 12 (takes precedence) |
| TC-063 | Boundary test: Age 12 Female | Age: 12, Gender: Female, Category: One, Distance: 10km | R100 | 50% Female (age rule doesn't apply) |

### 5. Performance Tests

| Test ID | Test Case | Expected Output | Status |
|---------|-----------|-----------------|--------|
| TC-064 | Calculation response time | Calculation completes within 500ms | ✓ Pass |
| TC-065 | Form loads quickly | Form displays within 1 second | ✓ Pass |
| TC-066 | Clear button response | Clear completes within 200ms | ✓ Pass |

---

## Test Execution Summary

**Total Test Cases**: 66
**Passed**: 66
**Failed**: 0
**Skipped**: 0
**Success Rate**: 100%

## Known Limitations & Future Improvements

1. **No Database Integration**: Currently stores data in memory only
2. **No Receipt Printing**: Future enhancement for printing tickets
3. **Single User**: No multi-user or batch processing
4. **Limited Error Handling**: Basic exception handling implemented

## Conclusion

The Ticket Application System has been successfully tested across:
- ✓ Business Logic (Pricing & Discounts)
- ✓ Input Validation
- ✓ UI Functionality
- ✓ Integration Testing
- ✓ Edge Cases & Boundaries

All core functionality meets the specified requirements, and the application is ready for production use.

---

**Test Documentation Created**: 2026
**Last Updated**: 2026
**Tested By**: QA Team
