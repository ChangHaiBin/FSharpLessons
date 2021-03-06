﻿
////////////////////////////////////////////////////////////////////////////////////
// 3.1 List creation

let list1 = [1 .. 100]          
let list2 = [50 .. 80]
let list3 = [1 .. 2 .. 100]      

let list4 = [1.0 .. 100.0]      
let list5 = [0.0 .. 0.05 .. 1.0]

let list6 = [1; 20; 50; 100; 55; 5; 10]
let list7 = [1.0; 6.0; 5.0; 10.0; 3.0; 2.0]

let list8 = ["ABC";"DEF";"GHI";"JKL";"MNO"]

// ####################################################
// ERROR: Cannot have a list with different types.  //#
let listError = ["ABC"; 123; 400.0]                 //#
// ####################################################

////////////////////////////////////////////////////////////////////////////////////
// 3.2 List.filter
let IsItEven x = (x % 2 = 0)

let trueOrFalse1 = IsItEven 10
let trueOrFalse2 = IsItEven 3

/////////////////////////////////////////
// List.filter
let result1 = List.filter IsItEven [1 .. 100]

// With anonymous/lambda function:
let result2 = List.filter (fun x -> x % 2 = 0) [1 .. 100]

////////////////////////////////////
// List.filter and |>

let SumMultiplesOfThree xList =
    xList
    |> List.filter (fun x -> x % 3 = 0)
    |> List.sum

// See the pdf file for a detailed explanation of the code.
    
// 3 + 6 + 9 + ... + 99 = 1683
let result3 = SumMultiplesOfThree [1 .. 100]

// 3 + 6 + 9 + ... + 198 = 6633
let result4 = SumMultiplesOfThree [1 .. 200]

//////////////////////////////////////////////////////////////////////////////////////
// Another example:

let CountGreaterThan80 scoreList =
    scoreList
    |> List.filter (fun x -> x >= 80)
    |> List.length
    
let result5 = CountGreaterThan80 [60; 65; 70; 75; 80; 85; 90; 95]
printfn "%i students scored 80 or above." result5

/////////////////////////////////////////////////////////////////////////////////////
// Example:
let SumMultiplesOf3ButNot5 xList =
    xList
    |> List.filter (fun x -> (x % 3 = 0) && (x % 5 <> 0))
    |> List.sum
    
// Include multiples of 3, e.g. 3, 6, 9, 12,......
// but ignore multiples of 5, e.g. 15, 30, 45,.......
let result6 = SumMultiplesOf3ButNot5 [1 .. 100]

/////////////////////////////////////////////////////////////////////////////////////
// Exercise: 

// PROJECT EULER QUESTION 1
// Implement a function that sums up all multiples of 3 or 5 in a list.
let SumMultiplesOf3Or5 xList =
    // Hint:  || means OR, && means AND
    failwith "NOT IMPLEMENTED!" 

// Within 1 to 10, the multiples of 3 or 5 are 3, 5, 6, 9, 10
// 3 + 5 + 6 + 9 + 10 = 33
let result7 = SumMultiplesOf3Or5 [1 .. 10]

// You can create an account, and submit your answers here for personal achievement/accomplishment.
// https://projecteuler.net/problem=1
let result8 = SumMultiplesOf3Or5 [1 .. 999]

/////////////////////////////////////////////////////////////////////////////////////
// Exercise:

// PROJECT EULER QUESTION 3

// Remark: This tutorial has already helped you implement the "IsPrime" function
// 
// You can just use it. No need to re-implement it.
let IsPrime x =
    let squareRoot = x |> double |> sqrt |> int 
    if x = 1 then false
    else if x = 2 then true
    else if x % 2 = 0 then false
    else 
        [3 .. 2 .. squareRoot]
        |> List.forall (fun i -> x%i <> 0)
        
printfn "Is 5 a prime? %b" (IsPrime 5)
printfn "Is 9 a prime? %b" (IsPrime 9)

// PROJECT EULER QUESTION 7

