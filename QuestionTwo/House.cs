namespace QuestionTwo
{
    public class House: FixedProperty, ITaxable{

    protected double area;

    public House(string location, bool inCity, double area, 
    decimal value):
    base(location, inCity, value){
    this.area = area;
  }

    public decimal TaxValue()
    {
        return value;
    }

    public double Area{
    get{
    return area;
    }
  } 
}
}