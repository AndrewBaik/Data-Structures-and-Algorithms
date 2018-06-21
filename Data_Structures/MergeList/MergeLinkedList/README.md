# Merge Linked List

## Summary
- Construct a method name mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternat between two linked lists and return a reference to the head of the single list.

![Merge Linked List WhiteBoard](MergeLinkedListWhiteBoard.jpg)

## Solutions
- Adjusted several lines from the whiteboard pseudocode, but big picture is the same. Inside the while iteration, written Linked List 2 merging into linked List 1, when either/both of linked lists are towards the end it breaks out of while iteration. And using if statements, find the condition of current state (whether LL1 or/and LL2 .Next equals to null), it performs different actions. 