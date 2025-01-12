public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize with a default value

    public void MyMethod()
    {
        // Accessing the property after initialization
        int value = MyProperty; 
    }

    public void MyMethod2()
    {
        MyProperty = 5;
        int value = MyProperty; // Accessing property after value assignment
    }
}