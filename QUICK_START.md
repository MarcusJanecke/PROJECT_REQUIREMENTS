# Quick Start Guide - Ticket Application System

## ⚡ 5-Minute Setup

### For Project Manager

```bash
# 1. Create GitHub repository
# - Go to github.com → New Repository
# - Name: TicketApplicationSystem
# - Initialize with README

# 2. Add team members as collaborators
# - Settings → Collaborators → Add people

# 3. Clone and set up initial code
git clone https://github.com/[your-username]/TicketApplicationSystem.git
cd TicketApplicationSystem

# 4. Copy all project files to repository
# (All files are ready - just copy to cloned directory)

# 5. Push initial setup
git add .
git commit -m "Initial project setup"
git push origin main

# Notify team of repository URL
```

---

### For Each Team Member

```bash
# 1. Clone the repository
git clone https://github.com/[team-username]/TicketApplicationSystem.git
cd TicketApplicationSystem

# 2. Create your development branch
git checkout -b Dev-ui-design-YourName
# OR
git checkout -b Dev-logic-module-YourName
# OR
git checkout -b Dev-testing-docs-YourName

# 3. Make your changes to assigned files

# 4. Commit your work
git add .
git commit -m "Your descriptive commit message"

# 5. Push to your branch
git push origin Dev-[role]-YourName

# 6. Repeat steps 3-5 for each completed task
```

---

## 📦 Project Files - Quick Reference

| File | Purpose | Who Edits? |
|------|---------|-----------|
| **TicketForm.Designer.cs** | UI Layout & Controls | UI Developer |
| **TicketForm.cs** | Form Logic & Events | UI Developer + Logic Developer |
| **TicketCalculator.cs** | Business Logic | Logic Developer |
| **Program.cs** | Application Entry | (Usually PM) |
| **README.md** | Project Overview | Everyone (PM leads) |
| **TEST_DOCUMENTATION.md** | Test Cases | Tester |
| **DEVELOPER_DOCUMENTATION.md** | Dev Guide | Logic Developer |

---

## 🎯 Role-Specific Workflows

### UI Developer Workflow

```bash
# Start
git checkout -b Dev-ui-design-[YourName]

# Task 1: Create form layout
# Edit: TicketForm.Designer.cs
# - Add labels, textboxes, radiobuttons, combobox
git commit -m "Created Windows Form layout"

# Task 2: Add styling
# Edit: TicketForm.Designer.cs
# - Apply colors, fonts, button colors
git commit -m "Applied professional styling"

# Task 3: Adjust spacing
# Edit: TicketForm.Designer.cs
# - Fine-tune positions and sizes
git commit -m "Adjusted spacing and alignment"

# Push all changes
git push origin Dev-ui-design-[YourName]
```

### Logic Developer Workflow

```bash
# Start
git checkout -b Dev-logic-module-[YourName]

# Task 1: Create TicketCalculator
# Edit: TicketCalculator.cs
# - Implement pricing logic
git commit -m "Implemented pricing calculation"

# Task 2: Add discounts
# Edit: TicketCalculator.cs
# - Add age and gender discount rules
git commit -m "Applied discount rules"

# Task 3: Complete form logic
# Edit: TicketForm.cs
# - Add button handlers
git commit -m "Implemented button event handlers"

# Push changes
git push origin Dev-logic-module-[YourName]
```

### Tester Workflow

```bash
# Start
git checkout -b Dev-testing-docs-[YourName]

# Task 1: Create test documentation
# Create/Edit: TEST_DOCUMENTATION.md
git commit -m "Created test documentation"

# Task 2: Test pricing scenarios
# Update: TEST_DOCUMENTATION.md with results
git commit -m "Tested pricing calculations"

# Task 3: Test validation
# Update: TEST_DOCUMENTATION.md with results
git commit -m "Tested input validation"

# Task 4: Create test cases
# Update: TEST_DOCUMENTATION.md
git commit -m "Added comprehensive test cases"

# Push documentation
git push origin Dev-testing-docs-[YourName]
```

---

## 🚀 Running the Application

### Option 1: Command Line (All Platforms)

```bash
# Navigate to project folder
cd TicketApplicationSystem

# Run directly
dotnet run

# Or build then run
dotnet build
cd bin/Debug/net6.0-windows
TicketApplicationSystem.exe
```

### Option 2: Visual Studio (Windows)

```bash
# Open solution
TicketApplicationSystem.sln

# Click Run (F5) or
# Debug → Start Debugging
```

---

## ✅ Before Each Commit

- [ ] Code compiles without errors
- [ ] No breaking warnings
- [ ] Changes match the feature
- [ ] Code is commented
- [ ] Naming conventions followed
- [ ] Documentation updated
- [ ] Tested manually

---

## 📝 Good Commit Messages

