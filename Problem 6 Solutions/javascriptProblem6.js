var sumto = 100;
var totsumto = totsumtosqr = 0;
var sqrOfAllFrom1Tosumto = 0;

for(let i = 1; i<=sumto; i++){
  totsumto+=i;
}
totsumtosqr = Math.pow(totsumto, 2);
for(let i = 1; i <= sumto; i++){
  sqrOfAllFrom1Tosumto += Math.pow(i, 2);
}
console.log(totsumtosqr - sqrOfAllFrom1Tosumto);
