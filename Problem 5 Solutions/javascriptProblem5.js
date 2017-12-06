var j = 20;
while(true){
  // console.log(j);
  if(divisileBy1to(20, j)){
    break;
  }
  else {
    j+=20;
  }
}
console.log(j);

function divisileBy1to(rangeOf, n){
  for(let i = 1; i < rangeOf; i++){
    if(n % i == 0){
      continue;
    }else{
      return false;
    }
  }
  return true;
}
