## `foreach` loop

- Repeats a block of code for each element in an `Array` (a list of things)
- Very readable
- The variable defines in the loop header (`name` in the following example) always points at the current element

```cs
// Loop over all entries of an array
string[] names = ["Alex", "Julez", "Leo"];
foreach (string name in names)
{
  console.log(name);
  // Output:
  // Alex
  // Julez
  // Leo
}
```

## `for` loop

- Allows to define any variable, but is usually being used with an `i` integer variable representing the index (counting iterations)
- Repeats a block of code as long as a condition (usually `i < length`) is true
- Is commonly used when you want to loop over an `Array`, but `foreach` isn't enough because you also want to keep track of the index

```cs
// Loop a set amount of times
int length = 3;
for (int i = 0; i < length; i++)
{
  console.log(i);
  // Output:
  // 0
  // 1
  // 2
}

// Loop over all entries of an array
string[] names = ["Alex", "Julez", "Leo"];
for (int i = 0; i < names.Length; i++)
{
  console.log("[" + i + "] " + names[i]);
  // Output:
  // [0] Alex
  // [1] Julez
  // [2] lLeo
}
```

## `while` loop

- Repeats a block of code as long as a condition is true (it's basically a simpler version `for` loop)
- Useful when you don't know exactly how often the code block shall be repeated

```cs
bool keepGoing = true;
string amountOfIterations = 0;
while (keepGoing) {
  // Keep count of iterations
  amountOfIterations++;
  // After the third iteration we'll stop
  if (amountOfIterations < 3) {
    console.log("Keep going!")
  } else {
    console.log("Stop!")
    keepGoing = false;
  }
  // Output:
  // Keep going!
  // Keep going!
  // Stop!
}

// However, the same can be achieved using `break` with less code
string amountOfIterations = 0;
while (true) {
  // Keep count of iterations
  amountOfIterations++;
  // After the third iteration we'll stop
  if (amountOfIterations < 3) {
    console.log("Keep going!")
  } else {
    console.log("Stop!")
    break;
  }
  // Output:
  // Keep going!
  // Keep going!
  // Stop!
}
```

## `continue` und `break`

- In each loop, you can use `continue` to end the current iteration and start the next one.
- In each loop, you can use `break` to immediately exit the loop.

```cs
// Stop after 'Julez'
string[] names = ["Alex", "Julez", "Leo"];
foreach (string name in names)
{
  console.log(name);
  if (name == "Julez") break;
  // Output:
  // Alex
  // Julez
}

// Skip 'Julez'
foreach (string name in names)
{
  if (name == "Julez") continue;
  console.log(name);
  // Output:
  // Alex
  // Leo
}
```
