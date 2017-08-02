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
 
