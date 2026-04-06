# 🧪 Assignment: Composition vs Aggregation & Unit Testing

## 🎯 Goal

* Understand the difference between **Composition** and **Aggregation**
* Apply OOP design principles in practice
* Implement geometric domain models
* Write **unit tests** to validate business logic

---

## 📚 Theory (Short Reminder)

| Concept         | Description                                                       |
| --------------- | ----------------------------------------------------------------- |
| **Composition** | Strong relationship. Child object **cannot exist without parent** |
| **Aggregation** | Weak relationship. Child object **can exist independently**       |

---

## 🧩 Task Description

### 1. Implement `Point` (Value Object)

Create a structure or class `Point`:

#### Requirements:

* Fields:

  * `x: double`
  * `y: double`
* Methods:

  * `ToString()` → returns point in format:

    ```
    (x,y)
    ```
  * `DistanceTo(Point other)` → returns distance between two points

---

### 2. Implement `Triangle` (Composition)

Create class `Triangle` using **composition**.

#### Requirements:

* Fields:

  * `vertex1: Point`
  * `vertex2: Point`
  * `vertex3: Point`

* Constructors:

  * Default
  * Parameterized (3 points)

* Methods:

  * `Distance(Point a, Point b)`
  * `Perimeter()`
  * `Area()` (use Heron's formula)
  * `Print()` → outputs triangle info

#### ❗ Composition Rule:

Triangle **owns** its points (points are not shared externally).

---

### 3. Implement `ShapeGroup` (Aggregation)

Create class `ShapeGroup` using **aggregation**.

#### Requirements:

* Field:

  * `List<Triangle> triangles`

* Methods:

  * `AddTriangle(Triangle triangle)`
  * `RemoveTriangle(Triangle triangle)`
  * `GetAll()`
  * `FindTriangleClosestToOrigin()`

#### ❗ Aggregation Rule:

Triangles can exist **independently** of `ShapeGroup`.

---

### 4. Program Entry Point

In `Main()`:

* Create **3 triangles**
* Add them to `ShapeGroup`
* Print all triangles
* Find and print:

  ```
  Triangle with vertex closest to (0,0)
  ```

---

## 🧠 Bonus (Optional)

* Validate triangle (points must not be collinear)
* Override `Equals()` and `GetHashCode()` in `Point`
* Add logging
* Make code immutable where possible

---

## 🧪 Unit Testing

Create a **separate test project**.

### 🔹 Test `Point`

Write tests for:

* `ToString()`
* `DistanceTo()`
* Edge cases:

  * Same point
  * Negative coordinates

---

### 🔹 Test `Triangle`

Write tests for:

* `Distance()`
* `Perimeter()`
* `Area()`
* Invalid triangle (collinear points)

---

### 🔹 Test `ShapeGroup`

Write tests for:

* Adding/removing triangles
* Finding triangle closest to origin
* Empty collection behavior
