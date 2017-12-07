sumto = 100
totsumto = totsumtosqr = 0
sqrOfAllFrom1Tosumto = 0

for i in range(sumto + 1):
    totsumto += i
totsumtosqr = totsumto * totsumto
for j in range(sumto + 1):
    sqrOfAllFrom1Tosumto += j * j
print(totsumtosqr - sqrOfAllFrom1Tosumto)
