require 'prime'

number = 1000000
primesUnder1million = Array.new()

def isCircularPrime(number)
  original = Array.new()
  possibilities = Array.new()
  #first off all we must find every combination of the number
  if number.prime?
    numberAsString = number.to_s
    for i in 0..numberAsString.size
      original << numberAsString[i]
    end #end for loop

    final = ""
    for i in 0..original.size
      for j in original
        final = final + j.to_s
      end
    end

  else
    false
  end #end if staement

end #end isCircularPrime


for i in 1..number
  if i.prime?
    primesUnder1million << i
  end #end if statement
end #end for loop