// Original Question: What is the 10001-th prime number?

// Solution part (a): We start with a random guess of "500000",
// How many prime numbers are between 2 and 500000?

let numberOfPrimesWithinRange =
    [2 .. 500000]
    // |> ..........
    // |> ..........
    
    failwith "NOT YET IMPLEMENTED!"
    // Implement the logic above.

    // Expected answer: 41538
    // This means that there are 41538 prime numbers between 2 and 500000, 
    // and so the 10001-th prime number that we are looking for is also in this range.

/////////////////////////////////////////
// We can use List.item to get the Nth item in a list. 
// But be careful of zero-based index!
let word1 = List.item 3 ["A"; "B"; "C"; "D"; "E"]

let word2 = List.item 5 ["A"; "B"; "C"; "D"; "E"; "F"; "G"; "H"; "I"; "J"]

/////////////////////////////////////////

// Solution part (b): To find the 10001-th prime number, 
// we can just find the 10001-th prime number between the range 2 to 500000

// To find the 10001-th element of a list, use "List.item 10000"

let find10001thPrime =
    [2 .. 500000]
    // |> ..........
    // |> ..........

    failwith "NOT YET IMPLEMENTED"

/////////////////////////////////////////////////////////////////////////////////////
// Exercise: Project Euler Question 3

// Original Question: What is the largest prime factor of 600851475143?
// We will not attempt the Original Question. Instead, we will look at the modified question:

// Modified Question: Write a function that takes a list of (positive) numbers, 
// and returns the largest prime number in that list.

// Hint: Use the "IsPrime" function above, and use "List.max"

let FindLargestPrime intList =
    intList
    // |> ............


    failwith "NOT YET IMPLEMENTED"
    // IMPLEMENT THE FUNCTION ABOVE.

let primeResult1 = FindLargestPrime [2;3;5;7;11]
// Expected Result: 11

let primeResult2 = FindLargestPrime [7; 100; 200; 333; 777]
// Expected Result: 7
// Because only 7 is a prime number in this list

let primeResult3 = FindLargestPrime [100; 200; 300; 400; 500]
// ERROR!
// Expected an error to occur, because there are no prime numbers,
// And so we cannot find the maximum of no numbers.

// See the appendix of the pdf manual to see why the modified Question 3 is related to Original Question 3.

/////////////////////////////////////////////////////////////////////////////////////
// Project Euler Problem 10

// Original Question: Find the sum of all prime numbers below 2 million (2,000,000)

// Modified Question: Given a number N, where N < 200,000  , 
//                    find the sum of all prime numbers between 2 and N

// Hint: Use the "IsPrime" function before.

// Assumption: Assume N < 200,000
let TotalSumOfPrimeLessThan N =
    [2 .. N]
    //|>...................

    failwith "NOT YET IMPLEMENTED!"


let primeSum1 = TotalSumOfPrimeLessThan 10
// 2 + 3 + 5 + 7 = 17

let primeSum2 = TotalSumOfPrimeLessThan 20
// 2 + 3 + 5 + 7 + 11 + 13 + 17 + 19 = 77

let primeSum4 = TotalSumOfPrimeLessThan 225286
// 2 + 3 + 5 + 7 + ........... = 2,147,431,330

let primeSumError = TotalSumOfPrimeLessThan 225287
// ERROR: integer overflow!

// We will revisit Problem 10 later.
  
/////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////
// 3.3 List.map

let Square x = x * x
let result9 = List.map Square [1 .. 10]

// Alternatively, we can use the "fun" keyword to define the "Square" function
let result10 = List.map (fun x -> x * x) [1 .. 100]

////////////////////////////////////////
// List.map and |>

let SumOfSquares xList =
    xList
    |> List.map (fun x -> x * x)
    |> List.sum
    
let result11 = SumOfSquares [1 .. 10]
printfn "Sum of squares from 1 to 10 is: %i" result11

