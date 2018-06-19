# Queue with Stack

## Summary of Challenge
- Create methods of Enqueue and Dequeue in the Queue (First in, First out) approach utilizing the two Stacks(one filled with Nodes and another empty) and Push/Pop methods in Stacks (First in, Last out) approach.

## Solution
- When I was whiteboarding, I miss understood the problem domain due to unclear instructions. Therefore, information on whiteboarding image may show differently than actual problem domain and code.
- I'v generated Enqueue method with just the Pop functionality with node value due to very similar functionalities among two methods.
- As far as the Dequeue method, I've moved all of the Nodes from one Stack to another in reversed order. After moving all the Nodes, last moved Node had been removed. Afterward, relocated rest of Node to pre-located Stack to place all of Nodes back in order after removing the very first Node so that it meets the funtionality of Dequeue.

![Stack and Queue Whiteboard](../../../assets/Stack_with_Queue_Whiteboard.jpg)