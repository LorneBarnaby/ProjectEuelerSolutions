limit = 2000000
primes = []
total = 0

def prime(n):
    if(n <= 1):
        return False
    elif (n <= 3):
        return True
    elif(n % 3 == 0) or (n % 2 == 0):
        return False
    it = 5
    while it * it <= n:
        if (n % it == 0) or (n % (it + 2) == 0):
            return False
        it += 6
    return True

for i in range(1, limit):
    if(prime(i)):
        primes.append(i)

for j in primes:
    total += j

print(total)
