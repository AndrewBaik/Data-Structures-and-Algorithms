# Find Island

## Challenge
- Create a method that takes a, adjacency matrix and returns the number of islands within the matrix. Island will be anything that is not
part of the island where the root is located.

## Whiteboard
![Find Island Whiteboard](../../../assets/FindIslandWhiteboard.jpg)

## Solution
- I have taken a complete different approach then what's displaying on the whiteboard image above.
- I utilized resursive method to identify each island searched by rows of array. First method 'Find_Island()' triggers the searching process
by calling 'recursive()', which it searches the integer '1' in each rows and recalls the 'recursive()' with column index found assigned to a row. 
Each row being searched via 'recursive()' will be marked as visited to avoid redundancy and infinit loop. When recursion stopps and kicks back out to 'Find_Island()', 
island counter will increment by one to count for the previous ran island. At the end, 'Find_Island()' returns with island counter.