needsToEqual = 1000
def checkIf(aVal, bVal, cVal, value = 1000)
  if (aVal + bVal + cVal) == 1000
    return true
  else
    return false
  end
end

def point0(check)
  work = check.to_s
  lastC = work[work.length - 1]
  secondlast = work[work.length - 2]
  if((lastC == "0") && (secondlast == "."))
    true
  else
    false
  end
end

def findC(aVal, bVal)
  cs = (aVal**2) + (bVal**2)
  cVal = Math.sqrt(cs)
  if(point0 cVal)
      cVal = cVal.to_i
    return cVal
  else
    return cVal
  end
end

for a in 1..needsToEqual
  for b in 1..needsToEqual
    c = findC a, b
      if c != 0
        if(c.is_a? Integer)
          if(checkIf a, b, c, needsToEqual)
            answer = a * b * c
          end
        else
          next
        end
      end
  end
end
puts answer
