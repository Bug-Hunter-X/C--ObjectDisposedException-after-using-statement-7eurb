public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
            var result = context.MyTable.FirstOrDefault();
        }

        //No Error, because result is used within the using statement
    }
}