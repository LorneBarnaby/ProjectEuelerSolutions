palindromes = []
digits = 3

def isPalin(toCheck):
    reversedS = str(toCheck)[::-1] # this line reverses the string. There are more readable ways to write this however this is the fastest method
    if(str(toCheck) == reversedS): # if a string is equal to itself reversed then the number is palindromic
        return True
    else:
        return False

for i in range(1, (10**digits) - 1):
    for j in range(1, (10**digits) - 1):
        product = i * j
        if(isPalin(product)):
            palindromes.append(product)
print(max(palindromes)) #prints the largest of the palindromes
