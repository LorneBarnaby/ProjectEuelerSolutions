total = num = counter = 0

def findFib(n):
    if(n <= 1):
        return n
    else:
        return findFib(n -1) + findFib(n -2)


while(num < 4000000):
    counter += 1
    num = findFib(counter)
    if(num % 2 == 0):
        total += num
print (total)
