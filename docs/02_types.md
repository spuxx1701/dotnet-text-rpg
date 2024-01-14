## Classes

## Methods (or Functions)

- have their own `scope` (have their own context)
- are code blocks that can be called
- can accept parameters (defined within round brackets `()`)
- can return a value (must have a type in that case)
- can also return nothing at all (then they have the type `void`)

```cs
int Add(int a, int b) {
  int c = a + b;
  return c;
}

void DoSomethingCompletelyDifferent() {
  // some code
  return;
}
```

## Variables

- have a type (e.g. `string`)
- can be assigned values and will store (e.g. `"Hello World!"`)
- can be mutated (changed)
- will live as long as their context lives (e.g. the method they were defined in)

```cs
// Basic types
string s = "Hello World!";
int i = 3;
float f = 1.1;
bool b = false;

// Arrays contain multiple values
string[] stringArray = ["foo", "bar"]
int[] integerArray = [1,2,3,4,5];
```
