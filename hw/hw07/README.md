# [Task 1: Person, Staff, Teacher, Developer](#task-1-person-staff-teacher-developer)

# [Task 2: Shapes](#task-2-shapes)


# Task 1: Person, Staff, Teacher, Developer

## 📌 Task Description

### 1. Base Classes

#### 👤 `Person`
- Create a class `Person` (use code from presentation)
- Include basic fields (e.g., `Name`)
- Add virtual method `Print()`

#### 👥 `Staff`
- Create a class `Staff` derived from `Person`

---

### 2. Derived Classes

#### 👨‍🏫 `Teacher`
- Inherit from `Staff`
- Add field `subject`
- Override method `Print()`

#### 👨‍💻 `Developer`
- Inherit from `Staff`
- Add field `level` (e.g., Junior, Middle, Senior)
- Override method `Print()`

---

### 3. Main Logic

#### ▶️ Create List
- In `Main`, create a `List<Person>`
- Add objects of different types:
  - `Person`
  - `Teacher`
  - `Developer`

#### 🖨️ Print All
- Iterate through the list
- Call `Print()` method for each object

---

### 4. Search by Name

- Ask user to enter a name
- If a person with this name exists in the list:
  - Print full information about this person

---

### 5. Sorting & File Output

- Sort the list by `Name`
- Save the result to a file (e.g., `output.txt`)

---

### 6 ⭐ Advanced Task

#### 👨‍💼 Employees List
- Create a new list `List<Staff>` or `List<Person>`
- Move only workers (`Teacher` + `Developer`) into this list

#### 💰 Sort by Salary
- Add field `salary` to `Staff`
- Sort employees by salary
- Output sorted result

---

## ✅ Example Usage

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("John"),
            new Teacher("Alice", "Math"),
            new Developer("Bob", "Senior")
        };

        // Print all
        foreach (var p in people)
        {
            p.Print();
        }

        // Search
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        var found = people.FirstOrDefault(p => p.Name == name);
        if (found != null)
        {
            found.Print();
        }

        // Sort and save to file
        var sorted = people.OrderBy(p => p.Name).ToList();
        File.WriteAllLines("output.txt", sorted.Select(p => p.Name));

        // Advanced: employees only
        var employees = people.OfType<Staff>().ToList();
        var sortedBySalary = employees.OrderBy(s => s.Salary);

        foreach (var emp in sortedBySalary)
        {
            emp.Print();
        }
    }
}
```

---

## 🎯 Requirements Checklist

* [ ] Classes `Person` and `Staff` created
* [ ] Classes `Teacher` and `Developer` implemented
* [ ] Fields `subject` and `level` added
* [ ] Method `Print()` overridden
* [ ] List of `Person` used in `Main`
* [ ] Search by name implemented
* [ ] Sorting by name completed
* [ ] Output written to file
* [ ] ⭐ Employees list created and sorted by salary

---

## 💡 Notes

* Use polymorphism when calling `Print()`
* Use `OfType<Staff>()` to filter employees
* Consider overriding `ToString()` for cleaner file output




# Task 2: Shapes

## 📌 Task Description

### 1. Abstract Class `Shape`

Create an abstract class `Shape` with:
- A field `name`
- A property `Name`
- A constructor with one parameter (`string name`)
- Abstract methods:
  - `Area()` – returns the area of the shape
  - `Perimeter()` – returns the perimeter of the shape

---

### 2. Derived Classes

#### 🔵 `Circle`
Create a class `Circle` derived from `Shape` with:
- A field `radius`
- A property `Radius`
- A constructor with two parameters:
  - `string name`
  - `double radius`
- Override methods:
  - `Area()`
  - `Perimeter()`

#### 🟥 `Square`
Create a class `Square` derived from `Shape` with:
- A field `side`
- A property `Side`
- A constructor with two parameters:
  - `string name`
  - `double side`
- Override methods:
  - `Area()`
  - `Perimeter()`

---

### 3. Class `Operator`

Create a class `Operator` with the following static methods:

#### 📊 `GetInfo`
- Takes a `List<Shape>` as a parameter
- Prints:
  - Shape name
  - Area
  - Perimeter

#### 📏 `GetLargestPerimeter`
- Takes a `List<Shape>` as a parameter
- Finds the shape with the largest perimeter
- Prints its name

#### 🔽 `Sort`
- Takes a `List<Shape>` as a parameter
- Sorts shapes by **area**
- Prints the `Name` of each shape in sorted order
- Use `IComparable` interface for sorting

---

## ✅ Example Usage

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle("Circle1", 3),
            new Square("Square1", 4),
            new Circle("Circle2", 5),
            new Square("Square2", 2)
        };

        Operator.GetInfo(shapes);
        Operator.GetLargestPerimeter(shapes);
        Operator.Sort(shapes);
    }
}
```

---

## 🎯 Requirements Checklist

* [ ] Abstract class `Shape` implemented
* [ ] Classes `Circle` and `Square` inherit from `Shape`
* [ ] Methods `Area()` and `Perimeter()` overridden
* [ ] Class `Operator` created with all required methods
* [ ] Sorting implemented using `IComparable`
* [ ] Program demonstrates functionality in `Main`

---

## 💡 Notes

* Use `Math.PI` for circle calculations
* Ensure encapsulation via properties
* Implement `IComparable<Shape>` in `Shape` or derived classes for sorting by area