/////////////////////////////////////////////////////////////////////////////
// Exercise: 
let originalPrice1 = 1.35
let originalPrice2 = 3.99

let newPrice1 = originalPrice1 |> System.Math.Floor
let newPrice2 = originalPrice2 |> System.Math.Floor

// Temporary ignore decimal numbers like 1.50, 2.50.
let newPrice3 = originalPrice1 |> System.Math.Round
let newPrice4 = originalPrice2 |> System.Math.Round

// Round down the prices to nearest integer.
let TotalPriceAfterRoundDown priceList =


    failwith "NOT YET IMPLEMENTED!"

    
// Round the prices to closest integer (ignore 1.50, 2.50, etc.)
let TotalPriceAfterRound priceList =


    failwith "NOT YET IMPLEMENTED!"

/////////////////////

let originalBasket = [1.99; 4.39; 5.00; 2.10; 8.05]

let totalPrice1 = TotalPriceAfterRoundDown originalBasket
// Expected Result: 20.00

let totalPrice2 = TotalPriceAfterRound originalBasket
// Expected Result: 21.00

/////////////////////////////////////////////////////////////////////////////
// Simple application:

// https://www.miniwebtool.com/sample-variance-calculator/
// Or you can use the excel function of VAR.s

let SampleVariance xList =
    let N = 
        xList
        |> List.length
        |> double         // The "double" function 

    let average = 
        xList
        |> List.average

    // return this:
    xList
    |> List.map (fun x -> (x - average) ** 2.0)
    |> List.sum
    |> fun final -> final / (N - 1.0)       // cannot divide by (N - 1), because decimal.

/////
    
let result12 = SampleVariance [1.0 .. 7.0]

/////////////////////////////////////////////////////////////////////////////////////
// Exercise:

// Fill in the code below, that will help you solve Problem6 in Project Euler (see the URL)

// You can create an account, and submit your answers here for personal achievement/accomplishment.
// https://projecteuler.net/problem=6

let ProjectEulerProblem6 xList =
    // if xList = [a;b;c], calculate a^2 + b^2 + c^2
    let sumOfSquares = 
        ......

    // if xList = [a;b;c], calculate a + b + c
    let sum =
        ......

    // return
    (sum * sum) - sumOfSquares

    
///////// Test:
let result13 = ProjectEulerProblem6 [1 .. 100]

// Expeected answer: 25164150

///////////////////////////////////////////////////////////////////////////////////////////
// Example: Project Euler Question 10 (Revisited)

// Remark: This tutorial has already helped you implement the "IsPrime" function
// 
// You can just use it. No need to re-implement it.
let IsPrime x =
    let squareRoot = x |> double |> sqrt |> int 
    if x = 1 then false
    else if x = 2 then true
    else if x % 2 = 0 then false
    else 
        [3 .. 2 .. squareRoot]
        |> List.forall (fun i -> x%i <> 0)
// Remark: No need to understand the code above. Just use it like below.

printfn "Is 5 a prime? %b" (IsPrime 5)
printfn "Is 9 a prime? %b" (IsPrime 9)

//////////////////////////////////////

// Example: Project Euler Question 10 (Revisited)

// Given a number N, find the sum of all prime numbers between 2 and N

let TotalSumOfPrimeLessThan N =
    [2 .. N]
    |> List.filter (IsPrime)
    |> List.sum

let primeSum4 = TotalSumOfPrimeLessThan 225286
// 2 + 3 + 5 + 7 + ........... = 2,147,431,330

let primeSumError = TotalSumOfPrimeLessThan 225287
// ERROR: integer overflow!
////////////////////////////////////////////////

    
open System.Numerics

let Version2_TotalSumOfPrimeLessThan N =
    [2 .. N]
    |> List.filter (IsPrime)
    |> List.map (BigInteger)
    |> List.sum

// Remark: The code below can take 10 seconds, as this is not the most optimal algorithm.
let result17 = Version2_TotalSumOfPrimeLessThan 2000000
// Result: 142913828922
