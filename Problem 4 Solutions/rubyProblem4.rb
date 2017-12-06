palindromes = []
digits = 3
limit = (10**digits) -1

def isPalin(tocheck)
  stocheck = tocheck.to_s
  comp = stocheck.reverse
  if stocheck == comp
    return true
  end
  return false
end

for i in 1..limit
  for j in 1..limit
    product = i * j
    if isPalin product
      palindromes << product
    end
  end
end
puts palindromes[palindromes.rindex(palindromes.max)]
