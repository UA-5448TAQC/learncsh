# 📚 C# Homework: Advanced Topics

## 🎯 Topics Covered

* C# Base
* Regular Expressions & LINQ
* LINQ (Language Integrated Query)
* Standard Query Operators
* IEnumerable vs IQueryable
* Delegates
* Events
* Serialization

---

## 🏠 Homework

### 🔹 Task 1: Working with Shapes, LINQ & File Operations

**Goal:** Practice LINQ, collections, and file handling.

#### 📌 Requirements:

1. Create a **Console Application** project.
2. Use classes `Shape`, `Circle`, `Square` from your previous homework.

#### ✅ Tasks:

1. Create a `List<Shape>` and fill it with **6 different objects** (`Circle` and `Square`).
2. Using **LINQ**, find shapes with **area in range [10, 100]** and write them into a file.
3. Find shapes whose **name contains letter 'a'** and write them into a file.
4. Remove from the list all shapes with **perimeter < 5**.

   * Output the resulting list to the **Console**.

---

### 🔹 Task 2: Text Processing & LINQ

**Goal:** Work with files, strings, and LINQ queries.

#### 📌 Requirements:

1. Create a **Console Application** project.
2. Prepare a `.txt` file with a large amount of text
   *(for example, use your `.cs` file from previous homework)*.

#### ✅ Tasks:

1. Read all lines from the file into an **array of strings**
   *(each element = one line)*.
2. For each line:

   * Count and output the **number of characters**.
3. Find:

   * The **longest line**
   * The **shortest line**
4. Find and output only lines that contain the word:

   ```
   var
   ```

   *(use LINQ and/or Regular Expressions)*.

---

### 🔹 Task 3: Delegates & Events

**Goal:** Understand delegates and event-driven programming.

#### 📌 Requirements:

1. Create delegate:

   ```csharp
   public delegate void MyDel(int m);
   ```

2. Create class `Student`:

   * Fields:

     * Name
     * List of marks (`List<int>`)
   * Event:

     ```csharp
     public event MyDel MarkChange;
     ```
   * Method:

     * `AddMark(int mark)` → adds mark and triggers event

3. Create class `Parent`:

   * Method:

     ```csharp
     void OnMarkChange(int mark)
     ```

     * Outputs mark to console

4. Create class `Accountancy`:

   * Method:

     ```csharp
     void PayingFellowship(int mark)
     ```

     * Prints whether student gets a scholarship

#### ✅ In `Main()`:

1. Create objects:

   * `Student`
   * `Parent`
   * `Accountancy`
2. Subscribe:

   * `Parent.OnMarkChange` → `Student.MarkChange`
   * `Accountancy.PayingFellowship` → `Student.MarkChange`
3. Call `AddMark()` several times and observe output.

---

### 🔹 Task 4: JSON Serialization

**Goal:** Learn serialization basics.

#### 📌 Requirements:

1. Take **any class** from previous tasks.
2. Implement **JSON serialization**:

   * Serialize object → JSON file
   * Deserialize JSON → object

#### ✅ Suggested tools:

* `System.Text.Json`
  **or**
* `Newtonsoft.Json`

---

## 📦 Deliverables

* ✅ Source code pushed to GitHub repository
* ✅ Each task should be:

  * Structured
  * Readable
  * Well-formatted
* ✅ Include:

  * `.cs` files
  * Example input/output files
  * JSON file (Task 4)

---

## ⭐ Bonus (Optional)

* Use **Regex** for advanced text filtering
* Compare `IEnumerable` vs `IQueryable` in comments
* Add logging or error handling
* Write clean and reusable code (SOLID principles)

