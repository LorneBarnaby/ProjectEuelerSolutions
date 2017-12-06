def divisileBy1to(rangeOf, n):
    for i in range(1, rangeOf):
        if n % i == 0:
            continue
        else:
            return False
    return True

j = 20
while(True):
    if(divisileBy1to(20, j)):
        break
    else:
        j += 20
print(j)
