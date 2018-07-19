# Left Join

## Summary
- Create a method that takes two Hashmaps containing key and value pairs. 
- First, combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
 all the values in the first hashmap are returned, and if values exist in the second hashmap, they are appended to the result row. 
 If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.
- Return any form of list of key and value pairs.


## Whiteboard
![Left Join Whiteboard](../../assets/LeftJoinWhiteboard.jpg)


## Solution
- I decided to assign hashmap data type to dictionary since it will only contain a key and value. First, I took all the key value pairs
and added onto a list of string. While second hashmap iterates, it compares the key to a first hashmaps key. If it contains, then it finds 
the location of the list of strings and places second hashmaps value.
