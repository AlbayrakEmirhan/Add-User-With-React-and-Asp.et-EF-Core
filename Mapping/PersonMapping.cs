using Contacts.Api.Dtos;

namespace Contacts.Api;

public static class PersonMapping
{
    public static Person ToEntity(this CreatePersonDtos person)
    {
        return new Person()
        {

            Name = person.Name,
            SurName = person.Surname,
            mail = person.mail,
            Number = person.Number,

        };
    }
    public static Person ToEntity(this UpdatePersonDtos person, int id)
    {
        return new Person()
        {
            Id = id,
            Name = person.Name,
            SurName = person.Surname,
            mail = person.mail,
            Number = person.Number,


        };
    }

    public static UsersSummaryDtos ToUsersSummaryDto(this Person person)
    {
        return new(
            person.Id,
             person.Name,
             person.SurName!,
             person.mail!,
             person.Number

    );
    }

    public static UsersDetailsDtos ToUsersDetailsDto(this Person person)
    {
        return new(
            person.Id,
            person.Name,
            person.SurName!,
            person.mail!,
            person.Number!
    );
    }
}
