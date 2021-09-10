using System;
public class CarClass
{
    public string myField = string.Empty;
    public CarClass()
    {
    }

    public int MyAutoImplementedProperty{get; set;}
    private string cname, mname,etype,ftype,color;
	private int mil, fuelcons, gscore;
	private double price;
	private string Company
    {
        get { return cname; }
    	set { cname= value; }
    }
	private string Model
    {
         get { return mname; }
    	set { mname= value; }
    }
    private int MileageProperty
    {
       get { return mil; }
    	set { mil= value; }
    }
	    
	private string Enginetype
    {
        get { return etype; }
    	set { etype= value; }
    }
    
	private string FuelType
    {
        get { return ftype; }
    	set { ftype= value; }
    }
    
	private int FuelConsumption
    {
        get { return fuelcons; }
    	set { fuelcons= value; }
    }
    
	private string Color
    {
       get { return color; }
    	set { color= value; }
    }
    
   
	private double Price
    {
        get { return price; }
    	set { price= value; }
    }
    
	private string SafetyProperty
    {
        get; set;
    }
	private int GreenScore
    {
        get { return gscore; }
    	set { gscore= value; }
    }
	
	
    
    
    public static void Main(string[] args){
     	CarClass car = new CarClass();
        car.Company="Mercedes-Benz";
		car.Model="S-Class";
		car.MileageProperty=13;
		car.Enginetype="2.9 l 6-cylinder diesel";
		car.Color=" Onyx Black";
		car.FuelType="Diesel";
		car.GreenScore=68;
		car.Price=2.17;
		car.FuelConsumption=16;
		Console.WriteLine("Company\t: "+car.Company+"\n"+ "Model\t: "+car.Model+"\n"+ "Mileage\t: "
						  +car.MileageProperty+"km/hr"+"\nEngine Type\t: "
						  +car.Enginetype +"\n"+ "Color \t: "
						  +car.Color+"\nFuel Type\t: "
						  +car.FuelType+"\nGreen Score\t: "
						  +car.GreenScore+"\nPrice\t: "
						  +car.Price+"\nFuel Consumption: "
						  +car.FuelConsumption);
		
		

         
    }
}