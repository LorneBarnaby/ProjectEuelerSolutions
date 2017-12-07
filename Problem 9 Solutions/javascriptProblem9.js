var needsToEqual = 1000;
answer = 0;

for(let a = 1; a <= needsToEqual; a++){
  for(let b = 1; b <= needsToEqual; b++){
    let c = findC(a,b);
    if(Number.isInteger(c)){
      if(checkIf(a,b,c,needsToEqual)){
        answer = a * b * c;
        break;
      }
    }
    else {
        continue;
      }
    }
  }
console.log(answer);

function findC(a,b){
  cSQ = Math.pow(a, 2) + Math.pow(b, 2);
  c = Math.sqrt(cSQ);
  return c;
}

function checkIf(a, b, c, value = 1000){
  if((a + b + c) == 1000){
    return true;
  }
  else{
    return false;
  }
}
