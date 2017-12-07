primes = []
nthPrime = 10001
i = 1

def isPrime(n):
    if(n <= 1):
        return False
    elif (n <= 3):
        return True
    elif(n % 3 == 0) or (n % 2 == 0):
        return False
    it = 5
    while it**2 <= n:
        if (n % it == 0) or (n % (it + 2) == 0):
            return False
        it += 6
    return True

while(True):
    if(isPrime(i)):
        primes.append(i)
    if len(primes) == nthPrime:
        break
    else:
        i += 1
print(primes[nthPrime - 1])
