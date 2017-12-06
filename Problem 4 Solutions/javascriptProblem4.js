var palindromes = [];

start(3); //starts the program

function start(digits){
  for(let i = 0; getNumberOfDidgits(i) <= digits; i++){
    for(let j = 0; getNumberOfDidgits(j) <= digits; j++){
      let product = i * j;
      let productAsString = String(product);
      if(checkIfPalin(productAsString) === true){
        palindromes.push(product);
      }
    }
  }
  console.log(getLargest(palindromes));
}

function getNumberOfDidgits(number){
  var numberAsString = String(number);
  var leng = numberAsString.length;
  return leng;
}


function checkIfPalin(tocheckAsNum){
  let tocheckAsString = String(tocheckAsNum);
  let tocompare = reverseNumber(tocheckAsString);
  switch (tocheckAsString) {
    case tocompare:
        return true;
        break;
    default:
      return false;
      break

  }

}

function reverseNumber(toReverse){
  let toReverseAsString = String(toReverse);
  let proc = toReverseAsString.split("");
  proc = proc.reverse();
  let finalString = proc.join("");
  return finalString;
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
