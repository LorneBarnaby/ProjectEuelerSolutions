numbers = []
class FibonacciNumber
  attr_reader :number

  def initialize(args)
    @myNum_             = args[:number]
    @myCalculatedValue_ = fib @myNum_
    @myDigitCount_      = digCount @myCalculatedValue_
  end #end initialize

  def answer()
    @myCalculatedValue_
  end #end ans

  def fib(n) #the problem  with this is that it takes ages
    if n <= 1
      return n
    else
      fib(n - 1) + fib(n - 2)
    end #end n <= 1
  end #end fib

  def digCount(n)
    n.to_s.length
  end #end digCount

  def digits()
    @myDigitCount_
  end # end digits

end #end FibonacciNumber

class QuicklyCalculatedFibonacciNumber
  attr_reader :number, :minus1, :minus2

  def initialize(args)
    @myNum_             = args[:number]
    @myNum1_            = args[:minus1]
    @myNum2_            = args[:minus2]
    @myCalculatedValue_ = fib @myNum_
    @myDigitCount_      = digCount @myCalculatedValue_
  end #end initialize

  def answer()
    @myCalculatedValue_
  end #end ans

  def fib(n)
    @myNum1_ + @myNum2_
  end #end fib

  def digCount(n)
    n.to_s.length
  end #end digCount

  def digits()
    @myDigitCount_
  end # end digits
end #end quicklyCalculatedFibonacciNumber

ans     = 0
counter = 1

while true
  if counter < 6
    x = FibonacciNumber.new(
      :number => counter
    )
    numbers << x.answer
  else
    x = QuicklyCalculatedFibonacciNumber.new(
      :number => counter,
      :minus1 => numbers[counter - 2],
      :minus2 => numbers[counter - 3]
    )
    numbers << x.answer
  end
  # puts "#{x.answer} : #{x.digits}"
  if x.digits >= 1000
    ans = x.answer
    break
  end #end if >= 3
  counter = counter + 1
end #end while True
puts counter
