# 🏰 Windsor Family Tree Console Application

A **C# console application** to dynamically create, display, and explore the **House of Windsor family tree**, with features like search, BFS/DFS traversal, and oldest-to-youngest ordering.



## Features

- **Dynamic Family Tree:** Add new members at runtime under any parent.  
- **Oldest-to-Youngest Order:** Children are automatically sorted by birth date.  
- **Display Tree:** Show the full family hierarchy with indentation.  
- **Search:** Locate a member by name.  
- **Traversal:** Explore the tree using **BFS** (Breadth-First Search) or **DFS** (Depth-First Search).  
- **Interactive Menu:** Easy-to-use console interface for adding members and performing operations.  



## Preloaded Structure

- **Root Monarch:** Queen Elizabeth II  
- **Children:** Charles, Anne, Andrew, Edward  
- **Grandchildren:** William, Harry (children of Charles)  
- **Great-grandchildren:** George, Charlotte, Louis (children of William)  

The tree is **dynamic**, so users can add more members at runtime.


## Screenshots
```
Queen Elizabeth II (b. 21/04/1926)
Prince Charles (b. 14/11/1948)
Prince William (b. 21/06/1982)
Prince George (b. 22/07/2013)
Princess Charlotte (b. 02/05/2015)
Prince Louis (b. 23/04/2018)
Prince Harry (b. 15/09/1984)
Princess Anne (b. 15/08/1950)
Prince Andrew (b. 19/02/1960)
Prince Edward (b. 10/03/1964)


```



## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed  
- Console/terminal environment  



### Running the Application

1. **Clone the repository:**

```bash
git clone https://github.com/yourusername/WindsorFamilyTree.git
cd WindsorFamilyTree

```
2. **Build the project:**

```
dotnet build
```
3. **Run the application:**
   ```
   dotnet run
   ```
   
## Menu Options

1. Display Full Family Tree – Show the entire tree from the root monarch.

2. Search for a Member – Search by name and display the member.

3. Add a New Member – Dynamically add children under any parent.

4. BFS Traversal – List members in level order.

5. DFS Traversal – List members in depth-first order.

6. Exit – Close the program.

## Adding Members

- Enter the parent's name.

- Enter the new member's name.

- Enter the title (e.g., Prince, Princess, Duke).

- Enter the birth date (yyyy-mm-dd).

  The member is automatically inserted oldest to youngest.

## Example
```
Enter parent name: Charles
Enter new member name: Archie
Enter title: Master
Enter birth date (yyyy-mm-dd): 2019-05-06
Added Archie under Charles
```

## Code Structure
- ```RoyalMember ``` – Represents a royal family member.

- ``` FamilyTreeNode  ```– Node in the tree containing a member and children.

- ``` FamilyTree ``` – Manages the tree, displays, traverses, and searches.

- ``` Program ``` – Interactive console menu to operate the family tree.

## Author

Keenan Davis – Developer
