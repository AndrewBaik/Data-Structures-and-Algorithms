# Repeated Word

## Summarize
- Write a function that takes a lengthy string as a parameter, return a string of a first word that occur more than once.


## Solution
- I utilized the Hashset to solve this problem. First, I splited an inputted string into individual words and pushed each of those 
words into a Hashset array. After calculating for ASCII integers for each words, it saves into an calcuated ASCII index. 
If the array index is already taken, it returns selected word.


## Whiteboard 
![Repeated Word Whiteboard](../../../assets/RepeatedwordWhiteboard.jpg)