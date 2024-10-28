# Code kata - Oct 2024

A kata we did at [FundApps](https://www.fundapps.co/). Patrick, the organiser, introduced it as:

> "...a fun little energetic one... focusing on writing small commits and breaking down your work."

## The challenge

You’re designing a new vending machine for the FundApps staff to dispense caffeine in regulated amounts for when we know what we’re doing and calming zen proverbs for when we don’t. To do this without incurring the wrath of the employees however you’re going to have to decide on how much change to give. With that in mind…

Write a program that will correctly determine the least number of coins to be given to a user such that the sum of the coins’ value equals the correct amount of change.

```csharp
Specification: 
Input: change amount 
Input: coin denomination array (i.e. [1, 2, 5, 10, 20, 50, 100, 200]) 
Output: array of the coins (i.e. [1, 0, 0, 0, 1, 0, 1, 0] would be £1.21) 

Examples: 
In : 15 , [1, 2, 5, 10, 20, 50] returns [0, 0, 1, 1, 0, 0] 
In : 45 , [1, 2, 5, 10, 20, 50] returns [0, 0, 1, 0, 2, 0]
```

## The constraints

Setup your project and source control.

You will then have **2 minutes!**

When writing code during the 2 minutes, either:

1. Write exactly one test
    1. If the timer rings and the test is red then ```git reset --hard``` and **start over**.
    2. If the test is green before timer rings then **commit**.
2. Refactor
    1. If the timer rings and the refactoring is not complete and tests are red then ```git reset --hard``` and **start over**.
    2. If the refactoring is complete and tests are green before the timer rings then **commit**.
