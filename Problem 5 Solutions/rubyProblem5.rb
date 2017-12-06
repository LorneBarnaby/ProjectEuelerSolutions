def divisileBy1to(rangeOf, n)
  for i in 1..rangeOf
    if n % i == 0
      next
    else
      return false
    end
  end
end

 j = 20
 while(true)
   if divisileBy1to 20, j
     break
   else
     j = j + 20
   end
 end
 puts j
