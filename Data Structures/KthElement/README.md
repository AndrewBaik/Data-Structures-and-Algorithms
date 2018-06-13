# Kth Element

## Summary
Write a method for the Linked List class which takes a number, k, as a parameter. Return the node that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges. ​

![Kth Element Screenshot](KthElementScreenShot.jpg)

## Solution
- Different than what I've planned on the whiteboard, I've found a different way to approach this problem while I was coding for the solution. Therefore, the code solution will be completely different from the algorithm and pseudocode on the whiteboard.
- I found out that a different variable can also act as a current/head variable. So instead of running the current run through the iteration of the run, I've created a different variable that runs ahead of current, so that the current value does not go past the 'k' th element(Node).