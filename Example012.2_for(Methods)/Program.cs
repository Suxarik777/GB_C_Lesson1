//4 вид - функции, которая что-то возвращает, и что-то принимает.

string Method4(int count, string text) //кстати название контейнера перед функцией это то в чём мы будем возвращать
{
    string result = String.Empty; //команда пустой строки (по другому было бы string result = "")

    for(int i =0; i < count; i++) //задаём счетчик, условие, инкремент - щедкаем счетчиком
    {
        result = result + text;
    }
    return result;
}

string result = Method4(10, "asdf");
Console.WriteLine(result);