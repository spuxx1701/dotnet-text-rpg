# Classes

# Methods (or Functions)

Methoden/Funktionen...

- ...haben einen eigenen `scope` (haben ihren eigenen Kontext)
- ...sind Code-Blöcke, die aufgerufen werden können
- ...können Parameter entgegennehmen (definiert runden Klammern `()`)
- ...können einen Wert zurückgeben (müssen dann einen Typ haben)
- ...können auch nichts zurückgeben (haben dann den Typ `void`)

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

Variablen...

- ...haben einen Typ (z.B. `string`)
- ...halten Werte (z.B. `"Hello World!"`)
- ...können verändert werden

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
