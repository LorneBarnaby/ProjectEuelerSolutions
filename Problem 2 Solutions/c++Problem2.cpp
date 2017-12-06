#include <iostream>

using namespace std;

int fib(int n)
{
  int a = 0, b = 1, c, i;
  if(n == 0)
    return a;
  for (i = 2; i <= n; i++)
  {
     c = a + b;
     a = b;
     b = c;
  }
  return b;
}


int main(){
  int num = 0;
  int total = 0;
  for(int i = 1; num < 4000000; i++){
    num = fib(i);
    if(num % 2 == 0){
      total += num;
    }
  }
  cout << total << endl;
  return 0;
}//
