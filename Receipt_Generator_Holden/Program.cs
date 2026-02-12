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
		Console.WriteLine("Our system is down, you'll have to pay cash today.");
		Console.WriteLine("Let's tally up your items, one kind of item at a time");
		Console.WriteLine("Please tell me what item you've got, how many of them" +
        "\n and the price on the shelf for that item ");

        //item
        Console.WriteLine("Let's get the price on that there in your hand");
        itemName = Console.ReadLine();

        //quantity
        Console.WriteLine("How many have you got?");
        quantityString = Console.ReadLine();
        //use string itemQuant to fill decimal quantityInt
        if (decimal.TryParse(quantityString, out decimal quantityInt))
            {
                //nothing to see here..... maybe
                //return itemPrice;
                //actually the number conversion here

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
        //do the logic for turning into cultured dollar amounts
        

        
        /*add quantityString and string priceString to functionality in receipt */
        Console.WriteLine($"Your total for {itemName} is ");
        
	}
}