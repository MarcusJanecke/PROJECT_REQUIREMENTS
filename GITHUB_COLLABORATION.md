# GitHub Collaboration Guide

## Team Setup

### Step 1: Project Manager Creates Repository

1. Go to GitHub.com
2. Click "New Repository"
3. Name: `TicketApplicationSystem`
4. Description: "Ticket Application System - C# Windows Forms"
5. Initialize with README (optional, will be updated)
6. Create repository

**Repository URL Example**: `https://github.com/[YourUsername]/TicketApplicationSystem`

### Step 2: Project Manager Adds Team Members

1. Go to Settings → Collaborators
2. Click "Add people"
3. Search for and add each team member
4. Set permission level: Maintain (so they can manage branches)

### Step 3: Project Manager Creates Initial Setup

```bash
# Clone repository
git clone https://github.com/[YourUsername]/TicketApplicationSystem.git
cd TicketApplicationSystem

# Create main project structure
# Add all source files to main branch
git add .
git commit -m "Initial project setup with structure"
git push origin main
```

---

## Individual Member Workflow

### Step 1: Clone Repository (Each Member)

```bash
git clone https://github.com/[YourUsername]/TicketApplicationSystem.git
cd TicketApplicationSystem
```

### Step 2: Create Personal Development Branch

Each member creates their own branch following the naming convention:

**Branch Naming**:
- **UI Developer**: `Dev-ui-design-[YourName]`
- **Logic Developer**: `Dev-logic-module-[YourName]`
- **Tester**: `Dev-testing-docs-[YourName]`
- **Project Manager**: `Dev-project-management-[YourName]`

**Example**: `Dev-ui-design-JohnDoe`

```bash
# Create and switch to new branch
git checkout -b Dev-ui-design-JohnDoe

# Or if branch already exists
git checkout Dev-ui-design-JohnDoe
```

### Step 3: Make Your Changes

```bash
# Make changes to files
# Edit TicketForm.Designer.cs (for UI developer)
# Edit TicketCalculator.cs (for logic developer)
# Create documentation (for tester)
```

### Step 4: Commit Your Changes

**Good Commit Messages** (Clear and Descriptive):
```bash
# UI Developer
git commit -m "Added gender selection controls"
git commit -m "Implemented responsive form layout"
git commit -m "Applied professional styling to buttons"

# Logic Developer
git commit -m "Implemented category pricing calculation"
git commit -m "Applied female discount rule"
git commit -m "Added age-based free ticket logic"

# Tester
git commit -m "Created test documentation"
git commit -m "Added test cases for pricing rules"
git commit -m "Documented validation test results"

# Project Manager
git commit -m "Updated README with feature list"
git commit -m "Created project structure"
git commit -m "Merged development branches to main"
```

**Bad Commit Messages** (Avoid):
```
git commit -m "update"
git commit -m "changes"
git commit -m "fixed stuff"
git commit -m "more work"
git commit -m "fix"
```

### Step 5: Push Your Branch

```bash
# Push your branch to remote
git push origin Dev-ui-design-JohnDoe

# Verify branch exists on GitHub
git branch -r
```

### Step 6: Create Pull Request (Optional)

1. Go to GitHub repository
2. Click "New Pull Request" or "Compare & pull request"
3. Select your branch as source
4. Select `main` as target
5. Add description of changes
6. Create pull request

---

## Project Manager Final Integration

### Step 1: Merge All Branches

```bash
# Switch to main branch
git checkout main

# Ensure main is up to date
git pull origin main

# Merge each member's branch
git merge Dev-ui-design-JohnDoe --no-ff
git merge Dev-logic-module-JaneSmith --no-ff
git merge Dev-testing-docs-BobJones --no-ff
git merge Dev-project-management-AliceWon --no-ff
```

### Step 2: Resolve Conflicts (If Any)

```bash
# If conflicts occur
git status

# Edit conflicted files
# Remove conflict markers (<<<<<<, ======, >>>>>>>)
# Keep desired code

# After resolving
git add [conflicted-file]
git commit -m "Resolved merge conflicts"
```

