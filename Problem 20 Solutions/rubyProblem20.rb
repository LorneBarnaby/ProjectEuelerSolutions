class FactoralNumber
  attr_reader :number
  @myDigitSum_   = 0

  def initialize(args)
    @myNum_             = args[:number]
    @myCalculatedValue_ = getCalcVal @myNum_
    @myDigitSum_        = getSumOfdigs @myCalculatedValue_.to_s
  end #end initialize

  def getCalcVal(n)
    tot = 1
    for i in 1..n
      tot = tot * i
    end #end for i in 1..n
    return tot
  end #end getCalcVal

  def getSumOfdigs(n)
    sum = 0
    for i in 0..(n.size)
      sum = sum + n[i].to_i
    end #end for i in 0..(n.size)

    return sum
  end #end getSumOfdigs

  def digitSum()
    @myDigitSum_
  end #end digitSum

end #end FactoralNumber

puts FactoralNumber.new(
  :number => 100
).digitSum
