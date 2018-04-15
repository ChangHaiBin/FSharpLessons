

////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////
// 1.1 Set up

let x = 1
let y = x + 5

// Put your mouse on top of "x" and "y" to see the type of "x" and "y"



////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////
// 1.2 Types 

let name = "John"
let age = 21
let height = 170.5

/////////////////////////////////////////////////////////////////////
// Printing and output

printfn "My name is: %s" name
printfn "Name: %s. Age: %i. Height: %f." name age height
printfn "His height is: %.2f" height

/////////////////////////////////////////////////////////////////////
// This is included for students who are familiar with C++/Java/Python's syntax
let inline (==) x y = (x = y)

/////////////////////////////////////////////////////////////////////
// Equality testing.
let x = 15 + 5

if x == 20 then
    printfn "Yes, the value is Twenty"
else 
    printfn "No, the value is not Twenty"

//////////////////////////////

let userName = "Jack"

if userName == "John" then
    printfn "Welcome back, John"
else 
    printfn "Access denied."
    
/////////////////////////////////////////////////////////////////////
// Immutability

// Warning: Do not use mutable value if possible! 
// 
// Using mutable value is a bad idea!
let mutable x = 100
printfn "Original value is: %i" x
// Output: "Original value is: 100"

x <- 200
printfn "Updated value is: %i" x
// Output: "Original value is: 200"

////////////////////////////
// #########################
// This contains ERROR!  //#
let x = 100              //#
x <- 300                 //#
//##########################

///////////////////////////////////////////////////////////////////
// Basic operator (+)

let x = 40 + 55

let y = 1.414 + 3.1415926

let sentenceStart = "My school is "
let schoolName = "National University of Singapore"
let combinedSentence = sentenceStart + schoolName

/////###################################################
// Cannot combine two different types using "+"      //#
// The following codes contain ERROR!                //#
                                                     //#
let x = 15 + 4.11                                    //#
let y = "My age is: " + 21                           //#
/////###################################################


//////////////////////////////////////////////////////////////////
// Multiply (*)
let x = 3 * 4
let y = 1.5 * 1.7

/////#####################################################
// Cannot multiply integer with decimal using "*"      //#
// The following codes contain ERROR!                  //#
                                                       //#
let x = 3 * 1.5                                        //#
/////#####################################################

//////////////////////////////////////////////////////////////////
// SquareRoot "sqrt" and math exponent (**) only accepts decimals, 

let x = sqrt 9.0
let y = 2.0 ** 5.0 
// 2^5 = 2*2*2*2*2 = 32

//##############################################################
// ERROR: sqrt and (power ** ) only accepts decimals/float   //#
let x = 2 ** 5                                               //#
let y = sqrt 9                                               //#
// ERROR!                                                    //#
//##############################################################

/////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////
// 1.3 Defining functions

// This function accepts integer only.

let f x = x + 5

let result1 = f 10
let result2 = f 20

// #########################################################
// ERROR: The function "f" cannot accept decimal input.  //#
let result = f (3.0)                                     //#
// #########################################################

// Practice: 

// Practice Q1:
// Write a function "f" so that:
// f 1 = 5
// f 2 = 6
// f 3 = 7
let f x = ......

// Check your answer here:
let result1 = f 1
let result2 = f 2
let result3 = f 3


// Practice Q2:
// Write a function "f" so that:
// f 3 = 6
// f 4 = 8
// f 5 = 10
let f x = ......

// Check your answer here:
let result1 = f 3
let result2 = f 4
let result3 = f 5

// Practice Q3:
// Write a function "f" so that:
// f 1 = 1
// f 2 = 4
// f 3 = 9
// f 4 = 16
// f 5 = 25
let f x = ......

// Check your answer here:
let result1 = f 1
let result2 = f 2
let result3 = f 3
let result4 = f 4
let result5 = f 5

/////////////////////////////////////////////////////////////////

////////////////////////////////
// Similarly, this function accepts decimals only.
let g price = price * 0.8

let result1 = g 399.99
let result2 = g result1 
////////////////////////////

// #########################################################
// ERROR: The function "f" cannot accept integer input.  //#
let result = g 100                                       //#
// #########################################################

