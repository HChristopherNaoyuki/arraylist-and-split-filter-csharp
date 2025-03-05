# **ArrayList and Split Filter in C#**  

## **Project Description**  
This C# console application takes user input as a question, filters out predefined ignored words, and checks for a match in stored questions. The program uses **ArrayList** for data storage and **exception handling** to ensure robust execution.  

---

## **Features**  
- Accepts user input as a question.  
- Splits the input into individual words.  
- Filters out specific ignored words (e.g., "the", "about", "will").  
- Checks if the remaining words match stored questions.  
- Displays relevant matches or informs the user if no match is found.  
- Includes **exception handling** for empty input and unexpected errors.  

---

## **Technologies Used**  
- **C#**
- **.NET Framework / .NET Core**
- **ArrayList for dynamic data storage**
- **Exception Handling for robustness**

---

## **Installation & Setup**  

### **1. Prerequisites**  
Make sure you have the following installed:  
- **Visual Studio** (or any C# IDE)  
- **.NET SDK**  

### **2. Clone the Repository**  
```sh
git clone https://github.com/HChristopherNaoyuki/arraylist-and-split-filter-csharp.git
```
```sh
cd arraylist-and-split-filter-csharp
```

### **3. Open in Visual Studio**  
- Open **Visual Studio** and load the project.  
- Ensure your **target framework** is set correctly.  

### **4. Run the Program**  
- Press **`Ctrl + F5`** (without debugging) or **`F5`** (with debugging).  
- Enter a question when prompted.  

---

## **Usage**  

### **Example 1: Matching Word Found**  
#### **Input:**  
Enter your question:
```sh
how to protect password
```
#### **Output:**  

Match found: password have to be protected

### **Example 2: All Words Ignored**  
#### **Input:**  
Enter your question:
```sh
the will about
```
#### **Output:**  
```
No matching words found.
```

### **Example 3: No Relevant Match**  
#### **Input:**  

Enter your question:
```sh
secure database
```
#### **Output:**  
```
No relevant matches found in stored questions.
```

### **Example 4: Empty Input**  
#### **Input:**  

Enter your question:
```sh
[Press Enter]
```
#### **Output:**  
```
Error: Input cannot be empty. Please enter a valid question.
```

---

## **Error Handling**  
| **Scenario**       | **Exception Type** | **Error Message** |
|--------------------|------------------|------------------|
| Empty Input       | `ArgumentException` | "Input cannot be empty. Please enter a valid question." |
| Unexpected Errors | `Exception` | "An unexpected error occurred: [error details]" |

---
