# C# Statements

## 1️⃣ Statements in C#

### 🔹 1. Selection Statements

#### ▪ If / else / else if
Used to execute code depending on conditions.

```csharp
if (condition)
{
    // code
}
else if (anotherCondition)
{
    // code
}
else
{
    // code
}
````

---

#### ▪ Switch / case / default

Used for selecting one of many code blocks.

```csharp
switch (variable)
{
    case value1:
        // code
        break;
    case value2:
        // code
        break;
    default:
        // code
        break;
}
```

---

### 🔹 2. Iteration Statements (Loops)

#### ▪ while

Executes while condition is true.

```csharp
while (condition)
{
    // code
}
```

---

#### ▪ do-while

Executes at least once.

```csharp
do
{
    // code
}
while (condition);
```

---

#### ▪ for

Used when number of iterations is known.

```csharp
for (int i = 0; i < 10; i++)
{
    // code
}
```

---

#### ▪ foreach

Used to iterate through collections or arrays.

```csharp
foreach (var item in collection)
{
    // code
}
```

---

#### ▪ Array

```csharp
int[] numbers = new int[5];
string[] names = { "John", "Anna", "Mark" };
```

---

### 🔹 3. Scope

Scope defines where a variable is accessible.

```csharp
if (true)
{
    int x = 10; // x exists only inside this block
}
// x is not accessible here
```

---

# 📝 HOMEWORK

## 🎯 Task 1

Read a string `str`.

Calculate the number of characters:

* 'a'
* 'o'
* 'i'
* 'e'

(Uppercase letters should also be counted.)

---

## 🎯 Task 2

Ask the user to enter a month number (1–12).

Output the number of days in this month.

---

## 🎯 Task 3

Enter 10 integer numbers.

* If the first 5 numbers are **all positive**, calculate their **sum**.
* Otherwise, calculate the **product of the last 5 numbers**.

---

## 🎯 Task 4

Enter two integers `a` and `b`.

Calculate how many integers in range `[a..b]` are divisible by 3 without remainder.

Example:

```
1..10 → 3  (3, 6, 9)
```

---

## 🎯 Task 5

Enter a string `text`.

Print every second character of the string.

Example:

```
Hello → el
```

---

## 🎯 Task 6

Enter the name of the drink:

* coffee
* tea
* juice
* water

Print:

* Drink name
* Price

(Use `switch` statement.)

---

## 🎯 Task 7

Enter a sequence of positive integers (stop when first negative number is entered).

Calculate the arithmetic average of all positive numbers.

Example:

```
1, 6, 3, 9, -8
(1 + 6 + 3 + 9) / 4
```

---

## 🎯 Task 8

Check if the entered year is a leap year.

(A leap year is divisible by 4, but not by 100, except if divisible by 400.)

---

## 🎯 Task 9

Find the sum of digits of the entered integer number.

Example:

```
365 → 3 + 6 + 5 = 14
```

---

## 🎯 Task 10

Check if the entered integer number contains only odd digits.

Example:

```
1357 → true
246 → false
```

---

## ✅ Requirements

* Use selection and iteration statements.
* Use arrays where appropriate.
* Validate user input.
* Follow C# naming conventions.
* Keep the code clean and readable.

---

🚀 Good luck!

