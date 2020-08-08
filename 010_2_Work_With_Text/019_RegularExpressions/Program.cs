using System;
using System.Text.RegularExpressions;

// Регулярные выражения.

/*
  
   МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.
       
  \d    Определяет символы цифр. 
  \D 	Определяет любой символ, который не является цифрой. 
  \w 	Определяет любой символ цифры, буквы или подчеркивания. 
  \W    Определяет любой символ, который не является цифрой, буквой или подчеркиванием. 
  \s 	Определяет любой непечатный символ, включая пробел. 
  \S 	Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
   .    Определяет любой символ кроме символа новой строки. 
  \.    Определяет символ точки.
 
  
  КВАНТИФИКАТОРЫ - это символы которые определяют, где и сколько раз необходимое вхождение символов может встречаться.
 
  ^ - c начала строки. 
  $ - с конца строки. 
  + - одно и более вхождений подшаблона в строке.  
 
 */
namespace _019_RegularExpressions
{
    class Program
    {
        static void Main()
        {
            Regex regex;
            //Шаблон
            string pattern;
            //Текст
            string text;

            // Возможно указать необходимые символы между скобок [].
            pattern = "^[qwerty]+$";
            // Анализируемая строка.
            text = "qwe"; 
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Строка может состоять только из символов - [qwerty]. Например:  qqq, yyqyqyyyq, eeer ...
            pattern = "^[qwerty]+$";
            text = "qrwere";  // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Весь алфавит
            pattern = "^[abcdefghigklmnopqrstuvwxyz]+$";
            text = "test"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Второй способ, a-z это замена более длинного шаблона 
            // abcdefghigklmnopqrstuvwxyz
            pattern = @"^[a-z]+$";
            text = "test"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // a-z это замена более длинного шаблона 
            // 0-9 это замена 01234567890.
            pattern = "^[a-z0-9]+$";
            text = "test007"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // 0-9 это замена 01234567890.
            // (Пробел не внесли) "^[a-z0-9 ]+$";
            pattern = "^[a-z0-9 ]+$";
            text = "test 007"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Шаблон даты.
            pattern = @"^\d{2}-\d{2}-\d{4}$";
            text = "27-04-1993"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Квантификатор * значит, что вхождение 0 и более раз...
            pattern = @"^\d*$";
            text = "ertty"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Квантификатор * значит, что вхождение 0 и более раз...
            pattern = @"^\d*$";
            text = ""; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Простой шаблон сравнения e-mail.
            pattern = @"^[0-9a-z_-]+@[\S]+\.\S{2,4}$";
            text = "test@mail123.rлu"; // Анализируемая строка.
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            // Задержка.
            Console.ReadKey();
        }
    }
}
