using System;
using System.Globalization;
					
public class Program
{

    //static global variables go under program and outside on top of Main method

    //strings
    static string itemName = "default";
    static string quantityString = "default_quantity";
    static string priceString = "0.67";


    //numbers ready for new values
    static int quantityInt = 0;
    static decimal priceNum = 0;


   

	public static void Main()
    //start main at the brackets below, wanted to possibly use seperate methods

    // the following method name is not in play: static cashierCounter(); 
	{
         //define our USA money logic
        var usCulture = CultureInfo.GetCultureInfo("en-US");
		
        Console.WriteLine("Our system is down, you'll have to pay cash today.");
		Console.WriteLine("Let's tally up your items, one kind of item at a time");
		Console.WriteLine("Please tell me what item you've got, how many of them" +
        "\n and the price on the shelf for that item ");

        //item
        Console.WriteLine("whats the brand name of that thing in your hand?");
        itemName = Console.ReadLine();

        //quantity
        Console.WriteLine("How many have you got?");
        quantityString = Console.ReadLine();
        //use string itemQuantity to fill decimal quantityInt
        if (int.TryParse(quantityString, out int quantityInt))
            {
                //nothing to see here..... maybe
                //return itemPrice;
                
            //force dollar currency formatting and add specifically 2 decimal places
            //does line 50 about quantityInt.ToString need to be there???
                string quantityString = quantityInt.ToString("C2", usCulture);
            }
            else
            {
            Console.WriteLine("Say again?");   
            }


        //price 
        Console.WriteLine("Whats the price tag on that?");
        priceString = Console.ReadLine();
        //use string priceString to get string to convert into decimal priceNum
        if (decimal.TryParse(priceString, out decimal priceNum))
            {
                //nothing to see here..... maybe
                //return itemPrice;
                string priceString = priceNum.ToString("C2", usCulture);
            }
            else
            {
            Console.WriteLine("Say again?");
            }
                                            //not important anymore i think
                                            /* = Console.ReadLine();
                                                itemQuant = Console.ReadLine();
                                                static string itemPrice = "0.67";
                                    
                                            */

        //ring up the receipt                                                
        Console.WriteLine("Great! Let me work up your total...");
        Console.WriteLine("Thank you for the cash here's your receipt");
        Console.WriteLine("----Receipt----");

       // int GrandTotal = tryParse * quant;
        /*add quantityString and string priceString to functionality in receipt */
        Console.WriteLine($"Item: {itemName}");
        Console.WriteLine($"Amount: {quantityInt}"); //wanted to stick this in the parenthesis of ToString()
        Console.WriteLine($"{priceNum.ToString("C2", usCulture)} per item");
        Console.WriteLine($"Grand Total: {(priceNum * quantityInt).ToString("C2", usCulture)}");
        Console.WriteLine("Thank you");


                    /* maybe do this calculation a little earlier */
        
	}
}