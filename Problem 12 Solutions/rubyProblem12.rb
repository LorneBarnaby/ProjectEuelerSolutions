
limit = 500

def decide(number, lLimit)
  divs = 1
  for j in 1..(number/2)
    if number % j == 0
      divs = divs + 1
    end
  end
  if divs >= 100
    puts divs.to_s + "                        " + number.to_s
  end

  if divs > lLimit
    true
  else
    false
  end
end

def triangle(n)
  ntot = 0
  for i in 1..n
    ntot = ntot  + i
  end
  return ntot
end

# puts triangle(7)
answer = 0
num = 1
while(true)
  t = triangle num
  if decide t, limit
     answer = t
     break
  end
  num = num + 1
end
puts answer
