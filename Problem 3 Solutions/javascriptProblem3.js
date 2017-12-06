var number = 600851475143;
var divisors = [];
var primeDivisors = [];

for(let i = 1; i < Math.floor(number / 2); i+=2){ //gets all divisors of the number and adds them to an array (these divisors can only be odd numbers as the number itself is off but if you are using other numbers then make it i++)
  if(number % i == 0){
    divisors.push(i);
}
}

for(let i = 0; i < divisors.length; i++){ //finds all of the divisors that are prime and adds them to a second array
  if(primeC(divisors[i])){
    primeDivisors.push(divisors[i]);
  }
}

console.log(getLargest(primeDivisors)); //sends the largest prime divisor to the console

function primeC(n){
  if(n <= 1){
    return false;
  }
  else if (n <= 3){
    return true;
  }
  else if((n % 2 == 0) || (n % 3 == 0)){
    return false;
  }
  var i = 5;
  while (i * i <= n){
    if((n % i == 0) || (n % (i + 2) == 0)){
      return false;
    }
    i += 6;
  }
  return true;

}

function getLargest(array){
  let max = array[0];
  for (let i = 1; i < array.length; i++) {
    if (array[i] > max) {
      max = array[i];
    }
  }
  return max;
}