### Step 3: Push Final Code

```bash
# Push merged code to main
git push origin main
```

### Step 4: Verify All Changes

```bash
# View commit history
git log --oneline --graph --all

# Should show all member contributions
```

---

## Working with Git - Common Commands

### View Status
```bash
git status                    # Current status
git log                       # View commits
git log --oneline            # Compact view
git log --oneline --graph    # Visual branch history
```

### Create & Switch Branches
```bash
git branch                    # List local branches
git branch -r                 # List remote branches
git branch [branch-name]      # Create branch
git checkout [branch-name]    # Switch branch
git checkout -b [branch]      # Create and switch
```

### Stage & Commit
```bash
git add [filename]            # Stage specific file
git add .                     # Stage all changes
git commit -m "message"       # Commit with message
```

### Push & Pull
```bash
git push origin [branch]      # Push branch to remote
git pull origin main          # Pull latest main
git fetch                     # Get all updates
```

### Undo Changes
```bash
git restore [file]            # Discard changes in file
git reset HEAD [file]         # Unstage file
git revert [commit-id]        # Create new commit that undoes changes
```

---

## Best Practices

### Commit Frequency
- ✓ Commit after completing a feature
- ✓ Commit logical units of work
- ✓ Commit at least once per session
- ❌ Don't commit huge changes at once

### Commit Messages
- ✓ Imperative mood: "Add feature" not "Added feature"
- ✓ Start with capital letter
- ✓ Be specific and descriptive
- ✓ Reference the work done
- ❌ Don't use vague messages

### Example Good Workflow
```bash
# Day 1
git add TicketForm.Designer.cs
git commit -m "Created Windows Form layout"

git add Program.cs
git commit -m "Added application entry point"

git push origin Dev-ui-design-JohnDoe

# Day 2
git add TicketForm.Designer.cs
git commit -m "Added label controls"

git add TicketForm.Designer.cs
git commit -m "Added textbox controls"

git push origin Dev-ui-design-JohnDoe

# Final
git push origin Dev-ui-design-JohnDoe
# Create Pull Request
```

---

## GitHub Repository Structure

### Final Repository Should Contain:

```
TicketApplicationSystem/
├── .git/                           # Git directory (auto-created)
├── .gitignore                      # Files to ignore
│
├── Source Code:
├── Program.cs
├── TicketForm.cs
├── TicketForm.Designer.cs
├── TicketCalculator.cs
├── TicketApplicationSystem.csproj
│
├── Solution File:
└── TicketApplicationSystem.sln
│
├── Documentation:
├── README.md                       # Project overview
├── PROJECT_REQUIREMENTS.md         # Requirements document
├── DEVELOPER_DOCUMENTATION.md      # Developer guide
├── TEST_DOCUMENTATION.md           # Test cases
└── GITHUB_COLLABORATION.md         # This file
│
└── Screenshots/ (Optional)
    ├── main-form.png
    ├── calculation-example.png
    └── summary-display.png
```

---

## Viewing Commit History

### On GitHub Web Interface

1. Go to repository
2. Click "Commits"
3. View all commits from all team members
4. Verify each member has contributed

### On Local Machine

```bash
git log --oneline --all --graph
# Output:
# *   abc1234 Merged all branches
# |\
# | * def5678 Added test documentation
# | * ghi9012 Created test cases
# |/
# * jkl3456 Implemented discount logic
# * mno7890 Added calculation method
```

---

## Troubleshooting

### Issue: Cannot Push Changes

**Problem**: `fatal: The current branch X has no upstream branch`

**Solution**:
```bash
git push -u origin [branch-name]
# The -u flag sets upstream tracking
```

### Issue: Changes Lost

**Problem**: Accidentally deleted important code

**Solution**:
```bash
git log -p                    # View all changes
git reflog                    # View reference logs
git checkout [commit-id] -- [file]  # Restore old version
```

### Issue: Merge Conflicts

