number = 600851475143     # this is the number that Problem 3 asks us to find the lares prime divisor of
divisors = Array.new      #divisors is a new array
primeDivisors = Array.new #primeDivisors is also now a new array
i = 1
require 'prime'


#
# we could right a greate big algorithm in ruby to find if a bumber is prime
# but there is actually a much more simple way to do it
#

while i < (number/2).floor  #seriously recommend changing this (may take upwars of an hour (having seen the answer you should make that 2 into 87000000))
  if number % i == 0 #further explained in the python script of this
    divisors << i
  end
  i = i + 2
end

for value in divisors #for adds every prime value in the divisors to a new array made of only prime numbers
  if value.prime?
    primeDivisors << value
  end
end


puts primeDivisors[primeDivisors.rindex(primeDivisors.max)]
