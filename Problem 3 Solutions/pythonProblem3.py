import math
number = 600851475143
divisors = []
primeDivisors = []
i = 1

def isPrime(n):
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


while i < math.floor(number / 2): #seriously recommend changing this (may take upwars of an hour (having seen the answer you should make that 2 into 87000000))
    if(number % i == 0):          #you are asking a lot of the cpu and should really follow my advice
        divisors.append(i)        #what is currently happening is you ae finding every single divisor of the number, however some of these have huge values and it will take time for the loop to reach them
        print(i)
    # print(i)
    i += 2

for num in divisors:
    if isPrime(num) == True:
        primeDivisors.append(num)

for what in primeDivisors:
    print(what)
print("the largest of these values is the answer")
