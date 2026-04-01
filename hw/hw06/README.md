# Homework 6 – Interfaces and Collections

## Homework 6.1 – Interface `IFlyable`

### Task

1. Develop an interface **`IFlyable`** with method:

```csharp
void Fly();
````

The method should output information about a bird or a plane.

2. Create two classes that implement this interface:

* **Bird**

  * fields:

    * `name`
    * `canFly`

* **Plane**

  * fields:

    * `mark`
    * `highFly`

3. Create a **List of `IFlyable` objects**.

4. Add several **Birds** and **Planes** to the list.

5. Iterate through the list and call the **`Fly()`** method for every object.

---

### Example Usage

```csharp
List<IFlyable> items = new List<IFlyable>()
{
    new Bird("Eagle", true),
    new Bird("Penguin", false),
    new Plane("Boeing", 10000)
};

foreach (var item in items)
{
    item.Fly();
}
```

---

# Homework 6.2 – Collections

### Task

1. Declare a collection **`myColl`** of **10 integers** (read values from the console).

2. Perform the following operations:

#### 1️⃣ Find positions of element `-10`

Print all positions (indexes) where the value **`-10`** occurs.

#### 2️⃣ Remove elements greater than `20`

Remove all elements that are **greater than 20**.

Print the updated collection.

#### 3️⃣ Insert new elements

Insert the following values into specific positions:

| Value | Position |
| ----- | -------- |
| 1     | 2        |
| -3    | 8        |
| -4    | 5        |

Print the updated collection.

#### 4️⃣ Sort the collection

Sort the collection in ascending order and print the result.

---

### Requirements

Use one of the following collections:

* `List<int>`
* `ArrayList`

---

### Example Usage

```csharp
List<int> myColl = new List<int>();

for (int i = 0; i < 10; i++)
{
    myColl.Add(int.Parse(Console.ReadLine()));
}
```

---

# Homework 6.3 – Interface `IDeveloper`

### Task

1. Create interface **`IDeveloper`** with:

* Property:

  * `Tool`

* Methods:

```csharp
void Create();
void Destroy();
```

---

2. Create two classes that implement this interface:

### Programmer

Field:

* `language`

### Builder

Field:

* `tool`

---

3. Create an **array or list of `IDeveloper`**.

Add several:

* Programmers
* Builders

Call **`Create()`** and **`Destroy()`** methods for each object.

---

4. Implement **`IComparable`** for these classes and **sort the collection of developers**.

---

### Example Usage

```csharp
List<IDeveloper> developers = new List<IDeveloper>()
{
    new Programmer("C#"),
    new Programmer("Python"),
    new Builder("Hammer"),
    new Builder("Drill")
};

foreach (var dev in developers)
{
    dev.Create();
    dev.Destroy();
}
```

---

# Homework 6.4 – Dictionary

### Task

1. Create a **Console Application**.

2. In the `Main()` method declare a dictionary:

```csharp
Dictionary<uint, string> persons = new Dictionary<uint, string>();
```

3. Add **7 pairs** `(ID, Name)` from the console.

Example input:

```
1 John
2 Anna
3 Michael
```

4. Ask the user to **enter an ID**.

5. Find and print the **corresponding Name** from the dictionary.

6. If the ID **does not exist**, print a message to the user.

---

### Example Usage

```csharp
Console.Write("Enter ID: ");
uint id = uint.Parse(Console.ReadLine());

if (persons.ContainsKey(id))
{
    Console.WriteLine(persons[id]);
}
else
{
    Console.WriteLine("ID not found.");
}
```
