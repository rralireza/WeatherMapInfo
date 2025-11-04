# Answers to Technical Questions

## 1. How much time did you spend on this task? If you had more time, what improvements or additions would you make?

I spent approximately **4–5 hours** on this task. Most of the time was dedicated to thinking about project structure, studying API documentation, and conducting research. For example, I initially planned to use the **One Call API**, but realized it required a paid subscription, so I switched to the **Weather API**, which works with a free token.

As mentioned, I considered the project architecture. If I had more time, I would have explored **Domain-Driven Design (DDD)**, a concept I’ve recently become familiar with. However, since I’m still in the learning phase and wanted to ensure timely delivery, I preferred to proceed with a clean, understandable, and compact architecture.

---

## 2. What is the most useful feature recently added to your favorite programming language? Please include a code snippet to demonstrate how you use it.

There are several features added in recent C# versions, such as **Collection Expressions**, where you no longer need to instantiate a list explicitly. Instead of:

var listOfNumbers = new List<int> { 1, 2, 3 };

You can now write:

var listOfNumbers = [1, 2, 3];

Also, file-scoped namespaces have significantly reduced boilerplate:

// Before
namespace Task { class Program { ... } }

// Now
namespace Task;
class Program { ... }

Additionally, the ability to run .cs files directly with dotnet run without a full project is incredibly powerful for rapid prototyping. I’m also excited about upcoming LINQ enhancements, such as left join, which will further boost productivity.

---

## 3. How do you identify and diagnose a performance issue in a production environment? Have you done this before?

Yes, I have encountered performance issues in heavy modules I’ve developed.

For example, I was implementing a loan calculation system for approximately 13,000 employees. The system first checked eligibility based on settings, then calculated the loan amount and generated installments.

I was repeatedly querying the database inside a loop using FirstOrDefault to find previous loans — resulting in an N+1 query problem and a 30-second data load time.

To resolve this, I switched to the Binary Search algorithm: I loaded the full list of employees once, kept it sorted in memory, and performed dynamic ID-based lookups.

Result: Data processing time dropped from 30 seconds to under 1 second.

---

## 4. What’s the last technical book you read or technical conference you attended? What did you learn from it?

The last technical book I'm currently reading is C# in a Nutshell.

My goal is to deepen my understanding of the language so I can write better, more creative, and more efficient code in C#.

---

## 5. What’s your opinion about this technical test?

It was a good test. I found it engaging that I had to do a lot of research.

So far, in my work environment and personal sample projects, I had always used Clean Architecture, and I had never been forced to think about a more compact architecture like the one I implemented here — and that was a valuable experience for me.

---

## 6. Please describe yourself using JSON format.

{
"FirstName": "Alireza",
"LastName": "Nikandish",
"Age": 26,
"Hobbies": ["Coding", "Learning", "Walking", "Reading"],
"Skills": ["C#", "ASP .NET", "SQL", "Clean Architecture", "EF Core"],
"Soft-Skills": ["TeamWork", "HardWork", "Responsible"],
"Weakness": ["Sometimes Hopeless"],
"Intrests": ["GO Lang", "Microservices", "Cloud", "DDD", "Docker"]
}
