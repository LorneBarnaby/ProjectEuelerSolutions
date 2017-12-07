require 'prime'
primes = []
nthPrime = 10001
i = 1

while(true)
  if(i.prime?)
    primes << i
  end
  if primes.length == nthPrime
    break
  else 
    i = i + 1
  end
end
puts primes[nthPrime - 1]
