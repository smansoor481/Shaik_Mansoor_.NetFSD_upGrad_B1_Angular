using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Reflection.Metadata.BlobBuilder;
namespace DapperAssignment
{
    internal class Program
    {
        string connectionString = "Data Source=MANSOOR\\SQLEXPRESS;Initial Catalog=dummydb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        IDbConnection connection;
        public Program()
        {
            connection = new SqlConnection(connectionString);
        }

        //Add
        private void AddBook(Book book)
        {
            try
            {
                connection.Open();
                var sql = "INSERT INTO Book (Title, Price, Author, Publisher, Language) " +
                            "VALUES (@Title, @Price, @Author, @Publisher, @Language)";
                connection.Execute(sql, book);
                Console.WriteLine("Book Added Successfully!!!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            { connection.Close(); }
        }


        private void EditBook(Book book)
        {
            try
            {
                connection.Open();
                var sql = "UPDATE Book SET Price = @Price, Author = @Author, Language = @Language WHERE BookId = @BookId";
                connection.Execute(sql, book);
                Console.WriteLine("Updated Successfully..!");
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
        }
        //delete id
        private void DeleteBookId(int BookId)
        {
            try
            {
                connection.Open();

                var sql = "DELETE FROM Book WHERE BookId = @BookId";

                var rows = connection.Execute(sql, new { BookId });

                if (rows > 0)
                    Console.WriteLine("Book deleted successfully");
                else
                    Console.WriteLine("No record found with given Id");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { connection.Close(); }
        }

        //get book name
        private void GetBookTitle(string Title)
        {
            try
            {
                connection.Open();

                var sql = "SELECT * FROM Book WHERE Title = @Title";

                var books = connection.Query<Book>(sql, new { Title }).ToList();

                if (books.Count > 0)
                {
                    foreach (var item in books)
                    {
                        Console.WriteLine($"Id: {item.BookId}, Title: {item.Title}, Price: {item.Price}, Author: {item.Author}, Publisher: {item.Publisher}, Language: {item.Language}, Created: {item.Created}");
                    }
                }
                else
                {
                    Console.WriteLine("No books found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void GetBookId(int BookId)
        {
            try
            {
                connection.Open();

                var sql = "SELECT * FROM Book WHERE BookId = @BookId";

                var books = connection.Query<Book>(sql, new { BookId }).ToList();

                if (books != null)
                {
                    foreach (var item in books)
                    {
                        Console.WriteLine($"Id: {item.BookId}, Title: {item.Title}, Price: {item.Price}, Author: {item.Author}, Publisher: {item.Publisher}, Language: {item.Language}, Created: {item.Created}");
                    }
                }
                else
                {
                    Console.WriteLine("No books found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        //GetAll
        private void GetAllBooks()
        {
            try
            {
                connection.Open();
                var sql = "SELECT * FROM Book";
                var books = connection.Query<Book>(sql).ToList();
                foreach (var item in books)
                {
                    Console.WriteLine($"Id: {item.BookId}, Title: {item.Title}, Price: {item.Price}, Author: {item.Author}, Publisher: {item.Publisher}, Language: {item.Language}, Created: {item.Created}");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { connection.Close(); }
        }

        //GetAllBooksByAuthor
        private List<Book> GetAllBooksByAuthor(string author)
        {
            try
            {
                connection.Open();

                var sql = "SELECT * FROM Book WHERE Author = @Author";

                var books = connection.Query<Book>(sql, new { Author = author }).ToList();

                return books;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Book>();
            }
            finally
            {
                connection.Close();
            }
        }

        private List<Book> GetAllBooksByLang(string lang)
        {
            try
            {
                connection.Open();

                var sql = "SELECT * FROM Book WHERE Language = @Language";

                var books = connection.Query<Book>(sql, new { Language = lang }).ToList();

                return books;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Book>();
            }
            finally
            {
                connection.Close();
            }
        }

        private List<Book> GetAllBooksByPublisher(string publisher)
        {
            try
            {
                connection.Open();

                var sql = "SELECT * FROM Book WHERE Publisher = @Publisher";

                var books = connection.Query<Book>(sql, new { Publisher = publisher }).ToList();

                return books;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Book>();
            }
            finally
            {
                connection.Close();
            }
        }
        //static void Main(string[] args)
        //{
            //Console.WriteLine("Hello, World!");
            //Program program = new Program();
            //program.AddBook(new Book
            //{
            //    Title = "Java Basics",
            //    Price = 500,
            //    Author = "James Gosling",
            //    Publisher = "Sun Publications",
            //    Language = "English"
            //});


            //program.GetAllBooks();

            //program.EditBook(new Book
            //{
            //    BookId = 2,
            //    Price = 500,
            //    Author = "John",
            //    Language = "English"
            //});

            //program.DeleteBookId(1);

            //program.GetBookTitle("Java Basics");

            //program.GetBookId(2);

            //program.GetBookId(1);

            //program.GetAllBooksByAuthor("John");
            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item.BookId} - {item.Title} - {item.Author}");
            //}

            //program.GetAllBooksByLang("English");

            //program.GetAllBooksByPublisher("Sun Publications");





            static void Main(string[] args)
            {
                Program program = new Program();

                while (true)
                {
                    Console.WriteLine("\n================ BOOK MENU ================");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Update Book");
                    Console.WriteLine("3. Delete Book");
                    Console.WriteLine("4. Get Book By Id");
                    Console.WriteLine("5. Get Book By Title");
                    Console.WriteLine("6. Get All Books");
                    Console.WriteLine("7. Get Books By Author");
                    Console.WriteLine("8. Get Books By Language");
                    Console.WriteLine("9. Get Books By Publisher");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter choice: ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Book newBook = new Book();
                            Console.Write("Title: ");
                            newBook.Title = Console.ReadLine();

                            Console.Write("Price: ");
                            newBook.Price = int.Parse(Console.ReadLine());

                            Console.Write("Author: ");
                            newBook.Author = Console.ReadLine();

                            Console.Write("Publisher: ");
                            newBook.Publisher = Console.ReadLine();

                            Console.Write("Language: ");
                            newBook.Language = Console.ReadLine();

                            program.AddBook(newBook);
                            break;

                        case 2:
                            Book updateBook = new Book();

                            Console.Write("BookId: ");
                            updateBook.BookId = int.Parse(Console.ReadLine());

                            Console.Write("Price: ");
                            updateBook.Price = int.Parse(Console.ReadLine());

                            Console.Write("Author: ");
                            updateBook.Author = Console.ReadLine();

                            Console.Write("Language: ");
                            updateBook.Language = Console.ReadLine();

                            program.EditBook(updateBook);
                            break;

                        case 3:
                            Console.Write("Enter BookId to delete: ");
                            int delId = int.Parse(Console.ReadLine());
                            program.DeleteBookId(delId);
                            break;

                        case 4:
                            Console.Write("Enter BookId: ");
                            int id = int.Parse(Console.ReadLine());
                            program.GetBookId(id);
                            break;

                        case 5:
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();
                            program.GetBookTitle(title);
                            break;

                        case 6:
                            program.GetAllBooks();
                            break;

                        case 7:
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();
                            var booksByAuthor = program.GetAllBooksByAuthor(author);
                            foreach (var b in booksByAuthor)
                                Console.WriteLine($"{b.BookId} - {b.Title} - {b.Author}");
                            break;

                        case 8:
                            Console.Write("Enter Language: ");
                            string lang = Console.ReadLine();
                            var booksByLang = program.GetAllBooksByLang(lang);
                            foreach (var b in booksByLang)
                                Console.WriteLine($"{b.BookId} - {b.Title} - {b.Language}");
                            break;

                        case 9:
                            Console.Write("Enter Publisher: ");
                            string pub = Console.ReadLine();
                            var booksByPub = program.GetAllBooksByPublisher(pub);
                            foreach (var b in booksByPub)
                                Console.WriteLine($"{b.BookId} - {b.Title} - {b.Publisher}");
                            break;

                        case 0:
                            Console.WriteLine("Exiting... Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }


        }
    }