### ✅ Good Examples
```
git commit -m "Created Windows Form layout"
git commit -m "Added gender selection controls"
git commit -m "Implemented category pricing logic"
git commit -m "Applied female discount rule"
git commit -m "Added validation for distance input"
git commit -m "Created test documentation"
```

### ❌ Bad Examples
```
git commit -m "update"
git commit -m "fix"
git commit -m "changes"
git commit -m "fixed stuff"
```

---

## 🆘 Common Issues & Quick Fixes

### Issue: Can't Push Changes
```bash
# Error: "no upstream branch"
git push -u origin [branch-name]
```

### Issue: Need Latest Changes
```bash
# Get updates from main
git fetch
git merge origin/main
```

### Issue: Wrong Branch
```bash
# Check current branch
git branch

# Switch branch
git checkout [correct-branch]
```

### Issue: Build Failed
```bash
# Clean and rebuild
dotnet clean
dotnet restore
dotnet build
```

---

## 📊 Project Progress Tracking

### Weekly Checklist

**Week 1**:
- [ ] Repository created
- [ ] Team members added
- [ ] Initial setup pushed
- [ ] Everyone has cloned repo

**Week 2 - Monday**:
- [ ] All branches created
- [ ] Work assignments distributed
- [ ] Team starts development

**Week 2 - Tuesday-Thursday**:
- [ ] Team commits regularly
- [ ] Documentation being created
- [ ] Testing begins

**Week 2 - Friday**:
- [ ] All branches completed
- [ ] Final merge to main
- [ ] Testing verified
- [ ] Documentation complete
- [ ] Ready to submit

---

## 📚 Documentation Quick Links

| Document | Purpose | When to Use |
|----------|---------|------------|
| **README.md** | Project overview | Share with others |
| **DEVELOPER_DOCUMENTATION.md** | How code works | Understand architecture |
| **PROJECT_REQUIREMENTS.md** | What to build | Reference requirements |
| **TEST_DOCUMENTATION.md** | Testing guide | Track test progress |
| **GITHUB_COLLABORATION.md** | How to use GitHub | Git questions |
| **COMPLETION_SUMMARY.md** | Project status | Final submission |

---

## 🔍 Verification Before Submission

```bash
# 1. Verify build
dotnet build

# 2. Check git status
git status

# 3. View all commits
git log --oneline --graph --all

# 4. Verify branches
git branch -r

# 5. Test application functionality
# (Run and manually test all features)

# 6. Check documentation
# (Open each .md file and verify complete)
```

---

## 📞 Team Communication Tips

### Use Git Commit Messages for Communication
```bash
git commit -m "Implemented female discount rule

This applies a 50% discount to female passengers.
Calculation happens after age check per BR3.
Testing: Works for ages 12+ only."
```

### Use Pull Request Comments (If Using PRs)
- Describe what you changed
- Why you made the change
- Any known issues or limitations

### Regular Updates
- Commit at end of each work session
- Push daily (or multiple times per day)
- Communicate with team about dependencies

---

## 🎓 Learning Resources

### Git Basics
```bash
git init          # Initialize repository
git add .         # Stage all changes
git commit -m "message"  # Commit with message
git push          # Send to remote
git pull          # Get from remote
git log           # View history
```

### C# Basics
- Microsoft C# Documentation: https://docs.microsoft.com/dotnet/csharp/
- Windows Forms: https://docs.microsoft.com/dotnet/desktop/winforms/

### .NET Build
```bash
dotnet new        # Create new project
dotnet build      # Compile
dotnet run        # Build and run
dotnet test       # Run tests
```

---

## ⏱️ Time Estimates

| Task | Estimate | Who |
|------|----------|-----|
| UI Layout | 2-3 hours | UI Dev |
| UI Styling | 1-2 hours | UI Dev |
| Business Logic | 2-3 hours | Logic Dev |
| Event Handlers | 1-2 hours | Logic Dev |
| Testing | 2-3 hours | Tester |
| Documentation | 1-2 hours | Everyone |
| GitHub Setup | 0.5-1 hour | PM |
| Final Integration | 1-2 hours | PM |
| **TOTAL** | **11-18 hours** | **Team** |

---

## 📋 Final Submission Checklist

- [ ] All source code files in repository
- [ ] All documentation files complete
- [ ] README.md updated and accurate
- [ ] All branches visible in GitHub
- [ ] Commit history shows all team members
- [ ] Application builds successfully
- [ ] All features working and tested
- [ ] No errors or breaking warnings
- [ ] .gitignore properly configured
- [ ] Repository URL ready to submit

---

## 🎉 You're Ready!

The Ticket Application System is ready for team collaboration. Follow the workflows above, maintain clear commits, and keep documentation updated. Good luck! 🚀

---

**Quick Start Version**: 1.0  
**Last Updated**: 2026  
**Status**: Ready for Use
