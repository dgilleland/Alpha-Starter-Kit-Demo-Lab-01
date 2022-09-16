# Demo Lab

> **STUDENT_NAME**

**NOTE:** Ensure that you have enabled *GitDoc* for this lab. To do so, press <kbd>F1</kbd>, type `GitDoc: Enable` and press <kbd>Enter</kbd>.

![Enable GitDoc](./images/EnableGitDoc.png)

**Read all the instructions before beginning your work!**

Your must place your work in the [src](./src/) folder. See the [ReadMe.md](./src/ReadMe.md) for setup details.

## Objectives

Upon completion of this exercise, you will have demonstrated the ability to:

- Identify the problem
- Construct an algorithm
- Translate an algorithm into C#
- Test an executable program.

Your solution will be assessed for **validity** (correctly solving the problem), **efficiency** (doing so without [extraneous](https://www.collinsdictionary.com/dictionary/english/extraneous) code), **maintainability** (how well the solution can be modified in the face of changing requirements), and **coding standards** (as outlined in class and directed by your instructor). Be sure to stay within the boundaries of the requirements for this assignment; if you need any clarifications, please direct them to your instructor.

----

## Problem Statement

You are tasked with creating a console application that calculates the area of a triangle. The formula is 

$$
a = \frac{1}{2} \cdot h \cdot b
$$

where $a$ is the area, $b$ is the base length and $h$ is the height. Prompt the user for the height and base (*in that order*) and then display the value of the area. Assume that the user input will be integer values; the calculated area should be a real value.

----

## Coding Standards

The following coding standards must be followed when developing your program:

- An opening documentation at the beginning of the source file describing the **purpose**, **input**, **output**, **author**, **instructor**, **section** of the program. For example:

    ```csharp
    // Purpose:
    // Input:
    // Output:
    // Written by: Student Name
    // Written for: Instructor Name
    // Section: A0#
    ```

- Write only one statement per line.
- Write only one declaration per line.
- Use meaningful variable names (i.e.: no one-character variables)
- Use `camelCase` for local variable names, `SCREAMING_SNAKE` for constants, and `PascalCase` for all other identifiers.
- If continuation lines are not indented automatically, indent them four spaces (the equivalent of one tab-stop).

## Marking Rubric

| **Mark** | **Description** |
| ---- | ---- |
| 5 | Excellent – program passes all test cases and coding follows best practices and class standards. |
| 4 | Very Good – program passes all test cases, but coding does not follow best practices and class standards. |
| 3 | Acceptable – coded all the requirements and program produces the expected results for some of the test cases. |
| 2 | Needs Work – coded all the requirements but program fails to produce expected results. |
| 1 | Unsatisfactory – coded less than 50% of the requirements. |
| 0 | Not done. |
