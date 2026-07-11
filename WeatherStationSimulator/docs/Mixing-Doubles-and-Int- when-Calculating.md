# Mixing Doubles and Ints when Calculating

We're going to see what happens when we mix `int` and `double` values in a calculation.

We'll explore:

- What happens when an `int` and a `double` are used in the same mathematical expression.
- Why C# automatically converts the `int` to a `double` before performing the calculation.
- What happens when we try to store the result inside an `int`.
- What happens when we store the result inside a `double`.
- Why some assignments work automatically (**implicit conversion**) while others require an explicit cast (**explicit conversion**).

## Key Idea

When an `int` and a `double` are used in the same expression, C# automatically converts the `int` into a `double`.

For example:

```csharp
int number1 = 10;
double number2 = 2.5;

double result = number1 + number2;
```

Internally, C# treats it like this:

```text
10      → 10.0
2.5     → 2.5

10.0 + 2.5 = 12.5
```

The result is a `double`.

---

## Storing the Result

### ✅ Storing in a `double`

```csharp
double result = number1 + number2;
```

Works because the result is already a `double`.

### ❌ Storing in an `int`

```csharp
int result = number1 + number2;
```

This causes a compile-time error because C# refuses to automatically throw away the decimal part.

If you really want an `int`, you must explicitly convert it:

```csharp
int result = (int)(number1 + number2);
```

The decimal part is discarded.

Example:

```text
12.5 → 12
```

---

## Rule to Remember

- If an expression contains a `double`, the entire calculation becomes a `double`.
- `int` → `double` happens automatically (**implicit conversion**).
- `double` → `int` requires an explicit cast because data could be lost.