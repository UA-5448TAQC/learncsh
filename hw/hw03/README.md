
# Console Application – Practice Tasks (C#)

## 🎯 Objective

Create a **Console Application** project in **Visual Studio**.

In the `Main()` method, write code to solve the following tasks.

---

## 📌 Tasks

### 1️⃣ Float Numbers in Range

- Read **3 float numbers** from the console.
- Check if **all of them belong to the range [-5; 5]**.
- Output the result to the console.

---

### 2️⃣ Max and Min of Integers

- Read **3 integer numbers**.
- Output:
  - Maximum value
  - Minimum value

---

### 3️⃣ HTTP Error Enum

- Read an integer representing an HTTP error code (e.g., 400, 401, 402, ...).
- Declare an `enum HTTPError`.
- Output the name of the corresponding error.

Example:

```csharp
enum HTTPError
{
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404
}
````

---

### 4️⃣ Struct Dog

* Declare a `struct Dog` with fields:

  * `string name`
  * `string mark`
  * `int age`
* Override the `ToString()` method.
* Create an object `myDog`.
* Read values from the console.
* Output dog information using `ToString()`.

---

### 5️⃣ Valid Date Check

* Enter **two integers**.
* Check whether they can represent a valid **day and month**.
* Output the result.

(You do not need to check leap years.)

---

### 6️⃣ Sum of First Two Digits After Decimal Point

* Enter a `double` number.
* Extract the **first two digits after the decimal point**.
* Output the sum of these two digits.

Example:

```
Input: 3.456
Output: 4 + 5 = 9
```

---

### 7️⃣ Greeting by Hour

* Enter an integer `h` representing the hour of the day (0–23).
* Output greeting depending on time:

| Time Range | Greeting        |
| ---------- | --------------- |
| 6–11       | Good morning!   |
| 12–17      | Good afternoon! |
| 18–22      | Good evening!   |
| 23–5       | Good night!     |

---

### 8️⃣ Test Case Status Enum

Declare:

```csharp
enum TestCaseStatus 
{
    Pass,
    Fail,
    Blocked,
    WP,
    Unexecuted
}
```

* Assign status `Pass` to variable `test1Status`.
* Output the result to the console.

---

### 9️⃣ Struct RGB

* Declare a `struct RGB` with fields:

  * `byte red`
  * `byte green`
  * `byte blue`

* Create two variables:

  * White color (`255, 255, 255`)
  * Black color (`0, 0, 0`)

* Output their values to the console.

---

## ✅ Requirements

* All tasks must be implemented inside `Main()` (you may use additional methods if needed).
* Use proper data types.
* Validate user input where appropriate.
* Format console output clearly.
* Follow C# naming conventions.

---

## 📦 Submission

Push your solution to GitHub in a separate branch and create a Pull Request.

Project structure example:

```
hw/hw03/<your_nickname>/ConsoleAppTasks
```

---

Good luck! 🚀

