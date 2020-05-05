using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PakistanNationalTrainingService.Models;
using System.Linq;

namespace PakistanNationalTrainingService.Data
{
	public class DatabaseSeeder
	{
		public static void SeedDatabase(IApplicationBuilder app)
		{
			ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
			context.Database.Migrate();

			if (!context.Courses.Any())
			{
				context.Courses.AddRange(
					new Course
					{
						Name = "Introduction to Computing",
						Topic = "Computer Science",
						Description = "Get an introduction to the basic blocks of a program, like variables, functions, loops and conditional statements",
						DeliveryMethod = "Online",
						Location = null,
						TotalSeats = 50,
						SeatsAvailable = 50,
						Cost = 7000
					},

				new Course
				{
					Name = "Computer Programming",
					Topic = "Computer Science",
					Description = "Learn the fundamentals of object oriented programming, including classes, composition, inheritance and polymorphism",
					DeliveryMethod = "On-Site",
					Location = null,
					TotalSeats = 40,
					SeatsAvailable = 40,
					Cost = 7000
				},

				new Course
				{
					Name = "Data Structures",
					Topic = "Computer Science",
					Description = "Get familiar with the core data structures like arrays, lists, stacks, queues and trees, and various algorithms used with them",
					DeliveryMethod = "Off-Site",
					Location = "Lahore",
					TotalSeats = 35,
					SeatsAvailable = 35,
					Cost = 7000
				},

				new Course
				{
					Name = "Database Systems",
					Topic = "Computer Science",
					Description = "Learn the basics of a typical relational database management software, including using SQL to perform CRUD operations and a hands-on with Oracle RDBMS",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Ooperating Systems",
					Topic = "Computer Science",
					Description = "A course that describes the role of operating systems as an interface between the hardware and the user, its core roles and services",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Computer Networks",
					Topic = "Computer Science",
					Description = "Learn the core aspects of computer networks, the components of the OSI model and a hand-on with WireShark sniffing tool",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Object Oriented Analysis and Design",
					Topic = "Computer Science",
					Description = "Learn how to design modern object-oriented applications with an emphasis on design patterns and various artifacts produced in software documentation",
					DeliveryMethod = "On-Site",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Advanced Programming",
					Topic = "Computer Science",
					Description = "Learn to program in Java, including the ORM tool Hibernate and JavaFX Library for building graphical user interfaces (GUIs)",
					DeliveryMethod = "Off-Site",
					Location = "Islamabad",
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				new Course
				{
					Name = "Theory of Automata",
					Topic = "Computer Science",
					Description = "Learn how to build finite automata, regular expressions and various other machines",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Design and Analysis of Algorithms",
					Topic = "Computer Science",
					Description = "Learn how to design efficient algorithms to perform various tasks and analyze existing ones",
					DeliveryMethod = "Off-Site",
					Location = "Karachi",
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Software Engineering",
					Topic = "Computer Science",
					Description = "Learn the methodologies that drive modern software development processes",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Data Mining",
					Topic = "Computer Science",
					Description = "Get familiar with the basics of machine learning, the types of problems that are addressed with it, and the core algorithms used for them",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				new Course
				{
					Name = "Artificial Intelligence",
					Topic = "Computer Science",
					Description = "This courses teaches you the theory of intelligent agents and a brief introduction to the sub-domain of machine learning",
					DeliveryMethod = "Off-Site",
					Location = "Peshawar",
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Human Computer Interaction",
					Topic = "Computer Science",
					Description = "Learn the science behind designing engaging, intuitive user interfaces",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Deep Learning for Perception",
					Topic = "Computer Science",
					Description = "Take a deep dive into the world of artifical neural networks. Learn how to build and optimize deep networks",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				new Course
				{
					Name = "Web Programming",
					Topic = "Computer Science",
					Description = "Learn a variety of aspects about web development, including the basic HTML/CSS/JS and various stacks",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				new Course
				{
					Name = "User Experience Engineering",
					Topic = "Computer Science",
					Description = "Take your front-end development skills a bit further by learning how to design user-centric, value-driven experiences",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				new Course
				{
					Name = "Introduction to Cloud Computing",
					Topic = "Computer Science",
					Description = "Learn the basics of cloud economics, get an introduction to OpenStack, AWS and DevOps",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				// EE courses below

				new Course
				{
					Name = "Basic Electronics",
					Topic = "Electrical Engineering",
					Description = "Course Description",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Digital Logic Design",
					Topic = "Electrical Engineering",
					Description = "Course Description",
					DeliveryMethod = "Off-Site",
					Location = "Quetta",
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Computer Organization and Assembly Language",
					Topic = "Electrical Engineering",
					Description = "Course Description",
					DeliveryMethod = "On-Site",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Computer Architecture",
					Topic = "Electrical Engineering",
					Description = "Course Description",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				// Math courses below

				new Course
				{
					Name = "Calculus I",
					Topic = "Mathematics",
					Description = "Course Description",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Linear Algebra",
					Topic = "Mathematics",
					Description = "Course Description",
					DeliveryMethod = "Off-Site",
					Location = "Lahore",
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Calculus II",
					Topic = "Mathematics",
					Description = "Course Description",
					DeliveryMethod = "On-Site",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Discrete Structures",
					Topic = "Mathematics",
					Description = "Course Description",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Probability and Statistics",
					Topic = "Mathematics",
					Description = "Course Description",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Numerical Methods",
					Topic = "Mathematics",
					Description = "Course Description",
					DeliveryMethod = "Off-Site",
					Location = "Islamabad",
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				// Management courses below

				new Course
				{
					Name = "Principles of Marketing",
					Topic = "Management Science",
					Description = "Course Description",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Fundamentals of Management",
					Topic = "Management Science",
					Description = "Course Description",
					DeliveryMethod = "On-Site",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Entrepreneurship",
					Topic = "Management Science",
					Description = "Course Description",
					DeliveryMethod = "Off-Site",
					Location = "Quetta",
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				new Course
				{
					Name = "Technology Management",
					Topic = "Management Science",
					Description = "Course Description",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 25,
					SeatsAvailable = 25,
					Cost = 7000
				},

				// SS courses below

				new Course
				{
					Name = "English Language",
					Topic = "Social Science",
					Description = "Course Description",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "English Composition",
					Topic = "Social Science",
					Description = "Course Description",
					DeliveryMethod = "Off-Site",
					Location = "Peshawar",
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Pakistan Studies",
					Topic = "Social Science",
					Description = "Course Description",
					DeliveryMethod = "Instructor-Led",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Islamic and Religious Studies",
					Topic = "Social Science",
					Description = "Course Description",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				},

				new Course
				{
					Name = "Technical Report Writing",
					Topic = "Social Science",
					Description = "Learn how to do technical writing, including reports, letters, application, instructions and summaries",
					DeliveryMethod = "Online",
					Location = null,
					TotalSeats = 30,
					SeatsAvailable = 30,
					Cost = 7000
				}
				); ; context.SaveChanges();
			}
		}
	}
}