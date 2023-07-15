# Array Split Coding Challenge

This solution was created in response to a coding challenge.

"Given an array of length >= 0, and a positive integer N, return the contents of the array divided into N equally sized
arrays."

The solution was written in C# and created as a .NET Framework 4.7.2 solution. Visual Studio 2022 Community Edition was used.

## Installation 

The solution can be downloaded directly from GitHub and opened in Visual Studio. Users can then created a new instance of the ArrayController by passing either an array size and division size, or passing an instantiated array along with division size. To run the solution, users can call the GroupArrayElementsAndPrint() method of the controller. A console style user interface Main method is also included that can be un-commented in the code.

## Brief description of solution

An ArrayController class has been created to handle the bulk of the logic. The ArrayController class contains two constructors. One can accept an array size and divisible size and will instantiate an array of the given size with prepopulated numbers starting from 1. The second constructor accepts a pre-defined array and divisible size. Division size is the number that is used to split the array. The ArrayController class contains the method GroupArrayElementsAndPrint which will complete the task and then output the results to the console.

### InstantiateArray()
Creates a new array with numbers 1..N for N size of array given when the controller was instantiated.

### DivideArray()
The core logic for this solution is in the DivideArray method of the ArrayController. By dividing the array's length by the given divisible size, a 'sub' array size is stored. Any remainder in this division is also stored. A 2D array is then constructed using the divisible size. This is used to store the results of dividing the main array.
While iterating through the divisible size, if there is a remainder to the division, 1 is added to the size of the subarray currently being worked on, otherwise the size remains the same. This is to accommodate the trailing elements of the main array that would otherwise be left behind after the division. The subarray is then populated with elements of the main array until the subarray is full. Once full, the subarray is added to the 2D array. This is then repeated until the 2D array has been filled. 
This 2D array is then passed to the method DivideArrayAsStringList.

### DivideArrayAsStringList()
This method joins all elements of the 2D array together into a readable string. A string builder is used, along with string.join to create comma delimited strings.

### GroupArrayElementsAndPrint()
This method combines both methods above before writing the results to the console.

## Unit Tests
Several unit tests are also included in the solution to test exception handling and expected results.
