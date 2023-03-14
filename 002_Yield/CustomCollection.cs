using System.Collections;

namespace Yield
{

    class CustomCollection
    {
        public static IEnumerable Power()
        {
            // yield на уровне компилятора строит nested класс, который
            // и реализует интерфейсы, необходимые для коллекции,
            // а сам Power возвращает экзмепляр данной 'коллекции'.

            // Оператор автоматической генерации кода итератора.
            yield return "Hello world!";
        }
    }
}
