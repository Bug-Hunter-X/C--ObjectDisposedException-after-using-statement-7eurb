public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some database operations ...
        }

        // Error: ObjectDisposedException
        var result = context.MyTable.FirstOrDefault(); 
    }
}