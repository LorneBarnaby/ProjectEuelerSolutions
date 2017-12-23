limit = 2000000 #value that primes have to be under
primes = []
total = 0
require 'prime'

for i in 1..limit #finds all primes below 'limit' and adds them to the 'primes' array
  if i.prime?
    primes << i
  end
end

primes.each { |vFromArray| total = total + vFromArray} #adds every value in the array to 'total'
puts total
