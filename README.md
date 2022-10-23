# String-N-iterations-String
https://www.codewars.com/kata/5ae43ed6252e666a6b0000a4/train/csharp

**Welcome**

This kata is in spired by [This Kata](https://www.codewars.com/kata/odd-even-string-sort)

We have a string **s**

We have a number **n**

Here is a function that takes your string, concatenates the even-indexed chars to 
the front, odd-indexed chars to the back.

**Examples**
```
s = "Wow Example!"
result = "WwEapeo xml!"
s = "I'm JomoPipi"
result = "ImJm ii' ooPp"
```

**The Task:**
return the result of the string after applying the function to it n times.

example where s = "qwertyuio" and n = 2:
```
after 1 iteration  s = "qetuowryi"
after 2 iterations s = "qtorieuwy"
return "qtorieuwy"
```

**Note**

there's a lot of tests, big strings, and n is greater than a billion

so be ready to optimize.

after doing this: do it's [best friend](https://www.codewars.com/kumite/5b238f2325c2bb040b000086?sel=5b238f2325c2bb040b000086)!