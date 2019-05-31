using System;

namespace HW5_30
{
    /***Tonight's homework is more practice with classes and inheritance.
            1. Create a new Console App project ***
            2. Create a new class file by adding it to your project name (it's the same folder where Program.cs is in) ***
            3. Your new class file will house your parent class and any subclasses that you create ***
            4. Create a class called Fruit ***
            5. Give the class two properties and one method ***
            6. Then create a new class and name it any fruit you want ***
            7. Make sure this class inherits from the Fruit class ***
            8. Give this new class a new property (this will work with the other properties from the Fruit class) ***
            9. For this new class create one method ***
            10. After you instantiate the subclass (your new class, not the Fruit class), call one of the methods that you created in the Fruit class, then call the method you created in your subclass***/

    internal class Program
    {
        private static void Main(string[] args)
        {
            Berry fruit1 = new Berry("Banana", "sweet", 4);
            fruit1.Bunch("berry");
            fruit1.eatFruit(35);
        }
    }
}