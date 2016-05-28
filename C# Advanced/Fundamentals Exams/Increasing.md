Absolute difference between two integer numbers A and B is the difference of the larger between A and B minus the smaller between A and B. Examples:
•	Absolute difference between 5 and 1 is 4 (5 – 1 = 4).
•	Absolute difference between -2 and -2 is 0 (-2 – -2 = 0).
•	Absolute difference between 1 and 4 is 3 (4 – 1 = 3).
If you are given a list of numbers, the sequence of absolute differences of the given list is constructed by taking all absolute differences between all two consecutive numbers. Examples:
•	In the list “0 1 2 3 5” it’s sequence of absolute differences is “1 1 1 2”
	011121325
•	In the list “-2 -2 -1 0 2 4 1 5” it’s sequence of absolute differences is “0 1 1 2 2 3 4”
	-20-21-11022243145
•	In the list “3 2 4 8” it’s sequence of absolute differences is “1 2 4”
	3122448
Increasing sequence is a zero-based sequence of numbers (called seq) in which the absolute difference between every 2 consecutive numbers is 0 or 1 and for every i (from 1 to N-1) seq[i-1]<=seq[i]. Examples:
•	“1 1 2 2” is increasing sequence because 1<=1<=2<=2 and
	1011202
•	“0 1 1 2 2 3 4” is increasing sequence because 0<=1<=1<=2<=2<=3<=4 and
	0110112021314
•	“1 2 1” is NOT increasing sequence because 2>1.
	11211
•	“1 2 4” is NOT increasing sequence because the absolute difference between numbers 2 and 4 is 2:
	11224

