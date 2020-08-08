using System.Data.Entity.ModelConfiguration;

namespace _017_FluentAPI
{
    class AttendeeSplittedEntityConfig : EntityTypeConfiguration<Attendee>
    {
        public AttendeeSplittedEntityConfig()
        {
            // По умолчанию в Entity Framework первичный ключ должен представлять свойство модели с именем Id 
            // или [Имя_класса]Id, например, PhoneId. Чтобы переопределить первичный ключ через Fluent API, 
            // надо использовать метод HasKey():
            HasKey(p => p.AttendeeTrackingID);

            // Столбцы в таблице в БД могут допускать значение NULL, которое указывает, 
            // что значение не определено. По умолчанию все столбцы при Code First, если не 
            // применяются аннотации данных, за исключением идентификатора допускают значение NULL.
            // Но мы можем указать с помощью метода IsRequired(), что значение для этого столбца и 
            // свойства требуется обязательно
            // HasMaxLength -максимальная длинна 
            Property(p => p.LastName).IsRequired().HasMaxLength(100);
        }
    }
}
