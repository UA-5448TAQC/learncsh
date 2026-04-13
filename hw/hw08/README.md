
# 📘 C# Homework: Exception Handling & Working with Files and Directories

## 🎯 Topics Covered

* Exception Handling in C#
* Working with Files (`StreamReader`, `StreamWriter`, `File`)
* Working with Directories
* Collections (`Dictionary`)

---

## 🧩 Tasks

### 🔹 1. Division with Exception Handling

Create a method `Div()` that performs division of two `int` numbers.

#### Requirements:

* Read two integers in `Main()`
* Call the `Div()` method
* Handle possible exceptions:

  * Division by zero
  * Invalid input format

---

### 🔹 2. Throwing Custom Exception

Create a method that divides two `double` numbers.

#### Requirements:

* Explicitly throw an exception when:

  * Division by zero occurs
* Handle the exception in `Main()`

---

### 🔹 3. Validate Input Range

Create a method:

```csharp
int ReadNumber(int start, int end)
```

#### Requirements:

* Read a number from console
* Return the number if it is within range `[start...end]`
* Throw exceptions if:

  * Input is not a number
  * Number is out of range

#### Task:

* In `Main()` read 10 numbers:

```
a1, a2, ..., a10 such that:
1 < a1 < a2 < ... < a10 < 100
```

* Use `ReadNumber()` for validation

---

### 🔹 4. File Read & Write

Read data from `data.txt` and write it into `rez.txt`.

#### 4.1 Using `StreamReader` and `StreamWriter`

* Read line-by-line
* Write to another file
* Handle exceptions

#### 4.2 Using `File.WriteAllText`

* Read all content at once
* Write into another file
* Handle exceptions

---

### 🔹 5. Directory Information

Write information about all files and directories from disk **D:\** into file `DirectoryC.txt`.

#### Include:

* Name
* Type (file/directory)
* Size (for files)

#### Requirements:

* Use `Directory` and `File` classes
* Handle exceptions (e.g., access denied)

---

### 🔹 6. Read Only `.txt` Files

#### Requirements:

* From disk **D:\**, select only `.txt` files
* Print their content into console
* Handle exceptions

---

### 🔹 7. PhoneBook with Dictionary

Create a `Dictionary<string, string>` called `PhoneBook`

---

#### 7.1 Read & Write

* Read **9 pairs** (Name → PhoneNumber) from file `phones.txt`
* Save only phone numbers into file `Phones.txt`

---

#### 7.2 Search

* Ask user to input a name
* Print corresponding phone number

---

#### 7.3 Format Update

* Change phone numbers format:

```
80######### → +380#########
```

* Save updated data into file `New.txt`

---

## ⚠️ General Requirements

* Use proper **exception handling (`try-catch-finally`)**
* Use **custom exceptions** where appropriate
* Follow **clean code practices**
* Add **comments** to explain logic
* Ensure program does not crash on invalid input

