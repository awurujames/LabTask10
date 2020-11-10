namespace QuestionTwo
{
    public class Bus: Vehicle, ITaxable{

    protected int numberOfSeats;

    public Bus(int numberOfSeats, int regNumber, decimal value):
    base(regNumber, 80, value){
    this.numberOfSeats = numberOfSeats;
  }

    public decimal TaxValue()
    {
        return value;
    }

    public int NumberOfSeats{
    get{
    return numberOfSeats;
    }
  } 

}
}