# CIS 7 - Discrete Structures - Assignment 3

## 35

Consider the following

  	repeat
    i = 1
    read a value for x
    if ((x < 5.0) and (2x < 10.7)) or (sqrt(5x) > 5.1) then
    write the value of x
    end if
    increase i by 1
    until i > 5

The input values for x are 1.0, 5.1, 2.4, 7.2, and 5.3. What are the output values?

	x = 1.0
	if T ∧ T ∧ F
	Returns 1.0

	x = 5.1
	if F ∧ T ∧ F
	Won't Print

	x = 2.4
	if T ∧ T ∧ F
	Returns 2.4

	x = 7.2
	if F ∧ F ∧ T
	Returns 7.2

	x = 5.3
	if F ∧ T v T
	Returns 5.3

## 37

Rewrite the following statement form with a simplified conditional expression, where the function odd(n) returns true if n is odd.

	if not((Value1 < Value2) or odd(Number))
	or (not(Value1 < Value2) and odd(Number)) then
	statement1
	else
	statement2
	end if

A = Value < Value 2

B = odd(Number)

(A v B)' = P

(A)' ^ B = Q


| A | B| P | Q | 
| - |:-:| -----:| ---:|
| T | T | F | F |
| T | F | F	| F |
| F | T | F	| T |
| F | F | T | F |

	if (A v B)'
	or (A' ^ B) -->
	statement1
	else
	statement2
	end if

and then

	if Q
	or P -->
	statement1
	else
	statement2
	end if

## 38

You want your program to execute statement 1 when A is false, B is false, and C is true, and to execute statement 2 otherwise. You wrote

	if not(A and B) and C then
	statement 1
	else
	statement 2
	end if

Does this do what you want?

((F ^ F)' and T) == T

Will run properly

## 61

A = if Percival is a truth teller

B = if Llewellyn is a truth teller

| A | B | A' v B' |  
| - |:-:| -:|
| T | T | F |
| T | F | T |
| F | T | T |
| F | F | T |

Percival is not a liar. 

## 62

	Traveling on, you meet Merlin and Meredith. Merlin says, “If I am a truth teller, then Meredith is a truth teller.” Is Merlin a liar or a truth teller? What about Meredith? Explain your answer.

A = Merlin is a truth teller

B = Meredith is a truth teller

P = A -> B [if I'm a truth teller, Meredith is too.]

Q = P < - > A [because logic]

| A | B | P | Q |  
| - |:-:|:-:| :-| 
| T | T | F | T | 
| T | F | T | F | 
| F | T | T | F | 
| F | F | T | F | 

	Merlin and Meredith are truth tellers

## 63

	Next, you meet Rothwold and Grymlin. Rothwold says, “Either I am a liar or Grymlin is a truth teller.” Is Rothwold a liar or a truth teller? What about Grymlin? Explain your answer

A = Rothwold is a truth teller

B = Grymlin is a truth teller

P = A' v B [I am a liar or Grymlin is a truth teller]

Q = P <-> A [logic]
	
| A | B | P | Q |  
| - |:-:|:-:| :-| 
| T | T | T | T | 
| T | F | F | F | 
| F | T | T | F | 
| F | F | T | F | 

	Same as 62, both are truth tellers.   

## 64

	Finally, you meet Gwendolyn and Merrilaine. Gwendolin says, “I am a liar but Merrilaine is not.” Is Gwendolyn a liar or a truth teller? What about Merrilaine?

A = Gwendolyn is a truth teller

B = Merrilaine is a truth-teller

P = A' ^ B [I am a liar but Merrilaine is a truth teller]

Q = P <-> A [more logic]

| A | B | P | Q |  
| - |:-:|:-:| :-| 
| T | T | F | F | 
| T | F | F | F | 
| F | T | T | F | 
| F | F | F | T | 

![relevant](https://media.giphy.com/media/GFZn0SpfS5Nrq/giphy.gif)

	They're both liars, thus the gif. 