import math
checked = []
def d(x):
    sumOf = 0
    for i in range(1, math.floor(x/2) + 1):
        if(x % i == 0):
            sumOf += i
    return sumOf

def isAmicable(n1, n2):
    # print(n1, n2)
    # print(d(n1), d(n2))
    if(n1 == 1) or (n2 == 1):
        return False
    if(n1 == d(n2)):
        return True
    else:
        return False

# num = 284
# if(isAmicable(d(num), num)):
#     print(num)
tot = 0
for i in range(2, 10001):
    n = d(i)

    if(isAmicable(n, i) and (i < 10000) and (n < 10000) and (i not in checked) and (n not in checked)):
        checked.append(i)
        checked.append(n)
        print(d(i))
        tot += n + i
print(tot)
