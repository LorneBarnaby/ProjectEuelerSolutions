var total = num = 0;

for(let i = 0; num < 4000000; i++){
  num = findFib(i);
  if(num % 2 == 0){
    total += num;
  }
}
console.log(total);

function findFib(n){
  if (n <= 1){
     return n;
   }
   else{
     return findFib(n-1) + findFib(n-2);
   }
}
