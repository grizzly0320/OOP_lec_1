MyClass obj = new MyClass();
obj.SomeAction();
Console.WriteLine(obj.GetA());
class MyClass
{
    /*Переменные описанные в классе называются полями, а функции - методами;
     * поля и методы класса называются элементами класс*/
    private int a;
    //Конструктор по умолчанию
    /*Конструктор - это метод класса, который используется начальной инициализации класса*/
    public MyClass()
    {
        a = 1;
    }
    public void SomeAction()
    {
        a++;
    }
    public int GetA()
    {
        return a;
    }
}