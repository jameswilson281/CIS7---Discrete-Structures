# CIS 7 - Discrete Structures - Assignment 3
These are the answers for this assignment

## 35

  	repeat
    i = 1
    read a value for x
    if ((x < 5.0) and (2x < 10.7)) or (sqrt(5x) > 5.1) then
    write the value of x
    end if
    increase i by 1
    until i > 5

The input values for x are 1.0, 5.1, 2.4, 7.2, and 5.3. What are the output values?

=========


First Option: X = 1.0

if T ∧ T ∧ F

Returns 1.0

=========

x = 5.1

if F ∧ T ∧ F

Won't Print

=========

x = 2.4

if T ∧ T ∧ F

Returns 2.4

=========

x = 7.2

if F ∧ F ∧ T
 
Returns 7.2

=========

x = 5.3

if F ∧ T v T

Returns 5.3