import math
hastoequal = 1000
answer = 90

def addABCValues(aVal, bVal, cVal):
    if(((aVal + bVal + cVal) == 1000)):
        return True
    else:
        return False

def point0(valueToCheck):
    workable = str(valueToCheck)
    if((workable[len(workable) - 1] == "0") and (workable[len(workable) - 2] == ".")):
        return True
    else:
        return False

def FindC(aVal, bVal):
    cSQR = (aVal**2) + (bVal**2)
    cACT = math.sqrt(cSQR)
    if(point0(cACT)):
        cACT = int(cACT)
        return cACT
    else:
        return cACT

for a in range(1, hastoequal):
    for b in range(1, hastoequal):
        c = FindC(a,b)
        if(c != 0):
            if(isinstance(c, int)): #check if number is an int
                if(addABCValues(a,b,c)):
                    answer = a * b * c
                    break
            else:
                continue
print(answer)