// In order to use the function on 100, you need to change it to "100.0"
let result = f 100.0

// Or you need to convert it using "double" or "float"
let a = float 100
let result = f a

/////////////////////////////////////////////////////////////
// Practice: 

// Practice Q1:
// Write a function "f" so that:
// f 2.0 = 3.6
// f 2.5 = 4.1
// f 3.0 = 4.6
let f x = ......

// Check your answer here:
let result1 = f 2.0
let result2 = f 2.5
let result3 = f 3.0

// Practice Q2:
// Write a function "f" so that:
// f 1.0 = 1.0
// f 2.0 = 0.5
// f 3.0 = 0.333333333
// f 4.0 = 0.25
// f 5.0 = 0.2
let f x = ......

// Check your answer here:
let result1 = f 1.0
let result2 = f 2.0
let result3 = f 3.0
let result4 = f 4.0
let result5 = f 5.0

/////////////////////////////

// Define a function for string.
let AddGreeting name =
    "Hello " + name

let greeting1 = AddGreeting "John"
let greeting2 = AddGreeting "Mary"

// ####################################################################
// ERROR: AddGreeting function does not accept integer/double/etc.  //#
let greeting3 = AddGreeting 123                                     //#
// ####################################################################





///////////////////////////
// Exercise: Write a function that calculates the area of a circle of radius r
let CircleArea r =

     // ... IMPLEMENT HERE ...
     failwith "ERROR. Function not yet implemented."
     // Delete the line above and replace with the correct implementation
     // Hint: Use    "System.Math.PI"

// // Test your function here.
let circleResult1 = CircleArea 1.0
printfn "The first circle has area of: %f" circleResult1

let circleResult2 = CircleArea 2.0
printfn "The first circle has area of: %f" circleResult2

//////////////////////////////////////////////////////////////
// Function with 2 variables.
let g x y = 3 * x + y

let result3 = g 3 1
let result4 = g 10 2

// ############################################################
// ERROR: The function "g" cannot accept decimal input.     //#
let result1 = g (3.0) 10                                    //#
let result2 = g 10 (2.0)                                    //#
// ERROR!                                                   //#
// ############################################################

//////////////////////////////////////////////////////////////

let f interestRate principal  = 
    principal * (1.0 + interestRate)

let balance1 = f 0.05 100000.00 

let balance2 = f 0.03 5000.00 

// ################################################
// ERROR: "f" does not accept integer values.   //#
let balanceError = f 0.04 100000                //#
// ################################################

///////////////////////////////////////////////////////////
// Function with 3 variables.
let h x y z = 3 * x + 4 * y + 5 * z

// 3*3 + 4*4 + 5*5 = 50
let result5 = h 3 4 5

// 3*1 + 4*1 + 5*1 = 12
let result6 = h 1 1 1

///////////////////////////////////////////////////////////
// Warning: F# may sometimes automatically assume the inputs are integer (if insufficient information)
let f x y z = x + y + z

let result = f 5 6 7

// ###########################################################################
// ERROR: The F# compiler assumes the "f" function accepts integer inputs. //#
f 1.0 2.0 3.0                                                              //#
// ###########################################################################

// Custom function to work for double
let f (x:double) y z = x + y + z

let result = f 2.1 3.0 4.2



/////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////
// 1.4 Scoping

let AddFriend person1 =
    let endOfSentence = " and Mary are friends"
    person1 + endOfSentence

let combinedSentence1 = AddFriend "Jack"
    
// ########################################################################
// ERROR: "endOfSentence" is not accessible outside of "AddFriend"      //#
printfn "The content of endOfSentence is: %s" endOfSentence             //#
// ########################################################################

/////////////////////////////////////////////
let DrinkFunction person =
    let endOfSentence = " likes to drink coffee."
    person + endOfSentence

let EatFunction person =
    let endOfSentence = " prefers eating chocolate."
    person + endOfSentence

printfn "%s" (DrinkFunction "Jack")
printfn "%s" (EatFunction "Jill")

/////////////////////////

let a = 5

let f1 b = 
    a + b

let f2 b = 
    a + a + b
    
printfn "%i" (f1 10)
printfn "%i" (f2 10)