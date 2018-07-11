# Get Edges	

## Direction
- Write a method that takes in a list of Cities, returns whether full trip is possible with direct flight and how much it cost.
- Each cities will be considered a node, and direction of flight and costs will be assigned to its edges between nodes.

## Whiteboard
![Get Edge whiteboard](../../assets/GetEdgeWhiteboard.jpg)


## Implementation
- Initially during whiteboard, question wasn't specific enough for the data type of edge weight. 
Therefore, I assumed it was just a property of a class Graph or Node. But, after realizing type was list of dictionary,
my implementation changed bit. I had to declared additional methods and class to access this particular data type. But the main functionality
did not change compared to whiteboard.
- I utilized the Queue method to solve this problem. I Enqueued all of given list of nodes and dequeue as two nodes edge is identified using foreach iterations and if conditions.
