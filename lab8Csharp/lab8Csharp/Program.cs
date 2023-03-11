public class MyGenericArray<T>
{
    private T[] array;
    private int length;

    public MyGenericArray(int size)
    {
        array = new T[size];
        length = size;
    }

    public T Get(int index)
    {
        return array[index];
    }

    public void Set(int index, T value)
    {
        array[index] = value;
    }

    public int Length()
    {
        return length;
    }

    public void Remove(int index)
    {
        for (int i = index; i < length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        length--;
    }
    

    public class LoginArray : MyGenericArray<string>
    {
        public LoginArray(int size) : base(size)
        {
        }
    }

    public class PasswordArray : MyGenericArray<string>
    {
        public PasswordArray(int size) : base(size)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            MyGenericArray<string> stringArray = new MyGenericArray<string>(3);
            MyGenericArray<double> doubleArray = new MyGenericArray<double>(10);
            LoginArray loginArray = new LoginArray(10);
            PasswordArray passwordArray = new PasswordArray(10);

            loginArray.Set(0, "user1");
            passwordArray.Set(0, "password1");

            loginArray.Set(1, "user2");
            passwordArray.Set(1, "password2");
        Console.WriteLine(loginArray.Get(0) + "\n" + passwordArray.Get(0));
            Console.ReadKey();
        }
    }
