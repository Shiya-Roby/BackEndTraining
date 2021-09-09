using System;
public class CarClass
{
    public string myField = string.Empty;
    public CarClass()
    {
    }

    public int MyAutoImplementedProperty{get; set;}
    private string cname;
    private int MileageProperty
    {
        get; set;
    }
	    
	private string Enginetype
    {
        get; set;
    }
    
	private string FuelType
    {
        get; set;
    }
    
	private int FuelConsumption
    {
        get; set;
    }
    
	private string Color
    {
        get; set;
    }
    
	private string Model
    {
        get; set;
    }
    
	private string Company
    {
        get { return cname; }
    	set { cname= value; }
    }
    
	private string Price
    {
        get; set;
    }
    
	private string SafetyProperty
    {
        get; set;
    }
	private string GreenScore
    {
        get; set;
    }
	
	
    
    
    public static void Main(string[] args){
     	 CarClass car = new CarClass();
         car.Company="Mercedes-Benz";
		
		

         
    }
}