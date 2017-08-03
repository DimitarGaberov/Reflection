# Reflection

⦁	Stealer 
Add the Hacker class from the box below to your project. 
Hacker.cs
public class Hacker
{
    public string username = "securityGod82";
    private string password = "mySuperSecretPassw0rd";

    public string Password
    {
        get => this.password;
        set => this.password = value;
    }

    private int Id { get; set; }

    public double BankAccountBalance { get; private set; }

    public void DownloadAllBankAccountsInTheWorld()
    {        
    }
}

There is one really nasty hacker but not so wise though. He is trying to steal a big amount of money and transfer it to his own account. The police is after him but they need a proffessional… Correct - this is you! 
	You have the information that this hacker is keeping some of his info in private fields. Create a new class named Spy and add inside a method called - StealFieldInfo which receives:
⦁	stirng - name of the class to investigate 
⦁	array of string - names of the filds to investigate 
After finding the fields you must print on the console:
“Class under investigation: {nameOfTheClass}”
On the next lines print info about each field in the current format:
“{filedName} = {fieldValue}”
Use StringBuilder to concatenate the answer. Don’t change anything in "Hacker" class! 

⦁	High Quality Mistakes
You are already expert of High Quality Code, so you know what kind of access modifiers must be set to members of class. You should have noticed our hacker is not familiar with these concepts. 
Create a method inside your Spy class called - AnalyzeAcessModifiers(stirng className). Check all fields and methods access modifiers. Print on console all mistakes in format:
⦁	Fields
⦁	{fieldName} must be private!
⦁	Getters
⦁	{methodName} have to be public!
⦁	Setters 
⦁	{methodName} have to be private!
Use StringBuilder to concatenate the answer. Don’t change anything in "Hacker" class! 

⦁	Mission Private Impossible
It’s time to see what this hacker you are dealing with aims to do.  Create a method inside your Spy class called - RevealPrivateMethods(stirng className). Print all private methods in the following format:
All Private Methods of Class: {className}
Base Class: {baseClassName}
On the next lines print found method’s names each on new line
Use StringBuilder to concatenate the answer. Don’t change anything in "Hacker" class! 

⦁	Collector
Using reflection to get all "Hacker" methods. Then prepare algorithm that will recognize, which methods are getters and setters. 
Print to console each getter on new line in format:
{name} will return {Return Type}
Then print all setters in format: 
{name} will set field of {Parameter Type}
Use StringBuilder to concatenate the answer. Don’t change anything in "Hacker" class! 
 
⦁	Harvesting Fields
You are given a RichSoilLand class with lots of fields (look at the provided skeleton). Like a good farmer as what you are, you must harvest them. Harvesting means that you must print each field in a certain format (see output).
Input
You will receive a maximum of 100 lines with one of the following commands:
⦁	private - print all private fields
⦁	protected - print all protected fields
⦁	public - print all public fields
⦁	all - print ALL declared fields
⦁	HARVEST - end the input
Output
For each command, you must print the fields that have the given access modifier as described in the input section. The format in which the fields should be printed is:
"<access modifier> <field type> <field name>"

⦁	Black Box Integer
You are helping a buddy of yours who is still in the OOP Basics course - his name is Peshoslav (not to be mistaken with real people or trainers). He is rather slow and made a class with all private members. Your tasks are to instantiate an object from his class (always with start value 0) and then invoke the different methods it has. Your restriction is to not change anything in the class itself (consider it a black box). You can look at his class but don't touch anything! The class itself is called BlackBoxInt it is a wrapper for the int primitive. 
The methods this class has are:
⦁	Add(int)
⦁	Subtract(int)
⦁	Multiply(int)
⦁	Divide(int)
⦁	LeftShift(int)
⦁	RightShift(int)
Input
The input will consist of lines in the form:
<method name>_<value>
For instance: Add_115
Input will always be valid and in the format described, so there is no need to check it explicitly. You stop receiving input when you encounter the command "END".
Output
Each command (except the END one) should print the current value of innerValue of the BlackBoxInt object you instantiated. Don't cheat by overriding ToString() in the class - you must get the value from the private field.

⦁	BarracksWars - A New Factory
You are given a small console based project called Barracks (the code for it is included in the provided skeleton).
The general functionalities of the project are adding new units to its repository and printing a report with statistics about the units currently in the repository. First let's go over the original task before the project was created:
Input
The input consists of commands each on a separate line. Commands that execute the functionality are:
⦁	add <Archer/Swordsman/Pikeman/{…}> - adds a unit to the repository.
⦁	report - prints a lexicological ordered statistic about the units in the repository.
⦁	fight - ends the input.
Output
Each command except fight should print output on the console.
⦁	add should print: "<Archer/Swordsman/Pikeman/{…}> added!"
⦁	report should print all the info in the repository in the format: "<UnitType> -> <UnitQuantity>", sorted by UnitType
Constraints
⦁	Input will consist of no more than 1000 lines
⦁	report command will never be given before any valid add command was provided

Your task
1) You have to study the code of the project and figure out how it works. However, there are parts of it that are not implemented (left with TODOs). You must implement the functionality of the CreateUnit method in the UnitFactory class so that it creates a unit based on the unit type received as parameter. Implement it in such a way that whenever you add a new unit it will be creatable without the need to change anything in the UnitFactory class (psst - use reflection). You can use the approach called Simple Factory.
2) Add two new unit classes (there will be tests that require them) - Horseman with 50 health and 10 attack and Gunner with 20 health and 20 attack.
If you complete everything correctly for this problem, you should add code only inside the Factories and Units folders.
