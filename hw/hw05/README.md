# CLASSES (C#)

## 📚 AGENDA

### 1️⃣ Data Type Class Hierarchy
- All types in C# derive from the base class `Object`.
- Value types (int, double, struct, etc.)
- Reference types (class, string, array, etc.)

---

### 2️⃣ Base Class `Object`

All classes implicitly inherit from `Object`.

Important methods:
- `ToString()`
- `Equals()`
- `GetHashCode()`
- `GetType()`

Example:

```csharp
object obj = new object();
Console.WriteLine(obj.ToString());
````

---

### 3️⃣ Class Definition

```csharp
class ClassName
{
    // Fields
    // Properties
    // Constructors
    // Methods
    // Operators
}
```

---

#### 🔹 Fields & Properties

```csharp
class Example
{
    private string name;   // field

    public string Name     // property
    {
        get { return name; }
        set { name = value; }
    }
}
```

---

#### 🔹 Constructors

```csharp
class Example
{
    public Example() { }

    public Example(string name)
    {
        this.name = name;
    }
}
```

---

#### 🔹 Methods

```csharp
public void Print()
{
    Console.WriteLine("Hello");
}
```

---

#### 🔹 Operators

```csharp
public static bool operator ==(Example a, Example b)
{
    return a.name == b.name;
}
```

---

# 📝 HOMEWORK

---

# 🚗 Task 1: Class Car

## 1️⃣ Define class `Car`

Fields:

* `string name`
* `string color`
* `double price`
* `const string CompanyName`

### Requirements:

* Create:

  * Default constructor
  * Constructor with parameters
* Create property for `color`
* Define methods:

  * `Input()` – enter data from console
  * `Print()` – output data to console
  * `ChangePrice(double x)` – change price by x%

---

## 2️⃣ Enter data about 3 cars

Create 3 objects of `Car` and input data.

---

## 3️⃣ Decrease price by 10%

Call:

```csharp
car.ChangePrice(-10);
```

Display updated information.

---

## 4️⃣ Repaint Car

* Enter a new color.
* If car color is `"white"` → repaint to entered color.

---

## 5️⃣ Overload operator `==`

Cars are equal if:

* `name` is equal
* `price` is equal

Example:

```csharp
public static bool operator ==(Car a, Car b)
{
    return a.name == b.name && a.price == b.price;
}
```

(Also override `Equals()` and `GetHashCode()`.)

---

## 6️⃣ Override `ToString()`

Return formatted string with car data:

```csharp
public override string ToString()
{
    return $"Name: {name}, Color: {color}, Price: {price}";
}
```

---

# 👤 Task 2: Class Person

## Define class `Person`

### Fields (private):

* `string name`
* `DateTime birthYear`

---

### Properties:

* `Name` (get)
* `BirthYear` (get)

---

### Constructors:

* Default constructor
* Constructor with 2 parameters

---

### Methods:

* `Age()` → calculate age
* `Input()` → read from console
* `ChangeName()` → change name
* `ToString()`
* `Output()` → call `ToString()`
* Overload operator `==` (equal by name)

---

# 🔹 Main() Requirements

1️⃣ Create **6 objects** of `Person`.

2️⃣ Enter data for all persons.

3️⃣ Output:

* Name
* Age

4️⃣ If Age < 16 → change name to `"Very Young"`.

5️⃣ Output updated information.

6️⃣ Find persons with same names (using `==`) and display them.

---

## ✅ Additional Requirements

* Follow C# naming conventions.
* Use encapsulation.
* Override:

  * `ToString()`
  * `Equals()`
  * `GetHashCode()`
* Handle possible null comparisons in operator overload.

---

🚀 Good luck!

