sumto = 100
totsumto = totsumtosqr = 0
sqrOfAllFrom1Tosumto = 0

for i in 1..sumto
  totsumto = totsumto + i
end
totsumtosqr = totsumto**2
for j in 1..sumto
  sqrOfAllFrom1Tosumto = sqrOfAllFrom1Tosumto + j**2
end
puts totsumtosqr - sqrOfAllFrom1Tosumto
