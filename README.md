# MyCraftShop
This will be a website to manage a craft hobby shop at home.
It will track inventory, orders, and templates.
Target User: Website owner (single business owner)

## Features
- Inventory Management: Add, update, and delete inventory items
   - Cost per item, sales price, profit margin
   - Quantity: Some items will be used partially, so the quantity for some items will be percentages
- Order Management: Create and manage customer orders
   - Each order will have a list of items, quantities, and total price
- Templates: Create and manage templates for sublimation designs
   - Each template will have a name, description, photoshop template file and image
 
## Project Productivity
This project uses some features and processes to improve productivity. This will be updated as the project continues.
- GitHub Action: Added as a CI pipeline to compile and run tests
- Branch Protection: Requires Pull Requests to merge code into main and requires the GitHub Action to pass. Optionally we can add required code review
- Repo Settings:
    - Choose Squash Merge as only pull request merge option to keep history of main branch clean and easy to follow.
    - Automatically delete head branches: New branches are created for each PR so old ones are automatically deleted on PR merge
 - Issue Templates: Templates are used to help ensure higher quality issues. These will need to be refined as project continues
 - AI Code Review and Assign Issue to Copilot: Used as applicable
