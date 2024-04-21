namespace Contacts.Api;

public static class phoneNumberMapping
{
    public static PhoneNumberDto ToDto(PhoneNumberDto phoneNumber)
    {
        return new PhoneNumberDto(phoneNumber.Id, phoneNumber.PhoneNumber);
    }

}