**Problem**: Can't merge because of conflicts

**Solution**:
```bash
git status                    # See conflicted files
# Edit files to resolve conflicts
git add [resolved-files]
git commit -m "Resolved merge conflicts"
```

### Issue: Wrong Branch

**Problem**: Made changes on wrong branch

**Solution**:
```bash
# Save your changes
git stash

# Switch to correct branch
git checkout [correct-branch]

# Apply your changes
git stash pop

# Commit
git commit -m "Changes on correct branch"
```

---

## GitHub Best Practices

### ✓ DO:
- ✓ Pull before you push (avoid conflicts)
- ✓ Commit frequently with clear messages
- ✓ Create descriptive branch names
- ✓ Review changes before committing
- ✓ Keep branches updated with main
- ✓ Use meaningful comments in code
- ✓ Test code before pushing

### ❌ DON'T:
- ❌ Commit sensitive information (passwords, keys)
- ❌ Commit large binary files
- ❌ Force push to main branch
- ❌ Ignore merge conflicts
- ❌ Make huge commits with multiple unrelated changes
- ❌ Commit broken code
- ❌ Delete someone else's branch

---

## Team Communication

### GitHub Issues (Optional)

Track tasks and bugs:
1. Go to "Issues" tab
2. Click "New Issue"
3. Title: Task description
4. Description: Details
5. Assign to team member
6. Add labels (bug, enhancement, documentation)

### Pull Request Discussion

Use PR comments to discuss code changes:
1. Create pull request
2. Add comments on specific lines
3. Team reviews and approves
4. Merge after approval

### Commit Messages as Communication

Good commit messages help team understand changes:
```bash
git commit -m "Implemented female discount rule

This applies a 50% discount to female passengers as per
business requirement BR3. Calculation is applied after
the age-based free ticket rule."
```

---

## Final Submission Checklist

Before final submission, verify:

- [x] All team members have committed code
- [x] All branches are visible in GitHub
- [x] README.md is complete and updated
- [x] Code is well-commented
- [x] Documentation is comprehensive
- [x] Test documentation is complete
- [x] All features are working
- [x] No broken code in main branch
- [x] Commit history shows all contributions
- [x] Project builds successfully

---

## GitHub Workflow Diagram

```
┌─────────────────────────────────────────┐
│  Step 1: PM Creates Repository          │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 2: PM Adds Team Members           │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 3: Each Member Clones Repo        │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 4: Create Personal Development    │
│          Branch                          │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 5: Make Changes & Commit          │
│          (Multiple commits)              │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 6: Push Branch to Remote          │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 7: Create Pull Request (Optional) │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 8: PM Merges All Branches         │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 9: Final Code in Main Branch      │
└────────────┬────────────────────────────┘
             │
┌────────────▼────────────────────────────┐
│  Step 10: Submit Repository Link        │
└─────────────────────────────────────────┘
```

---

## Sample Workflow Example

### Team Member: UI Developer (John Doe)

```bash
# Day 1: Initial setup
git clone https://github.com/team/TicketApplicationSystem.git
cd TicketApplicationSystem
git checkout -b Dev-ui-design-JohnDoe

# Day 1: Create form layout
# Edit: TicketForm.Designer.cs
git add TicketForm.Designer.cs
git commit -m "Created Windows Form layout with all controls"
git push origin Dev-ui-design-JohnDoe

# Day 2: Add styling
# Edit: TicketForm.Designer.cs
git add TicketForm.Designer.cs
git commit -m "Applied professional styling and colors"
git push origin Dev-ui-design-JohnDoe

# Day 3: Final adjustments
# Edit: TicketForm.Designer.cs
git add TicketForm.Designer.cs
git commit -m "Adjusted spacing and alignment for better UI"
git push origin Dev-ui-design-JohnDoe

# Final submission
# GitHub shows 3 commits from john-doe branch
# All changes visible in commit history
```

---

**Version**: 1.0  
**Last Updated**: 2026  
**For**: Ticket Application System Project
