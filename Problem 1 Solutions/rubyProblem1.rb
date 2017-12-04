muls = Array.new #creates muls as a new array
tot = 0
below = 1000

for i in 1..below -1 #completes loop 10 times equiv to for(let i = 1; i <= 10; i++)
  if i % 3 == 0 || i % 5 == 0 #if number is divisible by 5 or 3
    muls << i #inserts the value i into the arrange
  end
end
muls.each { |vFromArray| puts vFromArray} #reads out each value in the array called "muls"
muls.each { |vFromArray| tot = tot + vFromArray} #reads out each value in the array called "muls"
puts tot
