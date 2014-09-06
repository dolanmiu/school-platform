namespace Backend.Modules
{
    using Nancy;
    using Nancy.Authentication.Token;

    public class AuthModule : NancyModule
    {
        public AuthModule(ITokenizer tokenizer, IUserValidator userValidator) : base("/auth")
        {
            Post["/"] = x =>
                {
                    var userName = (string)this.Request.Form.UserName;
                    var password = (string)this.Request.Form.Password;

                    var userIdentity = userValidator.ValidateUser(userName, password);
                    if (userIdentity == null) return HttpStatusCode.Unauthorized;

                    var token = tokenizer.Tokenize(userIdentity, Context);
                    return new { Token = token };
                };
        }
    }
}