using EFCore8Assignment.Data;
using EFCore8Assignment.Models;

using var context = new AppDbContext();

// Insert
var student = new Student { Name = "Jaiganesh", Department = "ECE" };
context.Students.Add(student);
context.SaveChanges();
Console.WriteLine("Student Added!");

// Read
var students = context.Students.ToList();
Console.WriteLine("Students in Database:");
students.ForEach(s => Console.WriteLine($"{s.Id}: {s.Name} - {s.Department}"));
