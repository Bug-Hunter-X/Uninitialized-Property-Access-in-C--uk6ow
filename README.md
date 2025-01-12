# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value. This can lead to unpredictable behavior, including exceptions or incorrect results.

## The Bug

The `Bug.cs` file contains a class with a property (`MyProperty`) that is accessed in a method (`MyMethod`) before it's been given a value.  This results in an uninitialized property being read.

## The Solution

The `BugSolution.cs` file shows how to fix the problem by either assigning a default value to the property or ensuring the property is initialized before it is used. 

## How to run
1. Clone this repo
2. Open the solution in Visual Studio
3. Run the project. The solution will show the correct implementation