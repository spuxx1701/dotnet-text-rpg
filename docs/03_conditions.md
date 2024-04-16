## `if`, `else if` and `else`

- Allows to execute pieces of code based on conditions (type `bool`)

```csharp
int number = 10;

// Execute a block of code if the condition is true
if (number > 5)
{
  Interface.WriteLine("The number is greater than 5.");
}

// Also execute a different block of code if the condition is false
if (number > 5)
{
    Interface.WriteLine("The number is greater than 5.");
}
else
{
    Interface.WriteLine("The number is 5 or less.");
}

// Check multiple conditions
if (number > 5)
{
    Interface.WriteLine("The number is greater than 5.");
}
else if (number < 5)
{
    Interface.WriteLine("The number is less than 5.");
}
else
{
    Interface.WriteLine("The number is 5.");
}
```
