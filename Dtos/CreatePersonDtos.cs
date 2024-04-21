using System.ComponentModel.DataAnnotations;

namespace Contacts.Api;

public record class CreatePersonDtos(
[Required][StringLength(50)] string Name,
[Required][StringLength(50)] string Surname,
[Required][StringLength(50)] string mail,
[Required][StringLength(50)] string Number
);



