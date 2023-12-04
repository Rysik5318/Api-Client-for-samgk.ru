namespace SamGK_Api.Interfaces.Account;

public interface ICredentialSgk
{
    /// <summary>
    /// Логин
    /// </summary>
    public string Username { get; set; }
    /// <summary>
    /// Пароль в незахешированном формате
    /// </summary>
    public string Password { get; set; }
    
    /* Особое мнение TheCrazyWolf
     *
     * Надо ли учить людей юзать хотябы MD5?
     * Уважайте других людей, уважайте их частную личную жизнь
     * Не храните пароли в чистом виде, при сопоставление учетных записей
     * используйте MD5, SHA или другие односторонние алгоритмы, когда
     * будете хранить данные пользователей в БД
     *
     * Вдруг окажется, что логин и пароль отлично подходят к остальным
     * ресурсам, которые не относятся к колледжу
     */
}