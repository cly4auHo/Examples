using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Принцип разделения интерфейсов (Interface Segregation Principle) относится 
/// к тем случаям, когда классы имеют "жирный интерфейс", 
/// то есть слишком раздутый интерфейс, не все методы и свойства которого используются 
/// и могут быть востребованы. Таким образом, интерфейс получатся слишком избыточен или "жирным".
/// Принцип разделения интерфейсов можно сформулировать так:
/// Клиенты не должны вынужденно зависеть от методов, которыми не пользуются.
/// </summary>
namespace _04_Interface_Segregation_Principle_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// Интерфейс отправки сообщения:
    /// </summary>
    interface IMessage
    {
        void Send();
        string Text { get; set; }
        string Subject { get; set; }
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }

    /// <summary>
    /// Интерфейс определяет все основное, что нужно для отправки сообщения: 
    /// само сообщение, его тему, адрес отправителя и получателя и, конечно, сам метод отправки. 
    /// И пусть есть класс EmailMessage, который реализует этот интерфейс:
    /// </summary>
    class EmailMessage : IMessage
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Email сообщение: {0}", Text);
        }
    }

    /*Надо отметить, что класс EmailMessage выглядит целостно, вполне
     Теперь определим класс, который бы отправлял данные по смс:*/

    /// <summary>
    /// Здесь мы уже сталкиваемся с небольшой проблемой: свойство Subject, 
    /// которое определяет тему сообщения, при отправке смс не указывается, 
    /// поэтому оно в данном классе не нужно. Таким образом, в классе SmsMessage
    /// появляется избыточная функциональность, от которой класс SmsMessage начинает
    /// зависеть.
    /// </summary>
    class SmsMessage : IMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }

    /*Это не очень хорошо, но посмотрим дальше. Допустим, нам надо создать класс для 
     * отправки голосовых сообщений.*/

    /// <summary>
    /// Это не очень хорошо, но посмотрим дальше. Допустим, нам надо создать класс 
    /// для отправки голосовых сообщений. Класс голосовой почты также имеет отправителя 
    /// и получателя, только само сообщение передается в виде звука, что на уровне C# 
    /// можно выразить в виде массива байтов. И в этом случае было бы неплохо, если бы 
    /// интерфейс IMessage включал бы в себя дополнительные свойства и методы для этого, например:
    /// </summary>
    interface IMessageVoice
    {
        void Send();
        string Text { get; set; }
        string ToAddress { get; set; }
        string Subject { get; set; }
        string FromAddress { get; set; }

        byte[] Voice { get; set; }
    }

    /// <summary>
    /// класс голосовой почты VoiceMessage
    /// </summary>
    class VoiceMessage : IMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public byte[] Voice { get; set; }

        public string Text
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }

    /*Для решения возникшей проблемы нам надо выделить из классов группы связанных методов
     и свойств и определить для каждой группы свой интерфейс:*/

    interface IMessageRefactoring
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
    interface IVoiceMessage : IMessageRefactoring
    {
        byte[] Voice { get; set; }
    }
    interface ITextMessageRefactoring : IMessageRefactoring
    {
        string Text { get; set; }
    }

    interface IEmailMessageRefactoring : ITextMessageRefactoring
    {
        string Subject { get; set; }
    }

    class VoiceRefactoring : IVoiceMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }
    class EmailMessageRefactoring : IEmailMessageRefactoring
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Email сообщение: {0}", Text);
        }
    }

    class SmsMessageRefactoring : ITextMessageRefactoring
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }
}
